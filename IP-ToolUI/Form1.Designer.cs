namespace IP_ToolUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            excelToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            BroadcastAddressTextBox = new TextBox();
            LastIpTextBox = new TextBox();
            FirstIpTextBox = new TextBox();
            IPAddressWithCidrTextBox = new TextBox();
            label11 = new Label();
            CidrTextBox = new TextBox();
            SubnetMaskTextBox = new TextBox();
            BinarySubnetMaskTextBox = new TextBox();
            BinaryIPAddressTextBox = new TextBox();
            NumberOfUsableHostsTextBox = new TextBox();
            NumberOfHostsTextBox = new TextBox();
            NetworkAddressTextBox = new TextBox();
            IPAddressTextbox = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            MaskLabel = new Label();
            SubnetmaskComboBox = new ComboBox();
            CalculateButton = new Button();
            IPLabel = new Label();
            IPTextbox2 = new TextBox();
            IPTextbox4 = new TextBox();
            IPTextbox3 = new TextBox();
            IPTextbox1 = new TextBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 1, 0, 1);
            menuStrip1.Size = new Size(867, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(56, 22);
            toolStripMenuItem1.Text = "IP-Tool";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 22);
            fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { excelToolStripMenuItem });
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(180, 22);
            exportToolStripMenuItem.Text = "Export";
            // 
            // excelToolStripMenuItem
            // 
            excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            excelToolStripMenuItem.Size = new Size(180, 22);
            excelToolStripMenuItem.Text = "Excel";
            excelToolStripMenuItem.Click += excelToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BroadcastAddressTextBox);
            groupBox1.Controls.Add(LastIpTextBox);
            groupBox1.Controls.Add(FirstIpTextBox);
            groupBox1.Controls.Add(IPAddressWithCidrTextBox);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(CidrTextBox);
            groupBox1.Controls.Add(SubnetMaskTextBox);
            groupBox1.Controls.Add(BinarySubnetMaskTextBox);
            groupBox1.Controls.Add(BinaryIPAddressTextBox);
            groupBox1.Controls.Add(NumberOfUsableHostsTextBox);
            groupBox1.Controls.Add(NumberOfHostsTextBox);
            groupBox1.Controls.Add(NetworkAddressTextBox);
            groupBox1.Controls.Add(IPAddressTextbox);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(217, 44);
            groupBox1.Margin = new Padding(2, 1, 2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 1, 2, 1);
            groupBox1.Size = new Size(590, 264);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Result";
            // 
            // BroadcastAddressTextBox
            // 
            BroadcastAddressTextBox.BackColor = SystemColors.Control;
            BroadcastAddressTextBox.BorderStyle = BorderStyle.None;
            BroadcastAddressTextBox.Location = new Point(192, 98);
            BroadcastAddressTextBox.Name = "BroadcastAddressTextBox";
            BroadcastAddressTextBox.ReadOnly = true;
            BroadcastAddressTextBox.Size = new Size(100, 16);
            BroadcastAddressTextBox.TabIndex = 29;
            BroadcastAddressTextBox.TabStop = false;
            BroadcastAddressTextBox.Text = "0.0.0.0";
            // 
            // LastIpTextBox
            // 
            LastIpTextBox.BackColor = SystemColors.Control;
            LastIpTextBox.BorderStyle = BorderStyle.None;
            LastIpTextBox.Location = new Point(313, 78);
            LastIpTextBox.Name = "LastIpTextBox";
            LastIpTextBox.ReadOnly = true;
            LastIpTextBox.Size = new Size(100, 16);
            LastIpTextBox.TabIndex = 28;
            LastIpTextBox.TabStop = false;
            LastIpTextBox.Text = "0.0.0.0";
            // 
            // FirstIpTextBox
            // 
            FirstIpTextBox.BackColor = SystemColors.Control;
            FirstIpTextBox.BorderStyle = BorderStyle.None;
            FirstIpTextBox.Location = new Point(192, 78);
            FirstIpTextBox.Name = "FirstIpTextBox";
            FirstIpTextBox.ReadOnly = true;
            FirstIpTextBox.Size = new Size(100, 16);
            FirstIpTextBox.TabIndex = 27;
            FirstIpTextBox.TabStop = false;
            FirstIpTextBox.Text = "0.0.0.0";
            // 
            // IPAddressWithCidrTextBox
            // 
            IPAddressWithCidrTextBox.BorderStyle = BorderStyle.None;
            IPAddressWithCidrTextBox.Location = new Point(192, 40);
            IPAddressWithCidrTextBox.Name = "IPAddressWithCidrTextBox";
            IPAddressWithCidrTextBox.ReadOnly = true;
            IPAddressWithCidrTextBox.Size = new Size(100, 16);
            IPAddressWithCidrTextBox.TabIndex = 25;
            IPAddressWithCidrTextBox.TabStop = false;
            IPAddressWithCidrTextBox.Text = "0.0.0.0 /0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 36);
            label11.Name = "label11";
            label11.Size = new Size(38, 15);
            label11.TabIndex = 24;
            label11.Text = "Short:";
            // 
            // CidrTextBox
            // 
            CidrTextBox.BorderStyle = BorderStyle.None;
            CidrTextBox.Location = new Point(192, 219);
            CidrTextBox.Name = "CidrTextBox";
            CidrTextBox.ReadOnly = true;
            CidrTextBox.Size = new Size(100, 16);
            CidrTextBox.TabIndex = 23;
            CidrTextBox.TabStop = false;
            CidrTextBox.Text = "0";
            // 
            // SubnetMaskTextBox
            // 
            SubnetMaskTextBox.BorderStyle = BorderStyle.None;
            SubnetMaskTextBox.Location = new Point(192, 199);
            SubnetMaskTextBox.Name = "SubnetMaskTextBox";
            SubnetMaskTextBox.ReadOnly = true;
            SubnetMaskTextBox.Size = new Size(100, 16);
            SubnetMaskTextBox.TabIndex = 22;
            SubnetMaskTextBox.TabStop = false;
            SubnetMaskTextBox.Text = "0.0.0.0";
            // 
            // BinarySubnetMaskTextBox
            // 
            BinarySubnetMaskTextBox.BorderStyle = BorderStyle.None;
            BinarySubnetMaskTextBox.Location = new Point(192, 179);
            BinarySubnetMaskTextBox.Name = "BinarySubnetMaskTextBox";
            BinarySubnetMaskTextBox.ReadOnly = true;
            BinarySubnetMaskTextBox.Size = new Size(212, 16);
            BinarySubnetMaskTextBox.TabIndex = 21;
            BinarySubnetMaskTextBox.TabStop = false;
            BinarySubnetMaskTextBox.Text = "0.0.0.0";
            // 
            // BinaryIPAddressTextBox
            // 
            BinaryIPAddressTextBox.BorderStyle = BorderStyle.None;
            BinaryIPAddressTextBox.Location = new Point(192, 160);
            BinaryIPAddressTextBox.Name = "BinaryIPAddressTextBox";
            BinaryIPAddressTextBox.ReadOnly = true;
            BinaryIPAddressTextBox.Size = new Size(212, 16);
            BinaryIPAddressTextBox.TabIndex = 20;
            BinaryIPAddressTextBox.TabStop = false;
            BinaryIPAddressTextBox.Text = "0.0.0.0";
            // 
            // NumberOfUsableHostsTextBox
            // 
            NumberOfUsableHostsTextBox.BorderStyle = BorderStyle.None;
            NumberOfUsableHostsTextBox.Location = new Point(192, 140);
            NumberOfUsableHostsTextBox.Name = "NumberOfUsableHostsTextBox";
            NumberOfUsableHostsTextBox.ReadOnly = true;
            NumberOfUsableHostsTextBox.Size = new Size(100, 16);
            NumberOfUsableHostsTextBox.TabIndex = 19;
            NumberOfUsableHostsTextBox.TabStop = false;
            NumberOfUsableHostsTextBox.Text = "0";
            // 
            // NumberOfHostsTextBox
            // 
            NumberOfHostsTextBox.BorderStyle = BorderStyle.None;
            NumberOfHostsTextBox.Location = new Point(192, 119);
            NumberOfHostsTextBox.Name = "NumberOfHostsTextBox";
            NumberOfHostsTextBox.ReadOnly = true;
            NumberOfHostsTextBox.Size = new Size(100, 16);
            NumberOfHostsTextBox.TabIndex = 18;
            NumberOfHostsTextBox.TabStop = false;
            NumberOfHostsTextBox.Text = "0";
            // 
            // NetworkAddressTextBox
            // 
            NetworkAddressTextBox.BorderStyle = BorderStyle.None;
            NetworkAddressTextBox.Location = new Point(192, 58);
            NetworkAddressTextBox.Name = "NetworkAddressTextBox";
            NetworkAddressTextBox.ReadOnly = true;
            NetworkAddressTextBox.Size = new Size(100, 16);
            NetworkAddressTextBox.TabIndex = 17;
            NetworkAddressTextBox.TabStop = false;
            NetworkAddressTextBox.Text = "0.0.0.0";
            // 
            // IPAddressTextbox
            // 
            IPAddressTextbox.BackColor = SystemColors.Control;
            IPAddressTextbox.BorderStyle = BorderStyle.None;
            IPAddressTextbox.Location = new Point(192, 20);
            IPAddressTextbox.Name = "IPAddressTextbox";
            IPAddressTextbox.ReadOnly = true;
            IPAddressTextbox.Size = new Size(100, 16);
            IPAddressTextbox.TabIndex = 14;
            IPAddressTextbox.TabStop = false;
            IPAddressTextbox.Text = "0.0.0.0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 156);
            label10.Name = "label10";
            label10.Size = new Size(100, 15);
            label10.TabIndex = 15;
            label10.Text = "Binary IP-Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 216);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 12;
            label9.Text = "CIDR notation: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 176);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 11;
            label8.Text = "Binary subnet mask";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 136);
            label7.Name = "label7";
            label7.Size = new Size(136, 15);
            label7.TabIndex = 10;
            label7.Text = "Number of usable hosts:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 96);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 9;
            label6.Text = "Broadcast address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 76);
            label5.Name = "label5";
            label5.Size = new Size(162, 15);
            label5.TabIndex = 8;
            label5.Text = "Usable host IP-address range:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 196);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 6;
            label4.Text = "Subnet mask:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 16);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "IP-Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 56);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 2;
            label2.Text = "Network address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 116);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 1;
            label1.Text = "Total number of hosts:";
            // 
            // MaskLabel
            // 
            MaskLabel.AutoSize = true;
            MaskLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskLabel.Location = new Point(21, 104);
            MaskLabel.Name = "MaskLabel";
            MaskLabel.Size = new Size(138, 21);
            MaskLabel.TabIndex = 23;
            MaskLabel.Text = "Enter subnet mask";
            // 
            // SubnetmaskComboBox
            // 
            SubnetmaskComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SubnetmaskComboBox.FormattingEnabled = true;
            SubnetmaskComboBox.Items.AddRange(new object[] { "255.255.255.255 /32", "255.255.255.254 /31", "255.255.255.252 /30", "255.255.255.248 /29", "255.255.255.240 /28", "255.255.255.224 /27", "255.255.255.192 /26", "255.255.255.128 /25", "255.255.255.000 /24", "255.255.254.000 /23", "255.255.252.000 /22", "255.255.248.000 /21", "255.255.240.000 /20", "255.255.224.000 /19", "255.255.192.000 /18", "255.255.128.000 /17", "255.255.000.000 /16", "255.254.000.000 /15", "255.252.000.000 /14", "255.248.000.000 /13", "255.240.000.000 /12", "255.224.000.000 /11", "255.192.000.000 /10", "255.128.000.000 /9", "255.000.000.000 /8", "254.000.000.000 /7", "252.000.000.000 /6", "248.000.000.000 /5", "240.000.000.000 /4", "224.000.000.000 /3", "192.000.000.000 /2", "128.000.000.000 /1" });
            SubnetmaskComboBox.Location = new Point(21, 128);
            SubnetmaskComboBox.Name = "SubnetmaskComboBox";
            SubnetmaskComboBox.Size = new Size(154, 23);
            SubnetmaskComboBox.TabIndex = 24;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(56, 225);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(75, 23);
            CalculateButton.TabIndex = 30;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // IPLabel
            // 
            IPLabel.AutoSize = true;
            IPLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IPLabel.Location = new Point(21, 158);
            IPLabel.Margin = new Padding(2, 0, 2, 0);
            IPLabel.Name = "IPLabel";
            IPLabel.Size = new Size(125, 21);
            IPLabel.TabIndex = 25;
            IPLabel.Text = "Enter IP-Address";
            // 
            // IPTextbox2
            // 
            IPTextbox2.Location = new Point(59, 181);
            IPTextbox2.MaxLength = 3;
            IPTextbox2.Name = "IPTextbox2";
            IPTextbox2.Size = new Size(34, 23);
            IPTextbox2.TabIndex = 27;
            IPTextbox2.Text = "168";
            // 
            // IPTextbox4
            // 
            IPTextbox4.Location = new Point(137, 181);
            IPTextbox4.MaxLength = 3;
            IPTextbox4.Name = "IPTextbox4";
            IPTextbox4.Size = new Size(34, 23);
            IPTextbox4.TabIndex = 29;
            IPTextbox4.Text = "1";
            // 
            // IPTextbox3
            // 
            IPTextbox3.Location = new Point(98, 181);
            IPTextbox3.MaxLength = 3;
            IPTextbox3.Name = "IPTextbox3";
            IPTextbox3.Size = new Size(34, 23);
            IPTextbox3.TabIndex = 28;
            IPTextbox3.Text = "0";
            // 
            // IPTextbox1
            // 
            IPTextbox1.Location = new Point(21, 181);
            IPTextbox1.MaxLength = 3;
            IPTextbox1.Name = "IPTextbox1";
            IPTextbox1.Size = new Size(34, 23);
            IPTextbox1.TabIndex = 26;
            IPTextbox1.Text = "192";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 354);
            Controls.Add(groupBox1);
            Controls.Add(MaskLabel);
            Controls.Add(SubnetmaskComboBox);
            Controls.Add(CalculateButton);
            Controls.Add(IPLabel);
            Controls.Add(IPTextbox2);
            Controls.Add(IPTextbox4);
            Controls.Add(IPTextbox3);
            Controls.Add(IPTextbox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "IP-Tool";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem excelToolStripMenuItem;
        private GroupBox groupBox1;
        private TextBox BroadcastAddressTextBox;
        private TextBox LastIpTextBox;
        private TextBox FirstIpTextBox;
        private TextBox IPAddressWithCidrTextBox;
        private Label label11;
        private TextBox CidrTextBox;
        private TextBox SubnetMaskTextBox;
        private TextBox BinarySubnetMaskTextBox;
        private TextBox BinaryIPAddressTextBox;
        private TextBox NumberOfUsableHostsTextBox;
        private TextBox NumberOfHostsTextBox;
        private TextBox NetworkAddressTextBox;
        private TextBox IPAddressTextbox;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label MaskLabel;
        private ComboBox SubnetmaskComboBox;
        private Button CalculateButton;
        private Label IPLabel;
        private TextBox IPTextbox2;
        private TextBox IPTextbox4;
        private TextBox IPTextbox3;
        private TextBox IPTextbox1;
    }
}
