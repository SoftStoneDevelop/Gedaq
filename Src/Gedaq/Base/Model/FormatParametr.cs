using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Gedaq.Base.Model
{
    internal class FormatParametr
    {
        public string Name;
        public int Position;

        internal static bool CreateNew(
            ImmutableArray<TypedConstant> namedArguments,
            INamedTypeSymbol containsType,
            out FormatParametr format,
            out string methodName
            )
        {
            format = null;
            methodName = null;

            if (namedArguments.Length != 2)
            {
                return false;
            }

            var result = new FormatParametr();
            if (!SetPosition(namedArguments[0], result))
            {
                return false;
            }

            if (!SetName(namedArguments[1], result))
            {
                return false;
            }

            format = result;
            return true;
        }

        protected static bool SetName(TypedConstant argument, FormatParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol strParam) ||
                strParam.Name != nameof(String)
                )
            {
                return false;
            }

            parametr.Name = (string)argument.Value;
            return true;
        }

        protected static bool SetPosition(TypedConstant argument, FormatParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol sizeParam) ||
                sizeParam.Name != nameof(Int32)
                )
            {
                return false;
            }

            parametr.Position = (int)argument.Value;
            return true;
        }

        public void CalculateDatas(int index)
        {
            CalculateName(index);
        }

        private void CalculateName(int index)
        {
            if(Name != null)
            {
                return;
            }

            Name = $"format{index}";
        }
    }
}