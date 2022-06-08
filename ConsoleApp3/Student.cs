using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Student
    {
        public string FirstName { get; init; }
        public string LastName { get; set; }

        private readonly string firstName;
        private readonly string lastName;

        //public string FirstName
        //{
        //    get => firstName;
        //    init => firstName = string.IsNullOrWhiteSpace(value)
        //        ? throw new ArgumentException("Can't be null or space") : value;
        //}
        //public string LastName
        //{
        //    get => lastName;
        //    init => lastName = string.IsNullOrWhiteSpace(value)
        //        ? throw new ArgumentException("Can't be null or space") : value;
        //}
    }
    class OldStudent
    {
        public OldStudent(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; }
        public string LastName { get; }
    }
}
