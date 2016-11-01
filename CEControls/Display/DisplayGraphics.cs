using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CEControls.Display {
    public class DisplayGraphics {
        private Control _canvas;

        private DisplayGraphics() {
            // --- Must call constructor that defines a Control as the canvas
        }

        public DisplayGraphics(Control canvas) {
            _canvas = canvas;
        }

        public void Add(DisplayGraphic graphic) {
            _canvas.Controls.Add(graphic);
            graphic.Render();
        }
    }
}
