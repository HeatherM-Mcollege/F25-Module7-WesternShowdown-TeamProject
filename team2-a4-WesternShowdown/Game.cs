
﻿
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using team2_a4_WesternShowdown;

using team2_a4_WesternShowdown;



namespace MohawkGame2D
{

    namespace MohawkGame2D
    {

        public class Game
        {

            int duelMatch = 1;
            float timeElapsed = 0;
            float drawDelay = Random.Float(3, 10);
            int player1Input = Random.Integer(1, 5);
            int player2Input = Random.Integer(1, 5);
            int player1Score = 0;
            int player2Score = 0;
            float timeReset = 0;
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


            Options startButton = new Options(new Vector2(235, 203), new Vector2(95, 35));
            Options controlsButton = new Options(new Vector2(235, 263), new Vector2(95, 35));
            Options backButton = new Options(new Vector2(543, 368), new Vector2(45, 25));

            bool menuScreen = true;
            bool controlsScreen = false;
            bool gameStart = false;


            Character1 character1 = new Character1(new Vector2(350, 175));
            Character2 character2 = new Character2(new Vector2(0, 175));
            public void Setup()
            {
                Window.SetSize(600, 400);
                Window.SetTitle("Western Showdown");
                Window.ClearBackground(Color.White);

                westernF = Text.LoadFont("../../../Assets/Fonts/BroncoPersonalUse.ttf", sizeF);


                Menu titleMenu = new Menu();
                character1.Setup();
                character2.Setup();
            }

            public void Update()
            {
                
                if (menuScreen == true)
                {
                    Window.ClearBackground(Color.Black);   
                    cactusArt();
                    wheelArt();
                    startButton.Update();
                    controlsButton.Update();
                    DrawMenuText();

                    if (startButton.Click() == true)
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
                    Window.ClearBackground(Color.Black);
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
                    drawBackground();
                    character1.Update();
                    character2.Update();
                    
                    timeElapsed = Time.SecondsElapsed;
                    Score();
                    if (player1Score >= 5)
                    {
                        Window.ClearBackground(Color.Clear);
                        Score();
                        Text.Draw("Player 1 is the westiest", new Vector2(180, 200));
                        Text.Draw("in the west!!", new Vector2(230, 250));
                        duelMatch = -1;
                    }
                    else if (player2Score >= 5)
                    {
                        Window.ClearBackground(Color.Clear);
                        Score();
                        Text.Draw("Player 2 is the westiest", new Vector2(180, 200));
                        Text.Draw("in the west!!", new Vector2(230, 250));
                        duelMatch = -1;
                    }
                    else
                    {
                        if (duelMatch == 1)
                        {
                            Duel();
                        }
                        else if (duelMatch == 0)
                        {
                            resetDuel();
                        }
                        else { }
                    }

                }

               
            }

