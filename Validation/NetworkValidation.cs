using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

namespace Validation
{
    namespace Network
    {
        public static class NetworkValidation
        {
            public static bool CheckIPv4(this string input)
            {
                IPAddress address;
                if (IPAddress.TryParse(input, out address))
                {
                    if (address.AddressFamily == AddressFamily.InterNetwork)
                    {
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
                    PingReply r;
                    String s = ip; //Replace input from your text box for IP address here
                    r = p.Send(s, timeout);
                    if (r.Status == IPStatus.Success)
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
                bool networkUp = NetworkInterface.GetIsNetworkAvailable();
                return networkUp;
            }
            public static bool CheckEmail(this string mailAddress)
            {
                string strPattern = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                if (System.Text.RegularExpressions.Regex.IsMatch(mailAddress, strPattern))
                { return true; }
                return false;
            }
            public static bool CheckUrlValid(this string source)
            {
                Uri uriResult;
                return Uri.TryCreate(source, UriKind.Absolute, out uriResult) && uriResult.Scheme == Uri.UriSchemeHttp;
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
            public static bool IsValidUrl(this string url)
            {
                Regex rx = new Regex(@"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?");
                return rx.IsMatch(url);
            }


        }
    }

}
