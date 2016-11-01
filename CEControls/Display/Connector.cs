using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CEControls.Display {
    class Connector : DisplayGraphic {
        public Point p1 { get; set; }
        public Point p2 { get; set; }

        public override void Render() {
            Graphics renderer = CreateGraphics();

            renderer.DrawLine(Pens.Black, p1, p2);
            renderer.Dispose();
        }
    }
}
