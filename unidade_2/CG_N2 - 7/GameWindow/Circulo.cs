using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace exercicio7
{
  class Circulo
  {

    private int mainRaio = 150;
    private int dragRaio = 50;
    public Ponto4D pontoCirculoArrastavel = new Ponto4D(200, 200);
    public Ponto4D ponto = new Ponto4D(200, 200);
    public Circulo() {
    }
    public void DesenharCirculoMenor()
    {
      GL.LineWidth(3);
      this.DesenharCirculo(200, 200, this.mainRaio);
    }
    public void DrawDragCircle()
    {
      GL.LineWidth(2);
      this.DesenharCirculo(this.pontoCirculoArrastavel.X, this.pontoCirculoArrastavel.Y, this.dragRaio);
      this.DesenharCirculoArrastavel();

    }
    public void DesenharCirculoArrastavel()
    {
      GL.PointSize(5);
      GL.Begin(PrimitiveType.Points);
      pontoCirculoArrastavel.GLVertex();
      GL.End();
    }
    private void DesenharCirculo(double centerX, double centerY, int raio)
    {
      int pontos = 360;

      double anguloParte = 360 / pontos;
      GL.Color3(Color.Black);
      GL.PointSize(2);
      GL.Begin(PrimitiveType.Points);
      for (int i = 0; i <= 360; i++)
      {
          Ponto4D pto = ptoCirculo(anguloParte * i, raio);
          GL.Vertex2(centerX + pto.X, centerY + pto.Y);
      }
      GL.End();
    }
    public Ponto4D ptoCirculo(double angulo, double raio)
    {
      Ponto4D pto = new Ponto4D();
      pto.X = (raio * Math.Cos(Math.PI * angulo / 180.0));
      pto.Y = (raio * Math.Sin(Math.PI * angulo / 180.0));
      pto.Z = 0;
      return (pto);
    }
  }
}