using System;

namespace BlazorOverviewShared.Pages.User
{
    public class RandomService
    {
        private Random random;
        private Random Random
        {
            get
            {
                if (random != null)
                    return random;
                random = new Random(10);
                return random;
            }
        }
        public int Next()
        {
            return Random.Next(0, 9);
        }
    }
}
