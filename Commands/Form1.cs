using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;


namespace Commands
{
    public partial class Commands : Form
    {
        // A copy of Command
        private Command cmd =  new Command();
        // Create a new sorted dictionary of strings, with string keys
        Dictionary<string, Command> cmdsDict = new Dictionary<string, Command>();

        public Commands()
        {
            InitializeComponent();
        }

        //public void SetCmdNameComboBox(ref SortedDictionary<string, Command> cmds)
        //{
        //    cmdNameComboBox.DataSource = new BindingSource(cmds, null);
        //    cmdNameComboBox.DisplayMember = "Key";
        //    cmdNameComboBox.ValueMember = "Value";
        //}

        private void readMethodcomboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void funcTextBox_TextChanged(object sender, System.EventArgs e)
        {
            cmd.SetFunc(funcTextBox.Text);
        }

        private void SaveNewCmdBtn_Click(object sender, System.EventArgs e)
        {
            SortedDictionary<string, Command> cmds = (SortedDictionary<string, Command>)cmdNameComboBox.DataSource;
            cmds.Add(this.cmd.GetName(), this.cmd);
        }



        private void cmdNameComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // get selected KVP
            KeyValuePair<string, Command> selectedEntry
                = (KeyValuePair<string, Command>)cmdNameComboBox.SelectedItem;

            cmd = selectedEntry.Value;

            funcTextBox.Text = selectedEntry.Value.GetFunc();

            string units = selectedEntry.Value.GetUnits();

            if (units == "s8_Units_Pos") unitsCmboBox.SelectedIndex = 0;
            else if (units == "s8_Units_Analog_IO") unitsCmboBox.SelectedIndex = 1;
            else if (units == "s8_Units_Vel_Out_Loop_Scale") unitsCmboBox.SelectedIndex = 2;
            else unitsCmboBox.SelectedIndex = 3;

            FillArgsComboBox(selectedEntry.Value); // Fill additional args
            FillReadCmdArgs(selectedEntry.Value); // Read Arguments fill
            FillWriteCmdArgs(selectedEntry.Value); // Write Arguments fill
        }

        public static int ToInt(string str)
        {
            if (str == "") return 0;
            return int.Parse(str);
        }

        private void FillArgsComboBox(Command cmd)
        {
            string[] args = cmd.GetArgs();
            Args1ComboBox.SelectedIndex = ToInt(args[0]);
            Args2ComboBox.SelectedIndex = ToInt(args[1]);
            Args3ComboBox.SelectedIndex = ToInt(args[3]);
            Args4ComboBox.SelectedIndex = ToInt(args[4]);
            Args5ComboBox.SelectedIndex = ToInt(args[5]);
            Args6ComboBox.SelectedIndex = ToInt(args[6]);
            Args7ComboBox.SelectedIndex = ToInt(args[7]);
            Args8ComboBox.SelectedIndex = ToInt(args[8]);
            Args9ComboBox.SelectedIndex = ToInt(args[9]);
            Args10ComboBox.SelectedIndex = ToInt(args[10]);
            Args11ComboBox.SelectedIndex = ToInt(args[11]);
        }


        private void FillReadSignaturesComboBox(string signature)
        {
            string returnType = "int ";
            string[] signatures = { signature
                                    , returnType + signature + "(int*)"
                                    , returnType + signature + "(int*)"
                                    , returnType + signature + "(void) + Args"
                                    , returnType + signature + "(void) + Args"
                                    , returnType + signature + "(void) + Args + Both Axes"
                                    , returnType + signature + "(int *) + Both Axes" };

            ReadMethodComboBox.Items.AddRange(signatures);
            ReadMethodComboBox.SelectedIndex = 0;
        }


