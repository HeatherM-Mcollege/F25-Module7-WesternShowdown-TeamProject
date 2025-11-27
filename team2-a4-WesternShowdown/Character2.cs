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
    internal class Character2
    {
        public Vector2 character2Pos;

        public Texture2D character2Neutral;
        public Texture2D character2Shooting;

        public Character2(Vector2 character2Pos)
        {
            this.character2Pos = character2Pos;
        }

        public void Setup()
        {
            character2Neutral = Graphics.LoadTexture("../../../Assets/Graphics/Character Graphics/Cowboy2Neutral.png");
            character2Shooting = Graphics.LoadTexture("../../../Assets/Graphics/Character Graphics/Cowboy2Shooting.png");
        }

        public void Update()
        {
            DrawCharacter2(character2Pos);
        }

        public void DrawCharacter2(Vector2 character2Pos)
        {
            Graphics.Draw(character2Neutral, character2Pos);
        }

    }
}
