using System.Collections.Generic;
using System.Text;
using System.Management;
using System.Security.Cryptography;
using System.Globalization;

namespace EZLib
{
    internal static class Hardware_ID
    {
        public static string Generate()
        {
            StringBuilder sBuilder = new StringBuilder();

            sBuilder.Append(Processor());
            sBuilder.Append(Bios());
            sBuilder.Append(Motherboard());
            sBuilder.Append(HDD());
            sBuilder.Append(GraphicsCard());

            return GetHash(sBuilder.ToString());
        }

        private static string GetHash(string data)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] hashData = sha1.ComputeHash(Encoding.Default.GetBytes(data));
                return GetHexString(hashData);
            }
        }

        private static string GetHexString(IList<byte> bt)
        {
            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < bt.Count; i++)
            {
                byte b = bt[i];
                int n = b;
                int n1 = n & 15;
                int n2 = (n >> 4) & 15;
                if (n2 > 9)
                    sBuilder.Append(((char)(n2 - 10 + 'A')).ToString(CultureInfo.InvariantCulture));
                else
                    sBuilder.Append(n2.ToString(CultureInfo.InvariantCulture));
                if (n1 > 9)
                    sBuilder.Append(((char)(n1 - 10 + 'A')).ToString(CultureInfo.InvariantCulture));
                else
                    sBuilder.Append(n1.ToString(CultureInfo.InvariantCulture));
                if ((i + 1) != bt.Count && (i + 1) % 2 == 0)
                    sBuilder.Append("-");
            }

            return sBuilder.ToString();
        }

        private static string Processor()
        {
            return GetHardwareProperty("Win32_Processor", "UniqueId", "ProcessorId", "Name", "Manufacturer");
        }

        private static string Bios()
        {
            return GetHardwareProperty("Win32_BIOS", "Manufacturer", "SMBIOSBIOSVersion", "IdentificationCode", "SerialNumber", "ReleaseDate", "Version");
        }

        private static string HDD()
        {
            return GetHardwareProperty("Win32_DiskDrive", "Model", "Manufacturer", "Signature", "TotalHeads");
        }

        private static string Motherboard()
        {
            return GetHardwareProperty("Win32_BaseBoard", "Model", "Manufacturer", "Name", "SerialNumber");
        }

        private static string GraphicsCard()
        {
            return GetHardwareProperty("Win32_VideoController", "DriverVersion", "Name");
        }

        private static string GetHardwareProperty(string wmiClass, params string[] properties)
        {
            StringBuilder sBuilder = new StringBuilder();
            sBuilder.Append("SELECT ");
            for (int i = 0; i < properties.Length; i++)
                sBuilder.Append((i < properties.Length - 1) ? $"{properties[i]}, " : $"{properties[i]} ");

            sBuilder.Append($"FROM {wmiClass}");

            using (ManagementObjectCollection moCollection = new ManagementObjectSearcher("root\\CIMV2", sBuilder.ToString()).Get())
                foreach (ManagementBaseObject mbObject in moCollection)
                    using (mbObject)
                        for (int i = 0; i < properties.Length; i++)
                            sBuilder.Append(mbObject.Properties[properties[i]]);

            return sBuilder.ToString();
        }
    }
}
