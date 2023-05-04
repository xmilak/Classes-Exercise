using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car old = new Car();

            old.Make = "BMW";
            old.Year = "1996";
            old.Model = "E36";


            old.Data();

        }
    }
}
