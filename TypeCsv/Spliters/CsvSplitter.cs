using System;
using System.Collections.Generic;

namespace TypeCsv.Splitters
{
    class CsvSplitter : ISplitter
    {
        public CsvSplitter(ConsoleColor consoleColor)
        {
            _consoleColor = consoleColor;
        }

        private ConsoleColor _consoleColor;

        // The input line is split on every comma.
        // Sometines a comma is inside a cell if the cell begins with a double quote.
        // If we find a cel with that starts with a double quote then don't change the color until we find
        // a cell that ends with a double quote.
        public List<string> Split(string line)
        {
            List<string> parts = new List<string>();

            string part = "";
            bool inQuotes = false;
            foreach (var split in line.Split(",".ToCharArray()))
            {
                if (inQuotes)
                {
                    part = $"{part},{split}";
                }
                else
                {
                    part = split;
                    inQuotes = part.StartsWith("\"");
                }
                inQuotes &= !part.EndsWith("\"");

                if (!inQuotes)
                {
                    parts.Add(part);
                }
            }
            return parts;
        }

        public void Type(List<string> parts)
        {
            string join = "";
            int i = 0;
            foreach (var part in parts)
            {
                Console.Write(join);
                _consoleColor.SetColor(i++);
                Console.Write(part);
                join = ",";
            }
            Console.WriteLine();
        }
    }
}