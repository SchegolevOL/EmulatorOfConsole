using System;

namespace MyConsole.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str;

            do
            {
                str = Console.ReadLine();
                string[] consol = str.Split('-');
                switch (consol[0])
                {
                    case ("driver info"):
                        Consol.MyDriveInfo();
                        break;
                    default:
                        break;
                }


            } while (!str.Equals("exit"));
        }
    }
}
