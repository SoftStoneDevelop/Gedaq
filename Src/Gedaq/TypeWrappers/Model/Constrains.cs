using Gedaq.Enums;

namespace Gedaq.TypeWrappers.Model
{
    internal class Constrain
    {
        public string Name { get; set; }

        public ConstrainType Type { get; set; }
    }

    internal class DefaultConstrain : Constrain
    {
        public string Value { get; set; }
    }
}