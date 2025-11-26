// Include the namespaces (code libraries) you need below.
using System;
using team2_a4_WesternShowdown;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:

        Menu titleMenu = new Menu();
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Western ShowDown");
            Window.SetSize(800, 600);

            titleMenu.Setup();
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            titleMenu.Update();

        }
    }

}
