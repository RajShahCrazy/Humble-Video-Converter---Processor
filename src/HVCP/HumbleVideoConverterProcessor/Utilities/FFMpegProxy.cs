using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Resources;
using System.IO;

namespace HumbleVideoConverterProcessor
{
    public static class FFMpegProxy
    {
        public static String runCommand(string args)
        {
            try
            {

                ProcessStartInfo info = new ProcessStartInfo("ffmpeg.exe", args);
                info.CreateNoWindow = false;
                info.UseShellExecute = true;
                info.WorkingDirectory = HumbleVideoConverterProcessor.Properties.Resources.EXE_DIR;
                Process proc = Process.Start(info);
                proc.WaitForExit();

                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public static string getOutputFileName(string inputFile, string outputFileName, string outputExt = null)
        {
            return Path.GetDirectoryName(inputFile) 
                + Path.DirectorySeparatorChar
                + Path.GetFileNameWithoutExtension(inputFile)
                + outputFileName
                + "."
                + (outputExt == null ? Path.GetExtension(inputFile) : outputExt);
        }

    }
}
