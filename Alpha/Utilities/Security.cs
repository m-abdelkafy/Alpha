using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace Alpha.Utilities
{
    public static class Security
    {
        private static List<string> GetMacAddressList()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            List<string> macList = new List<string>();
            foreach (NetworkInterface adapter in nics)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties();
                var sMacAddress = adapter.GetPhysicalAddress().ToString();
                macList.Add(sMacAddress);
            }
            return macList;
        }

        public static bool ValidateComputer(string thisPcMacAddress)
        {
            List<string> macAddresses = GetMacAddressList();
            return macAddresses.Contains(thisPcMacAddress);
        }
    }
}
