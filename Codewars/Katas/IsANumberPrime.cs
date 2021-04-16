namespace Codewars.Katas
{
    class IsANumberPrime
    {
        public static bool IsPrimeEratosthenesSieve(int n)
        {
            if (n <= 1) return false;

            //array bool wszystkie wartości są false bo tak jest defaultowo - jeżeli wartość zmieni sie na true to znaczy że dana liczba NIE jest prime
            //można zamienić logikę żeby 
            bool[] prime = new bool[n + 1];

            for (int p = 2; p * p <= n; p++)
            {
                if (!prime[p])
                {
                    for (int i = p * p; i <= n; i += p)
                    {
                        prime[i] = true;
                        if (prime[n]) return false;
                    }
                }
            }

            return !prime[n];
        }

        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n <= 3) return true;
            if (n % 2 == 0 || n % 3 == 0) return false;

            for (int i = 5; i * i <= n; i = i + 6)
            {
                if (n % i == 0 || n % (i + 2) == 0) return false;
            }

            return true;
        }
    }
}
