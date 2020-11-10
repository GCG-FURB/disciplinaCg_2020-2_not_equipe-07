using System;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace exercicio5
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
        if (Key.Q.Equals(key.Key))
        {
          SegReta.Esquerda();
        } else if (Key.W.Equals(key.Key)) {
          SegReta.Direita();
        } else if (Key.A.Equals(key.Key))
        {
          SegReta.DiminuirRaio();
        } else if (Key.S.Equals(key.Key))
        {
          SegReta.AumentarRaio();
        } else if (Key.Z.Equals(key.Key))
        {
          SegReta.GirarEsquerda();
        } else if (Key.X.Equals(key.Key))
        {
          SegReta.GirarDireita();
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