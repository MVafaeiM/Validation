using System;
using Validation.Windows;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Net.Mime;

namespace Validation.UnitTest
{
    [TestClass()]
    public class WindowsTest
    {
        class Values
        {
            public string Value { set; get; }
            public bool Expected { set; get; }
        }
        class ValuesExtention
        {
            public string Value { set; get; }
            public bool Expected { set; get; }
            public WindowsValidation.Extension Ex { set; get; }
        }
        class ValuesAttribute
        {
            public string Value { set; get; }
            public bool Expected { set; get; }
            public FileAttributes Attr { set; get; }
        }
        [TestMethod()]
        public void CheckExtentionTest()
        {
            List<ValuesExtention> values = new List<ValuesExtention>
            {
                new ValuesExtention(){Value = "",Expected = false,Ex = WindowsValidation.Extension.Html} ,
                new ValuesExtention(){Value = "C:\\file.html",Expected = true,Ex=WindowsValidation.Extension.Html} ,
                new ValuesExtention(){Value = "C:\\file.html.",Expected = false,Ex=WindowsValidation.Extension.Html},
                new ValuesExtention(){Value = null,Expected = false,Ex=WindowsValidation.Extension.Html}

            };
            //Arange 
            foreach (var item in values)
            {
                //Actual 
                var act = item.Value.CheckExtention(WindowsValidation.Extension.Html);
                //Expected
                Assert.AreEqual(act, item.Expected);
            }
        }

        [TestMethod()]
        public void CheckAttributeFileTest()
        {
            List<ValuesAttribute> values = new List<ValuesAttribute>
            {
                new ValuesAttribute(){Value = @"c:\test.wav",Expected = true,Attr = FileAttributes.Archive} ,

            };
            //Arange 
            foreach (var item in values)
            {
                //Actual 
                var act = item.Value.CheckAttributeFile(item.Attr);
                //Expected
                Assert.AreEqual(act, item.Expected);
            }
        }

        [TestMethod()]
        public void CheckExistDriveTest()
        {
            List<Values> values = new List<Values>
            {
                new Values(){Value = @"d:\",Expected = true} ,
                new Values(){Value = "d:\\",Expected = true} ,
                new Values(){Value = "w:",Expected = false} ,
                new Values(){Value = null,Expected = false} ,
            };
            //Arange 
            foreach (var item in values)
            {
                //Actual 
                var act = item.Value.CheckExistDrive();
                //Expected
                Assert.AreEqual(act, item.Expected);
            }
        }

        [TestMethod()]
        public void CheckUsbConnectTest()
        {
            Assert.AreEqual(WindowsValidation.CheckUsbConnect(), false);
        }

        [TestMethod()]
        public void CheckInstalledFontTest()
        {
            List<Values> values = new List<Values>
            {
                new Values(){Value = "tahoma",Expected = true} ,
                new Values(){Value = "arial",Expected = true} ,
                new Values(){Value = "B Lotus",Expected = true} ,
                new Values(){Value = "B test",Expected = false} ,
                new Values(){Value = "B Yekan",Expected = true} ,
            };
            //Arange 
            foreach (var item in values)
            {
                //Actual 
                var act = item.Value.CheckInstalledFont();
                //Expected
                Assert.AreEqual(act, item.Expected);
            }
        }
    }
}
