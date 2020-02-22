using EOGCodeChallenge.Tools;

namespace EOGCodeChallenge.ViewModels
{
    class PlayerModel : ViewModelBase
    {
        private static int _playerCount = 0;

        private string _name;
        private int _chips;
        private int _playerNumber;

        public PlayerModel() 
        {
            PlayerNumber = ++_playerCount;

            Name = RandomNames.GetRandomName();
            Chips = 3;
        }

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public int Chips
        {
            get => _chips;
            set 
            {
                value = value < 0 ? 0 : value;
                SetProperty(ref _chips, value);
            } 
        }

        public int PlayerNumber
        {
            get => _playerNumber;
            set => SetProperty(ref _playerNumber, value);
        }

        public bool HasNoChips => _chips == 0;
    }
}
