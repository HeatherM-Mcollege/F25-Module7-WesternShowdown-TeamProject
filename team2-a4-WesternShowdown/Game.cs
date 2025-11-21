using System;
using System.Numerics;


namespace MohawkGame2D
{

    public class Game
    {


        public void Setup()
        {
            Window.SetSize(600, 400);
            Window.SetTitle("Western Showdown");
            Window.ClearBackground(Color.White);
        }


        public void Update()
        {
            for (int i = 0; i < 15; i++)
            {
                float timeStart = Time.SecondsElapsed;
                float timeDelay = Random.Float(3, 1000);
                float timePassed = Time.SecondsElapsed;
                if (timePassed - timeStart > timeDelay)
                {
                    //After a time delay, a random number is selected to determine what key Player 1 has to press
                    int player1Input = Random.Integer(1, 5);
                    if (player1Input == 1)
                    {
                        //W
                        Draw.FillColor = Color.Red;
                        Draw.Rectangle(50, 50, 100, 100);
                    }
                    else if (player1Input == 2)
                    {
                        //A
                        Draw.FillColor = Color.Blue;
                        Draw.Rectangle(50, 50, 100, 100);
                    }
                    else if (player1Input == 3)
                    {
                        //S
                        Draw.FillColor = Color.Green;
                        Draw.Rectangle(50, 50, 100, 100);
                    }
                    else if (player1Input == 4)
                    {
                        //D
                        Draw.FillColor = Color.Yellow;
                        Draw.Rectangle(50, 50, 100, 100);
                    }



                    //Player 2 Random Key
                    int player2Input = Random.Integer(1, 5);
                    if (player2Input == 1)
                        {
                        //Up Arrow
                        Draw.FillColor = Color.Red;
                        Draw.Rectangle(450, 50, 100, 100);
                    }
                    else if (player2Input == 2)
                    {
                        //Left Arrow
                        Draw.FillColor = Color.Blue;
                        Draw.Rectangle(450, 50, 100, 100);
                    }
                    else if (player2Input == 3)
                    {
                        //Down Arrow
                        Draw.FillColor = Color.Green;
                        Draw.Rectangle(450, 50, 100, 100);
                    }
                    else if (player2Input == 4)
                    {
                        //Right Arrow
                        Draw.FillColor = Color.Yellow;
                        Draw.Rectangle(450, 50, 100, 100);
                    }
                }
                else
                { }
            }
        }
    }

}
