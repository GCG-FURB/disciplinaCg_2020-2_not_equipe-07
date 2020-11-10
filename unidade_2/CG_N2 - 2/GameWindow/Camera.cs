using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace exercicio2
{
    class Camera
    {
        GameWindow window;

        private double left = 0.0;
        private double right = 0.0;
        private double top = 0.0;
        private double bottom = 0.0;

        private double pan = 1.0;
        private double zoom = 0.9;

        private int maxZoom = 15;
        private double actualZoom = 7;

        public Camera(GameWindow window)
        {
            this.window = window;
            window.KeyDown += KeyDown;
        }

        public void Ortho()
        {
            GL.Ortho(this.left, this.right, this.bottom, this.top, -1, 1);
        }

        public void Ortho(double left, double right, double bottom, double top)
        {
            this.left = left;
            this.right = right;
            this.bottom = bottom;
            this.top = top;
        }

        private void KeyDown(object sender, KeyboardKeyEventArgs e)
        {
            Console.WriteLine("KeyDown: {0} - {1}", e.Key, sender);
            switch (e.Key)
            {
              case Key.E:
                Esquerda();
                break;
              case Key.D:
                Direita();
                break;
              case Key.C:
                Cima();
                break;
              case Key.B:
                Baixo();
                break;
              case Key.I:
                if (actualZoom < maxZoom) {
                  ZoomIn();
                }
                break;
              case Key.O:
                if (actualZoom > 0) {
                  ZoomOut();
                }
                break;
            }
        }

        private void Esquerda() 
        {
            this.right = this.right + pan;
            this.left = this.left + pan;
        }

        private void Direita() 
        {
          this.right = this.right - pan;
          this.left = this.left - pan;
        }

        private void Cima()
        {
          this.top = this.top - pan;
          this.bottom = this.bottom - pan;
        }

        private void Baixo()
        {
          this.top = this.top + pan;
          this.bottom = this.bottom + pan;
        }

        private void ZoomIn()
        {
            this.top = this.top * zoom;
            this.bottom = this.bottom * zoom;
            this.right = this.right * zoom;
            this.left = this.left * zoom;
            this.actualZoom++;
        }

        private void ZoomOut()
        {
            this.top = this.top / zoom;
            this.bottom = this.bottom / zoom;
            this.right = this.right / zoom;
            this.left = this.left / zoom;
            this.actualZoom--;
        }

    }
}