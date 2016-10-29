namespace CEControls.Input {
    partial class LabelledTextBox {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this._textbox = new System.Windows.Forms.TextBox();
            this._label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _textbox
            // 
            this._textbox.Location = new System.Drawing.Point(3, 20);
            this._textbox.Name = "_textbox";
            this._textbox.Size = new System.Drawing.Size(340, 20);
            this._textbox.TabIndex = 0;
            // 
            // _label
            // 
            this._label.AutoSize = true;
            this._label.Location = new System.Drawing.Point(3, 4);
            this._label.Name = "_label";
            this._label.Size = new System.Drawing.Size(0, 13);
            this._label.TabIndex = 1;
            // 
            // LabelledTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._label);
            this.Controls.Add(this._textbox);
            this.Name = "LabelledTextBox";
            this.Size = new System.Drawing.Size(346, 42);
            this.Resize += new System.EventHandler(this.LabelledTextBox_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textbox;
        private System.Windows.Forms.Label _label;
    }
}
