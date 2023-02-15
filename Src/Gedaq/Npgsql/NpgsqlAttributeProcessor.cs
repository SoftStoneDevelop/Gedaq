using Gedaq.Helpers;
using Gedaq.Npgsql.Generators;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Gedaq.Npgsql
{
    internal class NpgsqlAttributeProcessor
    {
        private List<QueryReadNpgsql> _read = new List<QueryReadNpgsql>();
        private List<QueryBatchReadNpgsql> _readBatch = new List<QueryBatchReadNpgsql>();

        Dictionary<string, List<QueryReadNpgsql>> _readTemp = new Dictionary<string,List<QueryReadNpgsql>>();
        Dictionary<string, List<Parametr>> _parametrsTemp = new Dictionary<string, List<Parametr>>();
        Dictionary<string, List<QueryReadNpgsql>> _batchTemp = new Dictionary<string, List<QueryReadNpgsql>>();

        private QueryParser _queryParser = new QueryParser();

        public bool ProcessAttributes(ImmutableArray<AttributeData> attributes, INamedTypeSymbol containsType)
        {
            _readTemp.Clear();
            _parametrsTemp.Clear();

            foreach (var attribute in attributes)
            {
                if (attribute.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "QueryReadAttribute"))
                {
                    ProcessQueryRead(attribute, containsType);
                    continue;
                }

                if (attribute.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "ParametrAttribute"))
                {
                    ProcessParametr(attribute, containsType);
                    continue;
                }

                if (attribute.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "ScalarAttribute"))
                {
                    continue;
                }

                if (attribute.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "NonQueryAttribute"))
                {
                    continue;
                }
            }

            FillReadMethods();

            return false;
        }

        public void CompleteProcessContainTypes()
        {
            foreach (var item in _batchTemp)
            {
                _readBatch.Add(new QueryBatchReadNpgsql(item.Value));
            }
            _batchTemp.Clear();
        }

        private void FillReadMethods()
        {
            var set = new HashSet<int>();
            foreach (var read in _readTemp.Values)
            {
                if (read.Count != 1)
                {
                    //batch case
                    throw new NotImplementedException();
                }

                var readSingle = read[0];
                if (_parametrsTemp.TryGetValue(readSingle.MethodName, out var parametrs))
                {
                    parametrs = parametrs.OrderBy(or => or.Position).ToList();
                    readSingle.Parametrs = new Parametr[parametrs.Count];

                    set.Clear();
                    var containNamedParametr = false;
                    var containPositionParametr = false;
                    for (int i = 0; i < parametrs.Count; i++)
                    {
                        var parametr = parametrs[i];
                        if (parametr.HavePosition)
                        {
                            if (!set.Add(parametr.Position))
                            {
                                throw new Exception("Parametr position must be unique");
                            }

                            containPositionParametr |= true;
                        }
                        else
                        {
                            parametr.Position = i + 1;
                        }

                        containNamedParametr |= parametr.HaveName;

                        readSingle.Parametrs[i] = parametr;
                    }

                    if (containNamedParametr && containPositionParametr)
                    {
                        throw new Exception("Parameters in query can be positional or named, but not combined");
                    }
                }

                _read.Add(readSingle);
                if(readSingle.HaveBatch)
                {
                    if(!_batchTemp.TryGetValue(readSingle.BatchMethodName, out var batchList))
                    {
                        batchList = new List<QueryReadNpgsql>();
                        _batchTemp.Add(readSingle.BatchMethodName, batchList);
                    }

                    batchList.Add(readSingle);
                }
            }
        }

        private void ProcessQueryRead(AttributeData queryReadAttribute, INamedTypeSymbol containsType)
        {
            if (!QueryReadNpgsql.CreateNew(queryReadAttribute.ConstructorArguments, containsType, out var queryReadMethod))
            {
                throw new Exception($"Unknown {nameof(QueryReadNpgsql)} constructor");
            }

            if(!_readTemp.ContainsKey(queryReadMethod.MethodName))
            {
                var methods = new List<QueryReadNpgsql>();
                _readTemp.Add(queryReadMethod.MethodName, methods);
            }

            _readTemp[queryReadMethod.MethodName].Add(queryReadMethod);
        }

        private void ProcessParametr(AttributeData parametrAttribute, INamedTypeSymbol containsType)
        {
            if (!Parametr.CreateNew(parametrAttribute.ConstructorArguments, containsType, out var parametr, out var methodName))
            {
                throw new Exception($"Unknown {nameof(Parametr)} constructor");
            }

            if (!_parametrsTemp.ContainsKey(methodName))
            {
                var methods = new List<Parametr>();
                _parametrsTemp.Add(methodName, methods);
            }

            _parametrsTemp[methodName].Add(parametr);
        }

        public void GenerateAndSaveMethods(GeneratorExecutionContext context)
        {
            var readGenerator = new QueryReadGenerator();
            foreach (var queryRead in _read)
            {
                queryRead.Aliases = _queryParser.Parse(ref queryRead.Query);
                readGenerator.GenerateMethod(queryRead);
                context.AddSource($"{queryRead.MethodName}Class.g.cs", readGenerator.GetCode());
            }
            _read.Clear();

            var batchReadGenerator = new QueryBatchReadGenerator();
            foreach (var batchRead in _readBatch)
            {
                batchReadGenerator.GenerateMethod(batchRead);
                context.AddSource($"{batchRead.MethodName}Class.g.cs", batchReadGenerator.GetCode());
            }
            _readBatch.Clear();
        }
    }
}