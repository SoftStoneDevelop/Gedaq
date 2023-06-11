using System;

namespace TestsGenerator.TypeValueHelpers
{
    internal class DateOnlyValueHelper : ValueHelper
    {
        public override ValueHelper NewInstance()
        {
            return new DateOnlyValueHelper();
        }

        public override string NewValue()
        {
            var year = Random.Shared.Next(1917, 2020);
            var month = Random.Shared.Next(10, 11);
            var day = Random.Shared.Next(1, 20);
            return $"new DateOnly(year: {year}, month: {month}, day: {day})";
        }
    }
}
