using Gedaq.Base.Model;
using Gedaq.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

[assembly: InternalsVisibleTo("DbConnectionTests")]
namespace Gedaq.Parser
{
    internal class QueryParser
    {
        static readonly string[] _knownCommands = new string[] { "select", "insert", "delete" };

        public Aliases Parse(ref string query)
        {
            var querySpan = query.AsSpan();
            var lastCommandIndex = GetLastSplitedItem(querySpan, ';');
            var lastCommand = querySpan.Slice(lastCommandIndex);
            if (!FindInstruction(lastCommand, out var index, out var instructionType))
            {
                throw new Exception("Instruction in query not found");
            }

            if (index == lastCommand.Length)
            {
                throw new Exception("The instruction is followed by no parameters.");
            }

            if (instructionType == InstructionType.Delete || instructionType == InstructionType.Insert)
            {
                return new Aliases(true);
            }

            var aliases = FillAliases(lastCommand.Slice(index), out var newQuery);
            if (newQuery != null)
            {
                query = querySpan.Slice(0, lastCommandIndex + index).ToString() + newQuery;
            }

            return aliases;
        }

        public Aliases GetIntResultAlias()
        {
            return new Aliases(true);
        }

        internal int GetLastSplitedItem(ReadOnlySpan<char> query, char splitter)
        {
            int i = query.Length - 1;
            for (; i >= 0; i--)
            {
                if (query[i] != '\r' && query[i] != '\n' && query[i] != ' ')
                {
                    break;
                }
            }

            if (query[i] == splitter)
            {
                i--;
            }

            for (; i >= 0; i--)
            {
                if (query[i] == splitter)
                {
                    return i + 1;
                }
            }

            return 0;
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

        private bool FindInstruction(ReadOnlySpan<char> command, out int indexAfterInstruction, out InstructionType instruction)
        {
            indexAfterInstruction = -1;
            instruction = InstructionType.None;
            var currentPossibleCommand = 0;
            var indexInstruction = 0;
            var indexInCommand = 0;

            var emptySequence = true;
            for (; indexInCommand < command.Length; indexInCommand++)
            {
                if (emptySequence)
                {
                    if (command[indexInCommand] == '\r' || command[indexInCommand] == '\n' || command[indexInCommand] == ' ')
                    {
                        continue;
                    }

                    emptySequence = false;
                }

                if (command[indexInCommand] == '\r' || command[indexInCommand] == '\n' || command[indexInCommand] == ' ')
                {
                    if (currentPossibleCommand >= _knownCommands.Length)
                    {
                        return false;
                    }

                    break;
                }

                for (; currentPossibleCommand < _knownCommands.Length; currentPossibleCommand++)
                {
                    if (_knownCommands[currentPossibleCommand].Length <= indexInstruction)
                    {
                        continue;
                    }

                    if (_knownCommands[currentPossibleCommand][indexInstruction] == char.ToLowerInvariant(command[indexInCommand]))
                    {
                        indexInstruction++;
                        break;
                    }
                }
            }

            if (_knownCommands[currentPossibleCommand].Length == indexInstruction)
            {
                indexAfterInstruction = indexInCommand;
                instruction = IndexToType(currentPossibleCommand);
                return true;
            }

            return false;
        }

        private InstructionType IndexToType(int index)
        {
            switch (index)
            {
                case 0:
                    {
                        return InstructionType.Select;
                    }

                case 1:
                    {
                        return InstructionType.Insert;
                    }

                case 2:
                    {
                        return InstructionType.Delete;
                    }

                default:
                    {
                        return InstructionType.None;
                    }
            }
        }
    }
}