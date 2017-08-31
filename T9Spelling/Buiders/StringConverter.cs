using System;
using System.Collections.Generic;
using System.Text;
using T9Spelling.Mappers;

namespace T9Spelling
{
    public class StringConverter : IConverter
    {
        private readonly Dictionary<Char, int> _dictionary;

        public StringConverter()
        {
            _dictionary = CharsDictionary.InitDictionary();
        }

        public StringBuilder Convert(string inputString)
        {
            StringBuilder builder = new StringBuilder();
            var lastCharacter = '\0';
            int n;

            bool isNumeric = int.TryParse(inputString, out n);

            if (!isNumeric)
            {
                if (inputString.Length <= 1)
                {
                    return builder.Append("The string length very short. It should be greater than 1 and less than 15 characters");
                }
                else if (inputString.Length > 15)
                {
                    return builder.Append("The string length very long. It should be greater than 1 and less than 15 characters");
                }

                foreach (var symbol in inputString)
                {
                    var number = ToIntMapper.Map(symbol, _dictionary).ToString();

                    var nextCharacter = number[0];

                    if (lastCharacter.Equals(nextCharacter))
                    {
                        builder.Append(" ");
                    }

                    builder.Append(number);

                    lastCharacter = number[number.Length - 1];
                }
            }
            else
            {
                builder.Append("Please, enter not numeric characters");
            }

            return builder;
        }
    }
}