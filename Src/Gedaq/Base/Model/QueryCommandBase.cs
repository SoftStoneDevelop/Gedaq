using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Base.Model
{
    internal abstract class QueryBaseCommand : QueryBase
    {
        public string Query;
        public Aliases Aliases;
        public FormatParametr[] FormatParametrs;
        public bool HaveFromatParametrs()
        {
            return FormatParametrs != null;
        }

        public bool NeedGenerate;

        public abstract bool HaveParametrs();

        public abstract IEnumerable<BaseParametr> BaseParametrs();

        protected bool FillGenerate(TypedConstant argument)
        {
            if (!(argument.Type is INamedTypeSymbol namedTypeSymbol) ||
                namedTypeSymbol.Name != nameof(Boolean)
                )
            {
                return false;
            }

            NeedGenerate = (bool)argument.Value;
            return true;
        }

        protected bool FillQuery(TypedConstant argument)
        {
            if (!(argument.Type is INamedTypeSymbol strParam) ||
                strParam.Name != nameof(String)
                )
            {
                return false;
            }

            Query = (string)argument.Value;
            return true;
        }
    }
}