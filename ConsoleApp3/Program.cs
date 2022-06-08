using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello New Feature!");
            Student st = new Student() { FirstName = "   " };
            st.LastName = "MyLastName";

            //record part
            Student st2 = new Student() {FirstName="a",LastName="b" };
             Student st3 = new Student() { FirstName = st2.FirstName, LastName = "c" };
            //
            PersonRecord p1 = new PersonRecord { FirstName = "At", LastName = "Ra" };
          //  var p=new  Person ("fg", 56 );
     

            var p2 = p1 with { LastName = "Ah" };
            var p3 = p2 with { LastName = "Ra" };
            
            Console.WriteLine(p2==p1);
            Console.WriteLine(p3==p1);
            Console.WriteLine(p3.Equals(p1));
            Console.WriteLine("Ref "+ReferenceEquals(p3,p1));

            Test t = new Test { Name = "a" };
            Test t2 = new Test { Name = "a" };
            Console.WriteLine(t==t2); ;
            Console.WriteLine(t.Equals(t2));
         

            //old class initialize
            OldStudent oldStudent = new OldStudent("Atieh","Rasouli");
            //oldStudent.FirstName = "";
            Console.WriteLine("By Old Feature!");

        }
    }
}
