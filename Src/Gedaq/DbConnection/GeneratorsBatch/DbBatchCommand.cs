using Gedaq.Base;
using Gedaq.Base.Batch;
using Gedaq.Base.Model;
using Gedaq.DbConnection.Helpers;
using Gedaq.DbConnection.Model;
using Gedaq.Enums;
using System.Text;

namespace Gedaq.DbConnection.GeneratorsBatch
{
    internal class DbBatchCommand : BatchCommandBase
    {
        private readonly DbBatchCommon _batchCommon = new DbBatchCommon();
        protected override BatchCommonGenerator BatchCommon => _batchCommon;

        private readonly DbProviderInfo _dbProviderInfo = new DbProviderInfo();
        protected override ProviderInfo ProviderInfo => _dbProviderInfo;

        protected override void CreateFakeCommand(string sourceParametrName, StringBuilder builder)
        {
            builder.Append($@"
            var fakeCommand = {sourceParametrName}.CreateCommand();
");
        }

        protected override void CreateParametr(BaseParametr parametr, int index, StringBuilder builder)
        {
            DbGeneratorHelper.CreateParametr(parametr, index, builder, true);
        }

        protected override void DisposeFakeCommand(MethodType methodType, StringBuilder builder)
        {
            if (methodType == MethodType.Async)
            {
                builder.Append($@"
            await fakeCommand.DisposeAsync().ConfigureAwait(false);
");
            }
            else
            {
                builder.Append($@"
            fakeCommand.Dispose();
");
            }
        }
    }
}