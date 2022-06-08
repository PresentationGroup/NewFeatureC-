using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public record PersonRecord
    {
        // public PersonRecord(string ss)


        public string FirstName { get; init; }
        public string LastName { get; set; }
    }

    public record PersonRecord2(int BaseTemperature, string TempRecords) { }

   public record Person(string Name, int Age) { }
}
