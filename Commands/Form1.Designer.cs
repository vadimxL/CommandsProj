﻿using System;
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
            this.openCommandstxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.OpenCmdsTxtFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridCommands = new System.Windows.Forms.DataGridView();
            this.btnShowCmdDataGrid = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.ValueGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCommands)).BeginInit();
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
            this.BlockFlags.Location = new System.Drawing.Point(12, 16);
            this.BlockFlags.Name = "BlockFlags";
            this.BlockFlags.Size = new System.Drawing.Size(182, 184);
            this.BlockFlags.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdNameComboBox);
            this.groupBox1.Controls.Add(this.Mnemonic);
            this.groupBox1.Controls.Add(this.unitsCmboBox);
            this.groupBox1.Controls.Add(this.funcTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 103);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Misc";
            // 
            // cmdNameComboBox
            // 
            this.cmdNameComboBox.FormattingEnabled = true;
            this.cmdNameComboBox.Location = new System.Drawing.Point(60, 13);
            this.cmdNameComboBox.Name = "cmdNameComboBox";
            this.cmdNameComboBox.Size = new System.Drawing.Size(120, 21);
            this.cmdNameComboBox.TabIndex = 7;
            this.cmdNameComboBox.SelectedIndexChanged += new System.EventHandler(this.cmdNameComboBox_SelectedIndexChanged);
            this.cmdNameComboBox.TextUpdate += new System.EventHandler(this.cmdNameComboBox_TextUpdated);
            // 
            // Mnemonic
            // 
            this.Mnemonic.AutoSize = true;
            this.Mnemonic.Location = new System.Drawing.Point(5, 16);
            this.Mnemonic.Name = "Mnemonic";
            this.Mnemonic.Size = new System.Drawing.Size(35, 13);
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
            this.unitsCmboBox.Location = new System.Drawing.Point(59, 72);
            this.unitsCmboBox.Name = "unitsCmboBox";
            this.unitsCmboBox.Size = new System.Drawing.Size(120, 21);
            this.unitsCmboBox.TabIndex = 5;
            this.unitsCmboBox.SelectedIndexChanged += new System.EventHandler(this.unitsComboBox_SelectedIndexChanged);
            // 
            // funcTextBox
            // 
            this.funcTextBox.Location = new System.Drawing.Point(59, 43);
            this.funcTextBox.Name = "funcTextBox";
            this.funcTextBox.Size = new System.Drawing.Size(120, 20);
            this.funcTextBox.TabIndex = 4;
            this.funcTextBox.TextChanged += new System.EventHandler(this.funcTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Units";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BlockFlags);
            this.groupBox2.Location = new System.Drawing.Point(560, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 210);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Block Flags";
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
            this.groupBox3.Location = new System.Drawing.Point(20, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 121);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Read";
            // 
            // ReadMethodComboBox
            // 
            this.ReadMethodComboBox.FormattingEnabled = true;
            this.ReadMethodComboBox.Location = new System.Drawing.Point(68, 83);
            this.ReadMethodComboBox.Name = "ReadMethodComboBox";
            this.ReadMethodComboBox.Size = new System.Drawing.Size(158, 21);
            this.ReadMethodComboBox.TabIndex = 6;
            // 
            // ReadMethodLabel
            // 
            this.ReadMethodLabel.AutoSize = true;
            this.ReadMethodLabel.Location = new System.Drawing.Point(15, 84);
            this.ReadMethodLabel.Name = "ReadMethodLabel";
            this.ReadMethodLabel.Size = new System.Drawing.Size(52, 13);
            this.ReadMethodLabel.TabIndex = 12;
            this.ReadMethodLabel.Text = "Signature";
            // 
            // ReadAccessTextBox
            // 
            this.ReadAccessTextBox.Location = new System.Drawing.Point(68, 57);
            this.ReadAccessTextBox.Name = "ReadAccessTextBox";
            this.ReadAccessTextBox.Size = new System.Drawing.Size(158, 20);
            this.ReadAccessTextBox.TabIndex = 11;
            // 
            // AccessReadLabel
            // 
            this.AccessReadLabel.AutoSize = true;
            this.AccessReadLabel.Location = new System.Drawing.Point(20, 61);
            this.AccessReadLabel.Name = "AccessReadLabel";
            this.AccessReadLabel.Size = new System.Drawing.Size(35, 13);
            this.AccessReadLabel.TabIndex = 10;
            this.AccessReadLabel.Text = "Name";
            this.AccessReadLabel.Click += new System.EventHandler(this.AccessReadLabel_Click);
            // 
            // MinReadLabel
            // 
            this.MinReadLabel.AutoSize = true;
            this.MinReadLabel.Location = new System.Drawing.Point(59, 27);
            this.MinReadLabel.Name = "MinReadLabel";
            this.MinReadLabel.Size = new System.Drawing.Size(24, 13);
            this.MinReadLabel.TabIndex = 9;
            this.MinReadLabel.Text = "Min";
            // 
            // MaxReadTextBox
            // 
            this.MaxReadTextBox.Location = new System.Drawing.Point(177, 24);
            this.MaxReadTextBox.Name = "MaxReadTextBox";
            this.MaxReadTextBox.Size = new System.Drawing.Size(49, 20);
            this.MaxReadTextBox.TabIndex = 8;
            // 
            // MaxReadLabel
            // 
            this.MaxReadLabel.AutoSize = true;
            this.MaxReadLabel.Location = new System.Drawing.Point(144, 27);
            this.MaxReadLabel.Name = "MaxReadLabel";
            this.MaxReadLabel.Size = new System.Drawing.Size(27, 13);
            this.MaxReadLabel.TabIndex = 7;
            this.MaxReadLabel.Text = "Max";
            // 
            // MinReadTextBox
            // 
            this.MinReadTextBox.Location = new System.Drawing.Point(89, 24);
            this.MinReadTextBox.Name = "MinReadTextBox";
            this.MinReadTextBox.Size = new System.Drawing.Size(49, 20);
            this.MinReadTextBox.TabIndex = 6;
            // 
            // ArgsLabel
            // 
            this.ArgsLabel.AutoSize = true;
            this.ArgsLabel.Location = new System.Drawing.Point(19, 27);
            this.ArgsLabel.Name = "ArgsLabel";
            this.ArgsLabel.Size = new System.Drawing.Size(28, 13);
            this.ArgsLabel.TabIndex = 6;
            this.ArgsLabel.Text = "Args";
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
            this.groupBox4.Location = new System.Drawing.Point(20, 261);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(246, 121);
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
            this.WriteMethodComboBox.Location = new System.Drawing.Point(69, 93);
            this.WriteMethodComboBox.Name = "WriteMethodComboBox";
            this.WriteMethodComboBox.Size = new System.Drawing.Size(157, 21);
            this.WriteMethodComboBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Method";
            // 
            // WriteAccessTextBox
            // 
            this.WriteAccessTextBox.Location = new System.Drawing.Point(68, 58);
            this.WriteAccessTextBox.Name = "WriteAccessTextBox";
            this.WriteAccessTextBox.Size = new System.Drawing.Size(158, 20);
            this.WriteAccessTextBox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Min";
            // 
            // MaxWriteTextBox
            // 
            this.MaxWriteTextBox.Location = new System.Drawing.Point(177, 24);
            this.MaxWriteTextBox.Name = "MaxWriteTextBox";
            this.MaxWriteTextBox.Size = new System.Drawing.Size(49, 20);
            this.MaxWriteTextBox.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(144, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Max";
            // 
            // MinWriteTextBox
            // 
            this.MinWriteTextBox.Location = new System.Drawing.Point(89, 24);
            this.MinWriteTextBox.Name = "MinWriteTextBox";
            this.MinWriteTextBox.Size = new System.Drawing.Size(49, 20);
            this.MinWriteTextBox.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
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
            this.groupBox5.Location = new System.Drawing.Point(20, 388);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(746, 50);
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
            this.Args11ComboBox.Location = new System.Drawing.Point(659, 19);
            this.Args11ComboBox.Name = "Args11ComboBox";
            this.Args11ComboBox.Size = new System.Drawing.Size(59, 21);
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
            this.Args10ComboBox.Location = new System.Drawing.Point(594, 19);
            this.Args10ComboBox.Name = "Args10ComboBox";
            this.Args10ComboBox.Size = new System.Drawing.Size(59, 21);
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
            this.Args9ComboBox.Location = new System.Drawing.Point(529, 19);
            this.Args9ComboBox.Name = "Args9ComboBox";
            this.Args9ComboBox.Size = new System.Drawing.Size(59, 21);
            this.Args9ComboBox.TabIndex = 8;
            // 
            // Args8ComboBox
            // 
            this.Args8ComboBox.FormattingEnabled = true;
            this.Args8ComboBox.Items.AddRange(new object[] {
            "NA",
            "Int",
            "Decimal",
            "String"});
            this.Args8ComboBox.Location = new System.Drawing.Point(464, 19);
            this.Args8ComboBox.Name = "Args8ComboBox";
            this.Args8ComboBox.Size = new System.Drawing.Size(59, 21);
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
            this.Args7ComboBox.Location = new System.Drawing.Point(399, 19);
            this.Args7ComboBox.Name = "Args7ComboBox";
            this.Args7ComboBox.Size = new System.Drawing.Size(59, 21);
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
            this.Args6ComboBox.Location = new System.Drawing.Point(334, 19);
            this.Args6ComboBox.Name = "Args6ComboBox";
            this.Args6ComboBox.Size = new System.Drawing.Size(59, 21);
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
            this.Args5ComboBox.Location = new System.Drawing.Point(269, 19);
            this.Args5ComboBox.Name = "Args5ComboBox";
            this.Args5ComboBox.Size = new System.Drawing.Size(59, 21);
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
            this.Args4ComboBox.Location = new System.Drawing.Point(204, 19);
            this.Args4ComboBox.Name = "Args4ComboBox";
            this.Args4ComboBox.Size = new System.Drawing.Size(59, 21);
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
            this.Args3ComboBox.Location = new System.Drawing.Point(139, 19);
            this.Args3ComboBox.Name = "Args3ComboBox";
            this.Args3ComboBox.Size = new System.Drawing.Size(59, 21);
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
            this.Args2ComboBox.Location = new System.Drawing.Point(74, 19);
            this.Args2ComboBox.Name = "Args2ComboBox";
            this.Args2ComboBox.Size = new System.Drawing.Size(59, 21);
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
            this.Args1ComboBox.Location = new System.Drawing.Point(9, 19);
            this.Args1ComboBox.Name = "Args1ComboBox";
            this.Args1ComboBox.Size = new System.Drawing.Size(59, 21);
            this.Args1ComboBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(958, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCommandToolStripMenuItem,
            this.openCommandstxtToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCommandToolStripMenuItem
            // 
            this.newCommandToolStripMenuItem.Name = "newCommandToolStripMenuItem";
            this.newCommandToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.newCommandToolStripMenuItem.Text = "New Command";
            // 
            // openCommandstxtToolStripMenuItem
            // 
            this.openCommandstxtToolStripMenuItem.Name = "openCommandstxtToolStripMenuItem";
            this.openCommandstxtToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.openCommandstxtToolStripMenuItem.Text = "Open Commands.txt";
            this.openCommandstxtToolStripMenuItem.Click += new System.EventHandler(this.openCommandstxtToolStripMenuItem_Click);
            // 
            // SaveNewCmdBtn
            // 
            this.SaveNewCmdBtn.Location = new System.Drawing.Point(613, 324);
            this.SaveNewCmdBtn.Name = "SaveNewCmdBtn";
            this.SaveNewCmdBtn.Size = new System.Drawing.Size(152, 23);
            this.SaveNewCmdBtn.TabIndex = 17;
            this.SaveNewCmdBtn.Text = "Save As New Command";
            this.SaveNewCmdBtn.UseVisualStyleBackColor = true;
            this.SaveNewCmdBtn.Click += new System.EventHandler(this.SaveNewCmdBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(613, 359);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(152, 23);
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
            this.ValueGroup.Location = new System.Drawing.Point(354, 40);
            this.ValueGroup.Name = "ValueGroup";
            this.ValueGroup.Size = new System.Drawing.Size(189, 136);
            this.ValueGroup.TabIndex = 20;
            this.ValueGroup.TabStop = false;
            this.ValueGroup.Text = "Value";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(85, 96);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(88, 20);
            this.textBox10.TabIndex = 7;
            // 
            // DriveDefaultValue
            // 
            this.DriveDefaultValue.AutoSize = true;
            this.DriveDefaultValue.Location = new System.Drawing.Point(8, 96);
            this.DriveDefaultValue.Name = "DriveDefaultValue";
            this.DriveDefaultValue.Size = new System.Drawing.Size(71, 13);
            this.DriveDefaultValue.TabIndex = 6;
            this.DriveDefaultValue.Text = "Default Value";
            // 
            // UserRangeLabel
            // 
            this.UserRangeLabel.AutoSize = true;
            this.UserRangeLabel.Location = new System.Drawing.Point(15, 70);
            this.UserRangeLabel.Name = "UserRangeLabel";
            this.UserRangeLabel.Size = new System.Drawing.Size(64, 13);
            this.UserRangeLabel.TabIndex = 5;
            this.UserRangeLabel.Text = "User Range";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(85, 70);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(88, 20);
            this.textBox9.TabIndex = 4;
            // 
            // MaxValueLabel
            // 
            this.MaxValueLabel.AutoSize = true;
            this.MaxValueLabel.Location = new System.Drawing.Point(52, 42);
            this.MaxValueLabel.Name = "MaxValueLabel";
            this.MaxValueLabel.Size = new System.Drawing.Size(27, 13);
            this.MaxValueLabel.TabIndex = 3;
            this.MaxValueLabel.Text = "Max";
            // 
            // MinValueLabel
            // 
            this.MinValueLabel.AutoSize = true;
            this.MinValueLabel.Location = new System.Drawing.Point(55, 16);
            this.MinValueLabel.Name = "MinValueLabel";
            this.MinValueLabel.Size = new System.Drawing.Size(24, 13);
            this.MinValueLabel.TabIndex = 2;
            this.MinValueLabel.Text = "Min";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(85, 16);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(88, 20);
            this.textBox8.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 20);
            this.textBox1.TabIndex = 0;
            // 
            // SerializeBtn
            // 
            this.SerializeBtn.Location = new System.Drawing.Point(614, 288);
            this.SerializeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SerializeBtn.Name = "SerializeBtn";
            this.SerializeBtn.Size = new System.Drawing.Size(152, 23);
            this.SerializeBtn.TabIndex = 21;
            this.SerializeBtn.Text = "Serialize";
            this.SerializeBtn.UseVisualStyleBackColor = true;
            this.SerializeBtn.Click += new System.EventHandler(this.SerializeBtn_Click);
            // 
            // OpenCmdsTxtFileDialog
            // 
            this.OpenCmdsTxtFileDialog.FileName = "OpenCmdsTxtFileDialog";
            // 
            // dataGridCommands
            // 
            this.dataGridCommands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCommands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridCommands.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridCommands.Location = new System.Drawing.Point(0, 462);
            this.dataGridCommands.Name = "dataGridCommands";
            this.dataGridCommands.Size = new System.Drawing.Size(958, 114);
            this.dataGridCommands.TabIndex = 22;
            this.dataGridCommands.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCommands_CellContentClick);
            // 
            // btnShowCmdDataGrid
            // 
            this.btnShowCmdDataGrid.Location = new System.Drawing.Point(455, 359);
            this.btnShowCmdDataGrid.Name = "btnShowCmdDataGrid";
            this.btnShowCmdDataGrid.Size = new System.Drawing.Size(152, 23);
            this.btnShowCmdDataGrid.TabIndex = 19;
            this.btnShowCmdDataGrid.Text = "Show Command";
            this.btnShowCmdDataGrid.UseVisualStyleBackColor = true;
            this.btnShowCmdDataGrid.Click += new System.EventHandler(this.btnShowCmdDataGrid_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(794, 405);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Function";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Units";
            this.Column3.Name = "Column3";
            // 
            // Commands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 576);
            this.Controls.Add(this.dataGridCommands);
            this.Controls.Add(this.SerializeBtn);
            this.Controls.Add(this.ValueGroup);
            this.Controls.Add(this.btnShowCmdDataGrid);
            this.Controls.Add(this.btnExit);
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
            this.Name = "Commands";
            this.Text = "Commands";
            this.Load += new System.EventHandler(this.Commands_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCommands)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridCommands;
        private System.Windows.Forms.Button btnShowCmdDataGrid;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

