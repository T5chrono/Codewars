using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codewars.Katas
{
    public class CondiCipher
    {
        private static readonly List<char> _alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray().ToList();

        public static string Encode(string message, string key, int initShift)
        {
            Console.WriteLine(message + key + initShift);
            var completeKey = ProvideCompleteKey(key);
            var shift = initShift;
            var encryptedMessage = new StringBuilder();
            foreach (var character in message)
            {
                var initLetterPos = completeKey.FindIndex(letter => letter == character);
                if (initLetterPos == -1)
                {
                    encryptedMessage.Append(character);
                }
                else
                {
                    var encryptedLetterPos = initLetterPos + shift;
                    if (encryptedLetterPos > 25) encryptedLetterPos = EqualizePositive(encryptedLetterPos);
                    shift = initLetterPos + 1;

                    encryptedMessage.Append(completeKey[encryptedLetterPos]);
                }
            }

            return encryptedMessage.ToString();
        }

        private static List<char> ProvideCompleteKey(string key)
        {
            var uniqueKey = key.ToCharArray().Distinct().ToList();
            uniqueKey.AddRange(_alphabet);
            var completeKey = uniqueKey.Distinct().ToList();
            return completeKey;
        }

        public static int EqualizePositive(in int encryptedLetterPos)
        {
            return encryptedLetterPos % 26;
        }

        public static string Decode(string message, string key, int initShift)
        {
            var completeKey = ProvideCompleteKey(key);
            var shift = initShift;
            var decryptedMessage = new StringBuilder();
            foreach (var character in message)
            {
                var initLetterPos = completeKey.FindIndex(letter => letter == character);
                if (initLetterPos == -1)
                {
                    decryptedMessage.Append(character);
                }
                else
                {
                    var encryptedLetterPos = initLetterPos - shift;
                    if (encryptedLetterPos < 0) encryptedLetterPos = EqualizeNegative(encryptedLetterPos);
                    shift = encryptedLetterPos + 1;

                    decryptedMessage.Append(completeKey[encryptedLetterPos]);
                }
            }

            return decryptedMessage.ToString();
        }

        public static int EqualizeNegative(in int encryptedLetterPos)
        {
            return (encryptedLetterPos % 26 == 0) ? encryptedLetterPos % 26 : 26 + encryptedLetterPos % 26;
        }
    }
}
