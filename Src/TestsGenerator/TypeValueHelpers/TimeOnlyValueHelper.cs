﻿using System;
using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal class TimeOnlyValueHelper : ValueHelper
    {
        public TimeOnlyValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {

        }

        public override ValueHelper NewInstance()
        {
            new TimeOnly(hour: 1, minute: 1, second: 1, millisecond: 1);
            return new TimeOnlyValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            var hour = Random.Shared.Next(0, 23);
            var minute = Random.Shared.Next(0, 59);
            var second = Random.Shared.Next(0, 59);
            var millisecond = Random.Shared.Next(0, 999);
            return $"new TimeOnly(hour: {hour}, minute: {minute}, second: {second}, millisecond: {millisecond})";
        }
    }
}