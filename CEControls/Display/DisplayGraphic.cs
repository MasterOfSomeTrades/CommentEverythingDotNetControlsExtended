using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CEControls.Display {
    public abstract partial class DisplayGraphic {
        public Color Color { get; set; } = Color.Blue;
        public int Left { get; set; } = 0;
        public int Top { get; set; } = 0;
        public int Width { get; set; } = 10;
        public int Height { get; set; } = 10;
        protected DisplayGraphic _parentDisplayGraphic;

        //this.Paint += new System.Windows.Forms.PaintEventHandler(this.DisplayGraphic_Paint);

        public DisplayGraphic() {

        }

        public DisplayGraphic(DisplayGraphic displayGraphic) {
            _parentDisplayGraphic = displayGraphic;
            Left = _parentDisplayGraphic.Left;
            Top = _parentDisplayGraphic.Top;
            Width = _parentDisplayGraphic.Width;
            Height = _parentDisplayGraphic.Height;
        }

        public abstract void Render(Control canvas);

        /*protected void DisplayGraphic_Paint(object sender, EventArgs e) {
            Render();
        }*/
    }
}
