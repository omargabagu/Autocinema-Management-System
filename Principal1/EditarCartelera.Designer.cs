namespace Principal
{
    partial class EditarCartelera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarCartelera));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblResegna = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnElegir = new System.Windows.Forms.Button();
            this.btnElegir2 = new System.Windows.Forms.Button();
            this.btnElegir3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 217);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elige la Funcion ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(175, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(57, 17);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "lblTitulo";
            this.lblTitulo.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(120, 9);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(14, 13);
            this.lblnumero.TabIndex = 5;
            this.lblnumero.Text = "#";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(175, 75);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(51, 15);
            this.lblHorario.TabIndex = 6;
            this.lblHorario.Text = "Horario:";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.Location = new System.Drawing.Point(175, 100);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(50, 15);
            this.lblDirector.TabIndex = 7;
            this.lblDirector.Text = "Director";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.Location = new System.Drawing.Point(175, 125);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(63, 15);
            this.lblDuracion.TabIndex = 8;
            this.lblDuracion.Text = "Duracion: ";
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasificacion.Location = new System.Drawing.Point(175, 152);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(82, 15);
            this.lblClasificacion.TabIndex = 9;
            this.lblClasificacion.Text = "Clasificacion: ";
            // 
            // lblResegna
            // 
            this.lblResegna.AutoSize = true;
            this.lblResegna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResegna.Location = new System.Drawing.Point(175, 178);
            this.lblResegna.Name = "lblResegna";
            this.lblResegna.Size = new System.Drawing.Size(63, 15);
            this.lblResegna.TabIndex = 10;
            this.lblResegna.Text = "Resegna: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnElegir
            // 
            this.btnElegir.Location = new System.Drawing.Point(191, 236);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(153, 24);
            this.btnElegir.TabIndex = 12;
            this.btnElegir.Text = "Elegir para funcion 1";
            this.btnElegir.UseVisualStyleBackColor = true;
            this.btnElegir.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // btnElegir2
            // 
            this.btnElegir2.Location = new System.Drawing.Point(191, 266);
            this.btnElegir2.Name = "btnElegir2";
            this.btnElegir2.Size = new System.Drawing.Size(153, 24);
            this.btnElegir2.TabIndex = 13;
            this.btnElegir2.Text = "Elegir para funcion 2";
            this.btnElegir2.UseVisualStyleBackColor = true;
            this.btnElegir2.Click += new System.EventHandler(this.btnElegir2_Click);
            // 
            // btnElegir3
            // 
            this.btnElegir3.Location = new System.Drawing.Point(191, 296);
            this.btnElegir3.Name = "btnElegir3";
            this.btnElegir3.Size = new System.Drawing.Size(153, 24);
            this.btnElegir3.TabIndex = 14;
            this.btnElegir3.Text = "Elegir para funcion 3";
            this.btnElegir3.UseVisualStyleBackColor = true;
            this.btnElegir3.Click += new System.EventHandler(this.btnElegir3_Click);
            // 
            // EditarCartelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 354);
            this.Controls.Add(this.btnElegir3);
            this.Controls.Add(this.btnElegir2);
            this.Controls.Add(this.btnElegir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResegna);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "EditarCartelera";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EditarCartelera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.Label lblResegna;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnElegir;
        private System.Windows.Forms.Button btnElegir2;
        private System.Windows.Forms.Button btnElegir3;
    }
}