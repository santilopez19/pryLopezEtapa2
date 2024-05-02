namespace pryLopezEtapa2
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
            pctImagen = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pctImagen).BeginInit();
            SuspendLayout();
            // 
            // pctImagen
            // 
            pctImagen.Image = Properties.Resources.auto;
            pctImagen.Location = new Point(203, 24);
            pctImagen.Name = "pctImagen";
            pctImagen.Size = new Size(395, 302);
            pctImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pctImagen.TabIndex = 0;
            pctImagen.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(321, 361);
            button1.Name = "button1";
            button1.Size = new Size(150, 29);
            button1.TabIndex = 1;
            button1.Text = "Crear Vehiculos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pctImagen);
            Name = "Form1";
            Text = "Vehiculos";
            ((System.ComponentModel.ISupportInitialize)pctImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pctImagen;
        private Button button1;
    }
}
