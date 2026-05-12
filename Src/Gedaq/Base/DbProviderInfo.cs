using Gedaq.Base.Model;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace Gedaq.Base
{
    internal abstract class ProviderInfo
    {
        protected HashSet<ITypeSymbol> _typeProcessed = new HashSet<ITypeSymbol>(SymbolEqualityComparer.Default);

        protected HashSet<ITypeSymbol> _knownProviderTypes = new HashSet<ITypeSymbol>(SymbolEqualityComparer.Default);
        protected HashSet<ITypeSymbol> _definitelyNotKnownProviderTypes = new HashSet<ITypeSymbol>(SymbolEqualityComparer.Default);

        public abstract string TransactionType();

        public abstract bool CanSetTransaction { get; }

        public abstract string CommandType();

        public abstract string ReaderType();

        public abstract string BatchType();

        public abstract string DefaultSourceType();

        public abstract string DefaultSourceTypeParametr();

        public abstract string GetParametrType();

        public abstract string GetParametrValue(BaseParametr parametr, string source);

        public abstract string GetNullValue(BaseParametr parametr);

        public bool IsKnownProviderType(ITypeSymbol type)
        {
            if (_knownProviderTypes.Contains(type) || IsKnownProviderTypeInner(type))
            {
                return true;
            }

            if (_definitelyNotKnownProviderTypes.Contains(type))
            {
                return false;
            }

            return false;
        }

        protected abstract bool IsKnownProviderTypeInner(ITypeSymbol type);

        public void CheckIsKnownAttribute(ITypeSymbol mapType)
        {
            if (mapType == null || _typeProcessed.Contains(mapType))
            {
                return;
            }

            foreach (var member in mapType.GetMembers())
            {
                if (!member.Kind.HasFlag(SymbolKind.Property))
                {
                    continue;
                }

                if (!(member is Microsoft.CodeAnalysis.IPropertySymbol propertySymbol))
                {
                    continue;
                }

                var propertyType = propertySymbol.Type;
                if (_knownProviderTypes.Contains(propertyType)
                    || IsKnownProviderTypeInner(propertyType)
                    || _definitelyNotKnownProviderTypes.Contains(propertyType))
                {
                    continue;
                }

                var pAttributes = propertySymbol.GetAttributes();

                var known = false;
                var ignore = false;
                foreach (var pAttribute in pAttributes)
                {
                    if (pAttribute.AttributeClass.IsAssignableFrom("Gedaq.Common.Attributes", "IgnorePropertyAttribute"))
                    {
                        ignore = true;
                        break;
                    }

                    if (pAttribute.AttributeClass.IsAssignableFrom("Gedaq.Common.Attributes", "KnownTypeAttribute"))
                    {
                        _ = _knownProviderTypes.Add(propertyType);
                        known = true;
                        break;
                    }
                }

                if (!known && !ignore)
                {
                    _ = _definitelyNotKnownProviderTypes.Add(propertyType);
                }
            }

            _ = _typeProcessed.Add(mapType);

        }

        public abstract bool IsSpecialHandlerType(ITypeSymbol type);

        public abstract string GetSpecialTypeValue(
            ITypeSymbol type,
            string aliasesPrefix,
            Field field,
            string source = "reader");

        public string ValueReaderKey(
            string prefix,
            Field field,
            string readerVariable = "reader",
            bool alwaysByPosition = true)
        {
            if (field.Position.HasValue)
            {
                return field.Position.Value.ToString();
            }
            else
            {
                if (alwaysByPosition)
                {
                    return $"{readerVariable}.GetOrdinal(\"{prefix}{field.SQLName}\")";
                }
                else
                {
                    return $"\"{prefix}{field.SQLName}\"";
                }
            }
        }

        public virtual bool GetValueFromReader(
            ITypeSymbol typeOfValue,
            out string getMethod)
        {
            switch (typeOfValue.GetFullTypeName(replaceNullable: true, addQuestionNoatble: false))
            {
                case "System.Int32":
                {
                    getMethod = "GetInt32";
                    return true;
                }

                case "System.Int64":
                {
                    getMethod = "GetInt64";
                    return true;
                }

                case "System.Byte":
                {
                    getMethod = "GetByte";
                    return true;
                }

                case "System.Int16":
                {
                    getMethod = "GetInt16";
                    return true;
                }

                case "System.Char":
                {
                    getMethod = "GetChar";
                    return true;
                }

                case "System.Decimal":
                {
                    getMethod = "GetDecimal";
                    return true;
                }

                case "System.Double":
                {
                    getMethod = "GetDouble";
                    return true;
                }

                case "System.Boolean":
                {
                    getMethod = "GetBoolean";
                    return true;
                }

                case "System.Single":
                {
                    getMethod = "GetFloat";
                    return true;
                }

                case "System.DateTime":
                {
                    getMethod = "GetDateTime";
                    return true;
                }

                case "System.String":
                {
                    getMethod = "GetString";
                    return true;
                }

                case "System.Guid":
                {
                    getMethod = "GetGuid";
                    return true;
                }
            }

            getMethod = null;
            return false;
        }
    }
}