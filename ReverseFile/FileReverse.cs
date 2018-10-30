﻿using System.IO;
using System.Linq;
using System.Text;

namespace ReverseFile
{
    public static class FileReverse
    {
        public static string[] ReverseLines(string[] inputLines)
        {
            if (inputLines.Length == 0)
            {
                throw new InvalidDataException();
            }

            // remove blank lines
            inputLines = inputLines.Where(l => !string.IsNullOrEmpty(l)).ToArray();

            var startIndex = 0;
            var lastIndex = inputLines.Length - 1;

            while (startIndex <= lastIndex)
            {
                if (startIndex == lastIndex)
                {
                    var line = new StringBuilder(inputLines[startIndex]);

                    var firstChar = line[0];

                    line[0] = line[line.Length - 1];
                    line[line.Length - 1] = firstChar;

                    inputLines[startIndex] = line.ToString();

                    break;
                }

                var startLine = new StringBuilder(inputLines[startIndex]);
                var endLine = new StringBuilder(inputLines[lastIndex]);

                var startChar = startLine[0];

                startLine[0] = endLine[endLine.Length - 1];
                endLine[endLine.Length - 1] = startChar;

                inputLines[startIndex] = startLine.ToString();
                inputLines[lastIndex] = endLine.ToString();

                startIndex++;
                lastIndex--;
            }

            return inputLines;
        }
    }
}