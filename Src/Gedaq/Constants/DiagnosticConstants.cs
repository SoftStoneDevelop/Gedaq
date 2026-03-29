using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Gedaq.Constants
{
    internal class DiagnosticConstants
    {
        public const string Source = "Gedaq";

        public const string IncorrectAttributeParametrsCount = "GDC0001";
        public const string IncorrectAttributeParametr = "GDC0002";
        public const string BatchMustContainParts = "GDC0003";
        public const string BatchNumberUnique = "GDC0004";
        public const string NotAllowedOutParametr = "GDC0005";

        public const string AmbiguityOfParameterTypes = "GDC0006";
        public const string AmbiguityOfParameterTypesDescr = "It is allowed to have either explicit parameters or dynamic ones, but not both";

        public const string DynamicParameterDuplicate = "GDC0007";
        public const string DynamicParameterDuplicateDescr = "DynamicParameterDuplicate";

    }
}
