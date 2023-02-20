using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.DbConnection.Helpers;
using System.Text;

namespace Gedaq.DbConnection.Generators
{
    internal class DbCommandGenerator : CommandGeneratorBase
    {
        private readonly DbQueryCommon _queryCommon = new DbQueryCommon();
        protected override QueryCommonBase QueryCommon => _queryCommon;

        protected override void CreateParametr(BaseParametr baseParametr, int index, StringBuilder builder)
        {
            DbGeneratorHelper.CreateParametr(baseParametr, index, builder);
        }
    }
}