using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace exercicio4
{
  class Mundo
  {    
    Ponto4D pontoCentral = new Ponto4D(0, 0);
    Ponto4D pontoEsquerdo = new Ponto4D(150, 0);
    Ponto4D pontoSuperior = new Ponto4D(0, 150);
    Ponto4D pontoSuperiorEsquerdo = new Ponto4D(-200, 200);
    Ponto4D pontoSuperiorDireito = new Ponto4D(200, 200);
    Ponto4D pontoInferiorDireito = new Ponto4D(200, -200);
    Ponto4D pontoInferiorEsquerdo = new Ponto4D(-200, -200);
    private static PrimitiveType primitiva = PrimitiveType.Points;
    private static PrimitiveType[] tipos = {
      PrimitiveType.Points,
      PrimitiveType.Lines,
      PrimitiveType.LineLoop,
      PrimitiveType.LineStrip,
      PrimitiveType.Triangles,
      PrimitiveType.TriangleStrip,
      PrimitiveType.TriangleFan,
      PrimitiveType.Quads,
      PrimitiveType.QuadStrip,
      PrimitiveType.Polygon,
    };
    private static int primitivaGeometricaAtual = 0;
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
    public void DesenharPontos() {    

      GL.PointSize(5);
      GL.Begin(primitiva);
      GL.Color3(Color.LightBlue);
      pontoSuperiorEsquerdo.GLVertex();

      GL.Color3(Color.Violet);
      pontoSuperiorDireito.GLVertex();
      
      GL.Color3(Color.Black);
      pontoInferiorDireito.GLVertex();
      
      GL.Color3(Color.Yellow);
      pontoInferiorEsquerdo.GLVertex();
      GL.End();

    } 

    public static void TrocarPrimitiva()
    {
      primitivaGeometricaAtual++;

      if (primitivaGeometricaAtual >= tipos.Length)
      {
        primitivaGeometricaAtual = 0;
      }

      primitiva = tipos[primitivaGeometricaAtual];
    }
  }
}