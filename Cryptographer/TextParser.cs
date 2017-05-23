using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptographer
{
    class TextParser
    {
        NumericalAlphabet numAlphabet = new NumericalAlphabet();

        char[] replaceableLetters =
        {
                Convert.ToChar(" "),
                Convert.ToChar(","),
                Convert.ToChar("."),
                Convert.ToChar("?"),
                Convert.ToChar("!"),
        };

        public char[] getReplaceableLetters()
        {
            return replaceableLetters;
        }

        public char[] parseReplaceableLetters(char[] message)
        {
            // List holds parsed message (valid letters, without unnecessary symbols)
            var parsedMessage = new List<char>();
            char[] replaceableLetters = getReplaceableLetters();
            // Iterate through our current message
            for (int i = 0; i < message.Length; i++)
            {
                // If letter is replaceable by "" then skip to the next letter
                bool skip = false;
                for (int j = 0; j < replaceableLetters.Length; j++)
                {
                    if (message[i] == replaceableLetters[j])
                    {
                        skip = true;
                        break;
                    }
                }

                // If the letter is replaceable skip, otherwise add letter to the parsed message
                if (skip) continue; else parsedMessage.Add(message[i]);
            }

            return parsedMessage.ToArray();
        }

        public bool checkAllowedLetters(char[] message)
        {
            char[] allowedLetters = numAlphabet.getAlphabet();
            // Iterate through our current message
            for (int i = 0; i < message.Length; i++)
            {                
                int k = -1;
                for (k = 0; k < allowedLetters.Length; k++)
                {
                    if (message[i] == allowedLetters[k])
                    {
                        break;
                    }
                }
                if (k >= allowedLetters.Length)
                {
                    MessageBox.Show("Please use only latin letters form A to Z in your message!");
                    return false;
                }
            }
            return true;
        }

        public byte[] parseBinaryStringToBytes(string message)
        {
            int numOfBytes = message.Length / 8;
            byte[] bytes = new byte[numOfBytes];
            for (int i = 0; i < numOfBytes; ++i)
            {
                bytes[i] = Convert.ToByte(message.Substring(8 * i, 8), 2);
            }

            return bytes;
        }

        public byte[] parseHexadecimalStringToBytes(string message)
        {
            int messageLength = message.Length;
            byte[] bytes = new byte[messageLength / 2];
            for (int i = 0; i < messageLength; i += 2) bytes[i / 2] = Convert.ToByte(message.Substring(i, 2), 16);
            return bytes;
        }
    }
}
