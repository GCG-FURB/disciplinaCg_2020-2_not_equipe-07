using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace exercicio3
{
  class SegReta
  {    
    public Ponto4D pontoSuperior = new Ponto4D(0, 100);
    public Ponto4D pontoInferiorEsquerdo = new Ponto4D(-100, -100);
    public Ponto4D pontoInferiorDireito = new Ponto4D(100, -100);

    public void CriarTriangulo() {
      GL.Color3(Color.LightBlue);
      GL.Begin(PrimitiveType.Lines);
      pontoSuperior.GLVertex();
      pontoInferiorEsquerdo.GLVertex();
      // Linha da esquerda a direita - inferior
      pontoInferiorEsquerdo.GLVertex();
      pontoInferiorDireito.GLVertex();
      // Linha da direita para cima
      pontoInferiorDireito.GLVertex();
      pontoSuperior.GLVertex();
      GL.End();
    }
  }
}