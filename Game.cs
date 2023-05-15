using MothersDayAdventureGame.Scene;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MothersDayAdventureGame
{
    internal class Game
    {
        public TitleScene MyTitleScene;
        public DenScene MyDenScene;
        public BackyardScene MyBackyardScene;
        public FrontyardScene MyFrontyardScene;
        public RoomScene MyRoomScene;
        public KitchenScene MyKitchenScene;
        public ShedScene MyShedScene;
        public CreditScene MyCreditScene;
        public Player MyPlayer;
        public Game()
        {
            MyTitleScene = new TitleScene(this);
            MyDenScene = new DenScene(this);
            MyBackyardScene = new BackyardScene(this);
            MyFrontyardScene = new FrontyardScene(this);
            MyRoomScene = new RoomScene(this);
            MyKitchenScene  = new KitchenScene(this);
            MyShedScene = new ShedScene(this);
            MyCreditScene = new CreditScene(this);
            MyPlayer = new Player();
        }
        public void Start()
        {
            MyTitleScene.Run();
        }
    }
}
