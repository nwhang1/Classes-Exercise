using System.Security.Cryptography.X509Certificates;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make = "Toyota";
            myCar.Model = "RAV4";
            myCar.year = 2020;

            Console.WriteLine($"Make: {myCar.Make}, Model : {myCar.Model} , Year: {myCar.year}");
        }
    }
}
