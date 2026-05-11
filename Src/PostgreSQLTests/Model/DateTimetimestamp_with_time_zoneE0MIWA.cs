
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class DateTimetimestamp_with_time_zoneE0MIWA
    {
        [Gedaq.Npgsql.Attributes.DbType((NpgsqlTypes.NpgsqlDbType)(9))]
        [Gedaq.Common.Attributes.Alias(order: 0)]
        public System.Int32 Id { get; set; }

        [Gedaq.Npgsql.Attributes.DbType((NpgsqlTypes.NpgsqlDbType)(26))]
        [Gedaq.Common.Attributes.Alias(order: 1)]
        public System.DateTime Value { get; set; }

        [Gedaq.Npgsql.Attributes.DbType((NpgsqlTypes.NpgsqlDbType)(26))]
        [Gedaq.Common.Attributes.Alias(order: 2)]
        public System.DateTime? NullableValue { get; set; }

        public static void AssertModel(DateTimetimestamp_with_time_zoneE0MIWA actual, DateTimetimestamp_with_time_zoneE0MI expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));
                Assert.That(actual.Value, Is.EqualTo(expect.Value));
                if (expect.NullableValue == null)
                {
                    Assert.That(actual.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(actual.NullableValue, Is.Not.Null);
                    Assert.That(actual.NullableValue, Is.EqualTo(expect.NullableValue));
                }
        }
    }
}