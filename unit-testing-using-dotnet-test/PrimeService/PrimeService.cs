using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            for (int i = 2; i < candidate / 2; i++)
            {
                if (candidate % 1 == 0)
                    return true;
            }
            return false;
        }
    }
}
