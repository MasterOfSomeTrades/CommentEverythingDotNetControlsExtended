using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CEControls.Display {
    public class Connector {// : DisplayGraphic {
        public Point p1 { get; set; }
        public Point p2 { get; set; }

        /*public override void Render() {
            Graphics renderer = CreateGraphics();

            Top = p1.Y;
            Height = p2.Y - p1.Y;
            if (p2.Y < Top) {
                Top = p2.Y;
                Height = p1.Y - p2.Y;
            }
            Left = p1.X;
            Width = p2.X - p1.X;
            if (p2.X < Left) {
                Left = p2.X;
                Width = p1.X - p2.X;
            }
            renderer.DrawLine(Pens.Black, p1, p2);
            renderer.Dispose();
        }

        public override void RenderOnCanvas() { // TEST
            throw new NotImplementedException();
        }*/
    }
}
