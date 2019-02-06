using Validation.DataBase;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;

namespace Validation.UnitTest
{
    [TestClass]
    public class DataBaseTest
    {
        [TestMethod()]
        public void CheckAvalibleServiceAgentSqlServerTest()
        {
            bool act = DataBaseValidation.CheckAvalibleServiceAgentSqlServer();
            Assert.AreEqual(act, true);
        }

        [TestMethod()]
        public void CheckAvalibleServiceSqlWriterSqlServerTest()
        {
            bool act = DataBaseValidation.CheckAvalibleServiceSqlWriterSqlServer();
            Assert.AreEqual(act, true);
        }

        [TestMethod()]
        public void CheckExistsTableTest()
        {
            //arrange 
            SqlConnection sqlCon = new SqlConnection("Data Source=.;Initial Catalog=CommerceDb;Integrated Security=True");
            string tblName = "tblAccountSide";
            sqlCon.Open();
            bool act = sqlCon.CheckExistsTable(tblName);

            Assert.AreEqual(act, true);

        }

        [TestMethod()]
        public void CheckEmptyTableTest()
        {
            SqlConnection sqlCon = new SqlConnection("Data Source=.;Initial Catalog=CommerceDb;Integrated Security=True");
            string tblName = "tblAccountSide";
            bool act = sqlCon.CheckEmptyTable(tblName);

            Assert.AreEqual(act,false);
        }
    }
}
