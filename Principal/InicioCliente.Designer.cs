namespace Principal
{
    partial class InicioCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioCliente));
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.btnEditarPerfil = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnComprarBoletos = new System.Windows.Forms.Button();
            this.btnVerBoletos = new System.Windows.Forms.Button();
            this.btnVerRecibo = new System.Windows.Forms.Button();
            this.btnActualizarBoletos = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblResegna = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(12, 76);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(62, 39);
            this.btnCerrarSesion.TabIndex = 0;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(109, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(109, 40);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(24, 13);
            this.lbId.TabIndex = 3;
            this.lbId.Text = "ID: ";
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.Location = new System.Drawing.Point(80, 76);
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.Size = new System.Drawing.Size(64, 39);
            this.btnEditarPerfil.TabIndex = 4;
            this.btnEditarPerfil.Text = "Editar Perfil";
            this.btnEditarPerfil.UseVisualStyleBackColor = true;
            this.btnEditarPerfil.Click += new System.EventHandler(this.btnEditarPerfil_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 309);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ver Cartelera";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnComprarBoletos
            // 
            this.btnComprarBoletos.Location = new System.Drawing.Point(294, 129);
            this.btnComprarBoletos.Name = "btnComprarBoletos";
            this.btnComprarBoletos.Size = new System.Drawing.Size(135, 35);
            this.btnComprarBoletos.TabIndex = 8;
            this.btnComprarBoletos.Text = "Comprar Boletos";
            this.btnComprarBoletos.UseVisualStyleBackColor = true;
            this.btnComprarBoletos.Click += new System.EventHandler(this.btnComprarBoletos_Click);
            // 
            // btnVerBoletos
            // 
            this.btnVerBoletos.Location = new System.Drawing.Point(294, 170);
            this.btnVerBoletos.Name = "btnVerBoletos";
            this.btnVerBoletos.Size = new System.Drawing.Size(135, 35);
            this.btnVerBoletos.TabIndex = 9;
            this.btnVerBoletos.Text = "Ver Boletos";
            this.btnVerBoletos.UseVisualStyleBackColor = true;
            this.btnVerBoletos.Click += new System.EventHandler(this.btnVerBoletos_Click);
            // 
            // btnVerRecibo
            // 
            this.btnVerRecibo.Location = new System.Drawing.Point(294, 211);
            this.btnVerRecibo.Name = "btnVerRecibo";
            this.btnVerRecibo.Size = new System.Drawing.Size(135, 35);
            this.btnVerRecibo.TabIndex = 10;
            this.btnVerRecibo.Text = "Ver Recibo de Compra";
            this.btnVerRecibo.UseVisualStyleBackColor = true;
            this.btnVerRecibo.Click += new System.EventHandler(this.btnVerRecibo_Click);
            // 
            // btnActualizarBoletos
            // 
            this.btnActualizarBoletos.Location = new System.Drawing.Point(294, 252);
            this.btnActualizarBoletos.Name = "btnActualizarBoletos";
            this.btnActualizarBoletos.Size = new System.Drawing.Size(135, 35);
            this.btnActualizarBoletos.TabIndex = 11;
            this.btnActualizarBoletos.Text = "Actualizar Boletos";
            this.btnActualizarBoletos.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(511, 362);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(165, 144);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "label4";
            this.lblTitulo.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(165, 181);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(35, 13);
            this.lblHorario.TabIndex = 14;
            this.lblHorario.Text = "label5";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(165, 194);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(35, 13);
            this.lblDirector.TabIndex = 15;
            this.lblDirector.Text = "label6";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(165, 207);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(35, 13);
            this.lblDuracion.TabIndex = 16;
            this.lblDuracion.Text = "label7";
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Location = new System.Drawing.Point(165, 220);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(35, 13);
            this.lblClasificacion.TabIndex = 17;
            this.lblClasificacion.Text = "label8";
            // 
            // lblResegna
            // 
            this.lblResegna.AutoSize = true;
            this.lblResegna.Location = new System.Drawing.Point(165, 233);
            this.lblResegna.Name = "lblResegna";
            this.lblResegna.Size = new System.Drawing.Size(35, 13);
            this.lblResegna.TabIndex = 18;
            this.lblResegna.Text = "label9";
            // 
            // InicioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 360);
            this.Controls.Add(this.lblResegna);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnActualizarBoletos);
            this.Controls.Add(this.btnVerRecibo);
            this.Controls.Add(this.btnVerBoletos);
            this.Controls.Add(this.btnComprarBoletos);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnEditarPerfil);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.pictureBox3);
            this.Name = "InicioCliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InicioCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btnEditarPerfil;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnComprarBoletos;
        private System.Windows.Forms.Button btnVerBoletos;
        private System.Windows.Forms.Button btnVerRecibo;
        private System.Windows.Forms.Button btnActualizarBoletos;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.Label lblResegna;
    }
}