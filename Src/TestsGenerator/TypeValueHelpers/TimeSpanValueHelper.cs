using System;
namespace TestsGenerator.TypeValueHelpers
{
    internal class TimeSpanValueHelper : ValueHelper
    {
        private bool _likeTimeOnly;
        public TimeSpanValueHelper(bool likeTimeOnly)
        {
            _likeTimeOnly = likeTimeOnly;
        }

        public override ValueHelper NewInstance()
        {
            return new TimeSpanValueHelper(_likeTimeOnly);
        }

        public override string NewValue()
        {
            var days = Random.Shared.Next(0, 30);
            var hours = Random.Shared.Next(0, 23);
            var minutes = Random.Shared.Next(0, 59);
            var seconds = Random.Shared.Next(0, 59);
            var milliseconds = Random.Shared.Next(0, 999);
            if (_likeTimeOnly)
            {
                return $"new TimeSpan(days: 0, hours: {hours}, minutes: {minutes}, seconds: {seconds}, milliseconds: {milliseconds})";
            }
            else
            {
                return $"new TimeSpan(days: {days}, hours: {hours}, minutes: {minutes}, seconds: {seconds}, milliseconds: {milliseconds})";
            }
        }
    }
}