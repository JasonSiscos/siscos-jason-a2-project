// Include the namespaces (code libraries) you need below.
using System;
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

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Gray);

            Draw.FillColor = Color.White;
            for (int i = 0; i < 5; i++)
            {
                Draw.FillColor = Color.Red;
                Draw.Circle(i * 40, i * 40, 5);

                Draw.FillColor = Color.Green;
                Draw.Circle(i * 40 + 10, i * 40 + 10, 5);
            }

            for (int i = 0; i < 5; i++)
            {
                Draw.FillColor = Color.Red;
                Draw.Square(i * 40 + 60, i * 40 + 60, 5);

                Draw.FillColor = Color.Green;
                Draw.Square(i * 40 + 80, i * 40 + 80, 5);
            }

            DrawEye(20);
            DrawEye(120);



            //Draw Mouth
            Draw.FillColor = Color.White;
            if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
            {
                Draw.FillColor = Color.Yellow;
            }
            Draw.Rectangle(90, 60, 100, 20);
        }

        public void DrawEye(int x)
        {
            Draw.FillColor = Color.White;
            Draw.Rectangle(x, 20, 50, 20);
            Draw.FillColor = Color.Blue;
            Draw.Circle(x + 25, 20, 10);

        }
    }

}
