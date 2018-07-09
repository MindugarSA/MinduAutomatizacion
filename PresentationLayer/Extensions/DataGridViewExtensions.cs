using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace PresentationLayer
{
    public static class DataGridViewExtensions
    {
        public static void ExportToExcel(this DataGridView dgvItems)
        {

            // Copy DataGridView results to clipboard
            bool CurrentMultiSelect = dgvItems.MultiSelect;
            dgvItems.MultiSelect = true;
            dgvItems.SelectAll();
            DataObject dataObj = dgvItems.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            dgvItems.MultiSelect = CurrentMultiSelect;

            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;

            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;

            xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //// storing header part in Excel
            //for (int i = 1; i < dgvItems.Columns.Count + 1; i++)
            //{
            //    xlWorkSheet.Cells[1, i] = dgvItems.Columns[i - 1].HeaderText;
            //}

            //// storing Each row and column value to excel sheet
            //for (int i = 0; i < dgvItems.Rows.Count - 1; i++)
            //{
            //    for (int j = 0; j < dgvItems.Columns.Count; j++)
            //    {
            //        xlWorkSheet.Cells[i + 2, j + 1] = dgvItems.Rows[i].Cells[j].Value.ToString();
            //    }
            //}


            // Format column D as text before pasting results, this was required for my data
            //Excel.Range rng = xlWorkSheet.get_Range("D:D").Cells;
            //rng.NumberFormat = "@";

            //Paste clipboard results to worksheet range
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

            // For some reason column A is always blank in the worksheet. ¯\_(ツ)_/¯
            // Delete blank column A and select cell A1
            //Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
            //delRng.Delete(Type.Missing);
            //xlWorkSheet.get_Range("A1").Select();

            //// Save the excel file under the captured location from the SaveFileDialog
            ////xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //xlexcel.DisplayAlerts = false;
            //xlWorkBook.Close(true, misValue, misValue);
            //xlexcel.Quit();

            //releaseObject(xlWorkSheet);
            //releaseObject(xlWorkBook);
            //releaseObject(xlexcel);

            //// Clear Clipboard and DataGridView selection
            //Clipboard.Clear();
            //dgvItems.ClearSelection();

            //// Open the newly saved excel file
            //if (File.Exists(sfd.FileName))
            //    System.Diagnostics.Process.Start(sfd.FileName);

        }
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        /// <summary>
        ///   Buscar la primera coincidencia de una cadena en un DataGrid en una columna determinada
        ///   selecciona el row y ubica el scroll en dicha linea.
        /// </summary>
        /// <param name="TextoABuscar"></param>
        /// <param name="Columna"></param>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static void SearchAndSelectValue(this DataGridView grid, string TextoABuscar, string Columna)
        {
            //BuscandoenDGV = true;
            //bool encontrado = false;
            if (TextoABuscar == string.Empty) return;
            if (grid.RowCount == 0) return;
            //grid.ClearSelection();
            if (Columna == string.Empty)
            {
                IEnumerable<DataGridViewRow> obj = (from DataGridViewRow row in grid.Rows.Cast<DataGridViewRow>()
                                                    from DataGridViewCell cells in row.Cells
                                                    where cells.OwningRow.Equals(row) && Convert.ToString(cells.Value).Contains(TextoABuscar)
                                                    select row);
                if (obj.Any())
                {
                    //BuscandoenDGV = false;
                    grid.Rows[obj.FirstOrDefault().Index].Selected = true;
                    grid.FirstDisplayedScrollingRowIndex = obj.FirstOrDefault().Index;
                    grid.CurrentCell = grid[Convert.ToInt32(Columna), obj.FirstOrDefault().Index];
                    //return true;
                }

            }
            else
            {
                IEnumerable<DataGridViewRow> obj = (from DataGridViewRow row in grid.Rows.Cast<DataGridViewRow>()
                                                    where Convert.ToString(row.Cells[Convert.ToInt32(Columna)].Value).Contains(TextoABuscar)
                                                    select row);
                if (obj.Any())
                {
                    //BuscandoenDGV = false;
                    grid.Rows[obj.FirstOrDefault().Index].Selected = true;
                    grid.FirstDisplayedScrollingRowIndex = obj.FirstOrDefault().Index;
                    grid.CurrentCell = grid[Convert.ToInt32(Columna), obj.FirstOrDefault().Index];
                    //return true;
                }

            }
            //BuscandoenDGV = false;
            //return encontrado;

        }

        public static void SelectRowAndScroll(this DataGridView grid, int RowIndex)
        {
            if (grid.RowCount == 0) return;
            {
                grid.Rows[RowIndex].Selected = true;
                grid.FirstDisplayedScrollingRowIndex = RowIndex;
                //grid.CurrentCell = grid[, RowIndex];
            }

        }

        public static void SwapCellsValues(this DataGridView grid, int rowid, string option)
        {
            if (option == "UP")
            {
                for (int i = 0; i <= 1; i++)
                {
                    var temp = grid.Rows[rowid - 1].Cells[i].Value;
                    grid.Rows[rowid - 1].Cells[i].Value =
                    grid.Rows[rowid].Cells[i].Value;
                    grid.Rows[rowid].Cells[i].Value = temp;
                }
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    var temp = grid.Rows[rowid].Cells[i].Value;
                    grid.Rows[rowid].Cells[i].Value =
                    grid.Rows[rowid + 1].Cells[i].Value;
                    grid.Rows[rowid + 1].Cells[i].Value = temp;
                }
            }
        }

        public static void CopyContentToClipboard(this DataGridView dgvItems)
        {
            // Copy DataGridView results to clipboard
            bool CurrentMultiSelect = dgvItems.MultiSelect;
            dgvItems.MultiSelect = true;
            dgvItems.SelectAll();
            DataObject dataObj = dgvItems.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            dgvItems.MultiSelect = CurrentMultiSelect;
        }

        public static void AjustColumnsWidthForGridWidth(this DataGridView oDataGridView)
        {
            dynamic iVisibleCount = 0;
            //int iWidth = 0;
            //int iLastColumn = 0;

            int nLastColumn = oDataGridView.Columns.Count - 1;
            for (int i = 0; i < oDataGridView.Columns.Count; i++)
            {
                if (nLastColumn == i)
                    oDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                else
                    oDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            for (int i = 0; i < oDataGridView.Columns.Count; i++)
            {
                int colw = oDataGridView.Columns[i].Width;
                oDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                oDataGridView.Columns[i].Width = colw;
            }
            
            //var _with1 = oDataGridView;

            //if (_with1.RowCount > 0)
            //{
            //    foreach (DataGridViewColumn columna in _with1.Columns)
            //    {
            //        iVisibleCount += (columna.Visible ? 1 : 0);
            //        iLastColumn = columna.Index;
            //    }

            //    foreach (DataGridViewColumn columna in _with1.Columns)
            //    {
            //        if (columna.Visible)
            //        {
            //            columna.AutoSizeMode = (columna.Index == iLastColumn ? 
            //                                    DataGridViewAutoSizeColumnMode.Fill : 
            //                                    DataGridViewAutoSizeColumnMode.AllCells);
            //            iWidth = columna.Width;
            //            columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //            columna.Width = iWidth;

            //            //columna.MinimumWidth = Int((.Width - .RowHeadersWidth) / iVisibleCount)
            //            //columna.Width = Int((.Width - .RowHeadersWidth) / iVisibleCount)
            //        }
            //    }
            //}
        }

        public static string ConvertDataGridViewToHTMLWithFormatting(this DataGridView dgv)
        {
            StringBuilder sb = new StringBuilder();
            //create html & table
            sb.AppendLine("<html><body><center><table border='1' cellpadding='0' cellspacing='0'>");
            sb.AppendLine("<tr>");
            //create table header
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                sb.Append(DGVHeaderCellToHTMLWithFormatting(dgv, i));
                sb.Append(DGVCellFontAndValueToHTML(dgv, dgv.Columns[i].HeaderText, dgv.Columns[i].HeaderCell.Style.Font));
                sb.AppendLine("</td>");
            }
            sb.AppendLine("</tr>");
            //create table body
            for (int rowIndex = 0; rowIndex < dgv.Rows.Count; rowIndex++)
            {
                sb.AppendLine("<tr>");
                foreach (DataGridViewCell dgvc in dgv.Rows[rowIndex].Cells)
                {
                    sb.AppendLine(DGVCellToHTMLWithFormatting(dgv, rowIndex, dgvc.ColumnIndex));
                    string cellValue = dgvc.Value == null ? string.Empty : dgvc.Value.ToString();
                    sb.AppendLine(DGVCellFontAndValueToHTML(dgv, cellValue, dgvc.Style.Font));
                    sb.AppendLine("</td>");
                }
                sb.AppendLine("</tr>");
            }
            //table footer & end of html file
            sb.AppendLine("</table></center></body></html>");
            return sb.ToString();
        }

        //TODO: Add more cell styles described here: https://msdn.microsoft.com/en-us/library/1yef90x0(v=vs.110).aspx
        public static string DGVHeaderCellToHTMLWithFormatting(DataGridView dgv, int col)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<td");
            sb.Append(DGVCellColorToHTML(dgv.Columns[col].HeaderCell.Style.ForeColor, dgv.Columns[col].HeaderCell.Style.BackColor));
            sb.Append(DGVCellAlignmentToHTML(dgv.Columns[col].HeaderCell.Style.Alignment));
            sb.Append(">");
            return sb.ToString();
        }

        public static string DGVCellToHTMLWithFormatting(DataGridView dgv, int row, int col)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<td");
            sb.Append(DGVCellColorToHTML(dgv.Rows[row].Cells[col].Style.ForeColor, dgv.Rows[row].Cells[col].Style.BackColor));
            sb.Append(DGVCellAlignmentToHTML(dgv.Rows[row].Cells[col].Style.Alignment));
            sb.Append(">");
            return sb.ToString();
        }

        public static string DGVCellColorToHTML(Color foreColor, Color backColor)
        {
            if (foreColor.Name == "0" && backColor.Name == "0") return string.Empty;

            StringBuilder sb = new StringBuilder();
            sb.Append(" style=\"");
            if (foreColor.Name != "0" && backColor.Name != "0")
            {
                sb.Append("color:#");
                sb.Append(foreColor.R.ToString("X2") + foreColor.G.ToString("X2") + foreColor.B.ToString("X2"));
                sb.Append("; background-color:#");
                sb.Append(backColor.R.ToString("X2") + backColor.G.ToString("X2") + backColor.B.ToString("X2"));
            }
            else if (foreColor.Name != "0" && backColor.Name == "0")
            {
                sb.Append("color:#");
                sb.Append(foreColor.R.ToString("X2") + foreColor.G.ToString("X2") + foreColor.B.ToString("X2"));
            }
            else //if (foreColor.Name == "0" &&  backColor.Name != "0")
            {
                sb.Append("background-color:#");
                sb.Append(backColor.R.ToString("X2") + backColor.G.ToString("X2") + backColor.B.ToString("X2"));
            }

            sb.Append(";\"");
            return sb.ToString();
        }

        public static string DGVCellFontAndValueToHTML(DataGridView dgv, string value, Font font)
        {
            //If no font has been set then assume its the default as someone would be expected in HTML or Excel
            if (font == null || font == dgv.Font && !(font.Bold | font.Italic | font.Underline | font.Strikeout)) return value;
            StringBuilder sb = new StringBuilder();
            sb.Append(" ");
            if (font.Bold) sb.Append("<b>");
            if (font.Italic) sb.Append("<i>");
            if (font.Strikeout) sb.Append("<strike>");

            //The <u> element was deprecated in HTML 4.01. The new HTML 5 tag is: text-decoration: underline
            if (font.Underline) sb.Append("<u>");

            string size = string.Empty;
            if (font.Size != dgv.Font.Size) size = "font-size: " + font.Size + "pt;";

            //The <font> tag is not supported in HTML5. Use CSS or a span instead. 
            if (font.FontFamily.Name != dgv.Font.Name)
            {
                sb.Append("<span style=\"font-family: ");
                sb.Append(font.FontFamily.Name);
                sb.Append("; ");
                sb.Append(size);
                sb.Append("\">");
            }
            sb.Append(value);
            if (font.FontFamily.Name != dgv.Font.Name) sb.Append("</span>");

            if (font.Underline) sb.Append("</u>");
            if (font.Strikeout) sb.Append("</strike>");
            if (font.Italic) sb.Append("</i>");
            if (font.Bold) sb.Append("</b>");

            return sb.ToString();
        }

        public static string DGVCellAlignmentToHTML(DataGridViewContentAlignment align)
        {
            if (align == DataGridViewContentAlignment.NotSet) return string.Empty;

            string horizontalAlignment = string.Empty;
            string verticalAlignment = string.Empty;
            CellAlignment(align, ref horizontalAlignment, ref verticalAlignment);
            StringBuilder sb = new StringBuilder();
            sb.Append(" align='");
            sb.Append(horizontalAlignment);
            sb.Append("' valign='");
            sb.Append(verticalAlignment);
            sb.Append("'");
            return sb.ToString();
        }

        private static void CellAlignment(DataGridViewContentAlignment align, ref string horizontalAlignment, ref string verticalAlignment)
        {
            switch (align)
            {
                case DataGridViewContentAlignment.MiddleRight:
                    horizontalAlignment = "right";
                    verticalAlignment = "middle";
                    break;
                case DataGridViewContentAlignment.MiddleLeft:
                    horizontalAlignment = "left";
                    verticalAlignment = "middle";
                    break;
                case DataGridViewContentAlignment.MiddleCenter:
                    horizontalAlignment = "centre";
                    verticalAlignment = "middle";
                    break;
                case DataGridViewContentAlignment.TopCenter:
                    horizontalAlignment = "centre";
                    verticalAlignment = "top";
                    break;
                case DataGridViewContentAlignment.BottomCenter:
                    horizontalAlignment = "centre";
                    verticalAlignment = "bottom";
                    break;
                case DataGridViewContentAlignment.TopLeft:
                    horizontalAlignment = "left";
                    verticalAlignment = "top";
                    break;
                case DataGridViewContentAlignment.BottomLeft:
                    horizontalAlignment = "left";
                    verticalAlignment = "bottom";
                    break;
                case DataGridViewContentAlignment.TopRight:
                    horizontalAlignment = "right";
                    verticalAlignment = "top";
                    break;
                case DataGridViewContentAlignment.BottomRight:
                    horizontalAlignment = "right";
                    verticalAlignment = "bottom";
                    break;

                default: //DataGridViewContentAlignment.NotSet
                    horizontalAlignment = "left";
                    verticalAlignment = "middle";
                    break;
            }
        }
    }
}
