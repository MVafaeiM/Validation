using Validation.Windows;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

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
            public WindowsValidation.Extension ex { set; get; }
        }
        class ValuesAttribute
        {
            public string Value { set; get; }
            public bool Expected { set; get; }
            public FileAttributes attr { set; get; }
        }
        [TestMethod()]
        public void CheckExtentionTest()
        {
            List<ValuesExtention> values = new List<ValuesExtention>
            {
                new ValuesExtention(){Value = "",Expected = false,ex = WindowsValidation.Extension.Html} ,
                new ValuesExtention(){Value = "C:\\file.html",Expected = true,ex=WindowsValidation.Extension.Html} ,
                new ValuesExtention(){Value = "C:\\file.html.",Expected = false,ex=WindowsValidation.Extension.Html},
                new ValuesExtention(){Value = null,Expected = false,ex=WindowsValidation.Extension.Html}

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
                new ValuesAttribute(){Value = @"c:\test.wav",Expected = true,attr = FileAttributes.Archive} ,

            };
            //Arange 
            foreach (var item in values)
            {
                //Actual 
                var act = item.Value.CheckAttributeFile(item.attr);
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
    }
}
