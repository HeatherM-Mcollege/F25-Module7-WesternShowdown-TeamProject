// Include the namespaces (code libraries) you need below.
using System;
using System.Diagnostics;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(800, 600);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            drawBackground();
        }
        public void drawBackground()
        {
            //sand
            Window.ClearBackground(new Color(194, 178, 128));
            //sky
            Draw.LineSize = 0;
            Draw.FillColor = new Color(50, 135, 168);
            Draw.Rectangle(new Vector2(0, 0), new Vector2(800, 50));
            Draw.FillColor = new Color(30, 185, 199);
            Draw.Rectangle(new Vector2(0, 50), new Vector2(800, 50));
            Draw.FillColor = new Color(255, 192, 180);
            Draw.Rectangle(new Vector2(0, 100), new Vector2(800, 100));
            Draw.FillColor = new Color(225, 165, 0);
            Draw.Rectangle(new Vector2(0, 200), new Vector2(800, 100));
            //sun
            Draw.FillColor = Color.Yellow;
            Draw.Circle(new Vector2(200, 80), 30);
            //back mountain
            Draw.FillColor = new Color(43, 18, 1);
            Draw.Rectangle(new Vector2(0, 275), new Vector2(800, 25));
            Draw.Rectangle(new Vector2(200, 265), new Vector2(300, 10));
            Draw.Quad(new Vector2(250, 265), new Vector2(270, 245), new Vector2(370, 245), new Vector2(390, 265));
            Draw.Quad(new Vector2(440, 265), new Vector2(450, 250), new Vector2(470, 245), new Vector2(470, 265));
            Draw.Rectangle(new Vector2(470, 200), new Vector2(75, 100));
            Draw.Quad(new Vector2(545, 230), new Vector2(545, 300), new Vector2(645, 300), new Vector2(645, 260));

            //front mountains
            Draw.FillColor = new Color(89, 37, 3);
            //left mountain
            Draw.Rectangle(new Vector2(0, 100), new Vector2(100, 300));
            Draw.Rectangle(new Vector2(100, 150), new Vector2(25, 250));
            Draw.Rectangle(new Vector2(125, 250), new Vector2(25, 150));
            Draw.Rectangle(new Vector2(150, 290), new Vector2(10, 110));
            Draw.Quad(new Vector2(160, 290), new Vector2(150, 400), new Vector2(195, 400), new Vector2(195, 350));
            Draw.Rectangle(new Vector2(195, 350), new Vector2(30, 50));
            Draw.Quad(new Vector2(225, 350), new Vector2(225, 400), new Vector2(235, 380), new Vector2(235, 400));
            Draw.Rectangle(new Vector2(235, 380), new Vector2(30, 20));
            Draw.Triangle(new Vector2(265, 380), new Vector2(265, 400), new Vector2(285, 400));
            //right mountain
            Draw.Rectangle(new Vector2(625, 150), new Vector2(150, 250));
            Draw.Rectangle(new Vector2(775, 200), new Vector2(25, 200));
            Draw.Quad(new Vector2(625, 200), new Vector2(625, 400), new Vector2(575, 400), new Vector2(595, 220));
            Draw.Quad(new Vector2(595, 250), new Vector2(625, 400), new Vector2(525, 400), new Vector2(525, 340));
            Draw.Quad(new Vector2(525, 400), new Vector2(525, 360), new Vector2(475, 400), new Vector2(485, 380));
            //cacti
            Draw.FillColor = new Color(46, 96, 33);
            //main stem A
            Draw.Rectangle(new Vector2(90, 290), new Vector2(30, 200));
            Draw.Circle(new Vector2(105, 290), 15);
            //side stems A
            //stem A
            Draw.Rectangle(new Vector2(50, 375), new Vector2(40, 30));
            Draw.Rectangle(new Vector2(50, 325), new Vector2(20, 50));
            Draw.Circle(new Vector2(60, 325), 10);
            //stem B
            Draw.Rectangle(new Vector2(120, 405), new Vector2(40, 30));
            Draw.Rectangle(new Vector2(140, 375), new Vector2(20, 50));
            Draw.Circle(new Vector2(150, 375), 10);
            //main stem B
            Draw.Rectangle(new Vector2(500, 340), new Vector2(25, 125));
            Draw.Circle(new Vector2(512.5f, 340), 12.5f);
            //side stems B
            //stem A
            Draw.Rectangle(new Vector2(475, 390), new Vector2(25, 20));
            Draw.Rectangle(new Vector2(475, 370), new Vector2(15, 20));
            Draw.Circle(new Vector2(482.5f, 370), 7.5f);
            //stem B
            Draw.Rectangle(new Vector2(525, 425), new Vector2(25, 20));
            Draw.Rectangle(new Vector2(535, 405), new Vector2(15, 20));
            Draw.Circle(new Vector2(542.5f, 405), 7.5f);
        }
    }
}
