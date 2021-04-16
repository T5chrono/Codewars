namespace Codewars.Katas
{
    public class MoneyMoneyMoney
    {
        public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
        {
            if (principal == desiredPrincipal) return 0;

            int years = 0;
            double currentPrincipal = principal;

            while (currentPrincipal < desiredPrincipal)
            {
                currentPrincipal = CalculateOneYearPrincipal(currentPrincipal, interest, tax);
                years += 1;
            }

            return years;
        }

        public static double CalculateOneYearPrincipal(double principal, double interest, double tax)
        {
            var untaxedInterst = principal * interest;
            var taxToPay = untaxedInterst * tax;

            return principal + untaxedInterst - taxToPay;
        }
    }
}
