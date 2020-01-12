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
        private int argsReadMin;
        private int argsReadMax;

        private string commandType;

        // write
        private string writeAccess;
        private string writeMethod;
        private int argsWriteMin;
        private int argsWriteMax;

        private string retTypeSign; // 0 - Unsigned, Signed
        private string retTypeSize; //

        internal int[] GetArgs()
        {
            return this.args;
        }

        private int[] args; // 0 - 14

        private string[] words;

        public string GetFunc()
        {
            return func;
        }

        public Command()
        {
            // Default constructor
        }

        public Command(string[] words)
        {
            this.words = words;

            name = words[(int)CmdLabels.NAME]; // String
            func = words[(int)CmdLabels.FUNC]; // String
            units = words[(int)CmdLabels.UNITS];
            // read

            
            readAccess = words[(int)CmdLabels.READ_ACCESS];
            readMethod = words[(int)CmdLabels.READ_METHOD];

            if (!string.IsNullOrEmpty(words[(int)CmdLabels.MIN_ARGS_FOR_READ]))
            {
                argsReadMin = int.Parse(words[(int)CmdLabels.MIN_ARGS_FOR_READ]);
            }
            
            if(!string.IsNullOrEmpty(words[(int)CmdLabels.MAX_ARGS_FOR_READ]))
            {
                argsReadMax = int.Parse(words[(int)CmdLabels.MAX_ARGS_FOR_READ]);
            }
            readMethod = words[(int)CmdLabels.READ_METHOD];

            commandType = words[(int)CmdLabels.COMMAND_TYPE];

            // write
            writeAccess = words[(int)CmdLabels.WRITE_ACCESS];
            writeMethod = words[(int)CmdLabels.WRITE_METHOD];
            if (!string.IsNullOrEmpty(words[(int)CmdLabels.MIN_ARGS_FOR_WRITE]))
            {
                argsWriteMin = int.Parse(words[(int)CmdLabels.MIN_ARGS_FOR_WRITE]);
            }
            if (!string.IsNullOrEmpty(words[(int)CmdLabels.MAX_ARGS_FOR_WRITE]))
            {
                argsWriteMax = int.Parse(words[(int)CmdLabels.MAX_ARGS_FOR_WRITE]);
            }

            // return value
            retTypeSign = words[(int)CmdLabels.RETURN_TYPE_SIGN];
            retTypeSize = words[(int)CmdLabels.RETURN_TYPE_SIZE];

            args = new int[15];

            for (int i = (int)CmdLabels.ARG1, k = 0; i <= (int)CmdLabels.ARG15;k++, i++)
            {
                if ( !string.IsNullOrEmpty(words[i]) )
                {
                    args[k] = int.Parse(words[i]);
                }
                else
                {
                    args[k] = 0;
                }
            }
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
    }
}
