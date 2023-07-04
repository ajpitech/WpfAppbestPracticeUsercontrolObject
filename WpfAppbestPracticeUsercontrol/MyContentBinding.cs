using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppbestPracticeUsercontrolObject
{
    internal class MyContentBinding:BaseViewModel
    {


        public static object  GetMyContent(DependencyObject obj)
        {
            return (object )obj.GetValue(MyContentProperty);
        }

        public static void SetMyContent(DependencyObject obj, object  value)
        {
            obj.SetValue(MyContentProperty, value);
        }
       
      

        // Using a DependencyProperty as the backing store for MyContent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyContentProperty =
            DependencyProperty.RegisterAttached("MyContent", typeof(object), typeof(MyContentBinding), 
                new PropertyMetadata("", (a, b) =>
                {
                    object u = (object)a;
                    object  currenvalue = (object)a.GetValue(MyContentProperty);
                    Type type = currenvalue.GetType();
                    PropertyInfo[] type1 = type.GetProperties();
                    

                }));


    }
}
