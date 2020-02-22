using EOGCodeChallenge.ViewModels;
using System.Linq;

namespace EOGCodeChallenge.Controllers
{
    class GameController
    {
        private GameModel _gameModel;
        private bool _isGameOver;

        //tjhis would normally be an interface / depencyinjected
        public GameController(GameModel gameModel)
        {
            _gameModel = gameModel;
        }

        public TurnManager Turn { get; set; }


        public void SimulateSingleGame(GameModel game)
        {
            Turn = new TurnManager(game.NumberOfPlayers);

            while(!_isGameOver)
            {
                SimulateSingleTurn();
            }
        }

        public void SimulateSingleTurn()
        {
            var currentPlayer = Turn.GetNextPlayer();

            if(!currentPlayer.HasNoChips)
            {
                var rolls = Tools.Roll.RollDice(currentPlayer.Chips);
                currentPlayer.Chips -= 3;

                foreach (var roll in rolls)
                {
                    switch(roll)
                    {
                        case DiceSides.Left:
                            Turn.GetLeftPlayer(currentPlayer.PlayerNumber).Chips += 1;
                            break;
                        case DiceSides.Right:
                            Turn.GetRightPlayer(currentPlayer.PlayerNumber).Chips += 1;
                            break;
                        case DiceSides.Center:
                        default:

                            break;
                    }
                }
            }

            CheckForGameOver();
        }

        public void CheckForGameOver()
        {
            var playersWithNoChips = Turn.Players.Where(x => x.Chips == 0).Count();

            _isGameOver = playersWithNoChips == _gameModel.NumberOfPlayers - 1;
        }
    }
}
