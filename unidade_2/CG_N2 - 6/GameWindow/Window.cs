using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace exercicio6
{
  class Window : GameWindow
  {
    Camera camera;
    Mundo mundo;

    SegReta segReta = new SegReta();
    Spline spline = new Spline();
    public Window(int width, int height) : base(width, height) 
    {
      this.camera = new Camera(this);
      camera.Ortho(-400, 400, -400, 400);
      
      this.mundo = new Mundo(camera);
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
      GL.ClearColor(OpenTK.Color.Gray);

      mundo.SRU3D();
      segReta.CriarSegmentoReta();
      spline.AdicionarSpline();

      this.SwapBuffers();
    }

    class Program
    {
      static void Main(string[] args)
      {
        Console.WriteLine("[1] .. Main");

        Window window = new Window(500, 500);
        window.Run();
        window.Run(1.0 / 60.0);
      }
    }
  }
}
