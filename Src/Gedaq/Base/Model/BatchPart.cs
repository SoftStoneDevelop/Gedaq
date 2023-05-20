using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Gedaq.Base.Model
{
    internal class BatchPart
    {
        public string MethodName;
        public int BatchNumber;

        internal static bool CreateNew(ImmutableArray<TypedConstant> namedArguments, out BatchPart batchPart)
        {
            batchPart = null;
            if (namedArguments.Length != 2)
            {
                return false;
            }

            var result = new BatchPart();
            if (!(namedArguments[0].Type is INamedTypeSymbol methodName) ||
                methodName.Name != nameof(String)
                )
            {
                return false;
            }

            result.MethodName = (string)namedArguments[0].Value;

            if (!(namedArguments[1].Type is INamedTypeSymbol number) ||
                number.Name != nameof(Int32)
                )
            {
                return false;
            }

            result.BatchNumber = (int)namedArguments[1].Value;

            batchPart = result;
            return true;
        }
    }
}