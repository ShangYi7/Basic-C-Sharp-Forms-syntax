namespace p7_6_ScrollPic
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PicShow = new System.Windows.Forms.PictureBox();
            this.HsbWidth = new System.Windows.Forms.HScrollBar();
            this.VsbHeight = new System.Windows.Forms.VScrollBar();
            this.TkbPic = new System.Windows.Forms.TrackBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PicShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TkbPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // PicShow
            // 
            this.PicShow.Location = new System.Drawing.Point(26, 12);
            this.PicShow.Name = "PicShow";
            this.PicShow.Size = new System.Drawing.Size(237, 141);
            this.PicShow.TabIndex = 0;
            this.PicShow.TabStop = false;
            // 
            // HsbWidth
            // 
            this.HsbWidth.Location = new System.Drawing.Point(26, 175);
            this.HsbWidth.Name = "HsbWidth";
            this.HsbWidth.Size = new System.Drawing.Size(237, 28);
            this.HsbWidth.TabIndex = 1;
            this.HsbWidth.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HsbWidth_Scroll);
            // 
            // VsbHeight
            // 
            this.VsbHeight.Location = new System.Drawing.Point(275, 12);
            this.VsbHeight.Name = "VsbHeight";
            this.VsbHeight.Size = new System.Drawing.Size(39, 141);
            this.VsbHeight.TabIndex = 3;
            this.VsbHeight.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VsbHeight_Scroll);
            // 
            // TkbPic
            // 
            this.TkbPic.Location = new System.Drawing.Point(26, 221);
            this.TkbPic.Margin = new System.Windows.Forms.Padding(2);
            this.TkbPic.Name = "TkbPic";
            this.TkbPic.Size = new System.Drawing.Size(237, 45);
            this.TkbPic.TabIndex = 4;
            this.TkbPic.Scroll += new System.EventHandler(this.TkbPic_Scroll);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(26, 271);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.TkbPic);
            this.Controls.Add(this.VsbHeight);
            this.Controls.Add(this.HsbWidth);
            this.Controls.Add(this.PicShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TkbPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox PicShow;
        private HScrollBar HsbWidth;
        private VScrollBar VsbHeight;
        private TrackBar TkbPic;
        private ToolTip toolTip1;
        private NumericUpDown numericUpDown1;
    }
}