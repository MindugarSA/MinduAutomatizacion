using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer
{
    class Funciones
    {

        public static void Formato_Decimal(TextBox CajaTexto, System.Windows.Forms.KeyPressEventArgs e)
        {
            try
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Convert.ToString(e.KeyChar) == "." && CajaTexto.Text.IndexOf(",") == -1)
                {
                    e.KeyChar = Convert.ToChar(",");
                }
                else if (Convert.ToString(e.KeyChar) == "." && CajaTexto.Text.IndexOf(",") != -1)
                {
                    e.Handled = true;
                }
                else if (Convert.ToString(e.KeyChar) == "," && CajaTexto.Text.IndexOf(",") != -1)
                {
                    e.Handled = true;
                }
                else if (Convert.ToString(e.KeyChar) == ",")
                {
                    e.Handled = false;
                }
                else {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public static double ConvertStringToDouble(string s)
        {
            char systemSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];
            double result = 0;
            try
            {
                if (s != null)
                    if (!s.Contains(","))
                        result = double.Parse(s, System.Globalization.CultureInfo.InvariantCulture);
                    else
                        result = Convert.ToDouble(s.Replace(".", systemSeparator.ToString()).Replace(",", systemSeparator.ToString()));
            }
            catch (Exception)
            {
                try
                {
                    result = Convert.ToDouble(s);
                }
                catch
                {
                    try
                    {
                        result = Convert.ToDouble(s.Replace(",", ";").Replace(".", ",").Replace(";", "."));
                    }
                    catch
                    {
                        throw new Exception("Wrong string-to-double format");
                    }
                }
            }
            return result;
        }

      
    }
}