        private void FillWriteSignaturesComboBox(string signature)
        {

/*          Servotronix:
            Specifies the prototype of the writing function where:
            WR_DPTR - Write via data pointer
            WR_FPTR0 - Write via int fname(long long param, int drive)
            WR_FPTR1 - Write via int fname(int drive) no arguments needed
            WR_FPTR2 - Write via int fname(long param1, long param2)
            WR_FCUST - Write via int fname(int drive), arguments via s64_Execution_Parameter[]
            WR_FCUST0 - Write via int fname(void), shared with both axes, arguments via s64_Execution_Parameter[]
            WR_FCUST1 - Write via int fname(int drive), handle unit conversion only for the 2nd argument*/


            string returnType = "int ";
            string[] signatures = { signature
                                    , returnType + signature + "(int*)"
                                    , returnType + signature + "(int*)"
                                    , returnType + signature + "(void) + Args"
                                    , returnType + signature + "(void) + Args"
                                    , returnType + signature + "(void) + Args + Both Axes"
                                    , returnType + signature + "(int *) + Both Axes" };

            WriteMethodComboBox.Items.AddRange(signatures);
            WriteMethodComboBox.SelectedIndex = 0;
        }


        private void FillReadCmdArgs(Command cmd)
        {
            // Read Arguments
            MinReadTextBox.Text = cmd.GetMinReadVal();
            MaxReadTextBox.Text = cmd.GetMaxReadVal();
            ReadAccessTextBox.Text = cmd.GetReadAccess();
            FillSignaturesComboBox(cmd); // Fill Read Signature ComboBox
            ReadMethodComboBox.SelectedIndex = cmd.GetReadMethod();
        }

        private void FillWriteCmdArgs(Command cmd)
        {
            // Read Arguments
            MinWriteTextBox.Text = cmd.GetMinWriteVal();
            MaxWriteTextBox.Text = cmd.GetMaxWriteVal();
            WriteAccessTextBox.Text = cmd.GetWriteAccess();
            WriteMethodComboBox.SelectedIndex = cmd.GetWriteMethod();
        }

        private void cmdNameComboBox_TextUpdated(Object sender, EventArgs e)
        {
            MessageBox.Show("You are in the ComboBox.TextUpdate event.");
        }

        private void unitsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SerializeBtn_Click(object sender, EventArgs e)
        {
        // get selected KVP
        //KeyValuePair<string, Command> selectedEntry
        //= (KeyValuePair<string, Command>)cmdNameComboBox.SelectedItem;
        //MessageBox.Show(selectedEntry.Value.Serialize());

            StreamWriter file = new StreamWriter("..\\..\\Drive_Table_2.def");

            file.WriteLine("/*******************************************************************");
            file.WriteLine("*                                                                  *");
            file.WriteLine("*   Drive_Table.def                                                *");
            file.WriteLine("*                                                                  *");
            file.WriteLine("*   Do not modify this file directly                               *");
            file.WriteLine("*   To update table, modify CDHD -Commands.xls and run the macro   *");
            file.WriteLine("*                                                                  *");
            file.WriteLine("*                                                                  *");
            file.WriteLine("*******************************************************************/");
            file.WriteLine("");
            file.WriteLine("#define NA 0");
            file.WriteLine("");
            file.WriteLine("#define COMMANDS_TABLE \\");
            file.WriteLine("{ \\");

            foreach (var entry in cmdsDict)
            {
                file.WriteLine(entry.Value.SerializeForSrcFile());
            }
        }

        private void openCommandstxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCmdsTxtFileDialog.ShowDialog();
            string path = OpenCmdsTxtFileDialog.FileName;

            //Default file. MAKE SURE TO CHANGE THIS LOCATION AND FILE PATH TO YOUR FILE 
                // Read a text file line by line.
            string[] lines = File.ReadAllLines(path);
            char delimiter = ',';

            foreach (string line in lines)
            {
                // Add some elements to the dictionary. There are no 
                // duplicate keys, but some of the values are duplicates.
                string[] words = line.Split(delimiter);
                Command cmd = new Command(words);
                cmdsDict.Add(words[0], cmd);

            }

            cmdNameComboBox.DataSource = new BindingSource(cmdsDict, null);
            cmdNameComboBox.DisplayMember = "Key";
            cmdNameComboBox.ValueMember = "Value";
        }

        private void Commands_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowCmdDataGrid_Click(object sender, EventArgs e)
        {
            dataGridCommands.Rows.Add(cmd.GetName(), cmd.GetFunc(), cmd.GetUnits());
        }

        private void dataGridCommands_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AccessReadLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
