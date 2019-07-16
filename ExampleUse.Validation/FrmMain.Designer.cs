namespace ExampleUse.Validation
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem3 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.Database = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.txtInput = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnCheckEmpty = new DevComponents.DotNetBar.ButtonX();
            this.btnCheckNumeric = new DevComponents.DotNetBar.ButtonX();
            this.btnCheckMobile = new DevComponents.DotNetBar.ButtonX();
            this.btnCheckNationalCode = new DevComponents.DotNetBar.ButtonX();
            this.btnCheckLetter = new DevComponents.DotNetBar.ButtonX();
            this.lblResult = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtInputNetwork = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnCheckIpV4 = new DevComponents.DotNetBar.ButtonX();
            this.btnCheckPingIp = new DevComponents.DotNetBar.ButtonX();
            this.btnCheckInternet = new DevComponents.DotNetBar.ButtonX();
            this.btnCheckEmail = new DevComponents.DotNetBar.ButtonX();
            this.btnCheckOpenPort = new DevComponents.DotNetBar.ButtonX();
            this.btnCheckValidUrl = new DevComponents.DotNetBar.ButtonX();
            this.lblResultNetwork = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtInputWindows = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnCheckExtention = new DevComponents.DotNetBar.ButtonX();
            this.btnCheckAttribute = new DevComponents.DotNetBar.ButtonX();
            this.btnCheckDrive = new DevComponents.DotNetBar.ButtonX();
            this.btnCheckUsbConnect = new DevComponents.DotNetBar.ButtonX();
            this.btnCheckInstalledFont = new DevComponents.DotNetBar.ButtonX();
            this.lblResultWindows = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtInputDatabase = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnAgentSqlService = new DevComponents.DotNetBar.ButtonX();
            this.btnWriteSqlService = new DevComponents.DotNetBar.ButtonX();
            this.btnCheckExistTable = new DevComponents.DotNetBar.ButtonX();
            this.btnCheckEmptyTable = new DevComponents.DotNetBar.ButtonX();
            this.lblResultDatabase = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.superTabControlPanel3.SuspendLayout();
            this.superTabControlPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // superTabControl1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel4);
            this.superTabControl1.Controls.Add(this.superTabControlPanel3);
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl1.Location = new System.Drawing.Point(0, 0);
            this.superTabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 3;
            this.superTabControl1.Size = new System.Drawing.Size(452, 385);
            this.superTabControl1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.superTabControl1.TabIndex = 0;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1,
            this.superTabItem2,
            this.superTabItem3,
            this.Database});
            this.superTabControl1.Text = "DataBase Validation";
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "Public";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.lblResult);
            this.superTabControlPanel1.Controls.Add(this.btnCheckLetter);
            this.superTabControlPanel1.Controls.Add(this.btnCheckNationalCode);
            this.superTabControlPanel1.Controls.Add(this.btnCheckMobile);
            this.superTabControlPanel1.Controls.Add(this.btnCheckNumeric);
            this.superTabControlPanel1.Controls.Add(this.btnCheckEmpty);
            this.superTabControlPanel1.Controls.Add(this.labelX1);
            this.superTabControlPanel1.Controls.Add(this.txtInput);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(452, 360);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel2;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "Netwrok ";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.lblResultNetwork);
            this.superTabControlPanel2.Controls.Add(this.btnCheckValidUrl);
            this.superTabControlPanel2.Controls.Add(this.btnCheckOpenPort);
            this.superTabControlPanel2.Controls.Add(this.btnCheckEmail);
            this.superTabControlPanel2.Controls.Add(this.btnCheckInternet);
            this.superTabControlPanel2.Controls.Add(this.btnCheckPingIp);
            this.superTabControlPanel2.Controls.Add(this.btnCheckIpV4);
            this.superTabControlPanel2.Controls.Add(this.labelX2);
            this.superTabControlPanel2.Controls.Add(this.txtInputNetwork);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(452, 360);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.superTabItem2;
            // 
            // superTabItem3
            // 
            this.superTabItem3.AttachedControl = this.superTabControlPanel3;
            this.superTabItem3.GlobalItem = false;
            this.superTabItem3.Name = "superTabItem3";
            this.superTabItem3.Text = "Window ";
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.Controls.Add(this.lblResultWindows);
            this.superTabControlPanel3.Controls.Add(this.btnCheckInstalledFont);
            this.superTabControlPanel3.Controls.Add(this.btnCheckUsbConnect);
            this.superTabControlPanel3.Controls.Add(this.btnCheckDrive);
            this.superTabControlPanel3.Controls.Add(this.btnCheckAttribute);
            this.superTabControlPanel3.Controls.Add(this.btnCheckExtention);
            this.superTabControlPanel3.Controls.Add(this.labelX3);
            this.superTabControlPanel3.Controls.Add(this.txtInputWindows);
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(452, 360);
            this.superTabControlPanel3.TabIndex = 0;
            this.superTabControlPanel3.TabItem = this.superTabItem3;
            // 
            // Database
            // 
            this.Database.AttachedControl = this.superTabControlPanel4;
            this.Database.GlobalItem = false;
            this.Database.Name = "Database";
            this.Database.Text = "Database";
            // 
            // superTabControlPanel4
            // 
            this.superTabControlPanel4.Controls.Add(this.lblResultDatabase);
            this.superTabControlPanel4.Controls.Add(this.btnCheckEmptyTable);
            this.superTabControlPanel4.Controls.Add(this.btnCheckExistTable);
            this.superTabControlPanel4.Controls.Add(this.btnWriteSqlService);
            this.superTabControlPanel4.Controls.Add(this.btnAgentSqlService);
            this.superTabControlPanel4.Controls.Add(this.labelX4);
            this.superTabControlPanel4.Controls.Add(this.txtInputDatabase);
            this.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel4.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.superTabControlPanel4.Name = "superTabControlPanel4";
            this.superTabControlPanel4.Size = new System.Drawing.Size(452, 360);
            this.superTabControlPanel4.TabIndex = 0;
            this.superTabControlPanel4.TabItem = this.Database;
            // 
            // txtInput
            // 
            // 
            // 
            // 
            this.txtInput.Border.Class = "TextBoxBorder";
            this.txtInput.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtInput.Location = new System.Drawing.Point(77, 58);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInput.Name = "txtInput";
            this.txtInput.PreventEnterBeep = true;
            this.txtInput.Size = new System.Drawing.Size(350, 23);
            this.txtInput.TabIndex = 0;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(16, 59);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(39, 18);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Input :";
            // 
            // btnCheckEmpty
            // 
            this.btnCheckEmpty.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheckEmpty.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheckEmpty.Location = new System.Drawing.Point(94, 122);
            this.btnCheckEmpty.Name = "btnCheckEmpty";
            this.btnCheckEmpty.Size = new System.Drawing.Size(104, 29);
            this.btnCheckEmpty.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheckEmpty.TabIndex = 2;
            this.btnCheckEmpty.Text = "Check Empty";
            this.btnCheckEmpty.Click += new System.EventHandler(this.btnCheckEmpty_Click);
            // 
            // btnCheckNumeric
            // 
            this.btnCheckNumeric.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheckNumeric.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheckNumeric.Location = new System.Drawing.Point(278, 122);
            this.btnCheckNumeric.Name = "btnCheckNumeric";
            this.btnCheckNumeric.Size = new System.Drawing.Size(104, 29);
            this.btnCheckNumeric.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheckNumeric.TabIndex = 3;
            this.btnCheckNumeric.Text = "Check Numeric";
            this.btnCheckNumeric.Click += new System.EventHandler(this.btnCheckNumeric_Click);
            // 
            // btnCheckMobile
            // 
            this.btnCheckMobile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheckMobile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheckMobile.Location = new System.Drawing.Point(94, 186);
            this.btnCheckMobile.Name = "btnCheckMobile";
            this.btnCheckMobile.Size = new System.Drawing.Size(104, 29);
            this.btnCheckMobile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheckMobile.TabIndex = 4;
            this.btnCheckMobile.Text = "Check Mobile";
            this.btnCheckMobile.Click += new System.EventHandler(this.btnCheckMobile_Click);
            // 
            // btnCheckNationalCode
            // 
            this.btnCheckNationalCode.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheckNationalCode.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheckNationalCode.Location = new System.Drawing.Point(94, 242);
            this.btnCheckNationalCode.Name = "btnCheckNationalCode";
            this.btnCheckNationalCode.Size = new System.Drawing.Size(288, 29);
            this.btnCheckNationalCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheckNationalCode.TabIndex = 5;
            this.btnCheckNationalCode.Text = "Check National Code";
            this.btnCheckNationalCode.Click += new System.EventHandler(this.btnCheckNationalCode_Click);
            // 
            // btnCheckLetter
            // 
            this.btnCheckLetter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheckLetter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheckLetter.Location = new System.Drawing.Point(278, 186);
            this.btnCheckLetter.Name = "btnCheckLetter";
            this.btnCheckLetter.Size = new System.Drawing.Size(104, 29);
            this.btnCheckLetter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheckLetter.TabIndex = 6;
            this.btnCheckLetter.Text = "Check Letter";
            this.btnCheckLetter.Click += new System.EventHandler(this.btnCheckLetter_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblResult.Location = new System.Drawing.Point(179, 301);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(69, 18);
            this.lblResult.TabIndex = 7;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(18, 57);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(39, 18);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Input :";
            // 
            // txtInputNetwork
            // 
            // 
            // 
            // 
            this.txtInputNetwork.Border.Class = "TextBoxBorder";
            this.txtInputNetwork.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInputNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtInputNetwork.Location = new System.Drawing.Point(79, 56);
            this.txtInputNetwork.Margin = new System.Windows.Forms.Padding(4);
            this.txtInputNetwork.Name = "txtInputNetwork";
            this.txtInputNetwork.PreventEnterBeep = true;
            this.txtInputNetwork.Size = new System.Drawing.Size(350, 23);
            this.txtInputNetwork.TabIndex = 2;
            // 
            // btnCheckIpV4
            // 
            this.btnCheckIpV4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheckIpV4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheckIpV4.Location = new System.Drawing.Point(79, 111);
            this.btnCheckIpV4.Name = "btnCheckIpV4";
            this.btnCheckIpV4.Size = new System.Drawing.Size(104, 29);
            this.btnCheckIpV4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheckIpV4.TabIndex = 4;
            this.btnCheckIpV4.Text = "Check IP V4";
            this.btnCheckIpV4.Click += new System.EventHandler(this.btnCheckIpV4_Click);
            // 
            // btnCheckPingIp
            // 
            this.btnCheckPingIp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheckPingIp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheckPingIp.Location = new System.Drawing.Point(260, 111);
            this.btnCheckPingIp.Name = "btnCheckPingIp";
            this.btnCheckPingIp.Size = new System.Drawing.Size(104, 29);
            this.btnCheckPingIp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheckPingIp.TabIndex = 5;
            this.btnCheckPingIp.Text = "Check Ping IP";
            this.btnCheckPingIp.Click += new System.EventHandler(this.btnCheckPingIp_Click);
            // 
            // btnCheckInternet
            // 
            this.btnCheckInternet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheckInternet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheckInternet.Location = new System.Drawing.Point(79, 182);
            this.btnCheckInternet.Name = "btnCheckInternet";
            this.btnCheckInternet.Size = new System.Drawing.Size(104, 29);
            this.btnCheckInternet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheckInternet.TabIndex = 6;
            this.btnCheckInternet.Text = "Check Internet ";
            this.btnCheckInternet.Click += new System.EventHandler(this.btnCheckInternet_Click);
            // 
            // btnCheckEmail
            // 
            this.btnCheckEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheckEmail.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheckEmail.Location = new System.Drawing.Point(260, 182);
            this.btnCheckEmail.Name = "btnCheckEmail";
            this.btnCheckEmail.Size = new System.Drawing.Size(104, 29);
            this.btnCheckEmail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheckEmail.TabIndex = 7;
            this.btnCheckEmail.Text = "Check Email";
            this.btnCheckEmail.Click += new System.EventHandler(this.btnCheckEmail_Click);
            // 
            // btnCheckOpenPort
            // 
            this.btnCheckOpenPort.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheckOpenPort.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheckOpenPort.Location = new System.Drawing.Point(79, 253);
            this.btnCheckOpenPort.Name = "btnCheckOpenPort";
            this.btnCheckOpenPort.Size = new System.Drawing.Size(104, 29);
            this.btnCheckOpenPort.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheckOpenPort.TabIndex = 8;
            this.btnCheckOpenPort.Text = "Check Open Port";
            this.btnCheckOpenPort.Click += new System.EventHandler(this.btnCheckOpenPort_Click);
            // 
            // btnCheckValidUrl
            // 
            this.btnCheckValidUrl.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheckValidUrl.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheckValidUrl.Location = new System.Drawing.Point(260, 253);
            this.btnCheckValidUrl.Name = "btnCheckValidUrl";
            this.btnCheckValidUrl.Size = new System.Drawing.Size(104, 29);
            this.btnCheckValidUrl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheckValidUrl.TabIndex = 9;
            this.btnCheckValidUrl.Text = "Check Valid Url";
            this.btnCheckValidUrl.Click += new System.EventHandler(this.btnCheckValidUrl_Click);
            // 
            // lblResultNetwork
            // 
            this.lblResultNetwork.AutoSize = true;
            this.lblResultNetwork.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblResultNetwork.Location = new System.Drawing.Point(188, 312);
            this.lblResultNetwork.Name = "lblResultNetwork";
            this.lblResultNetwork.Size = new System.Drawing.Size(47, 18);
            this.lblResultNetwork.TabIndex = 10;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(16, 64);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(39, 18);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "Input :";
            // 
            // txtInputWindows
            // 
            // 
            // 
            // 
            this.txtInputWindows.Border.Class = "TextBoxBorder";
            this.txtInputWindows.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInputWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtInputWindows.Location = new System.Drawing.Point(77, 63);
            this.txtInputWindows.Margin = new System.Windows.Forms.Padding(4);
            this.txtInputWindows.Name = "txtInputWindows";
            this.txtInputWindows.PreventEnterBeep = true;
            this.txtInputWindows.Size = new System.Drawing.Size(350, 23);
            this.txtInputWindows.TabIndex = 4;
            // 
            // btnCheckExtention
            // 
            this.btnCheckExtention.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheckExtention.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheckExtention.Location = new System.Drawing.Point(101, 120);
            this.btnCheckExtention.Name = "btnCheckExtention";
            this.btnCheckExtention.Size = new System.Drawing.Size(131, 29);
            this.btnCheckExtention.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheckExtention.TabIndex = 6;
            this.btnCheckExtention.Text = "Check Extention";
            this.btnCheckExtention.Click += new System.EventHandler(this.btnCheckExtention_Click);
            // 
            // btnCheckAttribute
            // 
            this.btnCheckAttribute.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheckAttribute.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheckAttribute.Location = new System.Drawing.Point(278, 120);
            this.btnCheckAttribute.Name = "btnCheckAttribute";
            this.btnCheckAttribute.Size = new System.Drawing.Size(131, 29);
            this.btnCheckAttribute.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheckAttribute.TabIndex = 7;
            this.btnCheckAttribute.Text = "Check Attribute";
            this.btnCheckAttribute.Click += new System.EventHandler(this.btnCheckAttribute_Click);
            // 
            // btnCheckDrive
            // 
            this.btnCheckDrive.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheckDrive.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheckDrive.Location = new System.Drawing.Point(101, 185);
            this.btnCheckDrive.Name = "btnCheckDrive";
            this.btnCheckDrive.Size = new System.Drawing.Size(131, 29);
            this.btnCheckDrive.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheckDrive.TabIndex = 8;
            this.btnCheckDrive.Text = "Check Drive";
            this.btnCheckDrive.Click += new System.EventHandler(this.btnCheckDrive_Click);
            // 
            // btnCheckUsbConnect
            // 
            this.btnCheckUsbConnect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheckUsbConnect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheckUsbConnect.Location = new System.Drawing.Point(278, 185);
            this.btnCheckUsbConnect.Name = "btnCheckUsbConnect";
            this.btnCheckUsbConnect.Size = new System.Drawing.Size(131, 29);
            this.btnCheckUsbConnect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheckUsbConnect.TabIndex = 9;
            this.btnCheckUsbConnect.Text = "Check Usb Connect";
            this.btnCheckUsbConnect.Click += new System.EventHandler(this.btnCheckUsbConnect_Click);
            // 
            // btnCheckInstalledFont
            // 
            this.btnCheckInstalledFont.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheckInstalledFont.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheckInstalledFont.Location = new System.Drawing.Point(101, 248);
            this.btnCheckInstalledFont.Name = "btnCheckInstalledFont";
            this.btnCheckInstalledFont.Size = new System.Drawing.Size(308, 29);
            this.btnCheckInstalledFont.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheckInstalledFont.TabIndex = 10;
            this.btnCheckInstalledFont.Text = "Check Installed Font";
            this.btnCheckInstalledFont.Click += new System.EventHandler(this.btnCheckInstalledFont_Click);
            // 
            // lblResultWindows
            // 
            this.lblResultWindows.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblResultWindows.Location = new System.Drawing.Point(193, 306);
            this.lblResultWindows.Name = "lblResultWindows";
            this.lblResultWindows.Size = new System.Drawing.Size(75, 23);
            this.lblResultWindows.TabIndex = 11;
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(19, 54);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(39, 18);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "Input :";
            // 
            // txtInputDatabase
            // 
            // 
            // 
            // 
            this.txtInputDatabase.Border.Class = "TextBoxBorder";
            this.txtInputDatabase.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInputDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtInputDatabase.Location = new System.Drawing.Point(80, 53);
            this.txtInputDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.txtInputDatabase.Name = "txtInputDatabase";
            this.txtInputDatabase.PreventEnterBeep = true;
            this.txtInputDatabase.Size = new System.Drawing.Size(350, 23);
            this.txtInputDatabase.TabIndex = 6;
            // 
            // btnAgentSqlService
            // 
            this.btnAgentSqlService.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAgentSqlService.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAgentSqlService.Location = new System.Drawing.Point(80, 122);
            this.btnAgentSqlService.Name = "btnAgentSqlService";
            this.btnAgentSqlService.Size = new System.Drawing.Size(156, 29);
            this.btnAgentSqlService.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAgentSqlService.TabIndex = 8;
            this.btnAgentSqlService.Text = "Check Agent Sql Service";
            this.btnAgentSqlService.Click += new System.EventHandler(this.btnAgentSqlService_Click);
            // 
            // btnWriteSqlService
            // 
            this.btnWriteSqlService.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnWriteSqlService.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnWriteSqlService.Location = new System.Drawing.Point(266, 122);
            this.btnWriteSqlService.Name = "btnWriteSqlService";
            this.btnWriteSqlService.Size = new System.Drawing.Size(156, 29);
            this.btnWriteSqlService.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnWriteSqlService.TabIndex = 9;
            this.btnWriteSqlService.Text = "Check Writer Sql Service ";
            this.btnWriteSqlService.Click += new System.EventHandler(this.btnWriteSqlService_Click);
            // 
            // btnCheckExistTable
            // 
            this.btnCheckExistTable.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheckExistTable.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheckExistTable.Location = new System.Drawing.Point(80, 183);
            this.btnCheckExistTable.Name = "btnCheckExistTable";
            this.btnCheckExistTable.Size = new System.Drawing.Size(156, 29);
            this.btnCheckExistTable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheckExistTable.TabIndex = 10;
            this.btnCheckExistTable.Text = "Check Exists Table";
            this.btnCheckExistTable.Click += new System.EventHandler(this.btnCheckExistTable_Click);
            // 
            // btnCheckEmptyTable
            // 
            this.btnCheckEmptyTable.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheckEmptyTable.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheckEmptyTable.Location = new System.Drawing.Point(266, 183);
            this.btnCheckEmptyTable.Name = "btnCheckEmptyTable";
            this.btnCheckEmptyTable.Size = new System.Drawing.Size(156, 29);
            this.btnCheckEmptyTable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheckEmptyTable.TabIndex = 11;
            this.btnCheckEmptyTable.Text = "Check Empty Table";
            this.btnCheckEmptyTable.Click += new System.EventHandler(this.btnCheckEmptyTable_Click);
            // 
            // lblResultDatabase
            // 
            this.lblResultDatabase.AutoSize = true;
            this.lblResultDatabase.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblResultDatabase.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblResultDatabase.Location = new System.Drawing.Point(208, 255);
            this.lblResultDatabase.Name = "lblResultDatabase";
            this.lblResultDatabase.Size = new System.Drawing.Size(75, 23);
            this.lblResultDatabase.TabIndex = 12;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 385);
            this.Controls.Add(this.superTabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validation .Net Example";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.superTabControlPanel1.PerformLayout();
            this.superTabControlPanel2.ResumeLayout(false);
            this.superTabControlPanel2.PerformLayout();
            this.superTabControlPanel3.ResumeLayout(false);
            this.superTabControlPanel3.PerformLayout();
            this.superTabControlPanel4.ResumeLayout(false);
            this.superTabControlPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel3;
        private DevComponents.DotNetBar.SuperTabItem superTabItem3;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel4;
        private DevComponents.DotNetBar.SuperTabItem Database;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInput;
        private DevComponents.DotNetBar.ButtonX btnCheckNumeric;
        private DevComponents.DotNetBar.ButtonX btnCheckEmpty;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnCheckNationalCode;
        private DevComponents.DotNetBar.ButtonX btnCheckMobile;
        private DevComponents.DotNetBar.ButtonX btnCheckLetter;
        private DevComponents.DotNetBar.LabelX lblResult;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInputNetwork;
        private DevComponents.DotNetBar.ButtonX btnCheckInternet;
        private DevComponents.DotNetBar.ButtonX btnCheckPingIp;
        private DevComponents.DotNetBar.ButtonX btnCheckIpV4;
        private DevComponents.DotNetBar.ButtonX btnCheckValidUrl;
        private DevComponents.DotNetBar.ButtonX btnCheckOpenPort;
        private DevComponents.DotNetBar.ButtonX btnCheckEmail;
        private DevComponents.DotNetBar.LabelX lblResultNetwork;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInputWindows;
        private DevComponents.DotNetBar.ButtonX btnCheckInstalledFont;
        private DevComponents.DotNetBar.ButtonX btnCheckUsbConnect;
        private DevComponents.DotNetBar.ButtonX btnCheckDrive;
        private DevComponents.DotNetBar.ButtonX btnCheckAttribute;
        private DevComponents.DotNetBar.ButtonX btnCheckExtention;
        private DevComponents.DotNetBar.LabelX lblResultWindows;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtInputDatabase;
        private DevComponents.DotNetBar.LabelX lblResultDatabase;
        private DevComponents.DotNetBar.ButtonX btnCheckEmptyTable;
        private DevComponents.DotNetBar.ButtonX btnCheckExistTable;
        private DevComponents.DotNetBar.ButtonX btnWriteSqlService;
        private DevComponents.DotNetBar.ButtonX btnAgentSqlService;
    }
}