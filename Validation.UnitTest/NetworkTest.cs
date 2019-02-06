using Validation.Network;
using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Validation.UnitTest
{
    [TestClass]
    public class NetworkTest
    {
        class Values
        {
            public string Value { set; get; }
            public bool Expected { set; get; }

        }

        [TestMethod()]
        public void CheckIPv4Test()
        {
            List<Values> values = new List<Values>
            {
                new Values() {Value = "192.168.1.1", Expected = true},
                new Values() {Value = "1.1.1.1", Expected = true},
                new Values() {Value = null, Expected = false},
                new Values() {Value = "", Expected = false},
                new Values() {Value = "ali", Expected = false},
                new Values() {Value = "123", Expected = false}
            };
            //Arange 

            foreach (var item in values)
            {
                //Actual 
                var act = item.Value.CheckIPv4();
                //Expected
                Assert.AreEqual(act, item.Expected);
            }
        }

        [TestMethod()]
        public void CheckPingIpTest()
        {
            List<Values> values = new List<Values>
            {
                new Values() {Value = "192.168.1.1", Expected = false},
                new Values() {Value = "1.1.1.1", Expected = false},
                new Values() {Value = null, Expected = false},
                new Values() {Value = "", Expected = false},
                new Values() {Value = "ali", Expected = false},
                new Values() {Value = "123", Expected = false},
                new Values() {Value = "127.0.0.1", Expected = true}
            };
            //Arange 

            foreach (var item in values)
            {
                //Actual 
                var act = item.Value.CheckPingIp(500);
                //Expected
                Assert.AreEqual(act, item.Expected);
            }
        }

        [TestMethod()]
        public void CheckInternetConnectionTest()
        {
            //Arange 
            //Actual 
            var act = NetworkValidation.CheckInternetConnection();
            //Expected
            Assert.AreEqual(act, false);
        }

        [TestMethod()]
        public void CheckEmailTest()
        {
            List<Values> values = new List<Values>
            {
                new Values() {Value = "mvmsoft7@gmail.com", Expected = true},
                new Values() {Value = "1.1.1.1", Expected = false},
                new Values() {Value = null, Expected = false},
                new Values() {Value = "", Expected = false},
                new Values() {Value = "ali", Expected = false},
                new Values() {Value = "123", Expected = false},
                new Values() {Value = "@test.com", Expected = false}
            };
            //Arange 

            foreach (var item in values)
            {
                //Actual 
                var act = item.Value.CheckEmail();
                //Expected
                Assert.AreEqual(act, item.Expected);
            }
        }

        [TestMethod()]
        public void CheckOpenedPortTest()
        {
            List<Values> values = new List<Values>
            {
                new Values() {Value = "8080", Expected = false},
                new Values() {Value = "80", Expected = true},
                new Values() {Value = "0", Expected = false},
                new Values() {Value = "13", Expected = true},
            };
            //Arange 

            foreach (var item in values)
            {
                //Actual 
                var act = int.Parse(item.Value).CheckOpenedPort();
                //Expected
                Assert.AreEqual(act, item.Expected);
            }
        }

        [TestMethod()]
        public void CheckValidUrlTest()
        {
            //Arange 
            List<Values> values = new List<Values>
            {
                new Values() {Value = "http://google.com", Expected = true},
                new Values() {Value = "www.google.com", Expected = false},
                new Values() {Value = "test.com", Expected = false},
                new Values() {Value = "test", Expected = false},
                new Values() {Value = "https://google.com", Expected = true},
            };
            
            foreach (var item in values)
            {
                //Actual 
                var act = item.Value.CheckValidUrl();
                //Expected
                Assert.AreEqual(act, item.Expected);
            }
        }
    }
}
