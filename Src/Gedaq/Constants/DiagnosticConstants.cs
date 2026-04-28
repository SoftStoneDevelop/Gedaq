namespace Gedaq.Constants
{
    internal class DiagnosticConstants
    {
        public const string Source = "Gedaq";

        public const string Exception = "GDC0000";
        public const string ExceptionDescr = "Exception in generation: {0}; StackTrace: {1}";

        public const string IncorrectAttributeParametrsCount = "GDC0001";
        public const string IncorrectAttributeParametrsCountDescr = "The number of attribute parameters (attribute {0}) does not match: expect {1} but {2}";

        public const string IncorrectAttributeParametr = "GDC0002";
        public const string IncorrectAttributeParametrDescr = "Parameter {0}({1}) could not be parsed";

        public const string BatchMustContainParts = "GDC0003";
        public const string BatchNumberUnique = "GDC0004";
        public const string NotAllowedOutParametr = "GDC0005";

        public const string AmbiguityOfParameterTypes = "GDC0006";
        public const string AmbiguityOfParameterTypesDescr = "{0}: It is allowed to have either explicit parameters or dynamic ones, but not both";

        public const string DynamicParameterDuplicate = "GDC0007";
        public const string DynamicParameterDuplicateDescr = "DynamicParameterDuplicate";

        public const string UnknownMapTypes = "GDC0008";
        public const string UnknownMapTypesDescr = "The mapping type must be specified";

        public const string UnnamedQueryParametr = "GDC0009";
        public const string UnnamedQueryParametrDescr = "Parameter not have name";

        public const string AmbiguityOfParameterNamePosition = "GDC0010";
        public const string AmbiguityOfParameterNamePositionDescr = "Parameter can have position or name, but not both";

        public const string ParameterNotHavePosName = "GDC0011";
        public const string ParameterNotHavePosNameDescr = "Parameter not have position or name";

        public const string BICouldNotDetermine = "GDC0012";
        public const string BICouldNotDetermineDescr = "Binary import (method name {0}): Could not determine table write method for type {1}.";
    }
}