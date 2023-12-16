using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
namespace RSAproject
{
    
    internal static class helper
    {
        static long nBitRandom(int n)
        {
            DateTime dateTime = DateTime.Now;
            var rand = new Random((int)dateTime.Ticks);

            long max = (long)Math.Pow(2, n) - 1;
            long min = (long)Math.Pow(2, n - 1) + 1;
            return rand.NextInt64(min, max + 1);
        }
     
        static long getCandidatePrime(int n)
        {

            while (true)
            {
                long prime_candidate = nBitRandom(n);
                bool flag = true;
                
                foreach (int divisor in constant.first_primes_list)
                {
                    if (prime_candidate % divisor == 0 && divisor * divisor <= prime_candidate)
                    {
                        flag = false; break;
                    }
                }
                if(flag)
                    return prime_candidate;
            }
        }
        static long getCandidatePrime(long min, long max)
        {
            while (true)
            {
                DateTime dateTime = DateTime.Now;
                var rand = new Random((int)dateTime.Ticks);
                long prime_candidate = rand.NextInt64(min, max + 1);
                bool flag = true;

                foreach (int divisor in constant.first_primes_list)
                {
                    if (prime_candidate % divisor == 0 && divisor * divisor <= prime_candidate)
                    {
                        flag = false; break;
                    }
                }
                if (flag)
                    return prime_candidate;
            }
        }
        public static long expmod(long a, long exp, long mod)
        {
            if (exp == 0) return 1;
            if (exp % 2 == 0)
            {
                return (long)Math.Pow(expmod(a, (exp / 2), mod), 2) % mod;
            }
            else
            {
                return (a * expmod(a, (exp - 1), mod)) % mod;
            }
        }

        static bool trialComposite(long round_tester, long evenComponent,
                                   long miller_rabin_candidate, long maxDivisionsByTwo)
        {
            if (expmod(round_tester, evenComponent, miller_rabin_candidate) == 1)
                return false;
            for (int i = 0; i < maxDivisionsByTwo; i++)
            {
                if (expmod(round_tester, (1 << i) * evenComponent,
                           miller_rabin_candidate) == miller_rabin_candidate - 1)
                    return false;
            }
            return true;
        }

        static bool isMillerRabinPassed(long miller_rabin_candidate)
        {
            // Run 20 iterations of Rabin Miller Primality test

            long maxDivisionsByTwo = 0;
            long evenComponent = miller_rabin_candidate - 1;

            while (evenComponent % 2 == 0)
            {
                evenComponent >>= 1;
                maxDivisionsByTwo += 1;
            }

            // Set number of trials here 
            int numberOfRabinTrials = 20;
            for (int i = 0; i < (numberOfRabinTrials); i++)
            {
                Random rand = new Random();
                long round_tester = rand.NextInt64(2, (long)(Math.Sqrt(miller_rabin_candidate)));

                if (trialComposite(round_tester, evenComponent,
                                   miller_rabin_candidate, maxDivisionsByTwo))
                    return false;
            }
            return true;
        }

        public static long largePrimeGenerator(int n)
        {
            while (true)
            {
                try
                {
                    long randomCandidate = getCandidatePrime(n);
                    if(isMillerRabinPassed(randomCandidate))
                        return randomCandidate;
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        public static long largePrimeGenerator(long min, long max)
        {
            while (true)
            {
                try
                {
                    long randomCandidate = getCandidatePrime(min,max);
                    if (isMillerRabinPassed(randomCandidate))
                        return randomCandidate;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
    }
}
