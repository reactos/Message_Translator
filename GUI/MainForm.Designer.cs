namespace MsgTranslator
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainLookupButton = new System.Windows.Forms.Button();
            this.mainErrTxtBox = new System.Windows.Forms.TextBox();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.errorMsgTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.errorHexTxtBox = new System.Windows.Forms.TextBox();
            this.errorBackButton = new System.Windows.Forms.Button();
            this.errorForwardButton = new System.Windows.Forms.Button();
            this.errorTypeValueLabel = new System.Windows.Forms.Label();
            this.errorCodeTxtBox = new System.Windows.Forms.TextBox();
            this.errorCodeLabel = new System.Windows.Forms.Label();
            this.errorMessageTxtBox = new System.Windows.Forms.TextBox();
            this.errorDecimalTxtBox = new System.Windows.Forms.TextBox();
            this.errorTypeLabel = new System.Windows.Forms.Label();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.errorNumberLabel = new System.Windows.Forms.Label();
            this.wndmsgTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.wndmsgHexTxtBox = new System.Windows.Forms.TextBox();
            this.wndmsgDecimalTxtBox = new System.Windows.Forms.TextBox();
            this.wndmsgCodeTxtBox = new System.Windows.Forms.TextBox();
            this.wndmsgCodeLabel = new System.Windows.Forms.Label();
            this.wndmsgNumberLabel = new System.Windows.Forms.Label();
            this.status2Dos = new System.Windows.Forms.TabPage();
            this.dosCodeInfoLabel = new System.Windows.Forms.Label();
            this.ntstatusCodeInfoLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dosHexTextBox = new System.Windows.Forms.TextBox();
            this.dosDecimalTextBox = new System.Windows.Forms.TextBox();
            this.dosCodeTxtBox = new System.Windows.Forms.TextBox();
            this.dosDosErrorLabel = new System.Windows.Forms.Label();
            this.dosNumberLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ntstatusHexTextBox = new System.Windows.Forms.TextBox();
            this.ntstatusDecimalTextBox = new System.Windows.Forms.TextBox();
            this.ntstatusCodeTxtBox = new System.Windows.Forms.TextBox();
            this.ntstatusNtStatusLabel = new System.Windows.Forms.Label();
            this.ntstatusNumberLabel = new System.Windows.Forms.Label();
            this.bugurlTab = new System.Windows.Forms.TabPage();
            this.JiraSummaryLink = new System.Windows.Forms.LinkLabel();
            this.JiraDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.JiraAssigneeTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.JiraReporterTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.JiraResolutionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.JiraStatusTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bugLinkLabel = new System.Windows.Forms.LinkLabel();
            this.optionsTab = new System.Windows.Forms.TabPage();
            this.CopyrightlinkLabel = new System.Windows.Forms.LinkLabel();
            this.optionsRunStartChkBox = new System.Windows.Forms.CheckBox();
            this.optionsMinimizeChkBox = new System.Windows.Forms.CheckBox();
            this.mainErrLabel = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mainTabControl.SuspendLayout();
            this.errorMsgTab.SuspendLayout();
            this.wndmsgTab.SuspendLayout();
            this.status2Dos.SuspendLayout();
            this.bugurlTab.SuspendLayout();
            this.optionsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLookupButton
            // 
            this.mainLookupButton.Location = new System.Drawing.Point(237, 12);
            this.mainLookupButton.Name = "mainLookupButton";
            this.mainLookupButton.Size = new System.Drawing.Size(75, 23);
            this.mainLookupButton.TabIndex = 1;
            this.mainLookupButton.Text = "Lookup";
            this.mainLookupButton.UseVisualStyleBackColor = true;
            this.mainLookupButton.Click += new System.EventHandler(this.mainLookupButton_Click);
            // 
            // mainErrTxtBox
            // 
            this.mainErrTxtBox.Location = new System.Drawing.Point(79, 13);
            this.mainErrTxtBox.Name = "mainErrTxtBox";
            this.mainErrTxtBox.Size = new System.Drawing.Size(152, 20);
            this.mainErrTxtBox.TabIndex = 0;
            this.mainErrTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainErrTxtBox_KeyPress);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.errorMsgTab);
            this.mainTabControl.Controls.Add(this.wndmsgTab);
            this.mainTabControl.Controls.Add(this.status2Dos);
            this.mainTabControl.Controls.Add(this.bugurlTab);
            this.mainTabControl.Controls.Add(this.optionsTab);
            this.mainTabControl.Location = new System.Drawing.Point(12, 41);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(300, 211);
            this.mainTabControl.TabIndex = 2;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged);
            // 
            // errorMsgTab
            // 
            this.errorMsgTab.Controls.Add(this.label1);
            this.errorMsgTab.Controls.Add(this.errorHexTxtBox);
            this.errorMsgTab.Controls.Add(this.errorBackButton);
            this.errorMsgTab.Controls.Add(this.errorForwardButton);
            this.errorMsgTab.Controls.Add(this.errorTypeValueLabel);
            this.errorMsgTab.Controls.Add(this.errorCodeTxtBox);
            this.errorMsgTab.Controls.Add(this.errorCodeLabel);
            this.errorMsgTab.Controls.Add(this.errorMessageTxtBox);
            this.errorMsgTab.Controls.Add(this.errorDecimalTxtBox);
            this.errorMsgTab.Controls.Add(this.errorTypeLabel);
            this.errorMsgTab.Controls.Add(this.errorMessageLabel);
            this.errorMsgTab.Controls.Add(this.errorNumberLabel);
            this.errorMsgTab.Location = new System.Drawing.Point(4, 22);
            this.errorMsgTab.Name = "errorMsgTab";
            this.errorMsgTab.Padding = new System.Windows.Forms.Padding(3);
            this.errorMsgTab.Size = new System.Drawing.Size(292, 185);
            this.errorMsgTab.TabIndex = 1;
            this.errorMsgTab.Text = "Error Msg";
            this.errorMsgTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "/";
            // 
            // errorHexTxtBox
            // 
            this.errorHexTxtBox.Location = new System.Drawing.Point(176, 38);
            this.errorHexTxtBox.Name = "errorHexTxtBox";
            this.errorHexTxtBox.ReadOnly = true;
            this.errorHexTxtBox.Size = new System.Drawing.Size(104, 20);
            this.errorHexTxtBox.TabIndex = 6;
            // 
            // errorBackButton
            // 
            this.errorBackButton.Location = new System.Drawing.Point(236, 6);
            this.errorBackButton.Name = "errorBackButton";
            this.errorBackButton.Size = new System.Drawing.Size(22, 22);
            this.errorBackButton.TabIndex = 3;
            this.errorBackButton.Text = "<";
            this.errorBackButton.UseVisualStyleBackColor = true;
            this.errorBackButton.Click += new System.EventHandler(this.NavigateErrorPage);
            // 
            // errorForwardButton
            // 
            this.errorForwardButton.Location = new System.Drawing.Point(258, 6);
            this.errorForwardButton.Name = "errorForwardButton";
            this.errorForwardButton.Size = new System.Drawing.Size(22, 22);
            this.errorForwardButton.TabIndex = 4;
            this.errorForwardButton.Text = ">";
            this.errorForwardButton.UseVisualStyleBackColor = true;
            this.errorForwardButton.Click += new System.EventHandler(this.NavigateErrorPage);
            // 
            // errorTypeValueLabel
            // 
            this.errorTypeValueLabel.AutoSize = true;
            this.errorTypeValueLabel.Location = new System.Drawing.Point(64, 15);
            this.errorTypeValueLabel.Name = "errorTypeValueLabel";
            this.errorTypeValueLabel.Size = new System.Drawing.Size(0, 13);
            this.errorTypeValueLabel.TabIndex = 0;
            // 
            // errorCodeTxtBox
            // 
            this.errorCodeTxtBox.Location = new System.Drawing.Point(63, 64);
            this.errorCodeTxtBox.Name = "errorCodeTxtBox";
            this.errorCodeTxtBox.ReadOnly = true;
            this.errorCodeTxtBox.Size = new System.Drawing.Size(217, 20);
            this.errorCodeTxtBox.TabIndex = 7;
            // 
            // errorCodeLabel
            // 
            this.errorCodeLabel.AutoSize = true;
            this.errorCodeLabel.Location = new System.Drawing.Point(10, 67);
            this.errorCodeLabel.Name = "errorCodeLabel";
            this.errorCodeLabel.Size = new System.Drawing.Size(35, 13);
            this.errorCodeLabel.TabIndex = 0;
            this.errorCodeLabel.Text = "Code:";
            // 
            // errorMessageTxtBox
            // 
            this.errorMessageTxtBox.Location = new System.Drawing.Point(13, 109);
            this.errorMessageTxtBox.Multiline = true;
            this.errorMessageTxtBox.Name = "errorMessageTxtBox";
            this.errorMessageTxtBox.ReadOnly = true;
            this.errorMessageTxtBox.Size = new System.Drawing.Size(267, 59);
            this.errorMessageTxtBox.TabIndex = 8;
            // 
            // errorDecimalTxtBox
            // 
            this.errorDecimalTxtBox.Location = new System.Drawing.Point(63, 38);
            this.errorDecimalTxtBox.Name = "errorDecimalTxtBox";
            this.errorDecimalTxtBox.ReadOnly = true;
            this.errorDecimalTxtBox.Size = new System.Drawing.Size(98, 20);
            this.errorDecimalTxtBox.TabIndex = 5;
            // 
            // errorTypeLabel
            // 
            this.errorTypeLabel.AutoSize = true;
            this.errorTypeLabel.Location = new System.Drawing.Point(10, 15);
            this.errorTypeLabel.Name = "errorTypeLabel";
            this.errorTypeLabel.Size = new System.Drawing.Size(34, 13);
            this.errorTypeLabel.TabIndex = 0;
            this.errorTypeLabel.Text = "Type:";
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Location = new System.Drawing.Point(10, 93);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(53, 13);
            this.errorMessageLabel.TabIndex = 0;
            this.errorMessageLabel.Text = "Message:";
            // 
            // errorNumberLabel
            // 
            this.errorNumberLabel.AutoSize = true;
            this.errorNumberLabel.Location = new System.Drawing.Point(10, 41);
            this.errorNumberLabel.Name = "errorNumberLabel";
            this.errorNumberLabel.Size = new System.Drawing.Size(47, 13);
            this.errorNumberLabel.TabIndex = 0;
            this.errorNumberLabel.Text = "Number:";
            // 
            // wndmsgTab
            // 
            this.wndmsgTab.Controls.Add(this.label2);
            this.wndmsgTab.Controls.Add(this.wndmsgHexTxtBox);
            this.wndmsgTab.Controls.Add(this.wndmsgDecimalTxtBox);
            this.wndmsgTab.Controls.Add(this.wndmsgCodeTxtBox);
            this.wndmsgTab.Controls.Add(this.wndmsgCodeLabel);
            this.wndmsgTab.Controls.Add(this.wndmsgNumberLabel);
            this.wndmsgTab.Location = new System.Drawing.Point(4, 22);
            this.wndmsgTab.Name = "wndmsgTab";
            this.wndmsgTab.Size = new System.Drawing.Size(292, 185);
            this.wndmsgTab.TabIndex = 2;
            this.wndmsgTab.Text = "Window Msg";
            this.wndmsgTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "/";
            // 
            // wndmsgHexTxtBox
            // 
            this.wndmsgHexTxtBox.Location = new System.Drawing.Point(176, 12);
            this.wndmsgHexTxtBox.Name = "wndmsgHexTxtBox";
            this.wndmsgHexTxtBox.ReadOnly = true;
            this.wndmsgHexTxtBox.Size = new System.Drawing.Size(104, 20);
            this.wndmsgHexTxtBox.TabIndex = 4;
            // 
            // wndmsgDecimalTxtBox
            // 
            this.wndmsgDecimalTxtBox.Location = new System.Drawing.Point(63, 12);
            this.wndmsgDecimalTxtBox.Name = "wndmsgDecimalTxtBox";
            this.wndmsgDecimalTxtBox.ReadOnly = true;
            this.wndmsgDecimalTxtBox.Size = new System.Drawing.Size(98, 20);
            this.wndmsgDecimalTxtBox.TabIndex = 3;
            // 
            // wndmsgCodeTxtBox
            // 
            this.wndmsgCodeTxtBox.Location = new System.Drawing.Point(63, 38);
            this.wndmsgCodeTxtBox.Name = "wndmsgCodeTxtBox";
            this.wndmsgCodeTxtBox.ReadOnly = true;
            this.wndmsgCodeTxtBox.Size = new System.Drawing.Size(217, 20);
            this.wndmsgCodeTxtBox.TabIndex = 5;
            // 
            // wndmsgCodeLabel
            // 
            this.wndmsgCodeLabel.AutoSize = true;
            this.wndmsgCodeLabel.Location = new System.Drawing.Point(10, 41);
            this.wndmsgCodeLabel.Name = "wndmsgCodeLabel";
            this.wndmsgCodeLabel.Size = new System.Drawing.Size(35, 13);
            this.wndmsgCodeLabel.TabIndex = 0;
            this.wndmsgCodeLabel.Text = "Code:";
            // 
            // wndmsgNumberLabel
            // 
            this.wndmsgNumberLabel.AutoSize = true;
            this.wndmsgNumberLabel.Location = new System.Drawing.Point(10, 15);
            this.wndmsgNumberLabel.Name = "wndmsgNumberLabel";
            this.wndmsgNumberLabel.Size = new System.Drawing.Size(47, 13);
            this.wndmsgNumberLabel.TabIndex = 0;
            this.wndmsgNumberLabel.Text = "Number:";
            // 
            // status2Dos
            // 
            this.status2Dos.Controls.Add(this.dosCodeInfoLabel);
            this.status2Dos.Controls.Add(this.ntstatusCodeInfoLabel);
            this.status2Dos.Controls.Add(this.label11);
            this.status2Dos.Controls.Add(this.dosHexTextBox);
            this.status2Dos.Controls.Add(this.dosDecimalTextBox);
            this.status2Dos.Controls.Add(this.dosCodeTxtBox);
            this.status2Dos.Controls.Add(this.dosDosErrorLabel);
            this.status2Dos.Controls.Add(this.dosNumberLabel);
            this.status2Dos.Controls.Add(this.label8);
            this.status2Dos.Controls.Add(this.ntstatusHexTextBox);
            this.status2Dos.Controls.Add(this.ntstatusDecimalTextBox);
            this.status2Dos.Controls.Add(this.ntstatusCodeTxtBox);
            this.status2Dos.Controls.Add(this.ntstatusNtStatusLabel);
            this.status2Dos.Controls.Add(this.ntstatusNumberLabel);
            this.status2Dos.Location = new System.Drawing.Point(4, 22);
            this.status2Dos.Name = "status2Dos";
            this.status2Dos.Padding = new System.Windows.Forms.Padding(3);
            this.status2Dos.Size = new System.Drawing.Size(292, 185);
            this.status2Dos.TabIndex = 5;
            this.status2Dos.Text = "Status to Win32";
            this.status2Dos.UseVisualStyleBackColor = true;
            // 
            // dosCodeInfoLabel
            // 
            this.dosCodeInfoLabel.AutoSize = true;
            this.dosCodeInfoLabel.Location = new System.Drawing.Point(60, 102);
            this.dosCodeInfoLabel.Name = "dosCodeInfoLabel";
            this.dosCodeInfoLabel.Size = new System.Drawing.Size(178, 13);
            this.dosCodeInfoLabel.TabIndex = 27;
            this.dosCodeInfoLabel.Text = "Win32 / DOS error code Information";
            // 
            // ntstatusCodeInfoLabel
            // 
            this.ntstatusCodeInfoLabel.AutoSize = true;
            this.ntstatusCodeInfoLabel.Location = new System.Drawing.Point(60, 14);
            this.ntstatusCodeInfoLabel.Name = "ntstatusCodeInfoLabel";
            this.ntstatusCodeInfoLabel.Size = new System.Drawing.Size(147, 13);
            this.ntstatusCodeInfoLabel.TabIndex = 26;
            this.ntstatusCodeInfoLabel.Text = "NTSTATUS code Information";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(162, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "/";
            // 
            // dosHexTextBox
            // 
            this.dosHexTextBox.Location = new System.Drawing.Point(176, 123);
            this.dosHexTextBox.Name = "dosHexTextBox";
            this.dosHexTextBox.ReadOnly = true;
            this.dosHexTextBox.Size = new System.Drawing.Size(104, 20);
            this.dosHexTextBox.TabIndex = 23;
            // 
            // dosDecimalTextBox
            // 
            this.dosDecimalTextBox.Location = new System.Drawing.Point(63, 123);
            this.dosDecimalTextBox.Name = "dosDecimalTextBox";
            this.dosDecimalTextBox.ReadOnly = true;
            this.dosDecimalTextBox.Size = new System.Drawing.Size(98, 20);
            this.dosDecimalTextBox.TabIndex = 22;
            // 
            // dosCodeTxtBox
            // 
            this.dosCodeTxtBox.Location = new System.Drawing.Point(63, 149);
            this.dosCodeTxtBox.Name = "dosCodeTxtBox";
            this.dosCodeTxtBox.ReadOnly = true;
            this.dosCodeTxtBox.Size = new System.Drawing.Size(217, 20);
            this.dosCodeTxtBox.TabIndex = 24;
            // 
            // dosDosErrorLabel
            // 
            this.dosDosErrorLabel.AutoSize = true;
            this.dosDosErrorLabel.Location = new System.Drawing.Point(21, 152);
            this.dosDosErrorLabel.Name = "dosDosErrorLabel";
            this.dosDosErrorLabel.Size = new System.Drawing.Size(41, 13);
            this.dosDosErrorLabel.TabIndex = 20;
            this.dosDosErrorLabel.Text = "Win32:";
            // 
            // dosNumberLabel
            // 
            this.dosNumberLabel.AutoSize = true;
            this.dosNumberLabel.Location = new System.Drawing.Point(15, 126);
            this.dosNumberLabel.Name = "dosNumberLabel";
            this.dosNumberLabel.Size = new System.Drawing.Size(47, 13);
            this.dosNumberLabel.TabIndex = 21;
            this.dosNumberLabel.Text = "Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "/";
            // 
            // ntstatusHexTextBox
            // 
            this.ntstatusHexTextBox.Location = new System.Drawing.Point(176, 35);
            this.ntstatusHexTextBox.Name = "ntstatusHexTextBox";
            this.ntstatusHexTextBox.ReadOnly = true;
            this.ntstatusHexTextBox.Size = new System.Drawing.Size(104, 20);
            this.ntstatusHexTextBox.TabIndex = 17;
            // 
            // ntstatusDecimalTextBox
            // 
            this.ntstatusDecimalTextBox.Location = new System.Drawing.Point(63, 35);
            this.ntstatusDecimalTextBox.Name = "ntstatusDecimalTextBox";
            this.ntstatusDecimalTextBox.ReadOnly = true;
            this.ntstatusDecimalTextBox.Size = new System.Drawing.Size(98, 20);
            this.ntstatusDecimalTextBox.TabIndex = 16;
            // 
            // ntstatusCodeTxtBox
            // 
            this.ntstatusCodeTxtBox.Location = new System.Drawing.Point(63, 61);
            this.ntstatusCodeTxtBox.Name = "ntstatusCodeTxtBox";
            this.ntstatusCodeTxtBox.ReadOnly = true;
            this.ntstatusCodeTxtBox.Size = new System.Drawing.Size(217, 20);
            this.ntstatusCodeTxtBox.TabIndex = 18;
            // 
            // ntstatusNtStatusLabel
            // 
            this.ntstatusNtStatusLabel.AutoSize = true;
            this.ntstatusNtStatusLabel.Location = new System.Drawing.Point(10, 64);
            this.ntstatusNtStatusLabel.Name = "ntstatusNtStatusLabel";
            this.ntstatusNtStatusLabel.Size = new System.Drawing.Size(51, 13);
            this.ntstatusNtStatusLabel.TabIndex = 14;
            this.ntstatusNtStatusLabel.Text = "NtStatus:";
            // 
            // ntstatusNumberLabel
            // 
            this.ntstatusNumberLabel.AutoSize = true;
            this.ntstatusNumberLabel.Location = new System.Drawing.Point(14, 38);
            this.ntstatusNumberLabel.Name = "ntstatusNumberLabel";
            this.ntstatusNumberLabel.Size = new System.Drawing.Size(47, 13);
            this.ntstatusNumberLabel.TabIndex = 15;
            this.ntstatusNumberLabel.Text = "Number:";
            // 
            // bugurlTab
            // 
            this.bugurlTab.Controls.Add(this.JiraSummaryLink);
            this.bugurlTab.Controls.Add(this.JiraDescriptionTextBox);
            this.bugurlTab.Controls.Add(this.label6);
            this.bugurlTab.Controls.Add(this.JiraAssigneeTextBox);
            this.bugurlTab.Controls.Add(this.label7);
            this.bugurlTab.Controls.Add(this.JiraReporterTextBox);
            this.bugurlTab.Controls.Add(this.label5);
            this.bugurlTab.Controls.Add(this.JiraResolutionTextBox);
            this.bugurlTab.Controls.Add(this.label4);
            this.bugurlTab.Controls.Add(this.JiraStatusTextBox);
            this.bugurlTab.Controls.Add(this.label3);
            this.bugurlTab.Controls.Add(this.bugLinkLabel);
            this.bugurlTab.Location = new System.Drawing.Point(4, 22);
            this.bugurlTab.Name = "bugurlTab";
            this.bugurlTab.Size = new System.Drawing.Size(292, 185);
            this.bugurlTab.TabIndex = 3;
            this.bugurlTab.Text = "JIRA";
            this.bugurlTab.UseVisualStyleBackColor = true;
            // 
            // JiraSummaryLink
            // 
            this.JiraSummaryLink.AutoSize = true;
            this.JiraSummaryLink.Location = new System.Drawing.Point(55, 14);
            this.JiraSummaryLink.Name = "JiraSummaryLink";
            this.JiraSummaryLink.Size = new System.Drawing.Size(0, 13);
            this.JiraSummaryLink.TabIndex = 18;
            this.JiraSummaryLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.JiraSummaryLink_LinkClicked);
            // 
            // JiraDescriptionTextBox
            // 
            this.JiraDescriptionTextBox.Location = new System.Drawing.Point(7, 95);
            this.JiraDescriptionTextBox.Multiline = true;
            this.JiraDescriptionTextBox.Name = "JiraDescriptionTextBox";
            this.JiraDescriptionTextBox.ReadOnly = true;
            this.JiraDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.JiraDescriptionTextBox.Size = new System.Drawing.Size(275, 74);
            this.JiraDescriptionTextBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Assignee:";
            // 
            // JiraAssigneeTextBox
            // 
            this.JiraAssigneeTextBox.Location = new System.Drawing.Point(200, 43);
            this.JiraAssigneeTextBox.Name = "JiraAssigneeTextBox";
            this.JiraAssigneeTextBox.ReadOnly = true;
            this.JiraAssigneeTextBox.Size = new System.Drawing.Size(82, 20);
            this.JiraAssigneeTextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Reporter:";
            // 
            // JiraReporterTextBox
            // 
            this.JiraReporterTextBox.Location = new System.Drawing.Point(58, 43);
            this.JiraReporterTextBox.Name = "JiraReporterTextBox";
            this.JiraReporterTextBox.ReadOnly = true;
            this.JiraReporterTextBox.Size = new System.Drawing.Size(86, 20);
            this.JiraReporterTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Resolution:";
            // 
            // JiraResolutionTextBox
            // 
            this.JiraResolutionTextBox.Location = new System.Drawing.Point(58, 69);
            this.JiraResolutionTextBox.Name = "JiraResolutionTextBox";
            this.JiraResolutionTextBox.ReadOnly = true;
            this.JiraResolutionTextBox.Size = new System.Drawing.Size(86, 20);
            this.JiraResolutionTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status:";
            // 
            // JiraStatusTextBox
            // 
            this.JiraStatusTextBox.Location = new System.Drawing.Point(200, 69);
            this.JiraStatusTextBox.Name = "JiraStatusTextBox";
            this.JiraStatusTextBox.ReadOnly = true;
            this.JiraStatusTextBox.Size = new System.Drawing.Size(82, 20);
            this.JiraStatusTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Summary:";
            // 
            // bugLinkLabel
            // 
            this.bugLinkLabel.AutoSize = true;
            this.bugLinkLabel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.bugLinkLabel.Location = new System.Drawing.Point(160, 172);
            this.bugLinkLabel.Name = "bugLinkLabel";
            this.bugLinkLabel.Size = new System.Drawing.Size(132, 13);
            this.bugLinkLabel.TabIndex = 3;
            this.bugLinkLabel.TabStop = true;
            this.bugLinkLabel.Text = "ReactOS JIRA Homepage";
            this.bugLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.bugLinkLabel_LinkClicked);
            // 
            // optionsTab
            // 
            this.optionsTab.Controls.Add(this.CopyrightlinkLabel);
            this.optionsTab.Controls.Add(this.optionsRunStartChkBox);
            this.optionsTab.Controls.Add(this.optionsMinimizeChkBox);
            this.optionsTab.Location = new System.Drawing.Point(4, 22);
            this.optionsTab.Name = "optionsTab";
            this.optionsTab.Size = new System.Drawing.Size(292, 185);
            this.optionsTab.TabIndex = 4;
            this.optionsTab.Text = "Options";
            this.optionsTab.UseVisualStyleBackColor = true;
            // 
            // CopyrightlinkLabel
            // 
            this.CopyrightlinkLabel.AutoSize = true;
            this.CopyrightlinkLabel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.CopyrightlinkLabel.Location = new System.Drawing.Point(120, 172);
            this.CopyrightlinkLabel.Name = "CopyrightlinkLabel";
            this.CopyrightlinkLabel.Size = new System.Drawing.Size(169, 13);
            this.CopyrightlinkLabel.TabIndex = 5;
            this.CopyrightlinkLabel.TabStop = true;
            this.CopyrightlinkLabel.Text = "Copyright 2008-2018  Ged Murphy";
            this.CopyrightlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyrightlinkLabel_LinkClicked);
            // 
            // optionsRunStartChkBox
            // 
            this.optionsRunStartChkBox.AutoSize = true;
            this.optionsRunStartChkBox.Location = new System.Drawing.Point(5, 32);
            this.optionsRunStartChkBox.Name = "optionsRunStartChkBox";
            this.optionsRunStartChkBox.Size = new System.Drawing.Size(150, 17);
            this.optionsRunStartChkBox.TabIndex = 4;
            this.optionsRunStartChkBox.Text = "Run when Windows starts";
            this.optionsRunStartChkBox.UseVisualStyleBackColor = true;
            this.optionsRunStartChkBox.CheckedChanged += new System.EventHandler(this.OptionsHaveChanged);
            // 
            // optionsMinimizeChkBox
            // 
            this.optionsMinimizeChkBox.AutoSize = true;
            this.optionsMinimizeChkBox.Location = new System.Drawing.Point(5, 9);
            this.optionsMinimizeChkBox.Name = "optionsMinimizeChkBox";
            this.optionsMinimizeChkBox.Size = new System.Drawing.Size(125, 17);
            this.optionsMinimizeChkBox.TabIndex = 3;
            this.optionsMinimizeChkBox.Text = "Hide when minimized";
            this.optionsMinimizeChkBox.UseVisualStyleBackColor = true;
            this.optionsMinimizeChkBox.CheckedChanged += new System.EventHandler(this.OptionsHaveChanged);
            // 
            // mainErrLabel
            // 
            this.mainErrLabel.AutoSize = true;
            this.mainErrLabel.Location = new System.Drawing.Point(16, 17);
            this.mainErrLabel.Name = "mainErrLabel";
            this.mainErrLabel.Size = new System.Drawing.Size(53, 13);
            this.mainErrLabel.TabIndex = 0;
            this.mainErrLabel.Text = "Message:";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(200, 100);
            this.tabPage1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 100);
            this.tabPage2.TabIndex = 0;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 264);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.mainErrLabel);
            this.Controls.Add(this.mainErrTxtBox);
            this.Controls.Add(this.mainLookupButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Message Translator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.mainTabControl.ResumeLayout(false);
            this.errorMsgTab.ResumeLayout(false);
            this.errorMsgTab.PerformLayout();
            this.wndmsgTab.ResumeLayout(false);
            this.wndmsgTab.PerformLayout();
            this.status2Dos.ResumeLayout(false);
            this.status2Dos.PerformLayout();
            this.bugurlTab.ResumeLayout(false);
            this.bugurlTab.PerformLayout();
            this.optionsTab.ResumeLayout(false);
            this.optionsTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainLookupButton;
        private System.Windows.Forms.TextBox mainErrTxtBox;
        private System.Windows.Forms.Label mainErrLabel;
        private System.Windows.Forms.CheckBox optionsMinimizeChkBox;
        private System.Windows.Forms.TextBox errorMessageTxtBox;
        private System.Windows.Forms.TextBox errorDecimalTxtBox;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Label errorNumberLabel;
        private System.Windows.Forms.Label errorTypeLabel;
        private System.Windows.Forms.TextBox wndmsgCodeTxtBox;
        private System.Windows.Forms.Label wndmsgCodeLabel;
        private System.Windows.Forms.Label wndmsgNumberLabel;
        private System.Windows.Forms.LinkLabel bugLinkLabel;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage errorMsgTab;
        private System.Windows.Forms.TabPage wndmsgTab;
        private System.Windows.Forms.TabPage bugurlTab;
        private System.Windows.Forms.TabPage optionsTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox optionsRunStartChkBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox errorCodeTxtBox;
        private System.Windows.Forms.Label errorCodeLabel;
        private System.Windows.Forms.Label errorTypeValueLabel;
        private System.Windows.Forms.Button errorBackButton;
        private System.Windows.Forms.Button errorForwardButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox errorHexTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wndmsgHexTxtBox;
        private System.Windows.Forms.TextBox wndmsgDecimalTxtBox;
        private System.Windows.Forms.TextBox JiraDescriptionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox JiraAssigneeTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox JiraReporterTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox JiraResolutionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox JiraStatusTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel JiraSummaryLink;
        private System.Windows.Forms.LinkLabel CopyrightlinkLabel;
        private System.Windows.Forms.TabPage status2Dos;
        private System.Windows.Forms.Label dosCodeInfoLabel;
        private System.Windows.Forms.Label ntstatusCodeInfoLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox dosHexTextBox;
        private System.Windows.Forms.TextBox dosDecimalTextBox;
        private System.Windows.Forms.TextBox dosCodeTxtBox;
        private System.Windows.Forms.Label dosDosErrorLabel;
        private System.Windows.Forms.Label dosNumberLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ntstatusHexTextBox;
        private System.Windows.Forms.TextBox ntstatusDecimalTextBox;
        private System.Windows.Forms.TextBox ntstatusCodeTxtBox;
        private System.Windows.Forms.Label ntstatusNtStatusLabel;
        private System.Windows.Forms.Label ntstatusNumberLabel;
    }
}

