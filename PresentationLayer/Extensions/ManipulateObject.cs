using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public static class ManipulateForm
    {
        public static Control GetControl<T>(Form oForm, string IDControl)
        {
            var cList = oForm.GetAllControlList().ToList();//GetSelfAndChildrenRecursive(this).ToList();
            Control cControl = null;
            
            try
            {
                foreach (Control control in cList)
                    if (control.GetType() == typeof(T) && control.Name == IDControl)
                    {
                        cControl = control;
                        return cControl;
                    }
            }
            catch (Exception) { }

            return cControl;
        }

        public static void ChangeBoolProperty(object oForm, bool bStatus, string sPropertyName)
        {
            //this.bAcceso = bStatus;
            var cList = oForm.GetType().GetProperties().ToList();//GetSelfAndChildrenRecursive(this).ToList();

            Type t = oForm.GetType();
            PropertyInfo[] props = t.GetProperties();
            PropertyInfo[] aPropertyInfo = oForm.GetType().GetProperties();

            foreach (PropertyInfo propertyInfo in cList)
            {
                if (propertyInfo.Name == sPropertyName)
                    try
                    {
                        if (propertyInfo.PropertyType.Equals(typeof(Boolean)))
                            propertyInfo.SetValue(oForm, (bool)bStatus);
                    }
                    catch (Exception) { }
            }
        }

        public static void ChangeStringProperty(object oForm, string sString, string sPropertyName)
        {
            // this.bAcceso = bStatus;
            var cList = oForm.GetType().GetProperties().ToList();//GetSelfAndChildrenRecursive(this).ToList();

            Type t = oForm.GetType();
            PropertyInfo[] props = t.GetProperties();
            PropertyInfo[] aPropertyInfo = oForm.GetType().GetProperties();

            foreach (PropertyInfo propertyInfo in cList)
            {
                if (propertyInfo.Name == sPropertyName)
                    try
                    {
                        if (propertyInfo.PropertyType.Equals(typeof(string)))
                            propertyInfo.SetValue(oForm, sString.ToString());
                    }
                    catch (Exception) { }
            }

        }
    }
}
