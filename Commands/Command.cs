using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    public enum CmdLabels
    {
        NAME,
        FUNC,
        UNITS,
        READ_ACCESS,
        READ_METHOD,
        MIN_ARGS_FOR_READ,
        MAX_ARGS_FOR_READ,
        WRITE_ACCESS,
        WRITE_METHOD,
        COMMAND_TYPE,
        MIN_ARGS_FOR_WRITE,
        MAX_ARGS_FOR_WRITE,
        RETURN_TYPE_SIGN,
        RETURN_TYPE_SIZE,
        ARG1,
        ARG2,
        ARG3,
        ARG4,
        ARG5,
        ARG6,
        ARG7,
        ARG8,
        ARG9,
        ARG10,
        ARG11,
        ARG12,
        ARG13,
        ARG14,
        ARG15,
        MIN_VAL,
        MAX_VAL,
        USER_RANGE,
        DRIVE_DEFAULT_VALUE,
        DEFAULT_FOR_USER,
        DRIVE_ACTIVE,
        DRIVE_INACTIVE,
        VALUE_TOO_HIGH,
        VALUE_TOO_LOW,
        BURNIN_ACTIVE,
        LIMIT_SWITCH_HOLD,
        REJECT_IN_DDHD,
        REJECT_IN_BDHD,
        PASSWORD_PROTECTED,
        CAN_SDO,
        CAN_SDO_FOR_USER,
        NVRAM_VAR_NAME,
        NVRAM_VAR_SIZE,
        DUMP_GROUP,
        DUMP_SUB_GROUP,
        VER_ADDED,
        OWNER,
        GUI_DESCRIPTION_SHORT,
        GUI_DESCRIPTION_LONG,
        DUAL_MODE,
        HMI_GROUPING_NEW,
        RECORD_ENHANCE_HANDLING,
        SST_PARAM_TABLE_GROUP,


        NUM_OF_LABELS
    }
    public class Command
    {
        private string name;
        private string func;
        private string units;
        // read
        private string readAccess;
        private string readMethod;
        private string argsReadMin;
        private string argsReadMax;

        // Cmd type
        private string commandType;

        // write
        private string writeAccess;
        private string writeMethod;
        private string argsWriteMin;
        private string argsWriteMax;

        private string retTypeSign; // 0 - Unsigned, Signed
        private string retTypeSize; //

        internal string[] GetArgs()
        {
            return this.args;
        }

        private string[] args = new string[15]; // 0 - 14

        public string GetFunc()
        {
            return func;
        }

        public Command()
        {
            // Default constructor
        }

        // Contstructor from array of strings
        public Command(string[] words)
        {
            //this.words = words;

            this.name = words[(int)CmdLabels.NAME]; // 1
            this.func = words[(int)CmdLabels.FUNC]; // 2
            this.units = words[(int)CmdLabels.UNITS]; // 3

            // read
            this.readAccess = words[(int)CmdLabels.READ_ACCESS]; // 4
            this.readMethod = words[(int)CmdLabels.READ_METHOD]; // 5
            this.argsReadMin = words[(int)CmdLabels.MIN_ARGS_FOR_READ]; // 6
            this.argsReadMax = words[(int)CmdLabels.MAX_ARGS_FOR_READ]; // 7
            this.readMethod = words[(int)CmdLabels.READ_METHOD];

            // Cmd type
            this.commandType = words[(int)CmdLabels.COMMAND_TYPE]; // 8

            // write
            this.writeAccess = words[(int)CmdLabels.WRITE_ACCESS]; // 9
            this.writeMethod = words[(int)CmdLabels.WRITE_METHOD]; // 10
            this.argsWriteMin = words[(int)CmdLabels.MIN_ARGS_FOR_WRITE]; // 11
            this.argsWriteMax = words[(int)CmdLabels.MAX_ARGS_FOR_WRITE]; // 12

            // return value
            this.retTypeSign = words[(int)CmdLabels.RETURN_TYPE_SIGN]; // 13
            this.retTypeSize = words[(int)CmdLabels.RETURN_TYPE_SIZE]; // 14

            //args 15 - 30
            int count = args.Count();
            for(int i = 0; i < count; ++i)
                args[i] = words[i + (int)CmdLabels.ARG1];

        }

        public Command(Command cmd)
        {
            this.name = cmd.name;
            this.func = cmd.func;
            this.units = cmd.units;

            // Read
            this.readAccess = cmd.readAccess;
            this.readMethod = cmd.readMethod;
            this.argsReadMin = cmd.argsReadMin;
            this.argsReadMax = cmd.argsReadMax;

            // Command type
            this.commandType = cmd.commandType;

            // Write
            this.writeAccess = cmd.writeAccess;
            this.writeMethod = cmd.writeMethod;
            this.argsWriteMin = cmd.argsWriteMin;
            this.argsWriteMax = cmd.argsWriteMax;
        }

        public string Serialize()
        {
            string str = this.name + "," + this.func + "," + this.units + "," + this.readAccess + "," +
                this.readMethod + "," + this.argsReadMin + "," + this.argsReadMax + "," + this.commandType + "," +
                this.writeAccess + "," + this.writeMethod + "," + this.argsWriteMin + "," + this.argsWriteMax;
            return str;
        }

        internal string GetUnits()
        {
            return this.units;
        }

        public void SetFunc(string _func)
        {
            this.func = _func;
        }

        internal string GetName()
        {
            return this.name;
        }

        internal string GetMinReadVal()
        {
            return this.argsReadMin;
        }

        internal string GetMaxReadVal()
        {
            return this.argsReadMax;
        }

        internal int GetReadMethod()
        {
            int retVal = 0;
            if (this.readMethod == "RD_DPTR") retVal = 0;
            if (this.readMethod == "RD_FPTR0") retVal = 1;
            if (this.readMethod == "RD_FPTR1") retVal = 2;
            if (this.readMethod == "RD_FPTR2") retVal = 3;
            if (this.readMethod == "RD_FCUST0") retVal = 4;
            if (this.readMethod == "RD_FCUST1") retVal = 5;
            if (this.readMethod == "RD_FCUST2") retVal = 6;

            return retVal;
        }

        internal string GetReadAccess()
        {
            return readAccess;
        }
    }
}
