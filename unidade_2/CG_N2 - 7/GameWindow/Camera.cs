using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace exercicio7
{
  class Camera
  {
    GameWindow window;

    private double left = 0.0;
    private double right = 0.0;
    private double top = 0.0;
    private double bottom = 0.0;
    private IMouseEventListener mouseListener;

    public Camera(GameWindow window)
    {
        this.window = window;
    }

    public void SetMouseListener(IMouseEventListener listener)
    {
        this.mouseListener = listener;
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

    public void OnMouseDown(MouseButtonEventArgs e)
    {
      if (this.mouseListener != null)
          this.mouseListener.OnMouseKeyDown(e);
    }

    public void OnMouseUp(MouseButtonEventArgs e)
    {
      if (this.mouseListener != null)
          this.mouseListener.OnMouseKeyUp(e);
    }

    public void OnMouseMove(MouseMoveEventArgs e)
    {
      if (this.mouseListener != null)
          this.mouseListener.OnMouseMove(e);
    }
  }
}