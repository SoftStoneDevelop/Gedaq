using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Base.Model
{
    internal abstract class FieldInfo
    {

    }

    internal class Field
    {
        public string Name { get; set; }
        public int Position { get; set; }

        public FieldInfo AdditionalInfo { get; set; }

        public bool HaveAdditionalInfo => AdditionalInfo != null;
    }
}