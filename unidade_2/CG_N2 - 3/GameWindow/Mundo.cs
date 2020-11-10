using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace exercicio3
{
  class Mundo
  {
    Ponto4D pontoCentral = new Ponto4D(0, 0);
    Ponto4D pontoEsquerdo = new Ponto4D(150, 0);
    Ponto4D pontoSuperior = new Ponto4D(0, 150);
    public void SRU3D()
    {
      Console.WriteLine("[5] .. SRU3D");
      GL.LineWidth(4);
      GL.Begin(PrimitiveType.Lines);
      GL.Color3(Color.Red);
      pontoCentral.GLVertex();
      pontoEsquerdo.GLVertex();
      GL.Color3(Color.Green);
      pontoCentral.GLVertex();
      pontoSuperior.GLVertex();
      GL.End();
    }
  }
}