
using System;
using System.ComponentModel.Design;
using System.Numerics;


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
        public void Setup()
        {
            Window.SetSize(600, 400);
            Window.SetTitle("Western Showdown");
            Window.ClearBackground(Color.White);
        }

        public void Duel()
        {

            Text.Draw("Ready...", new Vector2(250, 180));
            if (timeElapsed - timeReset >= drawDelay)
            {
                Window.ClearBackground(Color.White);
                Score();
                Text.Draw("Draw!", new Vector2(300, 200));

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
                    Text.Draw("Up", new Vector2(400, 300));
                }
                else if (player2Input == 2)
                {
                    Text.Draw("Left", new Vector2(400, 300));
                }
                else if (player2Input == 3)
                {
                    Text.Draw("Down", new Vector2(400, 300));
                }
                else if (player2Input == 4)
                {
                    Text.Draw("Right", new Vector2(400, 300));
                }

                if (Input.IsKeyboardKeyPressed(KeyboardInput.W) && player1Input == 1)
                {
                    Window.ClearBackground(Color.White);
                    Text.Draw("Player 1 Shot Player 2!", new Vector2(125, 150));
                    Text.Draw("Player 1 Scores!", new Vector2(135, 190));
                    player1Score++;
                    Score();
                    resetDuel();
                }
                else if (Input.IsKeyboardKeyPressed(KeyboardInput.W) && player1Input != 1)
                {
                    Window.ClearBackground(Color.White);
                    Text.Draw("Player 1 Fumbled!", new Vector2(150, 150));
                    Text.Draw("Player 2 Scores!", new Vector2(150, 190));
                    player2Score++;
                    Score();
                    resetDuel();
                }
                else if (Input.IsKeyboardKeyPressed(KeyboardInput.A) && player1Input == 2)
                {
                    Window.ClearBackground(Color.White);
                    Text.Draw("Player 1 Shot Player 2!", new Vector2(125, 150));
                    Text.Draw("Player 1 Scores!", new Vector2(135, 190));
                    player1Score++;
                    Score();
                    resetDuel();
                }
                else if (Input.IsKeyboardKeyPressed(KeyboardInput.A) && player1Input != 2)
                {
                    Window.ClearBackground(Color.White);
                    Text.Draw("Player 1 Fumbled!", new Vector2(150, 150));
                    Text.Draw("Player 2 Scores!", new Vector2(150, 190));
                    player2Score++;
                    Score();
                    resetDuel();
                }

                else if (Input.IsKeyboardKeyPressed(KeyboardInput.S) && player1Input == 3)
                {
                    Window.ClearBackground(Color.White);
                    Text.Draw("Player 1 Shot Player 2!", new Vector2(125, 150));
                    Text.Draw("Player 1 Scores!", new Vector2(135, 190));
                    player1Score++;
                    Score();
                    resetDuel();

                }
                else if (Input.IsKeyboardKeyPressed(KeyboardInput.S) && player1Input != 3)
                {
                    Window.ClearBackground(Color.White);
                    Text.Draw("Player 1 Fumbled!", new Vector2(150, 150));
                    Text.Draw("Player 2 Scores!", new Vector2(150, 190));
                    player2Score++;
                    Score();
                    resetDuel();
                }

                else if (Input.IsKeyboardKeyPressed(KeyboardInput.D) && player1Input == 4)
                {
                    Window.ClearBackground(Color.White);
                    Text.Draw("Player 1 Shot Player 2!", new Vector2(125, 150));
                    Text.Draw("Player 1 Scores!", new Vector2(135, 190));
                    player1Score++;
                    Score();
                    resetDuel();
                }
                else if (Input.IsKeyboardKeyPressed(KeyboardInput.D) && player1Input != 4)
                {
                    Window.ClearBackground(Color.White);
                    Text.Draw("Player 1 Fumbled!", new Vector2(150, 150));
                    Text.Draw("Player 2 Scores!", new Vector2(150, 190));
                    player2Score++;
                    Score();
                    resetDuel();
                }
                else if (Input.IsKeyboardKeyPressed(KeyboardInput.Up) && player2Input == 1)
                {
                    Window.ClearBackground(Color.White);
                    Text.Draw("Player 2 Shot Player 1!", new Vector2(125, 150));
                    Text.Draw("Player 2 Scores!", new Vector2(135, 190));
                    player2Score++;
                    Score();
                    resetDuel();
                }
                else if (Input.IsKeyboardKeyPressed(KeyboardInput.Up) && player2Input != 1)
                {
                    Window.ClearBackground(Color.White);
                    Text.Draw("Player 2 Fumbled!", new Vector2(150, 150));
                    Text.Draw("Player 1 Scores!", new Vector2(150, 190));
                    player1Score++;
                    Score();
                    resetDuel();
                }
                else if (Input.IsKeyboardKeyPressed(KeyboardInput.Left) && player2Input == 2)
                {
                    Window.ClearBackground(Color.White);
                    Text.Draw("Player 2 Shot Player 1!", new Vector2(125, 150));
                    Text.Draw("Player 2 Scores!", new Vector2(135, 190));
                    player2Score++;
                    Score();
                    resetDuel();
                }
                else if (Input.IsKeyboardKeyPressed(KeyboardInput.Left) && player2Input != 2)
                {
                    Window.ClearBackground(Color.White);
                    Text.Draw("Player 2 Fumbled!", new Vector2(150, 150));
                    Text.Draw("Player 1 Scores!", new Vector2(150, 190));
                    player1Score++;
                    Score();
                    resetDuel();
                }
                else if (Input.IsKeyboardKeyPressed(KeyboardInput.Down) && player2Input == 3)
                {
                    Window.ClearBackground(Color.White);
                    Text.Draw("Player 2 Shot Player 1!", new Vector2(125, 150));
                    Text.Draw("Player 2 Scores!", new Vector2(135, 190));
                    player2Score++;
                    Score();
                    resetDuel();
                }
                else if (Input.IsKeyboardKeyPressed(KeyboardInput.Down) && player2Input != 3)
                {
                    Window.ClearBackground(Color.White);
                    Text.Draw("Player 2 Fumbled!", new Vector2(150, 150));
                    Text.Draw("Player 1 Scores!", new Vector2(150, 190));
                    player1Score++;
                    Score();
                    resetDuel();
                }
                else if (Input.IsKeyboardKeyPressed(KeyboardInput.Right) && player2Input == 4)
                {
                    Window.ClearBackground(Color.White);
                    Text.Draw("Player 2 Shot Player 1!", new Vector2(125, 150));
                    Text.Draw("Player 2 Scores!", new Vector2(135, 190));
                    player2Score++;
                    Score();
                    resetDuel();
                }
                else if (Input.IsKeyboardKeyPressed(KeyboardInput.Right) && player2Input != 4)
                {
                    Window.ClearBackground(Color.White);
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
            Text.Draw("Press Space to initiate", new Vector2(100, 300));
            Text.Draw("the next duel!", new Vector2(150, 350));
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
            Text.Draw("Player 1 Score: " + player1Score, new Vector2(10, 10));
            Text.Draw("Player 2 Score: " + player2Score, new Vector2(10, 45));
        }
        public void Update()
        {
            timeElapsed = Time.SecondsElapsed;
            Score();
            if (player1Score >= 5)
            {
                Window.ClearBackground(Color.White);
                Score();
                Text.Draw("Player 1 is the westiest", new Vector2(10, 200));
                Text.Draw("in the west!!", new Vector2(10, 250));
                duelMatch = -1;
            }
            else if (player2Score >= 5)
            {
                Window.ClearBackground(Color.White);
                Score();
                Text.Draw("Player 2 is the westiest", new Vector2(10, 200));
                Text.Draw("in the west!!", new Vector2(10, 250));
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
}
