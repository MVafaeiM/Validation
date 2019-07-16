using System;
using System.Windows.Forms;
using Validation.Public;
using Validation.DataBase;
using Validation.Network;
using Validation.Windows;
using System.Data.SqlClient;

namespace ExampleUse.Validation
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }


        #region PublicValidationExampleTab

        private void btnCheckEmpty_Click(object sender, EventArgs e)
        {
            lblResult.Text = txtInput.Text.CheckEmpty().ToString();
        }

        private void btnCheckNumeric_Click(object sender, EventArgs e)
        {
            lblResult.Text = txtInput.Text.CheckNumeric().ToString();
        }

        private void btnCheckMobile_Click(object sender, EventArgs e)
        {
            lblResult.Text = txtInput.Text.CheckMobile(MobileOptional.WithZero).ToString();
        }

        private void btnCheckLetter_Click(object sender, EventArgs e)
        {
            lblResult.Text = txtInput.Text.CheckLetter().ToString();
        }

        private void btnCheckNationalCode_Click(object sender, EventArgs e)
        {
            lblResult.Text = txtInput.Text.CheckNationalCode().ToString();
        }


        #endregion

        #region NetworkValidationExampleTab
        private void btnCheckIpV4_Click(object sender, EventArgs e)
        {
            lblResultNetwork.Text = txtInputNetwork.Text.CheckIPv4().ToString();

        }

        private void btnCheckPingIp_Click(object sender, EventArgs e)
        {
            lblResultNetwork.Text = txtInputNetwork.Text.CheckPingIp(500).ToString();
        }

        private void btnCheckInternet_Click(object sender, EventArgs e)
        {
            lblResultNetwork.Text = NetworkValidation.CheckInternetConnection().ToString();
        }

        private void btnCheckEmail_Click(object sender, EventArgs e)
        {
            lblResultNetwork.Text = txtInputNetwork.Text.CheckEmail().ToString();
        }

        private void btnCheckOpenPort_Click(object sender, EventArgs e)
        {
            lblResultNetwork.Text = NetworkValidation.CheckOpenedPort(int.Parse(txtInputNetwork.Text)).ToString();
        }

        private void btnCheckValidUrl_Click(object sender, EventArgs e)
        {
            lblResultNetwork.Text = txtInputNetwork.Text.CheckValidUrl().ToString();
        }



        #endregion

        #region WindowsValidationExampleTab
        private void btnCheckExtention_Click(object sender, EventArgs e)
        {
            lblResultWindows.Text = txtInputWindows.Text.CheckExtention(WindowsValidation.Extension.Mp3).ToString();
        }

        private void btnCheckAttribute_Click(object sender, EventArgs e)
        {
            lblResultWindows.Text = txtInputWindows.Text.CheckAttributeFile(System.IO.FileAttributes.Archive).ToString();
        }

        private void btnCheckDrive_Click(object sender, EventArgs e)
        {
            lblResultWindows.Text = txtInputWindows.Text.CheckExistDrive().ToString();
        }

        private void btnCheckUsbConnect_Click(object sender, EventArgs e)
        {
            lblResultWindows.Text = WindowsValidation.CheckUsbConnect().ToString();
        }

        private void btnCheckInstalledFont_Click(object sender, EventArgs e)
        {
            lblResultWindows.Text = txtInputWindows.Text.CheckInstalledFont().ToString();
        }


        #endregion

        #region DatabaseValidationExampleTab

        private void btnAgentSqlService_Click(object sender, EventArgs e)
        {
            lblResultDatabase.Text = DataBaseValidation.CheckAvalibleServiceAgentSqlServer().ToString();
        }

        private void btnWriteSqlService_Click(object sender, EventArgs e)
        {
            lblResultDatabase.Text = DataBaseValidation.CheckAvalibleServiceSqlWriterSqlServer().ToString();
        }

        private void btnCheckEmptyTable_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Your Connection String");
            lblResultDatabase.Text = DataBaseValidation.CheckEmptyTable(sqlConnection, "yourTable").ToString();
        }

        private void btnCheckExistTable_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Your Connection String");

            lblResultDatabase.Text = DataBaseValidation.CheckExistsTable(sqlConnection, "YourTable").ToString();
        }

        #endregion


    }
}
