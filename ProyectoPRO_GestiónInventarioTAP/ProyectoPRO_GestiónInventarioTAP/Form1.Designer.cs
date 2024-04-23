namespace ProyectoPRO_GestiónInventarioTAP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_Usuario = new System.Windows.Forms.TextBox();
            this.text_Contraseña = new System.Windows.Forms.TextBox();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(145)))), ((int)(((byte)(223)))));
            this.BarraTitulo.Controls.Add(this.btnRestaurar);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnMaximizar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(750, 40);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(654, 2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(35, 35);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 7;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(593, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(35, 35);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(654, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(35, 35);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 5;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(712, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.label1.Location = new System.Drawing.Point(60, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "INICIAR SESIÓN";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.label2.Location = new System.Drawing.Point(131, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "USUARIO: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.label3.Location = new System.Drawing.Point(131, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "CONTRASEÑA: ";
            // 
            // text_Usuario
            // 
            this.text_Usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(200)))), ((int)(((byte)(233)))));
            this.text_Usuario.Location = new System.Drawing.Point(394, 228);
            this.text_Usuario.Name = "text_Usuario";
            this.text_Usuario.Size = new System.Drawing.Size(211, 26);
            this.text_Usuario.TabIndex = 4;
            // 
            // text_Contraseña
            // 
            this.text_Contraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(200)))), ((int)(((byte)(233)))));
            this.text_Contraseña.Location = new System.Drawing.Point(394, 346);
            this.text_Contraseña.Name = "text_Contraseña";
            this.text_Contraseña.Size = new System.Drawing.Size(211, 26);
            this.text_Contraseña.TabIndex = 5;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Entrar.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entrar.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Entrar.Location = new System.Drawing.Point(554, 457);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(173, 40);
            this.btn_Entrar.TabIndex = 6;
            this.btn_Entrar.Text = "Iniciar Sesión";
            this.btn_Entrar.UseVisualStyleBackColor = false;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_Entrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(750, 520);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.text_Contraseña);
            this.Controls.Add(this.text_Usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_Usuario;
        private System.Windows.Forms.TextBox text_Contraseña;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}

