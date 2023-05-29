using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Parser;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("NpgsqlTests")]
namespace Gedaq.Npgsql.Parser
{
    internal class BinaryParser
    {
        public Aliases Parse(ref string query)
        {
            var querySpan = query.AsSpan();

            var body = FindBody(querySpan, out var start, out var end);
            var afterInstruction = 0;
            if (PostgreSQLQueryParser.FindInstruction(body, out afterInstruction, out var instructionType) &&
                (instructionType == InstructionType.Delete || instructionType == InstructionType.Insert || instructionType == InstructionType.Update)
                )
            {
                throw new Exception("Instruction delete/insert/update not support in subquery");
            }

            if(afterInstruction == -1)
            {
                afterInstruction = 0;
            }

            var aliases = FillAliases(body.Slice(afterInstruction), out var newBody);
            if (newBody != null)
            {
                var before = querySpan.Slice(0, start);
                var after = querySpan.Slice(end);
                query = before.ToString() + body.Slice(0, afterInstruction).ToString() + newBody.ToString() + after.ToString();//rewrite to better perf
            }

            return aliases;
        }

        internal ReadOnlySpan<char> FindBody(ReadOnlySpan<char> query, out int start, out int end)
        {
            var brackets = 0;
            start = 0;
            end = 0;

            for (int i = 0; i < query.Length; i++)
            {
                if (query[i] == '(')
                {
                    start = i+1;
                    brackets++;
                    continue;
                }

                if (query[i] == ')')
                {
                    if(--brackets == 0)
                    {
                        end = i;
                    }

                    return query.Slice(start, end - start);
                }
            }

            throw new Exception("Not found copy body");
        }

        private Aliases FillAliases(ReadOnlySpan<char> query, out string newQuery)
        {
            newQuery = null;
            var parser = new AliasParser(query);
            parser.Parse();
            if (parser.QueryIsNew())
            {
                newQuery = parser.GetNewQuery();
            }

            return
                parser.GetAliases();
        }
    }
}