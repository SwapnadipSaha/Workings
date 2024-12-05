using System;
using System.Reflection;
using System.Windows.Forms;

namespace Reflections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            Type T = Type.GetType("text");// this will  be null, as instead of giving the type, we have hard coded the text

            Type T1 = Type.GetType(text);
            MethodInfo[] met = T1.GetMethods();
            foreach (MethodInfo Method in met) 
            {
                Methods.Items.Add(Method.Name + " " + Method.GetParameters() + " " +Method.ReturnType.Name);
            }

            ConstructorInfo[] ctr = T1.GetConstructors();
            foreach (ConstructorInfo Cons in ctr)
            {
                Constructors.Items.Add( Cons.ToString());
            }

            PropertyInfo[] prop = T1.GetProperties();
            foreach (PropertyInfo pro in prop)
            {
                Properties.Items.Add(pro.Name+" " +pro.PropertyType);
            }
        }
    }
}
