using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole.App
{
    public static class Consol
    {
        public static void MyDriveInfo()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine(
                    $"Drive {d.Name}");
                Console.WriteLine(
                    $"  Drive type: {d.DriveType}");
                if (d.IsReady == true)
                {
                    Console.WriteLine(
                        $"  Volume label: {d.VolumeLabel}");
                    Console.WriteLine(
                        $"  File system: {d.DriveFormat}");
                    Console.WriteLine(
                        $"  Available space to current user:{d.AvailableFreeSpace, 15} bytes");
                    Console.WriteLine(
                        $"  Total available space:          {d.TotalFreeSpace, 15} bytes");
                    Console.WriteLine(
                        $"  Total size of drive:            {d.TotalSize, 15} bytes ");
                }
            }
        }
    }
}
