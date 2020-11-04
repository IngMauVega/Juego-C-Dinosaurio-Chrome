namespace dinosario_chrome_mamalon
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Carretera = new System.Windows.Forms.PictureBox();
            this.Dino = new System.Windows.Forms.PictureBox();
            this.DetectorChoque = new System.Windows.Forms.PictureBox();
            this.BtnReset = new System.Windows.Forms.PictureBox();
            this.lblGameover = new System.Windows.Forms.Label();
            this.lblpuntuacion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Carretera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetectorChoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReset)).BeginInit();
            this.SuspendLayout();
            // 
            // Carretera
            // 
            this.Carretera.Image = ((System.Drawing.Image)(resources.GetObject("Carretera.Image")));
            this.Carretera.Location = new System.Drawing.Point(12, 267);
            this.Carretera.Name = "Carretera";
            this.Carretera.Size = new System.Drawing.Size(735, 5);
            this.Carretera.TabIndex = 0;
            this.Carretera.TabStop = false;
            // 
            // Dino
            // 
            this.Dino.BackColor = System.Drawing.Color.Transparent;
            this.Dino.Image = ((System.Drawing.Image)(resources.GetObject("Dino.Image")));
            this.Dino.Location = new System.Drawing.Point(12, 217);
            this.Dino.Name = "Dino";
            this.Dino.Size = new System.Drawing.Size(100, 50);
            this.Dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dino.TabIndex = 1;
            this.Dino.TabStop = false;
            // 
            // DetectorChoque
            // 
            this.DetectorChoque.Location = new System.Drawing.Point(55, 192);
            this.DetectorChoque.Name = "DetectorChoque";
            this.DetectorChoque.Size = new System.Drawing.Size(21, 70);
            this.DetectorChoque.TabIndex = 2;
            this.DetectorChoque.TabStop = false;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.Transparent;
            this.BtnReset.Image = ((System.Drawing.Image)(resources.GetObject("BtnReset.Image")));
            this.BtnReset.Location = new System.Drawing.Point(167, 74);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(84, 49);
            this.BtnReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnReset.TabIndex = 3;
            this.BtnReset.TabStop = false;
            this.BtnReset.Visible = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // lblGameover
            // 
            this.lblGameover.AutoSize = true;
            this.lblGameover.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameover.Location = new System.Drawing.Point(175, 37);
            this.lblGameover.Name = "lblGameover";
            this.lblGameover.Size = new System.Drawing.Size(76, 16);
            this.lblGameover.TabIndex = 4;
            this.lblGameover.Text = "Game over";
            this.lblGameover.Visible = false;
            // 
            // lblpuntuacion
            // 
            this.lblpuntuacion.AutoSize = true;
            this.lblpuntuacion.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpuntuacion.Location = new System.Drawing.Point(355, 37);
            this.lblpuntuacion.Name = "lblpuntuacion";
            this.lblpuntuacion.Size = new System.Drawing.Size(20, 16);
            this.lblpuntuacion.TabIndex = 5;
            this.lblpuntuacion.Text = "...";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 299);
            this.Controls.Add(this.Dino);
            this.Controls.Add(this.lblpuntuacion);
            this.Controls.Add(this.lblGameover);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.DetectorChoque);
            this.Controls.Add(this.Carretera);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Carretera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetectorChoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Carretera;
        private System.Windows.Forms.PictureBox Dino;
        private System.Windows.Forms.PictureBox DetectorChoque;
        private System.Windows.Forms.PictureBox BtnReset;
        private System.Windows.Forms.Label lblGameover;
        private System.Windows.Forms.Label lblpuntuacion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

