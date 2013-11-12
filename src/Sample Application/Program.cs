using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessStartInfo info = new ProcessStartInfo("ffmpeg.exe");
            info.Arguments = " -i " + "Wildlife.wmv" + " -vn -ac 2 -ar 44100 -ab 320k -f mp3 " + "output.mp3";

            Process.Start(info);
            Console.ReadKey();
        }
    }
}
