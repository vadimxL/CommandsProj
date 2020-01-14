using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Commands
{
    public partial class Commands : Form
    {
        private Command cmd =  new Command();

        public Commands()
        {
            InitializeComponent();
        }

        public void SetCmdNameComboBox(ref SortedDictionary<string, Command> cmds)
        {
            cmdNameComboBox.DataSource = new BindingSource(cmds, null);
            cmdNameComboBox.DisplayMember = "Key";
            cmdNameComboBox.ValueMember = "Value";
        }

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

            funcTextBox.Text = selectedEntry.Value.GetFunc();

            string units = selectedEntry.Value.GetUnits();

            if (units == "s8_Units_Pos") unitsCmboBox.SelectedIndex = 0;
            else if (units == "s8_Units_Analog_IO") unitsCmboBox.SelectedIndex = 1;
            else if (units == "s8_Units_Vel_Out_Loop_Scale") unitsCmboBox.SelectedIndex = 2;
            else unitsCmboBox.SelectedIndex = 3;

            FillArgsComboBox(selectedEntry.Value); // Fill additional args
            ReadCommandArguments(selectedEntry.Value); // Read Arguments
        }

        private void FillArgsComboBox(Command cmd)
        {
            string[] args = cmd.GetArgs();
            Args1ComboBox.SelectedIndex = int.Parse(args[0]);
            Args2ComboBox.SelectedIndex = int.Parse(args[1]);
            Args3ComboBox.SelectedIndex = int.Parse(args[2]);
            Args4ComboBox.SelectedIndex = int.Parse(args[3]);
            Args5ComboBox.SelectedIndex = int.Parse(args[4]);
            Args6ComboBox.SelectedIndex = int.Parse(args[5]);
            Args7ComboBox.SelectedIndex = int.Parse(args[6]);
            Args8ComboBox.SelectedIndex = int.Parse(args[7]);
            Args9ComboBox.SelectedIndex = int.Parse(args[8]);
            Args10ComboBox.SelectedIndex = int.Parse(args[9]);
            Args11ComboBox.SelectedIndex = int.Parse(args[10]);
        }

        private void ReadCommandArguments(Command cmd)
        {
            // Read Arguments
            MinReadTextBox.Text = cmd.GetMinReadVal();
            MaxReadTextBox.Text = cmd.GetMaxReadVal();
            ReadAccessTextBox.Text = cmd.GetReadAccess();
            ReadMethodComboBox.SelectedIndex = cmd.GetReadMethod();
        }

        private void cmdNameComboBox_TextUpdated(Object sender, EventArgs e)
        {
            MessageBox.Show("You are in the ComboBox.TextUpdate event.");
        }


        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void unitsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void BlockFlags_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void SerializeBtn_Click(object sender, EventArgs e)
        {
            // get selected KVP
            KeyValuePair<string, Command> selectedEntry
                = (KeyValuePair<string, Command>)cmdNameComboBox.SelectedItem;
            MessageBox.Show(selectedEntry.Value.Serialize());
        }
    }
}
