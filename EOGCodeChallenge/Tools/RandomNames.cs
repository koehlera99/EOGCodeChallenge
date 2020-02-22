using System.Collections.Generic;

namespace EOGCodeChallenge.Tools
{
    //Not used, was to simulate player names ( not needed)
    class RandomNames
    {
        private static List<string> _randomName;

        public static string GetRandomName()
        {
            if (_randomName == null)
                InitializeRandomNames();

            int roll = Roll.Random(1, 7);

            return _randomName[roll];
        }

        private static void InitializeRandomNames()
        {
            _randomName = new List<string>();

            _randomName.Add("Bob");
            _randomName.Add("Chris");
            _randomName.Add("Jessica");
            _randomName.Add("Dan");
            _randomName.Add("Bill");
            _randomName.Add("Barbara");
            _randomName.Add("Julie");

        }

    }
}
