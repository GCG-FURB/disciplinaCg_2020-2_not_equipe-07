using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace exercicio2
{
    class Circulo
    {
      public void CriarCirculo() {
        Console.WriteLine("[6] .. Círculo");

        int raio = 100;
        int anguloParte = 5;
        int quantidadePontos = 72;

        GL.PointSize(anguloParte); // 360 / 2 para obter 72 pontos
        GL.Color3(Color.Yellow);
        GL.Begin(PrimitiveType.Points);
        for (int i = 0; i < quantidadePontos; i++) {
          double angulo = Math.PI * i * anguloParte / 180;
          GL.Vertex2(raio*Math.Cos(angulo), raio*Math.Sin(angulo));
        }
        GL.End();
      }
    }
}