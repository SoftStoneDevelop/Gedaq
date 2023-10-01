using Gedaq.Base.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Helpers
{
    internal static class CommandParametrsHelper
    {
        public static void AddOutParametrs(BaseParametr parametr, StringBuilder builder, string batchPostfix = "")
        {
            if (parametr.Direction == System.Data.ParameterDirection.InputOutput || parametr.Direction == System.Data.ParameterDirection.Output)
            {
                builder.Append($@",
            out {parametr.Type.GetFullTypeName(true)} {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.Output))}{batchPostfix}
");
                return;
            }

            if (parametr.Direction == System.Data.ParameterDirection.ReturnValue)
            {
                builder.Append($@",
            out {parametr.Type.GetFullTypeName(true)} {parametr.VariableName(BaseParametr.VariablePostfix(System.Data.ParameterDirection.ReturnValue))}{batchPostfix}
");
                return;
            }
        }
    }
}