using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public class ExcelExtensions
    {
        public static System.Data.DataTable LoadDataTableFromExcel(string sPathBook,int SheetNumBase0 = 0)
        {
            System.Data.DataTable dtDatos = new System.Data.DataTable();

            string csXlsx = @"Provider=Microsoft.ACE.OLEDB.12.0;
                            Data Source=" + sPathBook + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1\";";
            string csXls = @"Provider=Microsoft.Jet.OLEDB.4.0;
                            Data Source=" + sPathBook + ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\";";
            string ext = Path.GetExtension(sPathBook);
            sPathBook = ext.ToLower() == ".xls" ? sPathBook+"x" : sPathBook;
            string cs = ext.ToLower() == ".xls" ? csXls : csXlsx;

            try
            {
                if (!System.IO.File.Exists(sPathBook))
                {
                    MessageBox.Show("No se encontro el Libro: " + sPathBook, "Ruta Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                //Conectar con la sheet 1
                OleDbConnection cn = new OleDbConnection(cs);
                cn.Open();
                // Get the data table containg the schema guid.
                System.Data.DataTable dt = cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string firstSheetName = dt.Rows[SheetNumBase0]["TABLE_NAME"].ToString();
                OleDbDataAdapter dAdapter = new OleDbDataAdapter("select * from [" + firstSheetName + "]", cs);
                //Agregar los datos
                dAdapter.Fill(dtDatos);
                dtDatos.TableName = "CargaMasiva";

            }
            catch (Exception ) { }

            return dtDatos;

        }

        public static void SaveXSLtoXLSX(string fileName)
        {
            try
            {
                string svfileName = Path.GetDirectoryName(fileName) + "/" + Path.GetFileNameWithoutExtension(fileName);//Path.ChangeExtension(fileName, ".xlsx");
                object oMissing = Type.Missing;
                var app = new Microsoft.Office.Interop.Excel.Application();
                var wb = app.Workbooks.Open(fileName, oMissing, oMissing,
                                oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing);
                app.DisplayAlerts = false;
                wb.SaveAs(svfileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook, Missing.Value,
                           Missing.Value, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                           Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlUserResolution, true,
                           Missing.Value, Missing.Value, Missing.Value);
                //wb.SaveAs(svfileName, XlFileFormat.xlExcel8, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                app = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            catch (Exception) { }

        }

        public static string GetFirtsSheetName(string sPathBook)
        {

            Microsoft.Office.Interop.Excel.Application app = null;
            app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Open(sPathBook);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets.Item[1];
            string name = "";

            try
            {
                name = ws.Name;
                ws = null;
                wb.Close(false, Missing.Value, Missing.Value);
                wb = null;
                System.Runtime.InteropServices.Marshal.ReleaseComObject(ws);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wb);
            }
            catch (Exception ){}
            finally
            {
                if (((app != null)))
                    app.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                app = null;
            }
            return name;
        }
    }
}
