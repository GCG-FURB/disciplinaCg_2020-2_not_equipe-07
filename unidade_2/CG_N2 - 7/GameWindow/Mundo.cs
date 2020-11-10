using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using OpenTK.Input;
using System.Collections.Generic;

namespace exercicio7
{
  class Mundo : IMouseEventListener
  {
    Camera camera;
    Circulo circulo = new Circulo();
    static Ponto4D pontoInfEsquerdo = new Ponto4D(93, 93);
    static Ponto4D pontoSupDireito = new Ponto4D(307, 307);

    double lastX;
    double lastY;
    Retangulo retangulo = new Retangulo("Teste", null, pontoInfEsquerdo, pontoSupDireito);
    bool mousePressed = false;
    public Mundo(Camera camera)
    {
      this.camera = camera;
      camera.SetMouseListener(this);
    }
    public void Render()
    {
        circulo.DesenharCirculoMenor();
        circulo.DrawDragCircle();
        retangulo.Desenhar();
    }
    public void OnMouseKeyDown(MouseButtonEventArgs e)
    {

    }
    public void OnMouseKeyUp(MouseButtonEventArgs e)
    {
      this.reset();
    }
    public void OnMouseMove(MouseMoveEventArgs e)
    {
      this.mousePressed = e.Mouse.IsButtonDown(OpenTK.Input.MouseButton.Left);

      if (this.mousePressed)
      {
        double deslocX = lastX - e.X;
        double deslocY = lastY - e.Y;

        this.MoverPontoArrastavel(deslocX, deslocY);

        TrocarPosicaoPonto(e.X, e.Y);
      }
      else
      {
        TrocarPosicaoPonto(circulo.pontoCirculoArrastavel.X, circulo.pontoCirculoArrastavel.Y);
      }
    }
    public void MoverPontoArrastavel(double x, double y)
    {
      double newX = circulo.pontoCirculoArrastavel.X + x;
      double newY = circulo.pontoCirculoArrastavel.Y + y;

      UpdateDotCirclePoint(newX, newY);
    }

    private void UpdateDotCirclePoint(double x, double y)
    {
      circulo.pontoCirculoArrastavel.X = x;
      circulo.pontoCirculoArrastavel.Y = y;
    }
    public void reset()
    {
      ResetarPontoArrastavel(circulo.pontoCirculoArrastavel.X, circulo.pontoCirculoArrastavel.Y);
      ResetarPoonto(circulo.ponto.X, circulo.ponto.Y);
    }        
    private void ResetarPontoArrastavel(double x, double y)
    {
      circulo.pontoCirculoArrastavel.X = x;
      circulo.pontoCirculoArrastavel.Y = y;
    }

    private void ResetarPoonto(double x, double y)
    {
      circulo.ponto.X = x;
      circulo.ponto.Y = y;
    }
    private void TrocarPosicaoPonto(double x, double y)
    {
      this.lastX = x;
      this.lastY = y;
    }
    public void SRU3D()
    {
      Console.WriteLine("[5] .. SRU3D");
      GL.LineWidth(4);
      GL.Begin(PrimitiveType.Lines);
      GL.Color3(OpenTK.Color.Red);
      GL.Vertex3(0, 0, 0); 
      GL.Vertex3(200, 0, 0);
      GL.Color3(OpenTK.Color.Green);
      GL.Vertex3(0, 0, 0); 
      GL.Vertex3(0, 200, 0);
      GL.End();
    }
  }
}