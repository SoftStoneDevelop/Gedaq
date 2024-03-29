﻿using System;
using TestsGenerator.Enums;

namespace TestsGenerator.TypeValueHelpers
{
    internal class DoubleValueHelper : ValueHelper
    {
        public DoubleValueHelper(EnumerableType enumerableType) : base(enumerableType)
        {
        }

        public override ValueHelper NewInstance()
        {
            return new DoubleValueHelper(_enumerableType);
        }

        public override string NewSingleValue()
        {
            var result = (double)Random.Shared.NextDouble();
            return $"{result}d";
        }
    }
}