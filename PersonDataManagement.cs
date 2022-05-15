using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    internal class PersonDataManagement
    {

        //UC1 - Create list
        public static void GetRecords(List<Person> list)
        {
            Console.WriteLine("Records");
            Program.DisplayPersonDetails(list);
        }


        // UC2 - Get top 2 records age less than 60
        public static void GetTop2RecordsBasedOnAge(List<Person> list)
        {
            Console.WriteLine("\nGet Top 2 Records Based on Age");
            List<Person> top2 = list.FindAll(p => p.Age < 60).OrderBy(a => a.Age).Take(2).ToList();
            Program.DisplayPersonDetails(top2);
        }


        //UC3 - Retrieve all records from the list age between 13 to 18
        public static void GetTeenageRecords(List<Person> list)
        {
            Console.WriteLine("\nGet Teenage Records");
            List<Person> res = list.Where(p => p.Age >= 13 & p.Age <= 18).ToList();
            Program.DisplayPersonDetails(res);
        }


        //UC4 - Retrieve average age in the list
        public static void FindAverage(List<Person> list)
        {
            Console.WriteLine("\nAverage Age");
            double res = list.Average<Person>(a => a.Age);
            Console.WriteLine(res);
        }


        //UC5 - Check for specific name present in the list or not
        public static void SearchPersonBasedOnName(string name, List<Person> list)
        {
            Console.WriteLine("\nSearch Person By Name");
            List<Person> res = list.FindAll(p => p.Name == name);
            Program.DisplayPersonDetails(res);
        }


        //UC6 - Skip record from the list for age is less than 60
        public static void SkipRecordAgeLessThan60(List<Person> list)
        {
            Console.WriteLine("\nSkip Record Less Than 60");
            List<Person> data = list.OrderBy(p => p.Age).SkipWhile(p => p.Age < 60).ToList();
            Program.DisplayPersonDetails(data);

        }


        //UC7 - Remove specific person from list
        public static void RemoveSpecificPerson(string name, List<Person> list)
        {
            int res = list.RemoveAll(p => p.Name == name);
            Console.WriteLine();
            if (res != 0)
                Console.WriteLine("successfully removed");
            else
                Console.WriteLine("Failed to remove");
            Program.DisplayPersonDetails(list);
        }

    }
}
