using System;
using System.Collections.Generic;
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
    }
}