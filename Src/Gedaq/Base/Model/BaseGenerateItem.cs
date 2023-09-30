using Gedaq.Enums;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;

namespace Gedaq.Base.Model
{
    internal class BaseGenerateItem : IMethodInfo
    {
        public ITypeSymbol MapTypeName { get; protected set; }

        public BaseMethodInfo MethodInfo { get; set; }

        public string MethodName => MethodInfo.MethodName;

        public MethodType MethodType => MethodInfo.MethodType;

        public AccessModifier AccessModifier => MethodInfo.AccessModifier;

        public bool MethodsMustBeStatic => ContainTypeName.IsStatic || !ContainTypeName.IsPatrial();

        public string MethodStaticModifier => MethodsMustBeStatic ? "static" : "";

        public INamedTypeSymbol ContainTypeName;

        public ITypeSymbol PartInterfaceType { get; private set; }

        public bool AsPartInterface => PartInterfaceType != null;

        protected bool FillMapType(TypedConstant argument)
        {
            if (argument.IsNull)
            {
                return true;
            }

            if (!(argument.Value is ITypeSymbol typeParam))
            {
                return false;
            }

            MapTypeName = typeParam;
            return true;
        }

        protected bool SetPartInterfaceType(TypedConstant argument)
        {
            if (argument.IsNull)
            {
                return true;
            }

            if (!(argument.Value is ITypeSymbol typeParam))
            {
                return false;
            }

            PartInterfaceType = typeParam;
            return true;
        }
    }
}