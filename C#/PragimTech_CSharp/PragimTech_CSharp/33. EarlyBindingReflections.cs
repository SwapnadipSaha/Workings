using System;
using System.Reflection;

namespace NSEarlyBindingReflections
{
    /// <summary>
    /// There are two classes Reflections and Customer. While build this console application, these classes will compiled into an IL
    /// and packaged into an assembly (.exe or  .dll). An assembly has two parts one is the IL and the otherv one is MetaData, which contains the name of the class
    /// the types, members etc of thr class
    /// </summary>
    class EarlyBindingReflections
    {
        public static void Main33()
        {
            // We want write the list of elements (properties, methods, constructors, fields etc)

            //Type T = Type.GetType("NSEarlyBindingReflections.Customer"); //GetType() is a static method of Type class.
            //this method will get the type of the class i.e. <Namespace>.<Class>

            //Type T = typeof(Customer);

            Customer c1 = new Customer();
            Type T = c1.GetType();

            Console.WriteLine("------------Type Description---------------");
            Console.WriteLine("Full Name of Type:" + T.FullName);
            Console.WriteLine("Name of Type:" + T.Name);
            Console.WriteLine("Assembly Qualified Name of Type:" + T.AssemblyQualifiedName);
            Console.WriteLine("Namespace of Type:" + T.Namespace);
            Console.WriteLine("BaseType of Type:" + T.BaseType);

            Console.WriteLine("------------Properties of the Types---------------");
            PropertyInfo[] props = T.GetProperties(); // The GetProperty returns n array of PropertyInfo from using System.Reflection;
            foreach (PropertyInfo pro in props)
            {
                Console.WriteLine("Property Name -" + pro.Name + ". Property Type  -" + pro.PropertyType + ". Property Can Read  -" + pro.CanRead);
            }

            Console.WriteLine("------------Methods of the types---------------");
            MethodInfo[] meth = T.GetMethods(); // The GetMethods returns n array of MethodInfo from using System.Reflection;
            foreach (MethodInfo met in meth)
            {
                Console.WriteLine("Method Name -" + met.Name + ". Return Types -" + met.ReturnType + ". Parameters- " + met.GetParameters() + ". Is Static -" + met.IsStatic + ". DeclaringType -" + met.DeclaringType);
                Console.WriteLine();
            }

            Console.WriteLine("------------Fields of the types---------------");

            FieldInfo[] field = T.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

// The GetFields returns n array of FieldInfo from using System.Reflection; By default, GetFields() only returns public fields. If the class T has no public fields, nothing will be displayed. You can retrieve all fields (public and non-public) by modifying the GetFields call like this

            foreach (FieldInfo fld in field)
            {
                Console.WriteLine("Attributes Name -" + fld.Attributes + ". Field Name -" + fld.Name + ". fld.ToString()- " + fld.ToString() + ". Declaring Type -" + fld.DeclaringType + "Name -"+fld.Name);
            }


            Console.WriteLine("------------Constructors of the types---------------");
            ConstructorInfo[] ctor = T.GetConstructors(); // The GetConstructors returns n array of ConstructorInfo from using System.Reflection;
            foreach (ConstructorInfo cons in ctor)
            {
                Console.WriteLine("Is Public -" + cons.IsPublic + ". Parameters- " + cons.GetParameters() + ". DeclaringType -" + cons.DeclaringType  );
            }

            foreach (ConstructorInfo cons in ctor)
            {
                Console.WriteLine(cons.ToString());
            }
            
        }
    }
    class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public Customer()
        {
            this.id = -1;
            this.name = string.Empty;
        }

        public Customer(int Id, string Name)
        {
            this.id = Id;
            this.name = Name;
        }

        public void PrintID()
        {
            Console.WriteLine("Id is {0}", this.id);
        }
        public void PrintName()
        {
            Console.WriteLine("Name is {0}", this.name);
        }
    }
}
