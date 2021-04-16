using System.Text;

namespace Codewars.Katas
{
    public class SpoonerizeMe
    {
        public static string Spoonerize(string str)
        {
            var twoWords = str.Split(" ");

            var spoonedStringBuilder = new StringBuilder();
            spoonedStringBuilder.Append(twoWords[1][0]);
            spoonedStringBuilder.Append(twoWords[0].Substring(1));
            spoonedStringBuilder.Append(" ");
            spoonedStringBuilder.Append(twoWords[0][0]);
            spoonedStringBuilder.Append(twoWords[1].Substring(1));

            return spoonedStringBuilder.ToString();
        }
    }
}
