
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class NpgsqlIntervalintervalListD12MIWA
    {
        [Gedaq.Npgsql.Attributes.DbType((NpgsqlTypes.NpgsqlDbType)(9))]
        [Gedaq.Common.Attributes.Alias(order: 0)]
        public System.Int32 Id { get; set; }

        [Gedaq.Npgsql.Attributes.DbType((NpgsqlTypes.NpgsqlDbType)(-2147483618))]
        [Gedaq.Common.Attributes.Alias(order: 1)]
        public System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval> Value { get; set; }

        [Gedaq.Npgsql.Attributes.DbType((NpgsqlTypes.NpgsqlDbType)(-2147483618))]
        [Gedaq.Common.Attributes.Alias(order: 2)]
        public System.Collections.Generic.List<NpgsqlTypes.NpgsqlInterval> NullableValue { get; set; }

        public static void AssertModel(NpgsqlIntervalintervalListD12MIWA actual, NpgsqlIntervalintervalListD12MI expect, bool checkInInnerOnlyId)
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