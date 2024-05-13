namespace pryDacunteVs3
{
    partial class frmJuego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblCartel = new System.Windows.Forms.Label();
            this.pctAlien = new System.Windows.Forms.PictureBox();
            this.pctNave = new System.Windows.Forms.PictureBox();
            this.pctJugador = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblGanar = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctAlien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctJugador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Enabled = false;
            this.btnReiniciar.Location = new System.Drawing.Point(422, 12);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 3;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Visible = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblScore.Location = new System.Drawing.Point(0, 5);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(138, 29);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "SCORE : 0";
            // 
            // lblCartel
            // 
            this.lblCartel.AutoSize = true;
            this.lblCartel.BackColor = System.Drawing.Color.Transparent;
            this.lblCartel.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartel.ForeColor = System.Drawing.Color.Red;
            this.lblCartel.Location = new System.Drawing.Point(332, 262);
            this.lblCartel.Name = "lblCartel";
            this.lblCartel.Size = new System.Drawing.Size(269, 26);
            this.lblCartel.TabIndex = 5;
            this.lblCartel.Text = "GAME OVER";
            this.lblCartel.Visible = false;
            // 
            // pctAlien
            // 
            this.pctAlien.BackColor = System.Drawing.Color.Transparent;
            this.pctAlien.Image = global::pryDacunteVs3.Properties.Resources.alien2_removebg_preview;
            this.pctAlien.Location = new System.Drawing.Point(144, 29);
            this.pctAlien.Name = "pctAlien";
            this.pctAlien.Size = new System.Drawing.Size(78, 55);
            this.pctAlien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctAlien.TabIndex = 6;
            this.pctAlien.TabStop = false;
            this.pctAlien.Tag = "enemigo";
            // 
            // pctNave
            // 
            this.pctNave.BackColor = System.Drawing.Color.Transparent;
            this.pctNave.Image = global::pryDacunteVs3.Properties.Resources.alien_removebg_preview;
            this.pctNave.Location = new System.Drawing.Point(748, 34);
            this.pctNave.Name = "pctNave";
            this.pctNave.Size = new System.Drawing.Size(96, 47);
            this.pctNave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctNave.TabIndex = 7;
            this.pctNave.TabStop = false;
            this.pctNave.Tag = "enemigo";
            // 
            // pctJugador
            // 
            this.pctJugador.BackColor = System.Drawing.Color.Transparent;
            this.pctJugador.Image = global::pryDacunteVs3.Properties.Resources.j1;
            this.pctJugador.Location = new System.Drawing.Point(404, 458);
            this.pctJugador.Name = "pctJugador";
            this.pctJugador.Size = new System.Drawing.Size(107, 52);
            this.pctJugador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctJugador.TabIndex = 8;
            this.pctJugador.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lblGanar
            // 
            this.lblGanar.AutoSize = true;
            this.lblGanar.BackColor = System.Drawing.Color.Transparent;
            this.lblGanar.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanar.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblGanar.Location = new System.Drawing.Point(322, 382);
            this.lblGanar.Name = "lblGanar";
            this.lblGanar.Size = new System.Drawing.Size(290, 26);
            this.lblGanar.TabIndex = 9;
            this.lblGanar.Text = "HAS GANADO";
            this.lblGanar.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Enabled = false;
            this.btnSalir.Location = new System.Drawing.Point(814, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Visible = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryDacunteVs3.Properties.Resources.e75b070ea310d267380367293a015ac19425b66f_00;
            this.ClientSize = new System.Drawing.Size(901, 536);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblGanar);
            this.Controls.Add(this.pctJugador);
            this.Controls.Add(this.pctNave);
            this.Controls.Add(this.pctAlien);
            this.Controls.Add(this.lblCartel);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnReiniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galaga";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmJuego_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmJuego_KeyUp_1);
            ((System.ComponentModel.ISupportInitialize)(this.pctAlien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctJugador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblCartel;
        private System.Windows.Forms.PictureBox pctAlien;
        private System.Windows.Forms.PictureBox pctNave;
        private System.Windows.Forms.PictureBox pctJugador;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblGanar;
        private System.Windows.Forms.Button btnSalir;
    }
}