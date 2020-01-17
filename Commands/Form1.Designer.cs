using System;
using System.Collections.Generic;

namespace Commands
{
    partial class Commands
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Commands));
            this.BlockFlags = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdNameComboBox = new System.Windows.Forms.ComboBox();
            this.Mnemonic = new System.Windows.Forms.Label();
            this.unitsCmboBox = new System.Windows.Forms.ComboBox();
            this.funcTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ReadMethodComboBox = new System.Windows.Forms.ComboBox();
            this.ReadMethodLabel = new System.Windows.Forms.Label();
            this.ReadAccessTextBox = new System.Windows.Forms.TextBox();
            this.AccessReadLabel = new System.Windows.Forms.Label();
            this.MinReadLabel = new System.Windows.Forms.Label();
            this.MaxReadTextBox = new System.Windows.Forms.TextBox();
            this.MaxReadLabel = new System.Windows.Forms.Label();
            this.MinReadTextBox = new System.Windows.Forms.TextBox();
            this.ArgsLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.WriteMethodComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.WriteAccessTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MaxWriteTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MinWriteTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Args11ComboBox = new System.Windows.Forms.ComboBox();
            this.Args10ComboBox = new System.Windows.Forms.ComboBox();
            this.Args9ComboBox = new System.Windows.Forms.ComboBox();
            this.Args8ComboBox = new System.Windows.Forms.ComboBox();
            this.Args7ComboBox = new System.Windows.Forms.ComboBox();
            this.Args6ComboBox = new System.Windows.Forms.ComboBox();
            this.Args5ComboBox = new System.Windows.Forms.ComboBox();
            this.Args4ComboBox = new System.Windows.Forms.ComboBox();
            this.Args3ComboBox = new System.Windows.Forms.ComboBox();
            this.Args2ComboBox = new System.Windows.Forms.ComboBox();
            this.Args1ComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveNewCmdBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ValueGroup = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.DriveDefaultValue = new System.Windows.Forms.Label();
            this.UserRangeLabel = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.MaxValueLabel = new System.Windows.Forms.Label();
            this.MinValueLabel = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.commandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SerializeBtn = new System.Windows.Forms.Button();
            this.openCommandstxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenCmdsTxtFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.ValueGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BlockFlags
            // 
            this.BlockFlags.FormattingEnabled = true;
            this.BlockFlags.Items.AddRange(new object[] {
            "Drive Active",
            "Driva Inactive",
            "Value too high",
            "Value too low",
            "Burnin Active",
            "Limit Switch Hold",
            "Reject in BDHD",
            "Reject in DDHD",
            "Reject in LDHD",
            "Password  Protected"});
            this.BlockFlags.Location = new System.Drawing.Point(16, 20);
            this.BlockFlags.Margin = new System.Windows.Forms.Padding(4);
            this.BlockFlags.Name = "BlockFlags";
            this.BlockFlags.Size = new System.Drawing.Size(241, 174);
            this.BlockFlags.TabIndex = 0;
            this.BlockFlags.SelectedIndexChanged += new System.EventHandler(this.BlockFlags_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdNameComboBox);
            this.groupBox1.Controls.Add(this.Mnemonic);
            this.groupBox1.Controls.Add(this.unitsCmboBox);
            this.groupBox1.Controls.Add(this.funcTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(259, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Misc";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmdNameComboBox
            // 
            this.cmdNameComboBox.FormattingEnabled = true;
            this.cmdNameComboBox.Location = new System.Drawing.Point(80, 16);
            this.cmdNameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.cmdNameComboBox.Name = "cmdNameComboBox";
            this.cmdNameComboBox.Size = new System.Drawing.Size(159, 24);
            this.cmdNameComboBox.TabIndex = 7;
            this.cmdNameComboBox.SelectedIndexChanged += new System.EventHandler(this.cmdNameComboBox_SelectedIndexChanged);
            this.cmdNameComboBox.TextUpdate += new System.EventHandler(this.cmdNameComboBox_TextUpdated);
            // 
            // Mnemonic
            // 
            this.Mnemonic.AutoSize = true;
            this.Mnemonic.Location = new System.Drawing.Point(7, 20);
            this.Mnemonic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mnemonic.Name = "Mnemonic";
            this.Mnemonic.Size = new System.Drawing.Size(45, 17);
            this.Mnemonic.TabIndex = 6;
            this.Mnemonic.Text = "Name";
            // 
            // unitsCmboBox
            // 
            this.unitsCmboBox.FormattingEnabled = true;
            this.unitsCmboBox.Items.AddRange(new object[] {
            "Position",
            "Analogue",
            "Velocity",
            "NA"});
            this.unitsCmboBox.Location = new System.Drawing.Point(79, 89);
            this.unitsCmboBox.Margin = new System.Windows.Forms.Padding(4);
            this.unitsCmboBox.Name = "unitsCmboBox";
            this.unitsCmboBox.Size = new System.Drawing.Size(159, 24);
            this.unitsCmboBox.TabIndex = 5;
            this.unitsCmboBox.SelectedIndexChanged += new System.EventHandler(this.unitsComboBox_SelectedIndexChanged);
            // 
            // funcTextBox
            // 
            this.funcTextBox.Location = new System.Drawing.Point(79, 53);
            this.funcTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.funcTextBox.Name = "funcTextBox";
            this.funcTextBox.Size = new System.Drawing.Size(159, 22);
            this.funcTextBox.TabIndex = 4;
            this.funcTextBox.TextChanged += new System.EventHandler(this.funcTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Units";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Function";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BlockFlags);
            this.groupBox2.Location = new System.Drawing.Point(747, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(275, 224);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Block Flags";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ReadMethodComboBox);
            this.groupBox3.Controls.Add(this.ReadMethodLabel);
            this.groupBox3.Controls.Add(this.ReadAccessTextBox);
            this.groupBox3.Controls.Add(this.AccessReadLabel);
            this.groupBox3.Controls.Add(this.MinReadLabel);
            this.groupBox3.Controls.Add(this.MaxReadTextBox);
            this.groupBox3.Controls.Add(this.MaxReadLabel);
            this.groupBox3.Controls.Add(this.MinReadTextBox);
            this.groupBox3.Controls.Add(this.ArgsLabel);
            this.groupBox3.Location = new System.Drawing.Point(27, 167);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(328, 149);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Read";
            // 
            // ReadMethodComboBox
            // 
            this.ReadMethodComboBox.FormattingEnabled = true;
            this.ReadMethodComboBox.Items.AddRange(new object[] {
            "Variable",
            "int f(int*)",
            "int f(void)",
            "int f(void) + Args",
            "int f(void) + Args, Both Axes",
            "int f(int*), Both Axes"});
            this.ReadMethodComboBox.Location = new System.Drawing.Point(92, 114);
            this.ReadMethodComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ReadMethodComboBox.Name = "ReadMethodComboBox";
            this.ReadMethodComboBox.Size = new System.Drawing.Size(208, 24);
            this.ReadMethodComboBox.TabIndex = 6;
            this.ReadMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.cmdNameComboBox_SelectedIndexChanged);
            // 
            // ReadMethodLabel
            // 
            this.ReadMethodLabel.AutoSize = true;
            this.ReadMethodLabel.Location = new System.Drawing.Point(27, 118);
            this.ReadMethodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReadMethodLabel.Name = "ReadMethodLabel";
            this.ReadMethodLabel.Size = new System.Drawing.Size(55, 17);
            this.ReadMethodLabel.TabIndex = 12;
            this.ReadMethodLabel.Text = "Method";
            // 
            // ReadAccessTextBox
            // 
            this.ReadAccessTextBox.Location = new System.Drawing.Point(91, 71);
            this.ReadAccessTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ReadAccessTextBox.Name = "ReadAccessTextBox";
            this.ReadAccessTextBox.Size = new System.Drawing.Size(209, 22);
            this.ReadAccessTextBox.TabIndex = 11;
            // 
            // AccessReadLabel
            // 
            this.AccessReadLabel.AutoSize = true;
            this.AccessReadLabel.Location = new System.Drawing.Point(27, 75);
            this.AccessReadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AccessReadLabel.Name = "AccessReadLabel";
            this.AccessReadLabel.Size = new System.Drawing.Size(53, 17);
            this.AccessReadLabel.TabIndex = 10;
            this.AccessReadLabel.Text = "Access";
            this.AccessReadLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // MinReadLabel
            // 
            this.MinReadLabel.AutoSize = true;
            this.MinReadLabel.Location = new System.Drawing.Point(79, 33);
            this.MinReadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinReadLabel.Name = "MinReadLabel";
            this.MinReadLabel.Size = new System.Drawing.Size(30, 17);
            this.MinReadLabel.TabIndex = 9;
            this.MinReadLabel.Text = "Min";
            // 
            // MaxReadTextBox
            // 
            this.MaxReadTextBox.Location = new System.Drawing.Point(236, 30);
            this.MaxReadTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MaxReadTextBox.Name = "MaxReadTextBox";
            this.MaxReadTextBox.Size = new System.Drawing.Size(64, 22);
            this.MaxReadTextBox.TabIndex = 8;
            // 
            // MaxReadLabel
            // 
            this.MaxReadLabel.AutoSize = true;
            this.MaxReadLabel.Location = new System.Drawing.Point(192, 33);
            this.MaxReadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaxReadLabel.Name = "MaxReadLabel";
            this.MaxReadLabel.Size = new System.Drawing.Size(33, 17);
            this.MaxReadLabel.TabIndex = 7;
            this.MaxReadLabel.Text = "Max";
            this.MaxReadLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // MinReadTextBox
            // 
            this.MinReadTextBox.Location = new System.Drawing.Point(119, 30);
            this.MinReadTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MinReadTextBox.Name = "MinReadTextBox";
            this.MinReadTextBox.Size = new System.Drawing.Size(64, 22);
            this.MinReadTextBox.TabIndex = 6;
            // 
            // ArgsLabel
            // 
            this.ArgsLabel.AutoSize = true;
            this.ArgsLabel.Location = new System.Drawing.Point(25, 33);
            this.ArgsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArgsLabel.Name = "ArgsLabel";
            this.ArgsLabel.Size = new System.Drawing.Size(37, 17);
            this.ArgsLabel.TabIndex = 6;
            this.ArgsLabel.Text = "Args";
            this.ArgsLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.WriteMethodComboBox);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.WriteAccessTextBox);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.MaxWriteTextBox);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.MinWriteTextBox);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(27, 321);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(328, 149);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Write";
            // 
            // WriteMethodComboBox
            // 
            this.WriteMethodComboBox.FormattingEnabled = true;
            this.WriteMethodComboBox.Items.AddRange(new object[] {
            "WR_DPTR",
            "WR_FPTR0",
            "WR_FPTR1",
            "WR_FPTR2",
            "WR_FCUST0",
            "WR_FCUST1",
            "WR_FCUST2"});
            this.WriteMethodComboBox.Location = new System.Drawing.Point(92, 114);
            this.WriteMethodComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.WriteMethodComboBox.Name = "WriteMethodComboBox";
            this.WriteMethodComboBox.Size = new System.Drawing.Size(208, 24);
            this.WriteMethodComboBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 118);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Method";
            // 
            // WriteAccessTextBox
            // 
            this.WriteAccessTextBox.Location = new System.Drawing.Point(91, 71);
            this.WriteAccessTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.WriteAccessTextBox.Name = "WriteAccessTextBox";
            this.WriteAccessTextBox.Size = new System.Drawing.Size(209, 22);
            this.WriteAccessTextBox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Access";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Min";
            // 
            // MaxWriteTextBox
            // 
            this.MaxWriteTextBox.Location = new System.Drawing.Point(236, 30);
            this.MaxWriteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MaxWriteTextBox.Name = "MaxWriteTextBox";
            this.MaxWriteTextBox.Size = new System.Drawing.Size(64, 22);
            this.MaxWriteTextBox.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(192, 33);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Max";
            // 
            // MinWriteTextBox
            // 
            this.MinWriteTextBox.Location = new System.Drawing.Point(119, 30);
            this.MinWriteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MinWriteTextBox.Name = "MinWriteTextBox";
            this.MinWriteTextBox.Size = new System.Drawing.Size(64, 22);
            this.MinWriteTextBox.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 33);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Args";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Args11ComboBox);
            this.groupBox5.Controls.Add(this.Args10ComboBox);
            this.groupBox5.Controls.Add(this.Args9ComboBox);
            this.groupBox5.Controls.Add(this.Args8ComboBox);
            this.groupBox5.Controls.Add(this.Args7ComboBox);
            this.groupBox5.Controls.Add(this.Args6ComboBox);
            this.groupBox5.Controls.Add(this.Args5ComboBox);
            this.groupBox5.Controls.Add(this.Args4ComboBox);
            this.groupBox5.Controls.Add(this.Args3ComboBox);
            this.groupBox5.Controls.Add(this.Args2ComboBox);
            this.groupBox5.Controls.Add(this.Args1ComboBox);
            this.groupBox5.Location = new System.Drawing.Point(27, 478);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(995, 62);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Args";
            // 
            // Args11ComboBox
            // 
            this.Args11ComboBox.FormattingEnabled = true;
            this.Args11ComboBox.Items.AddRange(new object[] {
            "NA",
            "Int",
            "Decimal",
            "String"});
            this.Args11ComboBox.Location = new System.Drawing.Point(879, 23);
            this.Args11ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Args11ComboBox.Name = "Args11ComboBox";
            this.Args11ComboBox.Size = new System.Drawing.Size(77, 24);
            this.Args11ComboBox.TabIndex = 10;
            // 
            // Args10ComboBox
            // 
            this.Args10ComboBox.FormattingEnabled = true;
            this.Args10ComboBox.Items.AddRange(new object[] {
            "NA",
            "Int",
            "Decimal",
            "String"});
            this.Args10ComboBox.Location = new System.Drawing.Point(792, 23);
            this.Args10ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Args10ComboBox.Name = "Args10ComboBox";
            this.Args10ComboBox.Size = new System.Drawing.Size(77, 24);
            this.Args10ComboBox.TabIndex = 9;
            // 
            // Args9ComboBox
            // 
            this.Args9ComboBox.FormattingEnabled = true;
            this.Args9ComboBox.Items.AddRange(new object[] {
            "NA",
            "Int",
            "Decimal",
            "String"});
            this.Args9ComboBox.Location = new System.Drawing.Point(705, 23);
            this.Args9ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Args9ComboBox.Name = "Args9ComboBox";
            this.Args9ComboBox.Size = new System.Drawing.Size(77, 24);
            this.Args9ComboBox.TabIndex = 8;
            this.Args9ComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // Args8ComboBox
            // 
            this.Args8ComboBox.FormattingEnabled = true;
            this.Args8ComboBox.Items.AddRange(new object[] {
            "NA",
            "Int",
            "Decimal",
            "String"});
            this.Args8ComboBox.Location = new System.Drawing.Point(619, 23);
            this.Args8ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Args8ComboBox.Name = "Args8ComboBox";
            this.Args8ComboBox.Size = new System.Drawing.Size(77, 24);
            this.Args8ComboBox.TabIndex = 7;
            // 
            // Args7ComboBox
            // 
            this.Args7ComboBox.FormattingEnabled = true;
            this.Args7ComboBox.Items.AddRange(new object[] {
            "NA",
            "Int",
            "Decimal",
            "String"});
            this.Args7ComboBox.Location = new System.Drawing.Point(532, 23);
            this.Args7ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Args7ComboBox.Name = "Args7ComboBox";
            this.Args7ComboBox.Size = new System.Drawing.Size(77, 24);
            this.Args7ComboBox.TabIndex = 6;
            // 
            // Args6ComboBox
            // 
            this.Args6ComboBox.FormattingEnabled = true;
            this.Args6ComboBox.Items.AddRange(new object[] {
            "NA",
            "Int",
            "Decimal",
            "String"});
            this.Args6ComboBox.Location = new System.Drawing.Point(445, 23);
            this.Args6ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Args6ComboBox.Name = "Args6ComboBox";
            this.Args6ComboBox.Size = new System.Drawing.Size(77, 24);
            this.Args6ComboBox.TabIndex = 5;
            // 
            // Args5ComboBox
            // 
            this.Args5ComboBox.FormattingEnabled = true;
            this.Args5ComboBox.Items.AddRange(new object[] {
            "NA",
            "Int",
            "Decimal",
            "String"});
            this.Args5ComboBox.Location = new System.Drawing.Point(359, 23);
            this.Args5ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Args5ComboBox.Name = "Args5ComboBox";
            this.Args5ComboBox.Size = new System.Drawing.Size(77, 24);
            this.Args5ComboBox.TabIndex = 4;
            // 
            // Args4ComboBox
            // 
            this.Args4ComboBox.FormattingEnabled = true;
            this.Args4ComboBox.Items.AddRange(new object[] {
            "NA",
            "Int",
            "Decimal",
            "String"});
            this.Args4ComboBox.Location = new System.Drawing.Point(272, 23);
            this.Args4ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Args4ComboBox.Name = "Args4ComboBox";
            this.Args4ComboBox.Size = new System.Drawing.Size(77, 24);
            this.Args4ComboBox.TabIndex = 3;
            // 
            // Args3ComboBox
            // 
            this.Args3ComboBox.FormattingEnabled = true;
            this.Args3ComboBox.Items.AddRange(new object[] {
            "NA",
            "Int",
            "Decimal",
            "String"});
            this.Args3ComboBox.Location = new System.Drawing.Point(185, 23);
            this.Args3ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Args3ComboBox.Name = "Args3ComboBox";
            this.Args3ComboBox.Size = new System.Drawing.Size(77, 24);
            this.Args3ComboBox.TabIndex = 2;
            // 
            // Args2ComboBox
            // 
            this.Args2ComboBox.FormattingEnabled = true;
            this.Args2ComboBox.Items.AddRange(new object[] {
            "NA",
            "Int",
            "Decimal",
            "String"});
            this.Args2ComboBox.Location = new System.Drawing.Point(99, 23);
            this.Args2ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Args2ComboBox.Name = "Args2ComboBox";
            this.Args2ComboBox.Size = new System.Drawing.Size(77, 24);
            this.Args2ComboBox.TabIndex = 1;
            // 
            // Args1ComboBox
            // 
            this.Args1ComboBox.FormattingEnabled = true;
            this.Args1ComboBox.Items.AddRange(new object[] {
            "NA",
            "Int",
            "Decimal",
            "String"});
            this.Args1ComboBox.Location = new System.Drawing.Point(12, 23);
            this.Args1ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Args1ComboBox.Name = "Args1ComboBox";
            this.Args1ComboBox.Size = new System.Drawing.Size(77, 24);
            this.Args1ComboBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCommandToolStripMenuItem,
            this.openCommandstxtToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCommandToolStripMenuItem
            // 
            this.newCommandToolStripMenuItem.Name = "newCommandToolStripMenuItem";
            this.newCommandToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.newCommandToolStripMenuItem.Text = "New Command";
            // 
            // SaveNewCmdBtn
            // 
            this.SaveNewCmdBtn.Location = new System.Drawing.Point(817, 399);
            this.SaveNewCmdBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveNewCmdBtn.Name = "SaveNewCmdBtn";
            this.SaveNewCmdBtn.Size = new System.Drawing.Size(203, 28);
            this.SaveNewCmdBtn.TabIndex = 17;
            this.SaveNewCmdBtn.Text = "Save As New Command";
            this.SaveNewCmdBtn.UseVisualStyleBackColor = true;
            this.SaveNewCmdBtn.Click += new System.EventHandler(this.SaveNewCmdBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(817, 442);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(203, 28);
            this.SaveBtn.TabIndex = 19;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // ValueGroup
            // 
            this.ValueGroup.Controls.Add(this.textBox10);
            this.ValueGroup.Controls.Add(this.DriveDefaultValue);
            this.ValueGroup.Controls.Add(this.UserRangeLabel);
            this.ValueGroup.Controls.Add(this.textBox9);
            this.ValueGroup.Controls.Add(this.MaxValueLabel);
            this.ValueGroup.Controls.Add(this.MinValueLabel);
            this.ValueGroup.Controls.Add(this.textBox8);
            this.ValueGroup.Controls.Add(this.textBox1);
            this.ValueGroup.Location = new System.Drawing.Point(472, 49);
            this.ValueGroup.Margin = new System.Windows.Forms.Padding(4);
            this.ValueGroup.Name = "ValueGroup";
            this.ValueGroup.Padding = new System.Windows.Forms.Padding(4);
            this.ValueGroup.Size = new System.Drawing.Size(252, 167);
            this.ValueGroup.TabIndex = 20;
            this.ValueGroup.TabStop = false;
            this.ValueGroup.Text = "Value";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(113, 118);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(116, 22);
            this.textBox10.TabIndex = 7;
            // 
            // DriveDefaultValue
            // 
            this.DriveDefaultValue.AutoSize = true;
            this.DriveDefaultValue.Location = new System.Drawing.Point(11, 118);
            this.DriveDefaultValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DriveDefaultValue.Name = "DriveDefaultValue";
            this.DriveDefaultValue.Size = new System.Drawing.Size(93, 17);
            this.DriveDefaultValue.TabIndex = 6;
            this.DriveDefaultValue.Text = "Default Value";
            // 
            // UserRangeLabel
            // 
            this.UserRangeLabel.AutoSize = true;
            this.UserRangeLabel.Location = new System.Drawing.Point(20, 86);
            this.UserRangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserRangeLabel.Name = "UserRangeLabel";
            this.UserRangeLabel.Size = new System.Drawing.Size(84, 17);
            this.UserRangeLabel.TabIndex = 5;
            this.UserRangeLabel.Text = "User Range";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(113, 86);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(116, 22);
            this.textBox9.TabIndex = 4;
            // 
            // MaxValueLabel
            // 
            this.MaxValueLabel.AutoSize = true;
            this.MaxValueLabel.Location = new System.Drawing.Point(69, 52);
            this.MaxValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaxValueLabel.Name = "MaxValueLabel";
            this.MaxValueLabel.Size = new System.Drawing.Size(33, 17);
            this.MaxValueLabel.TabIndex = 3;
            this.MaxValueLabel.Text = "Max";
            // 
            // MinValueLabel
            // 
            this.MinValueLabel.AutoSize = true;
            this.MinValueLabel.Location = new System.Drawing.Point(73, 20);
            this.MinValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinValueLabel.Name = "MinValueLabel";
            this.MinValueLabel.Size = new System.Drawing.Size(30, 17);
            this.MinValueLabel.TabIndex = 2;
            this.MinValueLabel.Text = "Min";
            this.MinValueLabel.Click += new System.EventHandler(this.label13_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(113, 20);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(116, 22);
            this.textBox8.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 52);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 22);
            this.textBox1.TabIndex = 0;
            // 
            // commandBindingSource
            // 
            this.commandBindingSource.DataSource = typeof(Command);
            // 
            // SerializeBtn
            // 
            this.SerializeBtn.Location = new System.Drawing.Point(819, 354);
            this.SerializeBtn.Name = "SerializeBtn";
            this.SerializeBtn.Size = new System.Drawing.Size(203, 28);
            this.SerializeBtn.TabIndex = 21;
            this.SerializeBtn.Text = "Serialize";
            this.SerializeBtn.UseVisualStyleBackColor = true;
            this.SerializeBtn.Click += new System.EventHandler(this.SerializeBtn_Click);
            // 
            // openCommandstxtToolStripMenuItem
            // 
            this.openCommandstxtToolStripMenuItem.Name = "openCommandstxtToolStripMenuItem";
            this.openCommandstxtToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.openCommandstxtToolStripMenuItem.Text = "Open Commands.txt";
            this.openCommandstxtToolStripMenuItem.Click += new System.EventHandler(this.openCommandstxtToolStripMenuItem_Click);
            // 
            // OpenCmdsTxtFileDialog
            // 
            this.OpenCmdsTxtFileDialog.FileName = "OpenCmdsTxtFileDialog";
            // 
            // Commands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.SerializeBtn);
            this.Controls.Add(this.ValueGroup);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.SaveNewCmdBtn);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Commands";
            this.Text = "Commands";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ValueGroup.ResumeLayout(false);
            this.ValueGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox BlockFlags;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox funcTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox unitsCmboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label MinReadLabel;
        private System.Windows.Forms.TextBox MaxReadTextBox;
        private System.Windows.Forms.Label MaxReadLabel;
        private System.Windows.Forms.TextBox MinReadTextBox;
        private System.Windows.Forms.Label ArgsLabel;
        private System.Windows.Forms.Label AccessReadLabel;
        private System.Windows.Forms.ComboBox ReadMethodComboBox;
        private System.Windows.Forms.Label ReadMethodLabel;
        private System.Windows.Forms.TextBox ReadAccessTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox WriteMethodComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox WriteAccessTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MaxWriteTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox MinWriteTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmdNameComboBox;
        private System.Windows.Forms.Label Mnemonic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCommandToolStripMenuItem;
        private System.Windows.Forms.Button SaveNewCmdBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.BindingSource commandBindingSource;
        private System.Windows.Forms.ComboBox Args9ComboBox;
        private System.Windows.Forms.ComboBox Args8ComboBox;
        private System.Windows.Forms.ComboBox Args7ComboBox;
        private System.Windows.Forms.ComboBox Args6ComboBox;
        private System.Windows.Forms.ComboBox Args5ComboBox;
        private System.Windows.Forms.ComboBox Args4ComboBox;
        private System.Windows.Forms.ComboBox Args3ComboBox;
        private System.Windows.Forms.ComboBox Args2ComboBox;
        private System.Windows.Forms.ComboBox Args1ComboBox;
        private System.Windows.Forms.ComboBox Args11ComboBox;
        private System.Windows.Forms.ComboBox Args10ComboBox;
        private System.Windows.Forms.GroupBox ValueGroup;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label DriveDefaultValue;
        private System.Windows.Forms.Label UserRangeLabel;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label MaxValueLabel;
        private System.Windows.Forms.Label MinValueLabel;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SerializeBtn;
        private System.Windows.Forms.ToolStripMenuItem openCommandstxtToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenCmdsTxtFileDialog;
    }
}

