using System.Numerics;

namespace Laba3
{
    public class CryptoSystem
    {
        public BigInteger[] plaintext, ciphertext;
        public BigInteger p, q, b, n;

        public void Encrypt()
        {
            ciphertext = new BigInteger[plaintext.Length];

            for (int i = 0; i < plaintext.Length; i++)
            {
                BigInteger m = plaintext[i];
                ciphertext[i] = m * (m + b) % n;
            }
        }

        public void Decrypt()
        {
            ciphertext = new BigInteger[plaintext.Length];

            for (int i = 0; i < plaintext.Length; i++)
            {
                BigInteger c = plaintext[i];

                BigInteger D = CalculateD(c, n);
                BigInteger mp = CalculateRootModulo(D, p);
                BigInteger mq = CalculateRootModulo(D, q);

                (BigInteger yp, BigInteger yq) = Utils.ExtendedGCD(p, q);

                BigInteger[] d = CombineRoots(mp, mq, yp, yq, n);
                BigInteger[] m = CalculateMessage(d, n);

                for (int j = 0; j < 4; j++)
                {
                    if (m[j] < 256)
                    {
                        ciphertext[i] = m[j];
                        break;
                    }
                }
            }
        }

        private BigInteger CalculateD(BigInteger c, BigInteger n)
        {
            return (b * b + 4 * c) % n;
        }

        private BigInteger CalculateRootModulo(BigInteger D, BigInteger mod)
        {
            return Utils.FastPow(D, (mod + 1) / 4, mod);
        }

        private BigInteger[] CombineRoots(BigInteger mp, BigInteger mq, BigInteger yp, BigInteger yq, BigInteger n)
        {
            BigInteger[] d = new BigInteger[4];

            d[0] = (yp * p * mq + yq * q * mp) % n;
            if (d[0] < 0) { d[0] += n; }
            d[1] = n - d[0];
            d[2] = (yp * p * mq - yq * q * mp) % n;
            if (d[2] < 0) { d[2] += n; }
            d[3] = n - d[2];

            return d;
        }

        private BigInteger[] CalculateMessage(BigInteger[] d, BigInteger n)
        {
            BigInteger[] m = new BigInteger[4];

            for (int j = 0; j < 4; j++)
            {
                BigInteger delta = d[j] - b;
                BigInteger correction = (delta % 2 != 0) ? n : 0;

                m[j] = (delta + correction) / 2;
                m[j] = m[j] % n;

                if (m[j] < 0) { m[j] += n; }
            }

            return m;
        }
    }
}
