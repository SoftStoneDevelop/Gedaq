using NUnit.Framework;
using System.Threading.Tasks;

namespace Tests
{
    internal partial class TestsInt32
    {
        [Test, Order(0)]
        public async Task CreatePartitionAsync()
        {
            await using (var connection = await GlobalSetUp.NpgsqlDataSource.OpenConnectionAsync())
            {
                Assert.That(true);
            }
        }
    }
}