using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CEControls.Display {
    public class LabelledColoredCircle : DisplayGraphic, ILabelledGraphic {
        public string Label { get; set; }
        public Color LabelColor { get; set; }

        public override void Render() {
            SolidBrush circleBrush = new SolidBrush(ForeColor);
            Graphics renderer = CreateGraphics();
            Rectangle drawingSpace = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);
            StringFormat strFormat = new StringFormat();
            strFormat.Alignment = StringAlignment.Center;
            strFormat.LineAlignment = StringAlignment.Center;
            renderer.FillEllipse(circleBrush, drawingSpace);
            circleBrush = new SolidBrush(LabelColor);
            renderer.DrawString(Label, Font, circleBrush, drawingSpace, strFormat);
            circleBrush.Dispose();
            renderer.Dispose();
        }
    }
}
