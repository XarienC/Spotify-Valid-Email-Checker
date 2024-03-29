﻿namespace SpotifyValidEmailChecker
{
    partial class SpotifyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpotifyForm));
            this.SetupGB = new ns1.SiticoneGroupBox();
            this.StartButton = new ns1.SiticoneButton();
            this.ThreadLabelValue = new System.Windows.Forms.Label();
            this.ThreadTitle = new System.Windows.Forms.Label();
            this.ThreadBar = new ns1.SiticoneTrackBar();
            this.SOCKS5Toggle = new ns1.SiticoneRadioButton();
            this.SOCKS4Toggle = new ns1.SiticoneRadioButton();
            this.HTTPToggle = new ns1.SiticoneRadioButton();
            this.LoadProxiesButton = new ns1.SiticoneButton();
            this.LoadEmailButton = new ns1.SiticoneButton();
            this.TopPanel = new ns1.SiticonePanel();
            this.MinimizeButton = new ns1.SiticoneControlBox();
            this.CloseButton = new ns1.SiticoneControlBox();
            this.Title = new System.Windows.Forms.Label();
            this.Drag = new ns1.SiticoneDragControl(this.components);
            this.ResultListView = new System.Windows.Forms.ListView();
            this.ValidEmailHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValidEmailBar = new ns1.SiticonePanel();
            this.EmailTitle = new System.Windows.Forms.Label();
            this.LoadedEmailsLabel = new System.Windows.Forms.Label();
            this.LoadedEmailValue = new System.Windows.Forms.Label();
            this.LoadedProxyValue = new System.Windows.Forms.Label();
            this.LoadedProxyLabel = new System.Windows.Forms.Label();
            this.ValidEmailValue = new System.Windows.Forms.Label();
            this.ValidEmailLabel = new System.Windows.Forms.Label();
            this.InvalidEmailValue = new System.Windows.Forms.Label();
            this.InvalidEmailLabel = new System.Windows.Forms.Label();
            this.ErrorValue = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.CheckedEmailValue = new System.Windows.Forms.Label();
            this.CheckedLabel = new System.Windows.Forms.Label();
            this.SetupGB.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.ValidEmailBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetupGB
            // 
            this.SetupGB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SetupGB.Controls.Add(this.StartButton);
            this.SetupGB.Controls.Add(this.ThreadLabelValue);
            this.SetupGB.Controls.Add(this.ThreadTitle);
            this.SetupGB.Controls.Add(this.ThreadBar);
            this.SetupGB.Controls.Add(this.SOCKS5Toggle);
            this.SetupGB.Controls.Add(this.SOCKS4Toggle);
            this.SetupGB.Controls.Add(this.HTTPToggle);
            this.SetupGB.Controls.Add(this.LoadProxiesButton);
            this.SetupGB.Controls.Add(this.LoadEmailButton);
            this.SetupGB.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SetupGB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SetupGB.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetupGB.ForeColor = System.Drawing.Color.White;
            this.SetupGB.Location = new System.Drawing.Point(12, 43);
            this.SetupGB.Name = "SetupGB";
            this.SetupGB.ShadowDecoration.Parent = this.SetupGB;
            this.SetupGB.Size = new System.Drawing.Size(224, 302);
            this.SetupGB.TabIndex = 0;
            this.SetupGB.Text = "Setup";
            // 
            // StartButton
            // 
            this.StartButton.CheckedState.Parent = this.StartButton;
            this.StartButton.CustomImages.Parent = this.StartButton;
            this.StartButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.StartButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.HoveredState.Parent = this.StartButton;
            this.StartButton.Location = new System.Drawing.Point(35, 260);
            this.StartButton.Name = "StartButton";
            this.StartButton.ShadowDecoration.Parent = this.StartButton;
            this.StartButton.Size = new System.Drawing.Size(149, 28);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Start";
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ThreadLabelValue
            // 
            this.ThreadLabelValue.BackColor = System.Drawing.Color.Transparent;
            this.ThreadLabelValue.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreadLabelValue.ForeColor = System.Drawing.Color.White;
            this.ThreadLabelValue.Location = new System.Drawing.Point(147, 204);
            this.ThreadLabelValue.Name = "ThreadLabelValue";
            this.ThreadLabelValue.Size = new System.Drawing.Size(58, 17);
            this.ThreadLabelValue.TabIndex = 6;
            this.ThreadLabelValue.Text = "0";
            this.ThreadLabelValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ThreadTitle
            // 
            this.ThreadTitle.AutoSize = true;
            this.ThreadTitle.BackColor = System.Drawing.Color.Transparent;
            this.ThreadTitle.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreadTitle.ForeColor = System.Drawing.Color.White;
            this.ThreadTitle.Location = new System.Drawing.Point(19, 204);
            this.ThreadTitle.Name = "ThreadTitle";
            this.ThreadTitle.Size = new System.Drawing.Size(58, 17);
            this.ThreadTitle.TabIndex = 3;
            this.ThreadTitle.Text = "Threads:";
            // 
            // ThreadBar
            // 
            this.ThreadBar.BackColor = System.Drawing.Color.Transparent;
            this.ThreadBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ThreadBar.HoveredState.Parent = this.ThreadBar;
            this.ThreadBar.Location = new System.Drawing.Point(20, 224);
            this.ThreadBar.Maximum = 200;
            this.ThreadBar.Minimum = 1;
            this.ThreadBar.Name = "ThreadBar";
            this.ThreadBar.Size = new System.Drawing.Size(185, 23);
            this.ThreadBar.TabIndex = 5;
            this.ThreadBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.ThreadBar.Value = 100;
            this.ThreadBar.ValueChanged += new System.EventHandler(this.ThreadBar_ValueChanged);
            // 
            // SOCKS5Toggle
            // 
            this.SOCKS5Toggle.AutoSize = true;
            this.SOCKS5Toggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SOCKS5Toggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.SOCKS5Toggle.CheckedState.BorderThickness = 0;
            this.SOCKS5Toggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.SOCKS5Toggle.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.SOCKS5Toggle.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOCKS5Toggle.Location = new System.Drawing.Point(17, 174);
            this.SOCKS5Toggle.Name = "SOCKS5Toggle";
            this.SOCKS5Toggle.Size = new System.Drawing.Size(66, 21);
            this.SOCKS5Toggle.TabIndex = 4;
            this.SOCKS5Toggle.TabStop = true;
            this.SOCKS5Toggle.Text = "Socks5";
            this.SOCKS5Toggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SOCKS5Toggle.UncheckedState.BorderThickness = 2;
            this.SOCKS5Toggle.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.SOCKS5Toggle.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.SOCKS5Toggle.UseVisualStyleBackColor = false;
            // 
            // SOCKS4Toggle
            // 
            this.SOCKS4Toggle.AutoSize = true;
            this.SOCKS4Toggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SOCKS4Toggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.SOCKS4Toggle.CheckedState.BorderThickness = 0;
            this.SOCKS4Toggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.SOCKS4Toggle.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.SOCKS4Toggle.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOCKS4Toggle.Location = new System.Drawing.Point(17, 147);
            this.SOCKS4Toggle.Name = "SOCKS4Toggle";
            this.SOCKS4Toggle.Size = new System.Drawing.Size(66, 21);
            this.SOCKS4Toggle.TabIndex = 3;
            this.SOCKS4Toggle.TabStop = true;
            this.SOCKS4Toggle.Text = "Socks4";
            this.SOCKS4Toggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SOCKS4Toggle.UncheckedState.BorderThickness = 2;
            this.SOCKS4Toggle.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.SOCKS4Toggle.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.SOCKS4Toggle.UseVisualStyleBackColor = false;
            // 
            // HTTPToggle
            // 
            this.HTTPToggle.AutoSize = true;
            this.HTTPToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.HTTPToggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.HTTPToggle.CheckedState.BorderThickness = 0;
            this.HTTPToggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.HTTPToggle.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.HTTPToggle.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HTTPToggle.Location = new System.Drawing.Point(17, 120);
            this.HTTPToggle.Name = "HTTPToggle";
            this.HTTPToggle.Size = new System.Drawing.Size(67, 21);
            this.HTTPToggle.TabIndex = 2;
            this.HTTPToggle.TabStop = true;
            this.HTTPToggle.Text = "HTTP/s";
            this.HTTPToggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.HTTPToggle.UncheckedState.BorderThickness = 2;
            this.HTTPToggle.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.HTTPToggle.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.HTTPToggle.UseVisualStyleBackColor = false;
            // 
            // LoadProxiesButton
            // 
            this.LoadProxiesButton.CheckedState.Parent = this.LoadProxiesButton;
            this.LoadProxiesButton.CustomImages.Parent = this.LoadProxiesButton;
            this.LoadProxiesButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LoadProxiesButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadProxiesButton.ForeColor = System.Drawing.Color.White;
            this.LoadProxiesButton.HoveredState.Parent = this.LoadProxiesButton;
            this.LoadProxiesButton.Location = new System.Drawing.Point(35, 82);
            this.LoadProxiesButton.Name = "LoadProxiesButton";
            this.LoadProxiesButton.ShadowDecoration.Parent = this.LoadProxiesButton;
            this.LoadProxiesButton.Size = new System.Drawing.Size(149, 28);
            this.LoadProxiesButton.TabIndex = 1;
            this.LoadProxiesButton.Text = "Load Proxies";
            this.LoadProxiesButton.Click += new System.EventHandler(this.LoadProxiesButton_Click);
            // 
            // LoadEmailButton
            // 
            this.LoadEmailButton.CheckedState.Parent = this.LoadEmailButton;
            this.LoadEmailButton.CustomImages.Parent = this.LoadEmailButton;
            this.LoadEmailButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LoadEmailButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadEmailButton.ForeColor = System.Drawing.Color.White;
            this.LoadEmailButton.HoveredState.Parent = this.LoadEmailButton;
            this.LoadEmailButton.Location = new System.Drawing.Point(35, 48);
            this.LoadEmailButton.Name = "LoadEmailButton";
            this.LoadEmailButton.ShadowDecoration.Parent = this.LoadEmailButton;
            this.LoadEmailButton.Size = new System.Drawing.Size(149, 28);
            this.LoadEmailButton.TabIndex = 0;
            this.LoadEmailButton.Text = "Load Emails";
            this.LoadEmailButton.Click += new System.EventHandler(this.LoadEmailButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.MinimizeButton);
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Controls.Add(this.Title);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.ShadowDecoration.Parent = this.TopPanel;
            this.TopPanel.Size = new System.Drawing.Size(693, 35);
            this.TopPanel.TabIndex = 1;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.ControlBoxType = ns5.ControlBoxType.MinimizeBox;
            this.MinimizeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.MinimizeButton.HoveredState.Parent = this.MinimizeButton;
            this.MinimizeButton.IconColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(573, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.ShadowDecoration.Parent = this.MinimizeButton;
            this.MinimizeButton.Size = new System.Drawing.Size(60, 35);
            this.MinimizeButton.TabIndex = 2;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.CloseButton.HoveredState.Parent = this.CloseButton;
            this.CloseButton.IconColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(633, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.ShadowDecoration.Parent = this.CloseButton;
            this.CloseButton.Size = new System.Drawing.Size(60, 35);
            this.CloseButton.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(7, 8);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(224, 17);
            this.Title.TabIndex = 0;
            this.Title.Text = "Spotify Valid Email Checker | Matt101";
            // 
            // Drag
            // 
            this.Drag.TargetControl = this.TopPanel;
            // 
            // ResultListView
            // 
            this.ResultListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ResultListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ValidEmailHeader});
            this.ResultListView.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultListView.ForeColor = System.Drawing.Color.White;
            this.ResultListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ResultListView.HideSelection = false;
            this.ResultListView.Location = new System.Drawing.Point(241, 84);
            this.ResultListView.Name = "ResultListView";
            this.ResultListView.Size = new System.Drawing.Size(440, 196);
            this.ResultListView.TabIndex = 2;
            this.ResultListView.UseCompatibleStateImageBehavior = false;
            this.ResultListView.View = System.Windows.Forms.View.Details;
            // 
            // ValidEmailHeader
            // 
            this.ValidEmailHeader.Text = "Valid Emails";
            this.ValidEmailHeader.Width = 388;
            // 
            // ValidEmailBar
            // 
            this.ValidEmailBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ValidEmailBar.Controls.Add(this.EmailTitle);
            this.ValidEmailBar.Location = new System.Drawing.Point(241, 43);
            this.ValidEmailBar.Name = "ValidEmailBar";
            this.ValidEmailBar.ShadowDecoration.Parent = this.ValidEmailBar;
            this.ValidEmailBar.Size = new System.Drawing.Size(440, 42);
            this.ValidEmailBar.TabIndex = 3;
            // 
            // EmailTitle
            // 
            this.EmailTitle.AutoSize = true;
            this.EmailTitle.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTitle.ForeColor = System.Drawing.Color.White;
            this.EmailTitle.Location = new System.Drawing.Point(11, 10);
            this.EmailTitle.Name = "EmailTitle";
            this.EmailTitle.Size = new System.Drawing.Size(89, 20);
            this.EmailTitle.TabIndex = 3;
            this.EmailTitle.Text = "Valid Emails";
            // 
            // LoadedEmailsLabel
            // 
            this.LoadedEmailsLabel.AutoSize = true;
            this.LoadedEmailsLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadedEmailsLabel.ForeColor = System.Drawing.Color.White;
            this.LoadedEmailsLabel.Location = new System.Drawing.Point(242, 290);
            this.LoadedEmailsLabel.Name = "LoadedEmailsLabel";
            this.LoadedEmailsLabel.Size = new System.Drawing.Size(48, 17);
            this.LoadedEmailsLabel.TabIndex = 3;
            this.LoadedEmailsLabel.Text = "Emails:";
            // 
            // LoadedEmailValue
            // 
            this.LoadedEmailValue.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadedEmailValue.ForeColor = System.Drawing.Color.White;
            this.LoadedEmailValue.Location = new System.Drawing.Point(296, 290);
            this.LoadedEmailValue.Name = "LoadedEmailValue";
            this.LoadedEmailValue.Size = new System.Drawing.Size(76, 17);
            this.LoadedEmailValue.TabIndex = 4;
            this.LoadedEmailValue.Text = "0";
            this.LoadedEmailValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LoadedProxyValue
            // 
            this.LoadedProxyValue.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadedProxyValue.ForeColor = System.Drawing.Color.White;
            this.LoadedProxyValue.Location = new System.Drawing.Point(296, 317);
            this.LoadedProxyValue.Name = "LoadedProxyValue";
            this.LoadedProxyValue.Size = new System.Drawing.Size(76, 17);
            this.LoadedProxyValue.TabIndex = 6;
            this.LoadedProxyValue.Text = "0";
            this.LoadedProxyValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LoadedProxyLabel
            // 
            this.LoadedProxyLabel.AutoSize = true;
            this.LoadedProxyLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadedProxyLabel.ForeColor = System.Drawing.Color.White;
            this.LoadedProxyLabel.Location = new System.Drawing.Point(242, 317);
            this.LoadedProxyLabel.Name = "LoadedProxyLabel";
            this.LoadedProxyLabel.Size = new System.Drawing.Size(53, 17);
            this.LoadedProxyLabel.TabIndex = 5;
            this.LoadedProxyLabel.Text = "Proxies:";
            // 
            // ValidEmailValue
            // 
            this.ValidEmailValue.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidEmailValue.ForeColor = System.Drawing.Color.Lime;
            this.ValidEmailValue.Location = new System.Drawing.Point(466, 290);
            this.ValidEmailValue.Name = "ValidEmailValue";
            this.ValidEmailValue.Size = new System.Drawing.Size(77, 17);
            this.ValidEmailValue.TabIndex = 8;
            this.ValidEmailValue.Text = "0";
            this.ValidEmailValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ValidEmailLabel
            // 
            this.ValidEmailLabel.AutoSize = true;
            this.ValidEmailLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidEmailLabel.ForeColor = System.Drawing.Color.Lime;
            this.ValidEmailLabel.Location = new System.Drawing.Point(380, 290);
            this.ValidEmailLabel.Name = "ValidEmailLabel";
            this.ValidEmailLabel.Size = new System.Drawing.Size(80, 17);
            this.ValidEmailLabel.TabIndex = 7;
            this.ValidEmailLabel.Text = "Valid Emails:";
            // 
            // InvalidEmailValue
            // 
            this.InvalidEmailValue.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidEmailValue.ForeColor = System.Drawing.Color.Red;
            this.InvalidEmailValue.Location = new System.Drawing.Point(469, 317);
            this.InvalidEmailValue.Name = "InvalidEmailValue";
            this.InvalidEmailValue.Size = new System.Drawing.Size(74, 17);
            this.InvalidEmailValue.TabIndex = 10;
            this.InvalidEmailValue.Text = "0";
            this.InvalidEmailValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // InvalidEmailLabel
            // 
            this.InvalidEmailLabel.AutoSize = true;
            this.InvalidEmailLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidEmailLabel.ForeColor = System.Drawing.Color.Red;
            this.InvalidEmailLabel.Location = new System.Drawing.Point(380, 317);
            this.InvalidEmailLabel.Name = "InvalidEmailLabel";
            this.InvalidEmailLabel.Size = new System.Drawing.Size(89, 17);
            this.InvalidEmailLabel.TabIndex = 9;
            this.InvalidEmailLabel.Text = "Invalid Emails:";
            // 
            // ErrorValue
            // 
            this.ErrorValue.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorValue.ForeColor = System.Drawing.Color.Yellow;
            this.ErrorValue.Location = new System.Drawing.Point(601, 290);
            this.ErrorValue.Name = "ErrorValue";
            this.ErrorValue.Size = new System.Drawing.Size(76, 17);
            this.ErrorValue.TabIndex = 12;
            this.ErrorValue.Text = "0";
            this.ErrorValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Yellow;
            this.ErrorLabel.Location = new System.Drawing.Point(547, 290);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(47, 17);
            this.ErrorLabel.TabIndex = 11;
            this.ErrorLabel.Text = "Errors:";
            // 
            // CheckedEmailValue
            // 
            this.CheckedEmailValue.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckedEmailValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CheckedEmailValue.Location = new System.Drawing.Point(601, 317);
            this.CheckedEmailValue.Name = "CheckedEmailValue";
            this.CheckedEmailValue.Size = new System.Drawing.Size(76, 17);
            this.CheckedEmailValue.TabIndex = 14;
            this.CheckedEmailValue.Text = "0";
            this.CheckedEmailValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CheckedLabel
            // 
            this.CheckedLabel.AutoSize = true;
            this.CheckedLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CheckedLabel.Location = new System.Drawing.Point(547, 317);
            this.CheckedLabel.Name = "CheckedLabel";
            this.CheckedLabel.Size = new System.Drawing.Size(60, 17);
            this.CheckedLabel.TabIndex = 13;
            this.CheckedLabel.Text = "Checked:";
            // 
            // SpotifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(693, 354);
            this.Controls.Add(this.CheckedEmailValue);
            this.Controls.Add(this.CheckedLabel);
            this.Controls.Add(this.ErrorValue);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.InvalidEmailValue);
            this.Controls.Add(this.InvalidEmailLabel);
            this.Controls.Add(this.ValidEmailValue);
            this.Controls.Add(this.ValidEmailLabel);
            this.Controls.Add(this.LoadedProxyValue);
            this.Controls.Add(this.LoadedProxyLabel);
            this.Controls.Add(this.LoadedEmailValue);
            this.Controls.Add(this.LoadedEmailsLabel);
            this.Controls.Add(this.ValidEmailBar);
            this.Controls.Add(this.ResultListView);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.SetupGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SpotifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spotify Valid Email Checker";
            this.TopMost = true;
            this.SetupGB.ResumeLayout(false);
            this.SetupGB.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ValidEmailBar.ResumeLayout(false);
            this.ValidEmailBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.SiticoneGroupBox SetupGB;
        private ns1.SiticonePanel TopPanel;
        private ns1.SiticoneControlBox CloseButton;
        private System.Windows.Forms.Label Title;
        private ns1.SiticoneControlBox MinimizeButton;
        private ns1.SiticoneButton LoadEmailButton;
        private ns1.SiticoneDragControl Drag;
        private ns1.SiticoneButton StartButton;
        private System.Windows.Forms.Label ThreadLabelValue;
        private System.Windows.Forms.Label ThreadTitle;
        private ns1.SiticoneTrackBar ThreadBar;
        private ns1.SiticoneRadioButton SOCKS5Toggle;
        private ns1.SiticoneRadioButton SOCKS4Toggle;
        private ns1.SiticoneRadioButton HTTPToggle;
        private ns1.SiticoneButton LoadProxiesButton;
        private System.Windows.Forms.ListView ResultListView;
        private System.Windows.Forms.ColumnHeader ValidEmailHeader;
        private ns1.SiticonePanel ValidEmailBar;
        private System.Windows.Forms.Label EmailTitle;
        private System.Windows.Forms.Label LoadedEmailsLabel;
        private System.Windows.Forms.Label LoadedEmailValue;
        private System.Windows.Forms.Label LoadedProxyValue;
        private System.Windows.Forms.Label LoadedProxyLabel;
        private System.Windows.Forms.Label ValidEmailValue;
        private System.Windows.Forms.Label ValidEmailLabel;
        private System.Windows.Forms.Label InvalidEmailValue;
        private System.Windows.Forms.Label InvalidEmailLabel;
        private System.Windows.Forms.Label ErrorValue;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label CheckedEmailValue;
        private System.Windows.Forms.Label CheckedLabel;
    }
}

