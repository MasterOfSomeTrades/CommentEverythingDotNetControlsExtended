﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CEControls.Display {
    public class CEDisplayLabel : DisplayGraphic {
        public string Text { get; set; } = "Undefined";
        public FontFamily Font { get; set; } = FontFamily.GenericSansSerif;
        public int TextSize { get; set; } = 10;

        public CEDisplayLabel(DisplayGraphic displayGraphic) : base(displayGraphic) {
        }

        public CEDisplayLabel(Color labelColor, string label) : base() {
            Color = labelColor;
            Text = label;
        }

        public CEDisplayLabel(Color labelColor, FontFamily labelFont, int labelSize, string label) : this(labelColor, label) {
            Font = labelFont;
            TextSize = labelSize;
        }

        public CEDisplayLabel(DisplayGraphic displayGraphic, Color labelColor, string label) : base(displayGraphic) {
            Color = labelColor;
            Text = label;
        }

        public CEDisplayLabel(DisplayGraphic displayGraphic, Color labelColor, FontFamily labelFont, int labelSize, string label) : this(displayGraphic, labelColor, label) {
            Font = labelFont;
            TextSize = labelSize;
        }

        public override void Render(Control canvas) {
            if (_parentDisplayGraphic != null) {
                _parentDisplayGraphic.Render(canvas);
            }

            SolidBrush circleBrush = new SolidBrush(Color);
            Graphics renderer = canvas.CreateGraphics();
            Rectangle drawingSpace = new Rectangle(Left, Top, Width, Height);
            StringFormat strFormat = new StringFormat();
            strFormat.Alignment = StringAlignment.Center;
            strFormat.LineAlignment = StringAlignment.Center;
            //renderer.FillEllipse(circleBrush, drawingSpace);
            //circleBrush = new SolidBrush(LabelColor);
            Font stringFont = new Font(Font, TextSize);
            renderer.DrawString(Text, stringFont, circleBrush, drawingSpace, strFormat);
            stringFont.Dispose();
            circleBrush.Dispose();
            renderer.Dispose();
        }

        //public string Label { get; set; }
        //public Color LabelColor { get; set; }
        //private Control _canvas; // TEST

        /*public override void Render() {
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
        }*/

        /*public void AssignCanvas(Control canvas) {
            _canvas = canvas;
            _canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.DisplayGraphic_Paint);
        }*/

        /*public override void Render(Control canvas) {
            SolidBrush circleBrush = new SolidBrush(ForeColor);
            Graphics renderer = _canvas.CreateGraphics();
            Rectangle drawingSpace = new Rectangle(Left, Top, ClientSize.Width, ClientSize.Height);
            StringFormat strFormat = new StringFormat();
            strFormat.Alignment = StringAlignment.Center;
            strFormat.LineAlignment = StringAlignment.Center;
            renderer.FillEllipse(circleBrush, drawingSpace);
            circleBrush = new SolidBrush(LabelColor);
            renderer.DrawString(Label, Font, circleBrush, drawingSpace, strFormat);
            circleBrush.Dispose();
            renderer.Dispose();
        }*/
    }
}
