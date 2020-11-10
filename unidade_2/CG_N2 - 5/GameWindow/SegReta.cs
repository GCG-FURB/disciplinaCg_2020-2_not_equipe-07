using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace exercicio5
{
    class SegReta
    {      
      static double angulo = 45;
      static double raio = 100;
      static Ponto4D ponto1 = Ponto4D.InstanceFrom(angulo, 0);
      static Ponto4D ponto2 = Ponto4D.InstanceFrom(angulo, raio, ponto1);
      public void CriarSegmentoReta() 
      {
        GL.LineWidth(5);
        GL.Color3(OpenTK.Color.Black);
        GL.Begin(PrimitiveType.Lines);
        GL.Vertex2(ponto1.X, ponto1.Y);
        GL.Vertex2(ponto2.X, ponto2.Y);
        GL.End();
      }
      
      public static void Esquerda() 
      {        
        SetPonto1(ponto1.X - 2, ponto1.Y);
        SetPonto2(ponto2.X - 2, ponto2.Y);
      }

      public static void Direita() {        
        SetPonto1(ponto1.X + 2, ponto1.Y);
        SetPonto2(ponto2.X + 2, ponto2.Y);
      }

      public static void DiminuirRaio() 
      {
        if (raio >= 0)
        {
          raio -= 2;
          ponto2.UpdateRaio(raio);
        }
      }

      public static void AumentarRaio() 
      {
        raio += 2;
        ponto2.UpdateRaio(raio);
      }

      public static void GirarEsquerda() 
      {
        angulo += 1;
        ponto2.UpdateAngulo(angulo);
      }

      public static void GirarDireita() 
      {
        angulo -= 1;
        ponto2.UpdateAngulo(angulo);
      }

      private static void SetPonto1(double x, double y)
      {
        ponto1.X = x;
        ponto1.Y = y;
      }
      private static void SetPonto2(Ponto4D ponto)
      {
        ponto2 = ponto;
      }
      private static void SetPonto2(double x, double y)
      {
        ponto2.X = x;
        ponto2.Y = y;
      }
    }
}