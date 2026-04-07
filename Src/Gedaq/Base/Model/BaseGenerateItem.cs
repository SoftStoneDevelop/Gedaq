using Gedaq.Enums;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Immutable;
using System.Linq;

namespace Gedaq.Base.Model
{
    internal class BaseGenerateItem : IMethodInfo
    {
        public ITypeSymbol[] MapTypes { get; protected set; }

        public bool HaveMapTypes => MapTypes != null && MapTypes.Length > 0;

        public bool IsCollectionDelegateMap => HaveMapTypes && MapTypes.Length > 1;

        public string[] OverrideAliasPrefixs { get; protected set; }

        public BaseMethodInfo MethodInfo { get; set; }

        public string MethodName => MethodInfo.MethodName;

        public MethodType MethodType => MethodInfo.MethodType;

        public AccessModifier AccessModifier => MethodInfo.AccessModifier;

        public bool MethodsMustBeStatic => ContainTypeName.IsStatic || !ContainTypeName.IsPatrial();

        public string MethodStaticModifier => MethodsMustBeStatic ? "static" : "";

        public INamedTypeSymbol ContainTypeName;

        public ITypeSymbol PartInterfaceType { get; private set; }

        public bool AsPartInterface => PartInterfaceType != null;

        protected bool FillMapTypes(TypedConstant argument)
        {
            if (argument.IsNull)
            {
                return true;
            }

            if (argument.Kind != TypedConstantKind.Array)
            {
                return false;
            }

            if (!argument.Type.IsArrayType(out var elementType))
            {
                return false;
            }

            MapTypes = new ITypeSymbol[argument.Values.Length];
            for (int i = 0; i < argument.Values.Length; i++)
            {
                var value = (ITypeSymbol)argument.Values[i].Value;
                MapTypes[i] = value;
            }

            return true;
        }

        protected bool FillOverrideAliasPrefixs(TypedConstant argument)
        {
            if (argument.IsNull)
            {
                return true;
            }

            if (argument.Kind != TypedConstantKind.Array)
            {
                return false;
            }

            if (!argument.Type.IsArrayType(out var elementType))
            {
                return false;
            }

            if (elementType.Name != nameof(String))
            {
                return false;
            }

            OverrideAliasPrefixs = new string[argument.Values.Length];
            for (int i = 0; i < argument.Values.Length; i++)
            {
                var value = (string)argument.Values[i].Value;
                OverrideAliasPrefixs[i] = value;
            }

            return true;
        }

        protected bool SetPartInterfaceType(TypedConstant argument)
        {
            if (argument.IsNull)
            {
                return true;
            }

            if (!(argument.Value is ITypeSymbol interfaceType))
            {
                return false;
            }

            if(interfaceType.TypeKind != TypeKind.Interface)
            {
                return false;
            }

            foreach (var item in interfaceType.DeclaringSyntaxReferences)
            {
                var syntax = item.GetSyntax();
                if (!(syntax is InterfaceDeclarationSyntax interfaceDeclarationSyntax))
                {
                    continue;
                }

                if (!interfaceDeclarationSyntax.Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword)))
                {
                    throw new Exception($"Interface '{interfaceType.Name}' must be declared as partial");
                }

                PartInterfaceType = interfaceType;
                return true;
            }

            return false;
        }
    }
}