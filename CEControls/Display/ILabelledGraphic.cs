using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CEControls.Display {
    interface ILabelledGraphic {
        string Label { get; set; }
        Color LabelColor { get; set; }
    }
}
