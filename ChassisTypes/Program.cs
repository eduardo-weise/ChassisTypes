using ChassisTypes.Chassis;

if (OperatingSystem.IsWindows())
{
    WindowsChassisTypes.Get();
}

if (OperatingSystem.IsLinux())
{
    LinuxChassisTypes.Get();
}