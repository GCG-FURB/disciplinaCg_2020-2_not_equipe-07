using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace exercicio2
{
  class Window : GameWindow
  {
    Camera camera;
     Mundo mundo = new Mundo();
     Circulo circulo = new Circulo();
    public Window(int width, int height) : base(width, height) 
    {
       this.camera = new Camera(this);
      camera.Ortho(-300, 300, -300, 300); //camera  
    }

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
      camera.Ortho();
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
