using OpenTK.Graphics.OpenGL;

namespace exercicio6
{
    class SegReta
    {
      static string NOME_PONTO_1 = "1";
      static string NOME_PONTO_2 = "2";
      static string NOME_PONTO_3 = "3";
      static string NOME_PONTO_4 = "4";
      public static Ponto4D ponto1 = new Ponto4D(-100, 100, 0, NOME_PONTO_1);
      public static Ponto4D ponto2 = new Ponto4D(-100, -100, 0, NOME_PONTO_2);
      
      public static Ponto4D ponto3 = new Ponto4D(100, -100, 0, NOME_PONTO_3);
      public static Ponto4D ponto4 = new Ponto4D(100, 100, 0, NOME_PONTO_4);

      static Ponto4D pontoAtual;
      private static double pan = 1.0;

      public SegReta () {
        pontoAtual = ponto1;
      }

      public void CriarSegmentoReta() 
      {
        AdicionarPontos(pontoAtual);

        GL.LineWidth(3);        
        GL.Color3(OpenTK.Color.Cyan);
        GL.Begin(PrimitiveType.Lines);
        GL.Vertex2(ponto1.X, ponto1.Y);
        GL.Vertex2(ponto2.X, ponto2.Y);

        GL.Vertex2(ponto1.X, ponto1.Y);
        GL.Vertex2(ponto4.X, ponto4.Y);

        GL.Vertex2(ponto4.X, ponto4.Y);
        GL.Vertex2(ponto3.X, ponto3.Y);
        GL.End();
      }

      private void AdicionarPontos(Ponto4D pontoAtual) 
      {
        GL.PointSize(10); 
        GL.Color3(OpenTK.Color.Red);
        GL.Begin(PrimitiveType.Points);
        if (pontoAtual.nomePonto.Equals(NOME_PONTO_1)) {
          GL.Vertex2(ponto1.X, ponto1.Y);
        } 
        else if (pontoAtual.nomePonto.Equals(NOME_PONTO_2)) 
        {
          GL.Vertex2(ponto2.X, ponto2.Y);
        } 
        else if (pontoAtual.nomePonto.Equals(NOME_PONTO_3)) 
        {
          GL.Vertex2(ponto3.X, ponto3.Y);
        } 
        else if (pontoAtual.nomePonto.Equals(NOME_PONTO_4)) 
        {
          GL.Vertex2(ponto4.X, ponto4.Y);
        }
        GL.End();
        
        GL.Color3(OpenTK.Color.Black);
        GL.Begin(PrimitiveType.Points);        
        if (pontoAtual.nomePonto.Equals(NOME_PONTO_1)) {
          GL.Vertex2(ponto2.X, ponto2.Y);
          GL.Vertex2(ponto3.X, ponto3.Y);
          GL.Vertex2(ponto4.X, ponto4.Y);
        } 
        else if (pontoAtual.nomePonto.Equals(NOME_PONTO_2)) 
        {
          GL.Vertex2(ponto1.X, ponto1.Y);
          GL.Vertex2(ponto3.X, ponto3.Y);
          GL.Vertex2(ponto4.X, ponto4.Y);
        } 
        else if (pontoAtual.nomePonto.Equals(NOME_PONTO_3)) 
        {
          GL.Vertex2(ponto1.X, ponto1.Y);
          GL.Vertex2(ponto2.X, ponto2.Y);
          GL.Vertex2(ponto4.X, ponto4.Y);
        } 
        else if (pontoAtual.nomePonto.Equals(NOME_PONTO_4)) 
        {
          GL.Vertex2(ponto1.X, ponto1.Y);
          GL.Vertex2(ponto2.X, ponto2.Y);
          GL.Vertex2(ponto3.X, ponto3.Y);
        }
        GL.End();
      }

      public static void SetPontoAtual(int numeroPonto) 
      {
        if (numeroPonto == 1) 
        {
          pontoAtual = ponto1;

        } else if (numeroPonto == 2) 
        {
          pontoAtual = ponto2;
        } else if (numeroPonto == 3) 
        {
          pontoAtual = ponto3;
        } else if (numeroPonto == 4) 
        {
          pontoAtual = ponto4;
        }
      }
      public static void Esquerda() 
      {
        pontoAtual.X = pontoAtual.X - pan;
      }

      public static void Direita() 
      {
        pontoAtual.X = pontoAtual.X + pan;
      }

      public static void Cima()
      {
        pontoAtual.Y = pontoAtual.Y + pan;
      }

      public static void Baixo()
      {
        pontoAtual.Y = pontoAtual.Y - pan;
      }

      public static void Restaurar() 
      {
        ponto1.X = -100;
        ponto1.Y = 100;

        ponto2.X = -100;
        ponto2.Y = -100;

        ponto3.X = 100;
        ponto3.Y = -100;

        ponto4.X = 100;
        ponto4.Y = 100;

        pontoAtual = ponto1;
      }
    }
}