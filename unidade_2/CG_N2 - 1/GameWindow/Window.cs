using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace exercicio1
{
  class Window : GameWindow
  {
    Mundo mundo = new Mundo();
    Circulo circulo = new Circulo();
    public Window(int width, int height) : base(width, height) { }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      Console.WriteLine("[2] .. OnLoad");
      GL.MatrixMode(MatrixMode.Projection);
    }

    protected override void OnUpdateFrame(FrameEventArgs e)
    {
      base.OnUpdateFrame(e);
      Console.WriteLine("[3] .. OnUpdateFrame");    

      GL.LoadIdentity();
      GL.Ortho(-300, 300, -300, 300, -1, 1);//camera  
    }
    protected override void OnRenderFrame(FrameEventArgs e)
    {
      base.OnRenderFrame(e);
      Console.WriteLine("[4] .. OnRenderFrame");

      GL.Clear(ClearBufferMask.ColorBufferBit);
      GL.ClearColor(OpenTK.Color.White);

      mundo.SRU3D();
      circulo.CriarCirculo();
      
      this.SwapBuffers();
    }

    class Program
    {
      static void Main(string[] args)
      {
        Console.WriteLine("[1] .. Main");

        Window window = new Window(400, 400);
        window.Run();
        window.Run(1.0 / 60.0);
      }
    }
  }
}
