using OpenTK.Graphics.OpenGL;
using System;

namespace exercicio6
{
    class Spline
    {
      Ponto4D ponto1 = SegReta.ponto1;
      Ponto4D ponto2 = SegReta.ponto2;
      Ponto4D ponto3 = SegReta.ponto3;
      Ponto4D ponto4 = SegReta.ponto4;
      public static double qtdPontos = 10;

      public void AdicionarSpline() {
        GL.LineWidth(5);
        GL.Color3(OpenTK.Color.Yellow);
        GL.Begin(PrimitiveType.Lines);
        Ponto4D POld = ponto2;
        double num = Math.Truncate(100 * (1.0 / qtdPontos)) / 100;
        double t = 0;
        for (int i = 0; i < qtdPontos; i++) {
          t += (1.0 / qtdPontos);
          Ponto4D p = Bezier(ponto2, ponto1, ponto4, ponto3, t);

          GL.Vertex2(POld.X, POld.Y);
          GL.Vertex2(p.X, p.Y);
          POld = p;
        }
        GL.End();
      }
      
      Ponto4D Bezier(Ponto4D A, Ponto4D B, Ponto4D C, Ponto4D D, double t) {
        Ponto4D P = new Ponto4D();  
     
        P.X = Math.Pow((1 - t), 3) * A.X + 3 * t * Math.Pow((1 -t), 2) * B.X + 3 * (1-t) * Math.Pow(t, 2)* C.X + Math.Pow(t, 3)* D.X;
        P.Y = Math.Pow((1 - t), 3) * A.Y + 3 * t * Math.Pow((1 -t), 2) * B.Y + 3 * (1-t) * Math.Pow(t, 2)* C.Y + Math.Pow(t, 3)* D.Y;
    
        return P;
      }
    }
}