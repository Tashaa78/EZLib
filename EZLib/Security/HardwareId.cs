﻿using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace EZLib.Security
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
                var key = sha256Managed.ComputeHash(Encoding.ASCII.GetBytes("EZLIB_HWID"));
                var iv = new byte[16]
                    {0x8, 0x2, 0x7, 0x4, 0x55, 0x1, 0x6, 0x9, 0x4, 0x92, 0x90, 0x22, 0x65, 0x2, 0x9, 0x1};

                return Cryptography.Encrypt(hardwareId, key, iv);
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