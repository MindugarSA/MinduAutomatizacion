﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public static class ErrorProviderExtensions
    {
        private static int count;

        public static void SetErrorWithCount(this ErrorProvider ep, Control c, string message)
        {
            if (message == "")
            {
                if (ep.GetError(c) != "")
                    count--;
            }
            else
                count++;

            ep.SetError(c, message);
        }

        public static bool HasErrors(this ErrorProvider ep)
        {
            return count != 0;
        }

        public static int GetErrorCount(this ErrorProvider ep)
        {
            return count;
        }
    }
}
