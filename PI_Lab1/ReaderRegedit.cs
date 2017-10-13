using Microsoft.Win32;

namespace PI_Lab1
{
    public static class ReaderRegedit
    {
        private static string _way = @"HARDWARE\ACPI\DSDT\ALASKA\A_M_I\00000015";

        public static string GetValue(string way = null)
        {
            var key = Registry.LocalMachine.OpenSubKey(_way == null ? way : _way);
            return key.GetValue("00000000").ToString();
        }
    }
}
