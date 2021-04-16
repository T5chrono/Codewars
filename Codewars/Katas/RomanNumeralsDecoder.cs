namespace Codewars.Katas
{
    public class RomanNumeralsDecoder
    {
        public static int Solution(string roman)
        {
            var romanArray = roman.ToCharArray();
            
            if (roman.Length == 1) return TranslateRoman(romanArray[0]);

            var sum = 0;
            for (int i = 0; i < roman.Length-1; i = i + 1)
            {
                if (TranslateRoman(roman[i])<TranslateRoman(roman[i+1]))
                    sum = sum - TranslateRoman(romanArray[i]);
                else
                    sum = sum + TranslateRoman(romanArray[i]);
            }
            return sum + TranslateRoman(romanArray[roman.Length-1]);
        }

        private static int TranslateRoman(char romanLetter)
        {
            return (romanLetter.ToString()) switch
            {
                "I" => 1,
                "V" => 5,
                "X" => 10,
                "L" => 50,
                "C" => 100,
                "D" => 500,
                _ => 1000,
            };
        }
    }
}
