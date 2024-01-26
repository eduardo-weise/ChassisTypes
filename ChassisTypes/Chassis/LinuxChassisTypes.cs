using System.Diagnostics;
using System.Runtime.Versioning;

namespace ChassisTypes.Chassis;

[SupportedOSPlatform("linux")]
public class LinuxChassisTypes : IChassisTypes
{
    public static void Get()
    {
        var startInfo = new ProcessStartInfo
        {
            FileName = "/bin/bash",
            Arguments = "-c \"sudo dmidecode -t chassis\"",
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true,
        };

        var process = new Process { StartInfo = startInfo };
        process.Start();

        string output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();

        Console.WriteLine(output);
    }
}
