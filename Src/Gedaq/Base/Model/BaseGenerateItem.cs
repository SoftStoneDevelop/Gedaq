using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Enums;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Linq;

namespace Gedaq.Base.Model
{
    internal class BaseGenerateItem : IMethodInfo
    {
        public BaseMethodInfo MethodInfo { get; set; }

        public string MethodName => MethodInfo.MethodName;

        public MethodType MethodType => MethodInfo.MethodType;

        public AccessModifier AccessModifier => MethodInfo.AccessModifier;

        public bool MethodsMustBeStatic => ContainTypeName.IsStatic || !ContainTypeName.IsPatrial();

        public string MethodStaticModifier => MethodsMustBeStatic ? "static" : "";

        public INamedTypeSymbol ContainTypeName;
    }
}