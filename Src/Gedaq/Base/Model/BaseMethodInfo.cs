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
        public BaseMethodInfo(
            TypedConstant nameArgument,
            TypedConstant typeArgument,
            TypedConstant accessModifierArgument,
            TypedConstant asyncResultArgument,
            INamedTypeSymbol containsType
            )
        {
            SetMethodName(nameArgument);
            SetMethodType(typeArgument);
            SetAccessModifier(accessModifierArgument, containsType);
            SetAsyncResultType(asyncResultArgument);
        }

        public string MethodName { get; private set; }
        public MethodType MethodType { get; private set; }
        public AsyncResult AsyncResultType { get; private set; }
        public AccessModifier AccessModifier { get; private set; }

        private void SetMethodType(TypedConstant argument)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol namedTypeSymbol3) ||
                !namedTypeSymbol3.IsAssignableFrom("Gedaq.Common.Enums", "MethodType")
                )
            {
                throw new ArgumentException($"{nameof(SetMethodType)}:Wrong argument");
            }

            MethodType = (MethodType)argument.Value;
        }

        private void SetAsyncResultType(TypedConstant argument)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol namedTypeSymbol3) ||
                !namedTypeSymbol3.IsAssignableFrom("Gedaq.Common.Enums", "AsyncResult")
                )
            {
                throw new ArgumentException($"{nameof(SetAsyncResultType)}:Wrong argument");
            }

            AsyncResultType = (AsyncResult)argument.Value;
        }

        private void SetAccessModifier(TypedConstant argument, INamedTypeSymbol containsType)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol accessModifier) ||
                !accessModifier.IsAssignableFrom("Gedaq.Common.Enums", "AccessModifier")
                )
            {
                throw new ArgumentException($"{nameof(SetAccessModifier)}:Wrong argument");
            }

            var modifier = (AccessModifier)argument.Value;
            AccessModifier = GetAccessModifier((AccessModifier)argument.Value, containsType);
        }

        private AccessModifier GetAccessModifier(
            AccessModifier accessModifier,
            INamedTypeSymbol type
            )
        {
            if(accessModifier != AccessModifier.AsContainingClass)
            {
                return accessModifier;
            }

            if (type.DeclaredAccessibility == Accessibility.Private)
            {
                return AccessModifier.Private;
            }

            if (type.DeclaredAccessibility == Accessibility.Protected)
            {
                return AccessModifier.Protected;
            }

            if (type.DeclaredAccessibility == Accessibility.Internal)
            {
                return AccessModifier.Internal;
            }

            return AccessModifier.Public;
        }

        public void SetMethodName(TypedConstant argument)
        {
            if (!(argument.Type is INamedTypeSymbol namedTypeSymbol) ||
                namedTypeSymbol.Name != nameof(String)
                )
            {
                throw new ArgumentException($"{nameof(SetMethodName)}:Wrong argument");
            }

            MethodName = (string)argument.Value;
        }
    }
}