using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            AddPersonDetails(list);
            PersonDataManagement.GetRecords(list);
            PersonDataManagement.GetTop2RecordsBasedOnAge(list);
            PersonDataManagement.GetTeenageRecords(list);
            PersonDataManagement.FindAverage(list);
            PersonDataManagement.SearchPersonBasedOnName("Harish",list);
            PersonDataManagement.SkipRecordAgeLessThan60(list);
            PersonDataManagement.RemoveSpecificPerson("Harish", list);
            Console.ReadLine();
        }
        public static void AddPersonDetails(List<Person> list)
        {
            list.Add(new Person() { SSN = 1, Name = "Manoj", Address = "Pune", Age = 12 });
            list.Add(new Person() { SSN = 2, Name = "Sravan", Address = "Mumbai", Age = 70 });
            list.Add(new Person() { SSN = 3, Name = "Sai", Address = "Hyd", Age = 32 });
            list.Add(new Person() { SSN = 4, Name = "Harish", Address = "Bnglr", Age = 18 });
            list.Add(new Person() { SSN = 5, Name = "kamal", Address = "Vizag", Age = 63 });
            list.Add(new Person() { SSN = 6, Name = "Karan", Address = "Maharastra", Age = 36 });
            list.Add(new Person() { SSN = 6, Name = "Amul", Address = "Indore", Age = 14 });

        }
        public static void DisplayPersonDetails(List<Person> list)
        {
            foreach (Person person in list)
            {
                Console.WriteLine(person);
            }

        }

    }
}
