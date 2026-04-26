using Gedaq.Base.Model;
using Microsoft.CodeAnalysis;

namespace Gedaq.Base
{
    internal abstract class ProviderInfo
    {
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

        public abstract bool IsKnownProviderType(ITypeSymbol type);

        public abstract bool IsSpecialHandlerType(ITypeSymbol type);

        public abstract string GetSpecialTypeValue(
            ITypeSymbol type,
            string aliasesPrefix,
            Field field,
            string source = "reader");

        public string ValueReaderKey(string prefix, Field field)
        {
            if (field.Position.HasValue)
            {
                return field.Position.Value.ToString();
            }
            else
            {
                return $"\"{prefix}{field.SQLName}\"";
            }
        }
    }
}