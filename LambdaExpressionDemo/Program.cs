using System.Net;

namespace LambdaExpressionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<Person> listPersonInCity = new List<Person>();
            LambdaDemo.AddRecords(listPersonInCity);
          //  LambdaDemo.Retrieving_TopTwoRecord_ForAgels_LessThanSixty(listPersonInCity);
          //  LambdaDemo.CheckingForTeenagerPerson(listPersonInCity);
          //  LambdaDemo.AllPersonsAverageAge(listPersonInCity);
          //  LambdaDemo.CheckNameExistOrNot(listPersonInCity);
            Console.ReadKey();
           
        }
    }
}