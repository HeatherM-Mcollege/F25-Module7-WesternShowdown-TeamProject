using System;
using System.Numerics;
using team2_a4_WesternShowdown;

namespace MohawkGame2D
{
    public class Game
    {
        // Place your variables here:

        Character1 character1 = new Character1(new Vector2(550, 275));
        Character2 character2 = new Character2(new Vector2(0, 275));

        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Testing Neutral Position");

            character1.Setup();
            character2.Setup();
        }

        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            character1.Update();
            character2.Update();
        }
    }

}
