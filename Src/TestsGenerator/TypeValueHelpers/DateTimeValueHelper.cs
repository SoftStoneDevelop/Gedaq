using System;

namespace TestsGenerator.TypeValueHelpers
{
    internal class DateTimeValueHelper : ValueHelper
    {
        private readonly DateTimeKind _kind;

        public DateTimeValueHelper(DateTimeKind kind) 
        {
            _kind = kind;
        }

        public override ValueHelper NewInstance()
        {
            return new DateTimeValueHelper(_kind);
        }

        public override string NewValue()
        {
            var year = Random.Shared.Next(1917, 2020);
            var month = Random.Shared.Next(10, 11);
            var day = Random.Shared.Next(1, 20);
            var hour = Random.Shared.Next(1, 23);
            var minute = Random.Shared.Next(1, 59);
            var second = Random.Shared.Next(1, 59);
            var millisecond = Random.Shared.Next(1, 999);

            return $"new DateTime(year: {year}, month: {month}, day: {day}, hour: {hour}, minute: {minute}, second: {second}, millisecond: {millisecond}, kind: DateTimeKind.{_kind})";
        }
    }
}
