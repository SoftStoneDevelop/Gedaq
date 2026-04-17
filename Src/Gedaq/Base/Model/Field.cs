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
        /// <summary>
        /// Name of property in type
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Position in SQL row
        /// </summary>
        public int? Position { get; set; }

        public FieldInfo AdditionalInfo { get; set; }

        public bool HaveAdditionalInfo => AdditionalInfo != null;
    }
}