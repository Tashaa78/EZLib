using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace EZLib.Utility
{
    internal class HardwareId
    {
        public string Generate()
        {
            string hardwareId;
            string hddModel;
            string hddManufacturer;
            string hddSerialNumber;
            string motherboardModel;
            string motherboardManufacturer;
            string motherboardNumber;

            hddModel = GetComponentId("Win32_DiskDrive", "Model");
            hddManufacturer = GetComponentId("Win32_DiskDrive", "Manufacturer");
            hddSerialNumber = GetComponentId("Win32_DiskDrive", "SerialNumber");
            motherboardModel = GetComponentId("Win32_BaseBoard", "Model");
            motherboardManufacturer = GetComponentId("Win32_BaseBoard", "Manufacturer");
            motherboardNumber = GetComponentId("Win32_BaseBoard", "SerialNumber");

            hardwareId = hddModel + hddManufacturer + hddSerialNumber + motherboardModel + motherboardManufacturer +
                         motherboardNumber;

            using (var sha256Managed = new SHA256Managed())
            {
                var hashedHardwareId = Encoding.ASCII.GetBytes(hardwareId);
                var hashValue = sha256Managed.ComputeHash(hashedHardwareId);
                var hash = "";

                foreach (byte x in hashValue)
                {
                    hash += String.Format("{0:x2}", x);
                }
                return hash;
            }
        }

        private string GetComponentId(string hwclass, string syntax)
        {
            var managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementObject managementObject in managementObjectSearcher.Get())
                return Convert.ToString(managementObject[syntax]);
            return string.Empty;
        }
    }
}