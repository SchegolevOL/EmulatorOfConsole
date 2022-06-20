using System.Text;
using Consol;

namespace Consol.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str;
            do
            {
                str = Console.ReadLine();
                switch (str)
                {
                    case ("drive info"):
                        Consol.MyDriveInfo();
                        break;
                    case ("help"):
                        Consol.Help();
                        break;

                    default:
                        break;
                }


            } while (!str.Equals("exit"));
        }
    }
}