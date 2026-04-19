using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;

namespace Gedaq.Base.Model
{    
    internal abstract class QueryBaseCommand : QueryBase
    {
        public string Query;

        public bool IsDynamicQuery()
        {
            return Query == null;
        }

        public FormatParametr[] FormatParametrs;

        public bool HaveFromatParametrs()
        {
            return FormatParametrs?.Length > 0;
        }

        public abstract bool HaveDynamicParametrs();

        public abstract BaseDynamicParametr BaseDynamicParametrs();

        public bool NeedGenerate;

        public abstract bool HaveParametrs();

        public abstract IEnumerable<BaseParametr> BaseParametrs();

        /// <summary>
        /// ExecuteNonQuery method, means return type is int
        /// </summary>
        public bool IsRowsAffected { get; set; }

        protected bool FillGenerate(TypedConstant argument)
        {
            if (!(argument.Type is INamedTypeSymbol namedTypeSymbol) ||
                namedTypeSymbol.Name != nameof(Boolean))
            {
                return false;
            }

            NeedGenerate = (bool)argument.Value;
            return true;
        }

        protected bool FillQuery(TypedConstant argument)
        {
            if (!(argument.Type is INamedTypeSymbol strParam) ||
                strParam.Name != nameof(String))
            {
                return false;
            }

            Query = (string)argument.Value;
            return true;
        }
    }
}