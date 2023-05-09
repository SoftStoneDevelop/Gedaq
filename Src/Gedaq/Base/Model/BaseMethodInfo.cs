using Gedaq.Enums;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;

namespace Gedaq.Base.Model
{
    internal interface IMethodInfo
    {
        string MethodName { get; }
        MethodType MethodType { get; }
        AccessModifier AccessModifier { get; }
    }

    internal class BaseMethodInfo : IMethodInfo
    {
        public string MethodName { get; private set; }
        public MethodType MethodType { get; private set; }
        public AccessModifier AccessModifier { get; private set; }

        public bool FillMethodType(TypedConstant argument)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol namedTypeSymbol3) ||
                !namedTypeSymbol3.IsAssignableFrom("Gedaq.Common.Enums", "MethodType")
                )
            {
                return false;
            }

            MethodType = (MethodType)argument.Value;
            return true;
        }

        public bool FillAccessModifier(TypedConstant argument)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol accessModifier) ||
                !accessModifier.IsAssignableFrom("Gedaq.Common.Enums", "AccessModifier")
                )
            {
                return false;
            }

            AccessModifier = (AccessModifier)argument.Value;
            return true;
        }

        public bool FillMethodName(TypedConstant argument)
        {
            if (!(argument.Type is INamedTypeSymbol namedTypeSymbol) ||
                namedTypeSymbol.Name != nameof(String)
                )
            {
                return false;
            }

            MethodName = (string)argument.Value;
            return true;
        }
    }
}