            public void Duel()
            {

                Text.Draw("Ready...", new Vector2(250, 180));
                if (timeElapsed - timeReset >= drawDelay)
                {
                    drawBackground();
                    character1.Update();
                    character2.Update();
                    Score();
                    Text.Draw("Draw!", new Vector2(250, 180));

                    if (player1Input == 1)
                    {
                        Text.Draw("W", new Vector2(200, 300));
                    }
                    else if (player1Input == 2)
                    {
                        Text.Draw("A", new Vector2(200, 300));
                    }
                    else if (player1Input == 3)
                    {
                        Text.Draw("S", new Vector2(200, 300));
                    }
                    else if (player1Input == 4)
                    {
                        Text.Draw("D", new Vector2(200, 300));
                    }
                    if (player2Input == 1)
                    {
                        Text.Draw("Up", new Vector2(370, 300));
                    }
                    else if (player2Input == 2)
                    {
                        Text.Draw("Left", new Vector2(370, 300));
                    }
                    else if (player2Input == 3)
                    {
                        Text.Draw("Down", new Vector2(370, 300));
                    }
                    else if (player2Input == 4)
                    {
                        Text.Draw("Right", new Vector2(370, 300));
                    }

                    if (Input.IsKeyboardKeyPressed(KeyboardInput.W) && player1Input == 1)
                    {
                        Window.ClearBackground(Color.Clear);
                        Text.Draw("Player 1 Shot Player 2!", new Vector2(125, 150));
                        Text.Draw("Player 1 Scores!", new Vector2(135, 190));
                        player1Score++;
                        Score();
                        resetDuel();
                    }
                    else if (Input.IsKeyboardKeyPressed(KeyboardInput.W) && player1Input != 1)
                    {
                        Window.ClearBackground(Color.Clear);
                        Text.Draw("Player 1 Fumbled!", new Vector2(150, 150));
                        Text.Draw("Player 2 Scores!", new Vector2(150, 190));
                        player2Score++;
                        Score();
                        resetDuel();
                    }
                    else if (Input.IsKeyboardKeyPressed(KeyboardInput.A) && player1Input == 2)
                    {
                        Window.ClearBackground(Color.Clear);
                        Text.Draw("Player 1 Shot Player 2!", new Vector2(125, 150));
                        Text.Draw("Player 1 Scores!", new Vector2(135, 190));
                        player1Score++;
                        Score();
                        resetDuel();
                    }
                    else if (Input.IsKeyboardKeyPressed(KeyboardInput.A) && player1Input != 2)
                    {
                        Window.ClearBackground(Color.Clear);
                        Text.Draw("Player 1 Fumbled!", new Vector2(150, 150));
                        Text.Draw("Player 2 Scores!", new Vector2(150, 190));
                        player2Score++;
                        Score();
                        resetDuel();
                    }

                    else if (Input.IsKeyboardKeyPressed(KeyboardInput.S) && player1Input == 3)
                    {
                        Window.ClearBackground(Color.Clear);
                        Text.Draw("Player 1 Shot Player 2!", new Vector2(125, 150));
                        Text.Draw("Player 1 Scores!", new Vector2(135, 190));
                        player1Score++;
                        Score();
                        resetDuel();

                    }
                    else if (Input.IsKeyboardKeyPressed(KeyboardInput.S) && player1Input != 3)
                    {
                        Window.ClearBackground(Color.Clear);
                        Text.Draw("Player 1 Fumbled!", new Vector2(150, 150));
                        Text.Draw("Player 2 Scores!", new Vector2(150, 190));
                        player2Score++;
                        Score();
                        resetDuel();
                    }

                    else if (Input.IsKeyboardKeyPressed(KeyboardInput.D) && player1Input == 4)
                    {
                        Window.ClearBackground(Color.Clear);
                        Text.Draw("Player 1 Shot Player 2!", new Vector2(125, 150));
                        Text.Draw("Player 1 Scores!", new Vector2(135, 190));
                        player1Score++;
                        Score();
                        resetDuel();
                    }
                    else if (Input.IsKeyboardKeyPressed(KeyboardInput.D) && player1Input != 4)
                    {
                        Window.ClearBackground(Color.Clear);
                        Text.Draw("Player 1 Fumbled!", new Vector2(150, 150));
                        Text.Draw("Player 2 Scores!", new Vector2(150, 190));
                        player2Score++;
                        Score();
                        resetDuel();
                    }
                    else if (Input.IsKeyboardKeyPressed(KeyboardInput.Up) && player2Input == 1)
                    {
                        Window.ClearBackground(Color.Clear);
                        Text.Draw("Player 2 Shot Player 1!", new Vector2(125, 150));
                        Text.Draw("Player 2 Scores!", new Vector2(135, 190));
                        player2Score++;
                        Score();
                        resetDuel();
                    }
                    else if (Input.IsKeyboardKeyPressed(KeyboardInput.Up) && player2Input != 1)
                    {
                        Window.ClearBackground(Color.Clear);
                        Text.Draw("Player 2 Fumbled!", new Vector2(150, 150));
                        Text.Draw("Player 1 Scores!", new Vector2(150, 190));
                        player1Score++;
                        Score();
                        resetDuel();
                    }
                    else if (Input.IsKeyboardKeyPressed(KeyboardInput.Left) && player2Input == 2)
                    {
                        Window.ClearBackground(Color.Clear);
                        Text.Draw("Player 2 Shot Player 1!", new Vector2(125, 150));
                        Text.Draw("Player 2 Scores!", new Vector2(135, 190));
                        player2Score++;
                        Score();
                        resetDuel();
                    }
                    else if (Input.IsKeyboardKeyPressed(KeyboardInput.Left) && player2Input != 2)
                    {
                        Window.ClearBackground(Color.Clear);
                        Text.Draw("Player 2 Fumbled!", new Vector2(150, 150));
                        Text.Draw("Player 1 Scores!", new Vector2(150, 190));
                        player1Score++;
                        Score();
                        resetDuel();
                    }
                    else if (Input.IsKeyboardKeyPressed(KeyboardInput.Down) && player2Input == 3)
                    {
                        Window.ClearBackground(Color.Clear);
                        Text.Draw("Player 2 Shot Player 1!", new Vector2(125, 150));
                        Text.Draw("Player 2 Scores!", new Vector2(135, 190));
                        player2Score++;
                        Score();
                        resetDuel();
                    }
                    else if (Input.IsKeyboardKeyPressed(KeyboardInput.Down) && player2Input != 3)
                    {
                        Window.ClearBackground(Color.Clear);
                        Text.Draw("Player 2 Fumbled!", new Vector2(150, 150));
                        Text.Draw("Player 1 Scores!", new Vector2(150, 190));
                        player1Score++;
                        Score();
                        resetDuel();
                    }
                    else if (Input.IsKeyboardKeyPressed(KeyboardInput.Right) && player2Input == 4)
                    {
                        Window.ClearBackground(Color.Clear);
                        Text.Draw("Player 2 Shot Player 1!", new Vector2(125, 150));
                        Text.Draw("Player 2 Scores!", new Vector2(135, 190));
                        player2Score++;
                        Score();
                        resetDuel();
                    }
                    else if (Input.IsKeyboardKeyPressed(KeyboardInput.Right) && player2Input != 4)
                    {
                        Window.ClearBackground(Color.Clear);
                        Text.Draw("Player 2 Fumbled!", new Vector2(150, 150));
                        Text.Draw("Player 1 Scores!", new Vector2(150, 190));
                        player1Score++;
                        Score();
                        resetDuel();
                    }
                }
                else
                {
                }
            }
            public void resetDuel()
            {
                duelMatch = 0;
                drawDelay = Random.Float(3, 10);
                player1Input = Random.Integer(1, 5);
                player2Input = Random.Integer(1, 5);
                Text.Draw("Press Space to initiate", new Vector2(200, 200));
                Text.Draw("the next duel!", new Vector2(230, 250));
                if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
                {
                    timeReset = Time.SecondsElapsed;
                    duelMatch = 1;
                    Window.ClearBackground(Color.White);
                }
                else
                {
                    duelMatch = 0;
                }
            }
            public void Score()
            {
                Text.Color = Color.Red;
                Text.Draw("Player 1 Score: " + player1Score, new Vector2(10, 10));
                Text.Draw("Player 2 Score: " + player2Score, new Vector2(10, 45));
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
                Draw.Rectangle(50, 234, 32, 32);

                //cactus2
                Draw.LineSize = 0;
                Draw.FillColor = Color.DarkGray;
                Draw.Rectangle(75, 320, 20, 84);
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

            public void drawBackground()
            {
                //sand
                Window.ClearBackground(new Color(194, 178, 128));
                //sky
                Draw.LineSize = 0;
                Draw.FillColor = new Color(50, 135, 168);
                Draw.Rectangle(new Vector2(0, 0), new Vector2(600, 33));
                Draw.FillColor = new Color(30, 185, 199);
                Draw.Rectangle(new Vector2(0, 33), new Vector2(600, 33));
                Draw.FillColor = new Color(255, 192, 180);
                Draw.Rectangle(new Vector2(0, 66), new Vector2(600, 66));
                Draw.FillColor = new Color(225, 165, 0);
                Draw.Rectangle(new Vector2(0, 132), new Vector2(600, 66));
                //sun
                Draw.FillColor = Color.Yellow;
                Draw.Circle(new Vector2(132, 52), 20);
                //back mountain
                Draw.FillColor = new Color(43, 18, 1);
                Draw.Rectangle(new Vector2(0, 182), new Vector2(528, 17));
                Draw.Rectangle(new Vector2(132, 175), new Vector2(198, 7));
                Draw.Quad(new Vector2(165, 175), new Vector2(178, 162), new Vector2(244, 162), new Vector2(257, 175));
                Draw.Quad(new Vector2(297, 175), new Vector2(297, 165), new Vector2(310, 162), new Vector2(310, 175));
                Draw.Rectangle(new Vector2(310, 132), new Vector2(50, 66));
                Draw.Quad(new Vector2(360, 152), new Vector2(360, 198), new Vector2(426, 198), new Vector2(426, 172));

                //front mountains
                Draw.FillColor = new Color(89, 37, 3);
                //left mountain
                Draw.Rectangle(new Vector2(0, 66), new Vector2(66, 198));
                Draw.Rectangle(new Vector2(66, 99), new Vector2(17, 165));
                Draw.Rectangle(new Vector2(83, 165), new Vector2(17, 99));
                Draw.Rectangle(new Vector2(99, 191), new Vector2(7, 73));
                Draw.Quad(new Vector2(106, 191), new Vector2(99, 264), new Vector2(129, 264), new Vector2(129, 231));
                Draw.Rectangle(new Vector2(129, 231), new Vector2(20, 33));
                Draw.Quad(new Vector2(0, 231), new Vector2(149, 264), new Vector2(155, 251), new Vector2(155, 264));
                Draw.Rectangle(new Vector2(155, 251), new Vector2(20, 13));
                Draw.Triangle(new Vector2(175, 251), new Vector2(175, 264), new Vector2(188, 264));
                //right mountain
                Draw.Rectangle(new Vector2(488, 99), new Vector2(99, 165));
                Draw.Rectangle(new Vector2(583, 132), new Vector2(17, 132));
                Draw.Quad(new Vector2(490, 132), new Vector2(490, 264), new Vector2(460, 264), new Vector2(470, 145));
                Draw.Quad(new Vector2(477, 264), new Vector2(477, 237), new Vector2(443, 264), new Vector2(450, 251));
                //cacti
                Draw.FillColor = new Color(46, 96, 33);
                //main stem A
                Draw.Rectangle(new Vector2(60, 191), new Vector2(20, 132));
                Draw.Circle(new Vector2(70, 191), 10);
                //side stems A
                //stem A
                Draw.Rectangle(new Vector2(33, 248), new Vector2(28, 20));
                Draw.Rectangle(new Vector2(33, 215), new Vector2(13, 33));
                Draw.Circle(new Vector2(40, 215), 7);
                //stem B
                Draw.Rectangle(new Vector2(79, 267), new Vector2(26, 20));
                Draw.Rectangle(new Vector2(92, 248), new Vector2(13, 33));
                Draw.Circle(new Vector2(99, 246), 7);
                //main stem B
                Draw.Rectangle(new Vector2(430, 225), new Vector2(17, 83));
                Draw.Circle(new Vector2(438.25f, 224), 8.25f);
                //side stems B
                //stem A
                Draw.Rectangle(new Vector2(414, 257), new Vector2(17, 13));
                Draw.Rectangle(new Vector2(414, 244), new Vector2(10, 13));
                Draw.Circle(new Vector2(418.45f, 244), 4.95f);
                //stem B
                Draw.Rectangle(new Vector2(447, 281), new Vector2(16, 11));
                Draw.Rectangle(new Vector2(453, 267), new Vector2(10, 15));
                Draw.Circle(new Vector2(458.05f, 267), 4.95f);
            }


        }
    }
}
