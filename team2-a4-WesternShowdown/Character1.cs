using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace team2_a4_WesternShowdown
{
    internal class Character1
    {
        public Vector2 character1Pos;

        public Texture2D character1Neutral;
        public Texture2D character1Shooting;

        public Character1(Vector2 character1Pos)
        {
            this.character1Pos = character1Pos;
        }

        public void Setup()
        {
            character1Neutral = Graphics.LoadTexture("../../../Assets/Graphics/Character Graphics/Cowboy1Neutral.png");
            character1Shooting = Graphics.LoadTexture("../../../Assets/Graphics/Character Graphics/Cowboy1Shooting.png");
        }

        public void Update()
        {
            DrawCharacter1(character1Pos);
        }

        public void DrawCharacter1(Vector2 character1Pos)
        {
            if (Input.IsKeyboardKeyDown(KeyboardInput.Left) | Input.IsKeyboardKeyDown(KeyboardInput.Up) | Input.IsKeyboardKeyDown(KeyboardInput.Down) | Input.IsKeyboardKeyDown(KeyboardInput.Right))
            {
                Graphics.Draw(character1Shooting, character1Pos);
            }
            else 
            {
                Graphics.Draw(character1Neutral, character1Pos);
            }
        }

    }
}
