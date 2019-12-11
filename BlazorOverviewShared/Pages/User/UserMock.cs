using System.Collections.Generic;

namespace BlazorOverviewShared.Pages.User
{
    public class UserMock
    {
        private RandomService rndService;
        public UserMock(RandomService rnd)
        {
            rndService = rnd;
        }

        private List<string> names;
        private List<string> Names
        {
            get
            {
                if (names == null)
                {
                    names = new List<string>()
                    {
                        "Abigail",
                        "Amelia",
                        "Aria",
                        "Audrey",
                        "Alexa",
                        "Anna",
                        "Aaliyah",
                        "Ariana",
                        "Adeline",
                        "Aurora"
                    };
                }
                return names;
            }
        }

        private List<string> lastNames;
        private List<string> LastNames
        {
            get
            {
                if (lastNames == null)
                {
                    lastNames = new List<string>()
                    {
                        "Sherman",
                        "Howells",
                        "Warner",
                        "King",
                        "Bright",
                        "Walton",
                        "Warren",
                        "Flynn",
                        "Torres",
                        "Flowers" 
                    };
                }
                return lastNames;
            }
        }

        public string GetNextName()
        {
            return Names[rndService.Next()];
        }

        public string GetNextLastName()
        {
            return LastNames[rndService.Next()];
        }

        public int GetNextLevel()
        {
            return rndService.Next();
        }
    }
}
