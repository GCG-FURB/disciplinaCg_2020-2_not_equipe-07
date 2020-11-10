using OpenTK.Graphics.OpenGL;

namespace exercicio6
{
  internal class Ponto4D
  {
    private double x;
    private double y;
    private double z;
    private double w;
    public string nomePonto; 

    public Ponto4D(double x = 0.0, double y = 0.0, double z = 0.0, string nomePonto = "")
    {
      this.X = x;
      this.Y = y;
      this.Z = z;
      this.nomePonto = nomePonto;
    }

    public double X { get => x; set => x = value; }
    public double Y { get => y; set => y = value; }
    public double Z { get => z; set => z = value; }

    public override string ToString()
    {
      return string.Format("[Ponto4D => x: {0}, y:{1}, z:{2}]", this.X, this.Y, this.Z);
    }

    public void GLVertex(OpenTK.Color color)
    {
      GL.Color3(color);
      GL.Vertex3(this.X, this.Y, this.Z);
    }
    
    public void GLVertex()
    {
      GL.Vertex3(this.X, this.Y, this.Z);
    }

  }
}