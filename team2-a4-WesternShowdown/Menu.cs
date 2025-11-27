using MohawkGame2D;

using System;
using System.Numerics;


namespace team2_a4_WesternShowdown
{
    public class Menu
    {
        public Font westernF;
        public int sizeF = 70;
        public string Title = ("Western Showdown!");

        public Vector2[] wordPos = [
            new Vector2(75,100), //title [0]
            new Vector2(255, 205), //start [1]
            new Vector2(240,265), //Controls [2]
            new Vector2(25, 220), //draw player 1 controls [3]
            new Vector2(335, 220), //draw player 2 controls [4]
            new Vector2(25, 270), //draw fire [5]
            new Vector2(335, 270), //draw fire2 [6]
            new Vector2(550,370), //back [7] 
            new Vector2(125,80), //rule line1 [8] 
            new Vector2(65,130), //rule line 2 [9] 

            ];


        Options startButton = new Options(new Vector2(235, 203),new Vector2(95, 35));
        Options controlsButton = new Options(new Vector2(235, 263),new Vector2(95, 35));
        Options backButton = new Options(new Vector2(543,368),new Vector2(45, 25));

        bool menuScreen = true;
        bool controlsScreen = false;
        bool gameStart = false;

        public void Setup()
        {
            westernF = Text.LoadFont("../../../Assets/Fonts/BroncoPersonalUse.ttf", sizeF);

        }
        public void Update()
        {

            if (menuScreen == true)
            {
                cactusArt();
                wheelArt();
                startButton.Update();
                controlsButton.Update();
                DrawMenuText();

                if(startButton.Click() == true)
                {
                    menuScreen = false;
                    gameStart = true;
                    
                }

                if (controlsButton.Click() == true)
                {
                    menuScreen = false;
                    controlsScreen = true;
                }

            }

            if (controlsScreen == true)
            {
                backButton.Update();
                DrawControlMenu();

                if (backButton.Click() == true)
                {
                    menuScreen = true;
                    controlsScreen = false;
                }
            }

            if (gameStart == true)
            {

            }

        }



        public void DrawMenuText()
        {
            Text.Color = Color.White;
            Text.Font = westernF;
            Text.Size = sizeF;
            Text.Draw("Western Showdown!", wordPos[0]);
            Text.Color = Color.Gray;
            Text.Size = 30;
            Text.Draw("Start", wordPos[1]);
            Text.Draw("Controls", wordPos[2]);

        }

        public void DrawControlMenu()
        {
            Text.Color = Color.Gray;
            Text.Font = westernF;
            Text.Size = 30;
            Text.Draw("Player 1", wordPos[3]);
            Text.Draw("Player 2", wordPos[4]);
            Text.Size = 20;
            Text.Draw("Fire.......................W A S D", wordPos[5]);
            Text.Draw("Fire....................Up, Left, Down, Right", wordPos[6]);
            Text.Draw("Back", wordPos[7]);
            Text.Size = 30;
            Text.Draw("Can you become the top Gunman?", wordPos[8]);
            Text.Draw("When prompted press the corresponding button", wordPos[9]);

        }

        public void cactusArt()
        {
            //cactus1
            Draw.LineSize = 0;
            Draw.FillColor = Color.DarkGray;
            //body
            Draw.Rectangle(-14, 184, 50, 218);
            Draw.Rectangle(16, 264, 66, 36);
            Draw.Rectangle(50,234, 32, 32);

            //cactus2
            Draw.LineSize = 0;
            Draw.FillColor= Color.DarkGray;
            Draw.Rectangle(75,320,20,84 );
            Draw.Rectangle(88, 336, 18, 6);
            Draw.Rectangle(66, 362, 18, 6);
            Draw.Rectangle(100, 330, 6, 6);
            Draw.Rectangle(66, 358, 6, 6);


        }

        public void wheelArt()
        {
            Draw.LineSize = 0;
            Draw.FillColor = Color.DarkGray;
            Draw.Circle(600, 400, 120); 
            Draw.FillColor = Color.Black;
            Draw.Circle(600, 400, 100);
            Draw.FillColor = Color.DarkGray;
            Draw.Circle(600, 400, 40);
            Draw.FillColor = Color.Black;
            Draw.Circle(600, 400, 20);
            Draw.FillColor = Color.DarkGray;
            Draw.Capsule(530, 320, 580, 380, 5);
            Draw.Capsule(490, 380, 575, 400, 5);
            Draw.Capsule(590, 300, 600, 370, 5);
        }

    }
}
