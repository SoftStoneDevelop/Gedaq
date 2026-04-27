using Gedaq.Enums;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Linq;

namespace Gedaq.Base.Model
{
    internal abstract class BaseGenerateItem : IMethodInfo
    {
        public MapTypeInfo[] MapTypeInfos { get; protected set; }

        public abstract string MapDelegateParametrName { get; }

        public abstract string MapDelegateParametrType();

        public bool HaveMapTypes => MapTypeInfos?.Length > 0;

        public abstract bool IsCollectionDelegateMap { get; }

        public string[] _overrideAliasPrefixs { get; set; }

        /// <summary>
        /// Return not null if have override
        /// </summary>
        public string GetAliasOverride(int typeIndex)
        {
            if (!HaveMapTypes || _overrideAliasPrefixs == null || _overrideAliasPrefixs.Length <= typeIndex)
            {
                return null;
            }

            return _overrideAliasPrefixs[typeIndex];
        }

        public BaseMethodInfo MethodInfo { get; set; }

        public string MethodName => MethodInfo.MethodName;

        public MethodType MethodType => MethodInfo.MethodType;

        public AccessModifier AccessModifier => MethodInfo.AccessModifier;

        public bool MethodsMustBeStatic => ContainTypeName.IsStatic || !ContainTypeName.IsPatrial();

        public string MethodStaticModifier => MethodsMustBeStatic ? "static" : "";

        public INamedTypeSymbol ContainTypeName;

        public ITypeSymbol PartInterfaceType { get; private set; }

        public bool AsPartInterface => PartInterfaceType != null;

        protected bool FillMapTypesFromSingle(TypedConstant argument)
        {
            if (argument.IsNull)
            {
                return true;
            }

            if (!(argument.Value is ITypeSymbol typeParam))
            {
                return false;
            }

            MapTypeInfos = new MapTypeInfo[] { new MapTypeInfo(0) { MapType = typeParam } };
            return true;
        }

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

            if (!argument.Type.IsArrayType(out var _))
            {
                return false;
            }

            MapTypeInfos = new MapTypeInfo[argument.Values.Length];
            for (int i = 0; i < argument.Values.Length; i++)
            {
                var value = (ITypeSymbol)argument.Values[i].Value;
                MapTypeInfos[i] = new MapTypeInfo(i) { MapType = value };
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

            _overrideAliasPrefixs = new string[argument.Values.Length];
            for (int i = 0; i < argument.Values.Length; i++)
            {
                var value = (string)argument.Values[i].Value;
                _overrideAliasPrefixs[i] = value;
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