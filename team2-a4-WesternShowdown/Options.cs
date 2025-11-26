using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace team2_a4_WesternShowdown
{
    public class Options
    {
        Vector2 position;
        Vector2 size;

        public Options(Vector2 position, Vector2 size)
        {
            this.position = position;
            this.size = size;   
          
        }

        public void Update()
        {
            options();
        }

        public void options()
        {
            Draw.LineSize = 5;
            Draw.LineColor = Color.Gray;
            Draw.FillColor = Color.Clear;
            Draw.Rectangle(position,size);


        }


        public bool Click()
        {
            Vector2 mousePos = Input.GetMousePosition();

            if (mousePos.X >= position.X && mousePos.X <= position.X + 135 && mousePos.Y >= position.Y && mousePos.Y <= position.Y + 50)
            {
                if (Input.IsMouseButtonPressed(MouseInput.Left))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
    }
}
