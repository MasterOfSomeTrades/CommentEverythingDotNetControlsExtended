using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CEControls.Display {
    public abstract partial class DisplayGraphic : UserControl {
        public Color Color { get; set; }

        public DisplayGraphic() {
            InitializeComponent();
            Color = Color.Blue; // --- Default color

            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;
        }

        public abstract void Render();
    }
}
