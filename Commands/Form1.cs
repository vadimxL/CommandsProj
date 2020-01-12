using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Commands
{
    public partial class Form1 : Form
    {
        private Command cmd =  new Command();

        public Form1()
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

            string tmpStr = selectedEntry.Value.Serialize();

            //MessageBox.Show(tmpStr);

            funcTextBox.Text = selectedEntry.Value.GetFunc();

            string units = selectedEntry.Value.GetUnits();

            if (units == "s8_Units_Pos")
            {
                unitsCmboBox.SelectedIndex = 0;
            }
            else if (units == "s8_Units_Analog_IO")
            {
                unitsCmboBox.SelectedIndex = 1;
            }
            else if (units == "s8_Units_Vel_Out_Loop_Scale")
            {
                unitsCmboBox.SelectedIndex = 2;
            }
            else
            {
                unitsCmboBox.SelectedIndex = 3;
            }

            int[] args = selectedEntry.Value.GetArgs();

            Args1ComboBox.SelectedIndex = args[0];
            Args2ComboBox.SelectedIndex = args[1];
            Args3ComboBox.SelectedIndex = args[2];
            Args4ComboBox.SelectedIndex = args[3];
            Args5ComboBox.SelectedIndex = args[4];
            Args6ComboBox.SelectedIndex = args[5];
            Args7ComboBox.SelectedIndex = args[6];
            Args8ComboBox.SelectedIndex = args[7];
            Args9ComboBox.SelectedIndex = args[8];
            Args10ComboBox.SelectedIndex = args[9];
            Args11ComboBox.SelectedIndex = args[10];
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
    }
}
