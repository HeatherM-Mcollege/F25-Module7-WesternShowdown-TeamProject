using MohawkGame2D;

using System;
using System.Numerics;


namespace team2_a4_WesternShowdown
{
    public class Menu
    {
        public Font westernF;
        public int sizeF = 100;
        public string Title = ("Western Showdown!");

        public Vector2[] wordPos = [
            new Vector2(80,150), //title [0]
            new Vector2(352, 305), //start [1]
            new Vector2(330,365), //Controls [2]
            new Vector2(35, 150), //draw player 1 controls [3]
            new Vector2(385, 150), //draw player 2 controls [4]
            new Vector2(35, 250), //draw movement [5]
            new Vector2(385, 250), //draw movement2 [6]
            new Vector2(35, 290), //draw fire1 [7]
            new Vector2(385, 290), //draw fire2 [8]
            new Vector2(690,510), //back [9] 

            ];


        Options startButton = new Options(new Vector2(320, 300),new Vector2(135, 50));
        Options controlsButton = new Options(new Vector2(320, 360),new Vector2(135, 50));
        Options backButton = new Options(new Vector2(650,500),new Vector2(135, 50));

        bool menuScreen = true;
        bool controlsScreen = false;

        public void Setup()
        {
            westernF = Text.LoadFont("../../../Assets/Fonts/BroncoPersonalUse.ttf", sizeF);

        }
        public void Update()
        {
            Window.ClearBackground(Color.Black);

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
        }



        public void DrawMenuText()
        {
            Text.Color = Color.White;
            Text.Font = westernF;
            Text.Size = sizeF;
            Text.Draw("Western Showdown!", wordPos[0]);
            Text.Color = Color.Gray;
            Text.Size = 40;
            Text.Draw("Start", wordPos[1]);
            Text.Draw("Controls", wordPos[2]);

        }

        public void DrawControlMenu()
        {
            Text.Color = Color.Gray;
            Text.Font = westernF;
            Text.Size = 40;
            Text.Draw("Player 1", wordPos[3]);
            Text.Draw("Player 2", wordPos[4]);
            Text.Size = 30;
            Text.Draw("Movement.......................W A S D", wordPos[5]);
            Text.Draw("Movement....................Up, Left, Down, Right", wordPos[6]);
            Text.Draw("Fire...........................", wordPos[7]);
            Text.Draw("Fire........................", wordPos[8]);
            Text.Draw("Back", wordPos[9]);

        }

        public void cactusArt()
        {
            //cactus1
            Draw.LineSize = 0;
            Draw.FillColor = Color.DarkGray;
            //body
            Draw.Rectangle(-20, 280, 75, 330);
            Draw.Rectangle(25, 400, 100, 55);
            Draw.Rectangle(75,355, 50, 50);
           //spikes
            Draw.LineSize = 5;
            Draw.LineColor = Color.DarkGray;
            Draw.Line(55, 300, 57, 300);
            Draw.Line(55, 335, 60, 335);
            Draw.Line(55, 480, 58, 480);
            Draw.Line(55, 490, 60, 490);
            Draw.Line(55, 545, 56, 545);
            Draw.Line(125, 407, 130, 407);
            Draw.Line(75, 381, 72, 381);
            Draw.Line(5,275, 3, 280);
            Draw.Line(11,275, 11, 279);      
            Draw.Line(120,353, 120, 355);

            //cactus2
            Draw.LineSize = 0;
            Draw.FillColor= Color.DarkGray;
            Draw.Rectangle(120,470,30,130 );
            Draw.Rectangle(150, 510, 30, 10);
            Draw.Rectangle(100, 550, 30, 10);
            Draw.Rectangle(170, 500, 10, 10);
            Draw.Rectangle(100, 540, 10, 10);
            Draw.LineSize = 5;
            Draw.LineColor = Color.DarkGray;
            Draw.Line(150,580,151,580);
            Draw.Line(119,480,120,480);

        }

        public void wheelArt()
        {
            Draw.LineSize = 0;
            Draw.FillColor = Color.DarkGray;
            Draw.Circle(800, 600, 200); 
            Draw.FillColor = Color.Black;
            Draw.Circle(800, 600, 160);
            Draw.FillColor = Color.DarkGray;
            Draw.Circle(800, 600, 50);
            Draw.FillColor = Color.Black;
            Draw.Circle(800, 600, 25);
            Draw.FillColor = Color.DarkGray;
            Draw.Capsule(670, 470, 770, 570, 10);
            Draw.Capsule(620, 580, 750, 600, 10);
            Draw.Capsule(780, 435, 800, 550, 10);
        }

    }
}
