using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public static class Functions
    {
        public static void ConfigurarMaterialSkinManager()
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.ROBOTO_MEDIUM_10 = new Font("Segoe UI Light", 10);
            skinManager.ROBOTO_MEDIUM_11 = new Font("Segoe UI Light", 11);
            skinManager.ROBOTO_MEDIUM_12 = new Font("Segoe UI Light", 12);
            skinManager.ROBOTO_REGULAR_11 = new Font("Segoe UI Light", 11);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange500, MaterialSkin.Primary.LightBlue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);
        }

        public static void ConfigurarMaterialSkinManagerInicio()
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.ROBOTO_MEDIUM_10 = new Font("Segoe UI Light", 10);
            skinManager.ROBOTO_MEDIUM_11 = new Font("Segoe UI Light", 11);
            skinManager.ROBOTO_MEDIUM_12 = new Font("Segoe UI Light", 12);
            skinManager.ROBOTO_REGULAR_11 = new Font("Segoe UI Light", 16);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange500, MaterialSkin.Primary.LightBlue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);
        }

        public static T DeepCopy<T>(T obj)
        {
            if (!typeof(T).IsSerializable)//RECORDATORIO: CUANDO HAY ERROR AQUI HAY QUE AGREGAR la propiedad [Serializable] EN ITEM, ITEM DETALLE, ITEMCOSTO 
            {
                throw new Exception("The source object must be serializable");
            }

            if (Object.ReferenceEquals(obj, null))
            {
                throw new Exception("The source object must not be null");
            }

            T result = default(T);

            using (var memoryStream = new MemoryStream())

            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(memoryStream, obj);
                memoryStream.Seek(0, SeekOrigin.Begin);
                result = (T)formatter.Deserialize(memoryStream);
                memoryStream.Close();
            }

            return result;

        }

        public static bool Compare<T>(T Object1, T object2)
        {
            //Get the type of the object
            Type type = typeof(T);

            //return false if any of the object is false
            if (object.Equals(Object1, default(T)) || object.Equals(object2, default(T)))
                return false;

            //Loop through each properties inside class and get values for the property from both the objects and compare
            foreach (System.Reflection.PropertyInfo property in type.GetProperties())
            {
                if (property.Name != "ExtensionData")
                {
                    string Object1Value = string.Empty;
                    string Object2Value = string.Empty;
                    if (type.GetProperty(property.Name).GetValue(Object1, null) != null)
                        Object1Value = type.GetProperty(property.Name).GetValue(Object1, null).ToString();
                    if (type.GetProperty(property.Name).GetValue(object2, null) != null)
                        Object2Value = type.GetProperty(property.Name).GetValue(object2, null).ToString();
                    if (Object1Value.Trim() != Object2Value.Trim())
                    {
                        if (IsNumeric(Object1Value.Trim()))
                        {
                            if (Math.Round(Convert.ToDouble(Object1Value), 2) != Math.Round(Convert.ToDouble(Object2Value), 2))
                                return false;
                        }
                        else
                            return false;
                    }
                }
            }
            return true;
        }

        public static bool IsNumeric(this string s)
        {
            float output;
            return float.TryParse(s, out output);
        }
    }
}
