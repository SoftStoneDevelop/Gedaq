using System;

namespace TestsGenerator.TypeValueHelpers
{
    internal class NpgsqlIntervalValueHelper : ValueHelper
    {
        private readonly bool _likeTimeOnly;

        public NpgsqlIntervalValueHelper(bool likeTimeOnly) 
        {
            _likeTimeOnly = likeTimeOnly;
        }

        public override ValueHelper NewInstance()
        {
            return new NpgsqlIntervalValueHelper(_likeTimeOnly);
        }

        public override string NewValue()
        {
            var time = Random.Shared.Next(0, 5000);

            if(_likeTimeOnly)
            {
                return $"new NpgsqlTypes.NpgsqlInterval(months: 0, days: 0, time: {time})";
            }
            else
            {
                var months = Random.Shared.Next(0, 11);
                var days = Random.Shared.Next(0, 20);
                return $"new NpgsqlTypes.NpgsqlInterval(months: {months}, days: {days}, time: {time})";
            }
        }
    }
}