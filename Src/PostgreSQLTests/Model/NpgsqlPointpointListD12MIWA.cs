
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class NpgsqlPointpointListD12MIWA
    {
        [Gedaq.Npgsql.Attributes.DbType((NpgsqlTypes.NpgsqlDbType)(9))]
        [Gedaq.Common.Attributes.Alias(order: 0)]
        public System.Int32 Id { get; set; }

        [Gedaq.Npgsql.Attributes.DbType((NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        [Gedaq.Common.Attributes.Alias(order: 1)]
        public System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint> Value { get; set; }

        [Gedaq.Npgsql.Attributes.DbType((NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        [Gedaq.Common.Attributes.Alias(order: 2)]
        public System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint> NullableValue { get; set; }

        public static void AssertModel(NpgsqlPointpointListD12MIWA actual, NpgsqlPointpointListD12MI expect, bool checkInInnerOnlyId)
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