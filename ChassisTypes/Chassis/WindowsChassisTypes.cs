using System.Management;
using System.Runtime.Versioning;

namespace ChassisTypes.Chassis;

[SupportedOSPlatform("windows")]
public class WindowsChassisTypes : IChassisTypes
{
    public static void Get()
    {
        var property = "ChassisTypes";
        var searcher = new ManagementObjectSearcher($"SELECT {property} FROM Win32_SystemEnclosure");

        foreach (ManagementObject obj in searcher.Get().Cast<ManagementObject>())
        {
            foreach (ushort type in (ushort[])obj[property])
            {
                var chassisType = type switch
                {
                    1 => ChassisTypesEnum.Other,
                    2 => ChassisTypesEnum.Unknown,
                    3 => ChassisTypesEnum.Desktop,
                    4 => ChassisTypesEnum.LowProfileDesktop,
                    5 => ChassisTypesEnum.PizzaBox,
                    6 => ChassisTypesEnum.MiniTower,
                    7 => ChassisTypesEnum.Tower,
                    8 => ChassisTypesEnum.Portable,
                    9 => ChassisTypesEnum.Laptop,
                    10 => ChassisTypesEnum.Notebook,
                    11 => ChassisTypesEnum.HandHeld,
                    12 => ChassisTypesEnum.DockingStation,
                    13 => ChassisTypesEnum.AllInOne,
                    14 => ChassisTypesEnum.SubNotebook,
                    15 => ChassisTypesEnum.SpaceSaving,
                    16 => ChassisTypesEnum.LunchBox,
                    17 => ChassisTypesEnum.MainSystemChassis,
                    18 => ChassisTypesEnum.ExpansionChassis,
                    19 => ChassisTypesEnum.SubChassis,
                    20 => ChassisTypesEnum.BusExpansionChassis,
                    21 => ChassisTypesEnum.PeripheralChassis,
                    22 => ChassisTypesEnum.StorageChassis,
                    23 => ChassisTypesEnum.RackMountChassis,
                    24 => ChassisTypesEnum.SealedCasePC,
                    30 => ChassisTypesEnum.Tablet,
                    31 => ChassisTypesEnum.Convertible,
                    32 => ChassisTypesEnum.Detachable,
                    _ => default,
                };
                Console.WriteLine(chassisType);
            }
        }
    }
}
