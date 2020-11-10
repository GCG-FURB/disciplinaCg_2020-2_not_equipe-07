using OpenTK.Graphics.OpenGL;

namespace exercicio7
{
  public class Ponto4D
  {
    private double x;
    private double y;
    private double z;
    private readonly double w;

    public Ponto4D(double x = 0.0, double y = 0.0, double z = 0.0, double w = 1.0)
    {
      this.x = x;
      this.y = y;
      this.z = z;
      this.w = w;
    }
    public Ponto4D(Ponto4D pto)
    {
      this.x = pto.x;
      this.y = pto.y;
      this.z = pto.z;
    }
    public static Ponto4D operator +(Ponto4D pto1, Ponto4D pto2) => new Ponto4D(pto1.X + pto2.X, pto1.Y + pto2.Y, pto1.Z + pto2.Z);
    public double X { get => x; set => x = value; }
    public double Y { get => y; set => y = value; }
    public double Z { get => z; set => z = value; }
    public double W { get => w; }

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