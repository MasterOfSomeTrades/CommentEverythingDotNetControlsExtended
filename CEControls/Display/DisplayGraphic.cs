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
        public DisplayGraphic() {
            InitializeComponent();

            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;
        }

        public abstract void Render();

        private void DisplayGraphic_Paint(object sender, EventArgs e) {
            Render();
        }
    }
}
