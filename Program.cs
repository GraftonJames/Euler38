// https://projecteuler.net/problem=38

namespace Euler_thirtyeight {
    class Program {
        static void Main()
        {
            int maxPandigital = 0;
            for (int i = 1; i < 10000 ; i++)
            {
                int totalDigits = 0;
                int number = 0;
                int n = 0;
                for (int j = 1; totalDigits < 9; j++)
                {
                    int digits = (int) Math.Floor(Math.Log10(i*j))+1;
                    totalDigits += digits;
                    number =  number * ((int)Math.Pow(10,digits)) + i*j;
                    n = j;
                }
                if (totalDigits == 9)
                {
                    if (isPandigital(number))
                    {
                        Console.WriteLine($"{i} (1...{n}) = {number} is pandigital");
                        if (number > maxPandigital){
                            maxPandigital = number;
                        }
                    }
                }
            } 
            Console.WriteLine($"largest Pandigital is {maxPandigital}");
        }
        static bool isPandigital(int number)
        {
            // corresponds to 1,2,3....
            bool[] digitCheck = {false,false,false,false,false,false,false,false,false};
            while (number != 0)
            {
                int digit = number % 10;
                if (digit == 0) return false;
                if (digitCheck[digit -1]){
                    return false;
                } 
                else {
                    digitCheck[digit -1] = true;
                }
                number = (number - digit) / 10;
            }
            foreach (bool check in digitCheck ) {
                if (!check)
                { 
                    return false;
                } 
            }
            return true;
        }
    }
}