using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace exercicio4
{
  class Camera
  {
    GameWindow window;

    private double left = 0.0;
    private double right = 0.0;
    private double top = 0.0;
    private double bottom = 0.0;

    public Camera(GameWindow window)
    {
        this.window = window;
        window.KeyDown += KeyDown;
    }

    public void Ortho()
    {
        GL.Ortho(this.left, this.right, this.bottom, this.top, -1, 1);
    }

    public void Ortho(double left, double right, double bottom, double top)
    {
        this.left = left;
        this.right = right;
        this.bottom = bottom;
        this.top = top;
    }

    private void KeyDown(object sender, KeyboardKeyEventArgs e)
    {
        Console.WriteLine("KeyDown: {0} - {1}", e.Key, sender);
        switch (e.Key)
        {
          case Key.Space:
            Mundo.TrocarPrimitiva();
            break;
        }
    }
  }
}