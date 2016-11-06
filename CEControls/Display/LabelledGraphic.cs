using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CEControls.Display {
    public abstract class LabelledGraphic {
        string Label { get; set; }
        Color LabelColor { get; set; } = Color.Black;

        protected void Render(Control canvas, int drawingAreaLeft, int drawingAreaTop, int drawingAreaWidth, int drawingAreaHeight) {

        }
    }
}
