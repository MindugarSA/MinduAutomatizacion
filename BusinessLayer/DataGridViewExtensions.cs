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

namespace CapaNegocios
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

    }
}
