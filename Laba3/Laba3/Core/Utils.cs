using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    public static class Utils
    {
        public static BigInteger FastPow(BigInteger baseNumber, BigInteger power, BigInteger mod)
        {
            BigInteger result = 1;
            while (power != 0)
            {
                while (power % 2 == 0)
                {
                    power /= 2;
                    baseNumber = (baseNumber * baseNumber) % mod;
                }
                power--;
                result = (result * baseNumber) % mod;
            }
            return result;
        }

        public static bool IsPrime(BigInteger n)
        {
            if (n <= 1) return false;
            if (n == 2 || n == 3) return true;
            if (n % 2 == 0) return false;

            const int iterations = 20;
            BigInteger d = n - 1;
            int s = 0;

            while (d % 2 == 0)
            {
                d /= 2;
                s++;
            }

            Random rand = new Random();
            for (int i = 0; i < iterations; i++)
            {
                BigInteger a = GenerateRandomBase(n, rand);
                BigInteger x = FastPow(a, d, n);

                if (x == 1 || x == n - 1) continue;

                bool isComposite = true;
                for (int r = 1; r < s; r++)
                {
                    x = FastPow(x, 2, n);
                    if (x == n - 1)
                    {
                        isComposite = false;
                        break;
                    }
                }

                if (isComposite) return false;
            }
            return true;
        }

        private static BigInteger GenerateRandomBase(BigInteger n, Random rand)
        {
            byte[] bytes = n.ToByteArray();
            BigInteger a;
            do
            {
                rand.NextBytes(bytes);
                bytes[^1] &= 0x7F;
                a = new BigInteger(bytes);
            } while (a < 2 || a >= n - 1);

            return a;
        }

        public static (BigInteger bezoutX, BigInteger bezoutY) ExtendedGCD(BigInteger a, BigInteger b)
        {
            BigInteger prevR = a, currR = b;
            BigInteger prevX = 1, currX = 0;
            BigInteger prevY = 0, currY = 1;

            while (currR > 1)
            {
                BigInteger quotient = prevR / currR;
                BigInteger nextR = prevR % currR;

                BigInteger nextX = prevX - quotient * currX;
                BigInteger nextY = prevY - quotient * currY;

                prevR = currR;
                currR = nextR;

                prevX = currX;
                currX = nextX;

                prevY = currY;
                currY = nextY;
            }
            return (currX, currY);
        }
    }
}
