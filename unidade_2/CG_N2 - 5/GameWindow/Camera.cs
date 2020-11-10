using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace exercicio5
{
  class Camera
  {
    GameWindow window;

    private double left = 0.0;
    private double right = 0.0;
    private double top = 0.0;
    private double bottom = 0.0;
    private double pan = 1.0;
    private IKeyDownListener keyDownListener;

    public Camera(GameWindow window)
    {
        this.window = window;
        window.KeyDown += OnKeyDown;
    }

    public void SetOnKeyDownListener(IKeyDownListener listener)
    {
        this.keyDownListener = listener;
    }
    private void OnKeyDown(object sender, KeyboardKeyEventArgs e)
    {
      if (this.keyDownListener != null)
          this.keyDownListener.OnKeyPressed(e);
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
  }
}