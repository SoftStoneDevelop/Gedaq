
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class DateTimetimestamp_without_time_zoneListD1E2MIWA
    {
        [Gedaq.Npgsql.Attributes.DbType((NpgsqlTypes.NpgsqlDbType)(9))]
        [Gedaq.Common.Attributes.Alias(order: 0)]
        public System.Int32 Id { get; set; }

        [Gedaq.Npgsql.Attributes.DbType((NpgsqlTypes.NpgsqlDbType)(-2147483627))]
        [Gedaq.Common.Attributes.Alias(order: 1)]
        public System.Collections.Generic.List<System.DateTime> Value { get; set; }

        [Gedaq.Npgsql.Attributes.DbType((NpgsqlTypes.NpgsqlDbType)(-2147483627))]
        [Gedaq.Common.Attributes.Alias(order: 2)]
        public System.Collections.Generic.List<System.DateTime> NullableValue { get; set; }

        public static void AssertModel(DateTimetimestamp_without_time_zoneListD1E2MIWA actual, DateTimetimestamp_without_time_zoneListD1E2MI expect, bool checkInInnerOnlyId)
        {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Id, Is.EqualTo(expect.Id));

                if (expect.NullableValue == null)
                {
                    Assert.That(actual.NullableValue, Is.Null);
                }
                else
                {
                    Assert.That(actual.NullableValue, Is.Not.Null);
                }
        }
    }
}