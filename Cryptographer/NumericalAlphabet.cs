﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptographer
{
    class NumericalAlphabet
    {
        // Char array containing letters of the used alphabet 
        char[] alphabet = {
                Convert.ToChar("A"),
                Convert.ToChar("B"),
                Convert.ToChar("C"),
                Convert.ToChar("D"),
                Convert.ToChar("E"),
                Convert.ToChar("F"),
                Convert.ToChar("G"),
                Convert.ToChar("H"),
                Convert.ToChar("I"),
                Convert.ToChar("J"),
                Convert.ToChar("K"),
                Convert.ToChar("L"),
                Convert.ToChar("M"),
                Convert.ToChar("N"),
                Convert.ToChar("O"),
                Convert.ToChar("P"),
                Convert.ToChar("Q"),
                Convert.ToChar("R"),
                Convert.ToChar("S"),
                Convert.ToChar("T"),
                Convert.ToChar("U"),
                Convert.ToChar("V"),
                Convert.ToChar("W"),
                Convert.ToChar("X"),
                Convert.ToChar("Y"),
                Convert.ToChar("Z")
            };
        public int[] lettersToNumbers (char[] messageInChar)
        {
            int[] messageInInt = new int[messageInChar.Length];
            for (int i = 0; i < messageInChar.Length; i++)
            {
                int j;
                for (j = 0; j < alphabet.Length; j++)
                {
                    if (messageInChar[i] == alphabet[j])
                    {
                        messageInInt[i] = j;
                        break;
                    }
                }

                // Check for charecters out of our alphabet
                if(j >= alphabet.Length)
                {
                    return null;
                }
            }
            return messageInInt;
        }

        public char[] numbersToLetters(int[] messageInInt)
        {
            char[] messageInChar = new char[messageInInt.Length];
            for (int i = 0; i < messageInInt.Length; i++)
            {
                int j;
                for (j = 0; j < alphabet.Length; j++)
                {
                    if (messageInInt[i] == j)
                    {
                        messageInChar[i] = alphabet[j];
                        break;
                    }
                }

                // Check for charecters out of our alphabet
                if (j >= alphabet.Length)
                {
                    return null;
                }
            }
            return messageInChar;
        }

        public int alphabetLength()
        {
            return alphabet.Length;
        }
    }
}
