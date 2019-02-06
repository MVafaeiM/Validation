using System;
using System.Collections.Generic;
using System.Windows.Markup;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Validation;
using Validation.Network;
using Validation.Public;

namespace Validation.UnitTest
{
    [TestClass]
    public class PublicTest
    {
        class Values
        {
            public string Value { set; get; }
            public bool Expected { set; get; }

        }
        [TestMethod]
        public void CheckEmptyTest()
        {
            //Arange 
            List<Values> values = new List<Values>
            {
                new Values(){Value = "test",Expected = false} ,
                new Values(){Value = "",Expected = true} ,
                new Values(){Value = null,Expected = false} ,
                new Values(){Value = "    ",Expected = true},
                new Values(){Value =string.Empty ,Expected = true}
            };

            foreach (var item in values)
            {
                //Actual 
                var act = item.Value.CheckEmpty();
                //Expected
                Assert.AreEqual(act, item.Expected);
            }
        }

        [TestMethod()]
        public void CheckNumericTest()
        {

            //Arange 
            List<Values> values = new List<Values>
            {
                new Values(){Value = "09363286141",Expected = true} ,
                new Values(){Value = "12345678910111213142254448448",Expected = false} ,
                new Values(){Value = null,Expected = false} ,
                new Values(){Value = "",Expected = false},
                new Values(){Value ="123" ,Expected = true}
            };
            

            foreach (var item in values)
            {
                //Actual 
                var act = item.Value.CheckNumeric();
                //Expected
                Assert.AreEqual(act, item.Expected);
            }
        }

        [TestMethod()]
        public void CheckLetterTest()
        {
            //Arange 
            List<Values> values = new List<Values>
            {
                new Values(){Value = "123",Expected = false} ,
                new Values(){Value = "132abs",Expected = false} ,
                new Values(){Value = null,Expected = false} ,
                new Values(){Value = "",Expected = false},
                new Values(){Value ="abs" ,Expected = true}
            };

            foreach (var item in values)
            {
                //Actual 
                var act = item.Value.CheckLetter();
                //Expected
                Assert.AreEqual(act, item.Expected);
            }
        }

        [TestMethod()]
        public void CheckNationalCodeTest()
        {
            //Arange 
            List<Values> values = new List<Values>
            {
                new Values(){Value = "0371222451",Expected = true} ,
                new Values(){Value = "021",Expected = false} ,
                new Values(){Value = null,Expected = false} ,
                new Values(){Value = "    ",Expected = false},
                new Values(){Value =string.Empty ,Expected = false} ,
                new Values(){Value ="8947411" ,Expected = false}
            };

            foreach (var item in values)
            {
                //Actual 
                var act = item.Value.CheckNationalCode();
                //Expected
                Assert.AreEqual(act, item.Expected);
            }
        }

        [TestMethod()]
        public void CheckMobileTest()
        {
            //Arange 
            List<Values> values = new List<Values>
            {
                new Values(){Value = "09363286141",Expected = true} ,
                new Values(){Value = "021",Expected = false} ,
                new Values(){Value = null,Expected = false} ,
                new Values(){Value = "    ",Expected = false},
                new Values(){Value =string.Empty ,Expected = false} ,
                new Values(){Value ="987456321" ,Expected = false} ,
                new Values(){Value ="Ali" ,Expected = false}
            };

            foreach (var item in values)
            {
                //Actual 
                var act = item.Value.CheckMobile(MobileOptional.WithZero);
                //Expected
                Assert.AreEqual(act, item.Expected);
            }
        }


    }
}
