using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using Validation.Public;

namespace Validation
{
    namespace Network
    {
        public static class NetworkValidation
        {
            public static bool CheckIPv4(this string input)
            {
                if (input.CheckEmpty()) return false;
                if (input == null) return false;
                if (input.Contains(".") == false) return false;
                if (IPAddress.TryParse(input, out var address))
                {
                    if (address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        if (address.GetAddressBytes().Length == 4)
                            return true;
                    }
                }
                return false;
            }
            public static bool CheckPingIp(this string ip, int timeout)
            {
                if (CheckIPv4(ip) == false) return false;
                try
                {
                    Ping p = new Ping();
                    String s = ip; 
                    var r = p.Send(s, timeout);
                    if (r != null && r.Status == IPStatus.Success)
                    {
                        return true;
                    }
                    return false;
                }
                catch (PingException)
                {
                    return false;
                }
            }
            public static bool CheckInternetConnection()
            {
                    try
                    {
                        using (var client = new WebClient())
                        using (client.OpenRead("http://google.com"))
                        {
                            return true;
                        }
                    }
                    catch
                    {
                        return false;
                    }
            }
            public static bool CheckEmail(this string mailAddress)
            {
                if (mailAddress.CheckEmpty()) return false;
                if (mailAddress == null) return false;
                string strPattern = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                if (Regex.IsMatch(mailAddress, strPattern))
                { return true; }
                return false;
            }
            public static bool CheckOpenedPort(this int port)
            {
                IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
                IPEndPoint[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpListeners();

                foreach (IPEndPoint endpoint in tcpConnInfoArray)
                {
                    if (endpoint.Port == port)
                    {
                        return true;
                    }
                }
                return false;
            }
            public static bool CheckValidUrl(this string url)
            {
                if (url.CheckEmpty()) return false;
                if (url == null) return false; 
                Regex rx = new Regex(@"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?");
                return rx.IsMatch(url);
            }


        }
    }

}
