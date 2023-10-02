using Gedaq.Base.Model;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public abstract string GetParametrValue(BaseParametr parametr, string source);

        public abstract string GetNullValue(BaseParametr parametr);

        public abstract bool IsKnownProviderType(ITypeSymbol type);

        public abstract bool IsSpecialHandlerType(ITypeSymbol type);

        public abstract string GetSpecialTypeValue(ITypeSymbol type, int fieldId, string source = "reader");
    }
}