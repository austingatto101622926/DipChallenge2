using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DipChallenge2_DataAccess;

namespace ConsoleTesting
{
    class Program
    {
        public static DataHandler DH = new DataHandler("https://dipchallenge2.azurewebsites.net/");

        static void Main(string[] args)
        {
            Run();

            Console.ReadKey();
        }

        static public async void Run()
        {
            Event result = await DH.Event.GET(1);
            Console.WriteLine(result.Fee);
        }
    }
}
