using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Enums;
using Microsoft.CodeAnalysis;
using System;

namespace Gedaq.Base.Model
{
    internal class BaseGenerateItem : IMethodInfo
    {
        public BaseMethodInfo MethodInfo { get; } = new BaseMethodInfo();

        public string MethodName => MethodInfo.MethodName;

        public MethodType MethodType => MethodInfo.MethodType;

        public AccessModifier AccessModifier => MethodInfo.AccessModifier;

        public INamedTypeSymbol ContainTypeName;
    }
}