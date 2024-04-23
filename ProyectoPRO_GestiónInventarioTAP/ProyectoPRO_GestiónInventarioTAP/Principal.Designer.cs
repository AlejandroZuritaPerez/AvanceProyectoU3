namespace ProyectoPRO_GestiónInventarioTAP
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(596, 619);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(66, 26);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblFecha.Location = new System.Drawing.Point(12, 619);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(74, 26);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(696, 481);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(137)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(908, 654);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer horaFecha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}