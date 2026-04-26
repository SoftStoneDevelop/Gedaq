using Gedaq.Base;
using Gedaq.Base.Batch;
using Gedaq.Base.Model;
using Gedaq.DbConnection.Helpers;
using Gedaq.Enums;
using System.Text;

namespace Gedaq.DbConnection.GeneratorsBatch
{
    internal class DbBatchCommand : BatchCommandBase
    {
        private readonly DbProviderInfo _dbProviderInfo = new DbProviderInfo();
        protected override ProviderInfo ProviderInfo => _dbProviderInfo;

        protected override void CreateParametr(BaseParametr parametr, StringBuilder builder)
        {
            DbGeneratorHelper.CreateParametr(parametr, builder);
        }
    }
}