using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer
{
    public abstract class MetroShadowBase : Form
    {
        private bool isBringingToFront;
        private long lastResizedOn;
        private const long RESIZE_REDRAW_INTERVAL = 0x989680L;
        private readonly int shadowSize;
        private const int TICKS_PER_MS = 0x2710;
        protected const int WS_EX_LAYERED = 0x80000;
        protected const int WS_EX_NOACTIVATE = 0x8000000;
        protected const int WS_EX_TRANSPARENT = 0x20;
        private readonly int wsExStyle;

        protected MetroShadowBase(Form targetForm, int shadowSize, int wsExStyle)
        {
            this.TargetForm = targetForm;
            this.shadowSize = shadowSize;
            this.wsExStyle = wsExStyle;
            this.TargetForm.Activated += new EventHandler(this.OnTargetFormActivated);
            this.TargetForm.ResizeBegin += new EventHandler(this.OnTargetFormResizeBegin);
            this.TargetForm.ResizeEnd += new EventHandler(this.OnTargetFormResizeEnd);
            this.TargetForm.VisibleChanged += new EventHandler(this.OnTargetFormVisibleChanged);
            this.TargetForm.SizeChanged += new EventHandler(this.OnTargetFormSizeChanged);
            this.TargetForm.Move += new EventHandler(this.OnTargetFormMove);
            this.TargetForm.Resize += new EventHandler(this.OnTargetFormResize);
            if (this.TargetForm.Owner != null)
            {
                base.Owner = this.TargetForm.Owner;
            }
            //this.TargetForm.Parent = this;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.ShowInTaskbar = false;
            base.ShowIcon = false;
            base.FormBorderStyle = FormBorderStyle.None;
            base.Bounds = this.GetShadowBounds();
        }

        protected abstract void ClearShadow();
        private Rectangle GetShadowBounds()
        {
            Rectangle bounds = this.TargetForm.Bounds;
            bounds.Inflate(this.shadowSize, this.shadowSize);
            return bounds;
        }

        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            this.isBringingToFront = true;
        }

        private void OnTargetFormActivated(object sender, EventArgs e)
        {
            if (base.Visible)
            {
                base.Update();
            }
            if (this.isBringingToFront)
            {
                base.Visible = true;
                this.isBringingToFront = false;
            }
            else
            {
                base.BringToFront();
            }
        }

        private void OnTargetFormMove(object sender, EventArgs e)
        {
            if (!this.TargetForm.Visible || (this.TargetForm.WindowState != FormWindowState.Normal))
            {
                base.Visible = false;
            }
            else
            {
                base.Bounds = this.GetShadowBounds();
            }
        }

        private void OnTargetFormResize(object sender, EventArgs e)
        {
            this.ClearShadow();
        }

        private void OnTargetFormResizeBegin(object sender, EventArgs e)
        {
            this.lastResizedOn = DateTime.Now.Ticks;
        }

        private void OnTargetFormResizeEnd(object sender, EventArgs e)
        {
            this.lastResizedOn = 0L;
            this.PaintShadowIfVisible();
        }

        private void OnTargetFormSizeChanged(object sender, EventArgs e)
        {
            base.Bounds = this.GetShadowBounds();
            if (!this.IsResizing)
            {
                this.PaintShadowIfVisible();
            }
        }

        private void OnTargetFormVisibleChanged(object sender, EventArgs e)
        {
            base.Visible = this.TargetForm.Visible && (this.TargetForm.WindowState != FormWindowState.Minimized);
            base.Update();
        }

        protected abstract void PaintShadow();
        private void PaintShadowIfVisible()
        {
            if (this.TargetForm.Visible && (this.TargetForm.WindowState != FormWindowState.Minimized))
            {
                this.PaintShadow();
            }
        }

        protected override System.Windows.Forms.CreateParams CreateParams
        {
            get
            {
                System.Windows.Forms.CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= this.wsExStyle;
                return createParams;
            }
        }

        private bool IsResizing
        {
            get
            {
                return (this.lastResizedOn > 0L);
            }
        }

        protected Form TargetForm { get; private set; }
    }

}

