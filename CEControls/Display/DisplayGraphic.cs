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
        protected DisplayGraphic _parentDisplayGraphic = null;
        public Color Color { get; set; } = Color.Blue;
        private int _left = 0;
        public int Left {
            get { if (_parentDisplayGraphic == null) return _left; else return _parentDisplayGraphic._left; }
            set { if (_parentDisplayGraphic == null) _left = value; }
        }
        private int _top = 0;
        public int Top {
            get { if (_parentDisplayGraphic == null) return _top; else return _parentDisplayGraphic._top; }
            set { if (_parentDisplayGraphic == null) _top = value; }
        }
        private int _width = 0;
        public int Width {
            get { if (_parentDisplayGraphic == null) return _width; else return _parentDisplayGraphic._width; }
            set { if (_parentDisplayGraphic == null) _width = value; }
        }
        private int _height = 0;
        public int Height {
            get { if (_parentDisplayGraphic == null) return _height; else return _parentDisplayGraphic._height; }
            set { if (_parentDisplayGraphic == null) _height = value; }
        }

        //this.Paint += new System.Windows.Forms.PaintEventHandler(this.DisplayGraphic_Paint);

        public DisplayGraphic() { }

        public DisplayGraphic(DisplayGraphic displayGraphic) {
            _parentDisplayGraphic = displayGraphic;
        }

        public abstract void Render(Control canvas);

        /*protected void DisplayGraphic_Paint(object sender, EventArgs e) {
            Render();
        }*/
    }
}
