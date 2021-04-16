using System;
using System.Linq;
using System.Text;

namespace Codewars.Katas
{
    public class DecipherThis
    {
        public static string DecipherThisMessage(string encodedMessage)
        {
            if (String.IsNullOrEmpty(encodedMessage)) return "";

            StringBuilder decryptedMessage = new StringBuilder("");

            var encodedWords = encodedMessage.Split(' ');
            foreach (var encodedWord in encodedWords)
            {
                var textPartOfEncodedWord = ExtractWords(encodedWord);
                switch (textPartOfEncodedWord.Length)
                {
                    case 0:
                        decryptedMessage.Append(Convert.ToChar(ExtractNumber(encodedWord)).ToString() + " ");
                        break;
                    case 1:
                        decryptedMessage.Append(Convert.ToChar(ExtractNumber(encodedWord)).ToString() + textPartOfEncodedWord + " ");
                        break;
                    default:
                    {
                        var firstDecryptedLetter = Convert.ToChar(ExtractNumber(encodedWord)).ToString();
                        var secondDecryptedLetter = textPartOfEncodedWord[textPartOfEncodedWord.Length - 1];
                        var lastDecryptedLetter = textPartOfEncodedWord[0];

                        StringBuilder decryptedWord = new StringBuilder("");
                        decryptedWord.Append(firstDecryptedLetter + secondDecryptedLetter);
                        for (int i = 1; i < textPartOfEncodedWord.Length - 1; i++)
                        {
                            decryptedWord.Append(textPartOfEncodedWord[i]);
                        }
                        decryptedWord.Append(lastDecryptedLetter + " ");

                        decryptedMessage.Append(decryptedWord);
                        break;
                    }
                }
            }
            return decryptedMessage.ToString().Trim();
        }

        private static string ExtractWords(string encodedWord)
        {
            var encryptedText = new StringBuilder("");
            foreach (var t in encodedWord.Where(t => !Char.IsDigit(t)))
            {
                encryptedText.Append(t);
            }
            return encryptedText.ToString();
        }

        private static int ExtractNumber(string numeralMessage)
        {
            var encryptedNumber = new StringBuilder("");
            foreach (var t in numeralMessage.Where(t => Char.IsDigit(t)))
            {
                encryptedNumber.Append(t);
            }
            return Convert.ToInt16(encryptedNumber.ToString());
        }
    }
}
