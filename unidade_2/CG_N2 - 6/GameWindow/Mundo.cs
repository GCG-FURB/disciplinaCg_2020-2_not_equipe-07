using System;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace exercicio6
{
    class Mundo: IKeyDownListener
    {

      Camera camera;

      public Mundo(Camera camera)
      {
        this.camera = camera;
        camera.SetOnKeyDownListener(this);
      }

      public void OnKeyPressed(KeyboardKeyEventArgs key)
      {
        if (Key.Number1.Equals(key.Key))
        {
          SegReta.SetPontoAtual(1);
        } 
        else if (Key.Number2.Equals(key.Key))
        {
          SegReta.SetPontoAtual(2);
        }
        else if (Key.Number3.Equals(key.Key))
        {
          SegReta.SetPontoAtual(3);
        }
        else if (Key.Number4.Equals(key.Key))
        {
          SegReta.SetPontoAtual(4);
        } 
        else if (Key.C.Equals(key.Key))
        {
          SegReta.Cima();
        }
        else if (Key.E.Equals(key.Key))
        {
          SegReta.Esquerda();
        }
        else if (Key.B.Equals(key.Key))
        {
          SegReta.Baixo();
        }
        else if (Key.D.Equals(key.Key))
        {
          SegReta.Direita();
        }
        else if (Key.Plus.Equals(key.Key))
        {
          Spline.qtdPontos++;
        }
        else if (Key.Minus.Equals(key.Key))
        {
          if (Spline.qtdPontos > 1) {
            Spline.qtdPontos--;
          }
        } 
        else if (Key.R.Equals(key.Key)) 
        {
          SegReta.Restaurar();
          Spline.qtdPontos = 10;
        }
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