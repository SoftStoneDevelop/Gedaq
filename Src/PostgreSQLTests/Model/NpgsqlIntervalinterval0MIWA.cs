
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class NpgsqlIntervalinterval0MIWA
    {
        [Gedaq.Npgsql.Attributes.DbType((NpgsqlTypes.NpgsqlDbType)(9))]
        [Gedaq.Common.Attributes.Alias(order: 0)]
        public System.Int32 Id { get; set; }

        [Gedaq.Npgsql.Attributes.DbType((NpgsqlTypes.NpgsqlDbType)(30))]
        [Gedaq.Common.Attributes.Alias(order: 1)]
        public NpgsqlTypes.NpgsqlInterval Value { get; set; }

        [Gedaq.Npgsql.Attributes.DbType((NpgsqlTypes.NpgsqlDbType)(30))]
        [Gedaq.Common.Attributes.Alias(order: 2)]
        public NpgsqlTypes.NpgsqlInterval? NullableValue { get; set; }

        public static void AssertModel(NpgsqlIntervalinterval0MIWA actual, NpgsqlIntervalinterval0MI expect, bool checkInInnerOnlyId)
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