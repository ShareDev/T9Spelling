using System;
using System.Collections.Generic;
using System.Linq;

namespace T9Spelling.Mappers
{
    public class ToIntMapper
    {
        internal static int Map(Char symbol, Dictionary<Char, int> dictionary)
        {
            return dictionary.FirstOrDefault(s => s.Key.Equals(symbol)).Value;
        }
    }
}