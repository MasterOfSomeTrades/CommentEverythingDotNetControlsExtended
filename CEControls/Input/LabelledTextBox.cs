using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CEControls.Input {
    public partial class LabelledTextBox : UserControl {
        /// <summary>
        /// Property representing Text of the LabelledTextBox.
        /// </summary>
        public override string Text {
            get {
                return _textbox.Text;
            }
            set {
                _textbox.Text = value;
            }
        }
        /// <summary>
        /// Property representing Label of the LabelledTextBox.
        /// </summary>
        public string Label {
            get {
                return _label.Text;
            }
            set {
                _label.Text = value;
            }
        }

        /// <summary>
        /// No-arg constructor for LabelledTextbox.
        /// </summary>
        public LabelledTextBox() {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor for LabelledTextbox with Label initialized.
        /// </summary>
        /// <param name="label"></param>
        public LabelledTextBox(string label) {
            InitializeComponent();
            Label = label;
        }

        /// <summary>
        /// Constructor for LabelledTextbox with Width initialized.
        /// </summary>
        /// <param name="width"></param>
        public LabelledTextBox(int width) {
            InitializeComponent();
            Width = width;
        }

        /// <summary>
        /// Constructor for LabelledTextbox with Label and Width initialized.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="width"></param>
        public LabelledTextBox(string label, int width) {
            InitializeComponent();
            Label = label;
            Width = width;
        }

        /// <summary>
        /// Handles event when LabelledTextBox resizes to resize TextBox accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelledTextBox_Resize(object sender, EventArgs e) {
            _textbox.Width = ClientSize.Width - _textbox.Left - 1;
        }
    }
}
