﻿using System;

namespace TestsGenerator.TypeValueHelpers
{
    internal class SingleValueHelper : ValueHelper
    {
        public override ValueHelper NewInstance()
        {
            return new SingleValueHelper();
        }

        public override string NewValue()
        {
            var result = (float)Random.Shared.NextSingle();
            return $@"{result}f";
        }
    }
}