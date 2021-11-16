namespace ElChegu
{
    partial class inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboCantidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkAmor = new System.Windows.Forms.CheckBox();
            this.checkJamon = new System.Windows.Forms.CheckBox();
            this.checkAji = new System.Windows.Forms.CheckBox();
            this.checkChimichurry = new System.Windows.Forms.CheckBox();
            this.checkQueso = new System.Windows.Forms.CheckBox();
            this.checkHuevo = new System.Windows.Forms.CheckBox();
            this.checkCebolla = new System.Windows.Forms.CheckBox();
            this.checkLechga = new System.Windows.Forms.CheckBox();
            this.checkTomate = new System.Windows.Forms.CheckBox();
            this.checkQuechu = new System.Windows.Forms.CheckBox();
            this.checkMostaza = new System.Windows.Forms.CheckBox();
            this.checkMayonasa = new System.Windows.Forms.CheckBox();
            this.lstChegu = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblPrecioParcial = new System.Windows.Forms.Label();
            this.btnAddCarrito = new System.Windows.Forms.Button();
            this.btnCompltarCompra = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(190, 117);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(121, 21);
            this.cboProducto.TabIndex = 1;
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_MouseCaptureChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Coolvetica Rg", 20.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(28, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(190, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(345, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 86);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cboCantidad);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(345, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 86);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // cboCantidad
            // 
            this.cboCantidad.FormattingEnabled = true;
            this.cboCantidad.Location = new System.Drawing.Point(50, 53);
            this.cboCantidad.Name = "cboCantidad";
            this.cboCantidad.Size = new System.Drawing.Size(121, 21);
            this.cboCantidad.TabIndex = 4;
            this.cboCantidad.SelectedIndexChanged += new System.EventHandler(this.cboCantidad_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Coolvetica Rg", 20.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "CANTIDAD";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Black;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox4.Controls.Add(this.checkAmor);
            this.groupBox4.Controls.Add(this.checkJamon);
            this.groupBox4.Controls.Add(this.checkAji);
            this.groupBox4.Controls.Add(this.checkChimichurry);
            this.groupBox4.Controls.Add(this.checkQueso);
            this.groupBox4.Controls.Add(this.checkHuevo);
            this.groupBox4.Controls.Add(this.checkCebolla);
            this.groupBox4.Controls.Add(this.checkLechga);
            this.groupBox4.Controls.Add(this.checkTomate);
            this.groupBox4.Controls.Add(this.checkQuechu);
            this.groupBox4.Controls.Add(this.checkMostaza);
            this.groupBox4.Controls.Add(this.checkMayonasa);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(118, 144);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(221, 156);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // checkAmor
            // 
            this.checkAmor.AutoSize = true;
            this.checkAmor.Font = new System.Drawing.Font("Coolvetica Rg", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAmor.ForeColor = System.Drawing.Color.White;
            this.checkAmor.Location = new System.Drawing.Point(90, 134);
            this.checkAmor.Name = "checkAmor";
            this.checkAmor.Size = new System.Drawing.Size(94, 19);
            this.checkAmor.TabIndex = 11;
            this.checkAmor.Tag = "1000";
            this.checkAmor.Text = "Oro ($1000)";
            this.checkAmor.UseVisualStyleBackColor = true;
            this.checkAmor.CheckedChanged += new System.EventHandler(this.chequeos);
            // 
            // checkJamon
            // 
            this.checkJamon.AutoSize = true;
            this.checkJamon.Font = new System.Drawing.Font("Coolvetica Rg", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkJamon.ForeColor = System.Drawing.Color.White;
            this.checkJamon.Location = new System.Drawing.Point(90, 111);
            this.checkJamon.Name = "checkJamon";
            this.checkJamon.Size = new System.Drawing.Size(98, 19);
            this.checkJamon.TabIndex = 10;
            this.checkJamon.Tag = "20";
            this.checkJamon.Text = "Jamon ($20)";
            this.checkJamon.UseVisualStyleBackColor = true;
            this.checkJamon.CheckedChanged += new System.EventHandler(this.chequeos);
            // 
            // checkAji
            // 
            this.checkAji.AutoSize = true;
            this.checkAji.Font = new System.Drawing.Font("Coolvetica Rg", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAji.ForeColor = System.Drawing.Color.White;
            this.checkAji.Location = new System.Drawing.Point(90, 88);
            this.checkAji.Name = "checkAji";
            this.checkAji.Size = new System.Drawing.Size(81, 19);
            this.checkAji.TabIndex = 9;
            this.checkAji.Tag = "150";
            this.checkAji.Text = "Aji ($150)";
            this.checkAji.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkAji.UseVisualStyleBackColor = true;
            this.checkAji.CheckedChanged += new System.EventHandler(this.chequeos);
            // 
            // checkChimichurry
            // 
            this.checkChimichurry.AutoSize = true;
            this.checkChimichurry.Font = new System.Drawing.Font("Coolvetica Rg", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkChimichurry.ForeColor = System.Drawing.Color.White;
            this.checkChimichurry.Location = new System.Drawing.Point(90, 65);
            this.checkChimichurry.Name = "checkChimichurry";
            this.checkChimichurry.Size = new System.Drawing.Size(105, 19);
            this.checkChimichurry.TabIndex = 8;
            this.checkChimichurry.Tag = "30";
            this.checkChimichurry.Text = "Picante ($30)";
            this.checkChimichurry.UseVisualStyleBackColor = true;
            this.checkChimichurry.CheckedChanged += new System.EventHandler(this.chequeos);
            // 
            // checkQueso
            // 
            this.checkQueso.AutoSize = true;
            this.checkQueso.Font = new System.Drawing.Font("Coolvetica Rg", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkQueso.ForeColor = System.Drawing.Color.White;
            this.checkQueso.Location = new System.Drawing.Point(90, 42);
            this.checkQueso.Name = "checkQueso";
            this.checkQueso.Size = new System.Drawing.Size(98, 19);
            this.checkQueso.TabIndex = 7;
            this.checkQueso.Tag = "20";
            this.checkQueso.Text = "Queso ($20)";
            this.checkQueso.UseVisualStyleBackColor = true;
            this.checkQueso.CheckedChanged += new System.EventHandler(this.chequeos);
            // 
            // checkHuevo
            // 
            this.checkHuevo.AutoSize = true;
            this.checkHuevo.Font = new System.Drawing.Font("Coolvetica Rg", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkHuevo.ForeColor = System.Drawing.Color.White;
            this.checkHuevo.Location = new System.Drawing.Point(90, 19);
            this.checkHuevo.Name = "checkHuevo";
            this.checkHuevo.Size = new System.Drawing.Size(97, 19);
            this.checkHuevo.TabIndex = 6;
            this.checkHuevo.Tag = "50";
            this.checkHuevo.Text = "Huevo ($50)";
            this.checkHuevo.UseVisualStyleBackColor = true;
            this.checkHuevo.CheckedChanged += new System.EventHandler(this.chequeos);
            // 
            // checkCebolla
            // 
            this.checkCebolla.AutoSize = true;
            this.checkCebolla.Font = new System.Drawing.Font("Coolvetica Rg", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCebolla.ForeColor = System.Drawing.Color.White;
            this.checkCebolla.Location = new System.Drawing.Point(11, 134);
            this.checkCebolla.Name = "checkCebolla";
            this.checkCebolla.Size = new System.Drawing.Size(68, 19);
            this.checkCebolla.TabIndex = 5;
            this.checkCebolla.Text = "Cebolla";
            this.checkCebolla.UseVisualStyleBackColor = true;
            this.checkCebolla.CheckedChanged += new System.EventHandler(this.chequeos);
            // 
            // checkLechga
            // 
            this.checkLechga.AutoSize = true;
            this.checkLechga.Font = new System.Drawing.Font("Coolvetica Rg", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLechga.ForeColor = System.Drawing.Color.White;
            this.checkLechga.Location = new System.Drawing.Point(11, 111);
            this.checkLechga.Name = "checkLechga";
            this.checkLechga.Size = new System.Drawing.Size(75, 19);
            this.checkLechga.TabIndex = 4;
            this.checkLechga.Text = "Lechuga";
            this.checkLechga.UseVisualStyleBackColor = true;
            this.checkLechga.CheckedChanged += new System.EventHandler(this.chequeos);
            // 
            // checkTomate
            // 
            this.checkTomate.AutoSize = true;
            this.checkTomate.Font = new System.Drawing.Font("Coolvetica Rg", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTomate.ForeColor = System.Drawing.Color.White;
            this.checkTomate.Location = new System.Drawing.Point(11, 88);
            this.checkTomate.Name = "checkTomate";
            this.checkTomate.Size = new System.Drawing.Size(70, 19);
            this.checkTomate.TabIndex = 3;
            this.checkTomate.Text = "Tomate";
            this.checkTomate.UseVisualStyleBackColor = true;
            this.checkTomate.CheckedChanged += new System.EventHandler(this.chequeos);
            // 
            // checkQuechu
            // 
            this.checkQuechu.AutoSize = true;
            this.checkQuechu.Font = new System.Drawing.Font("Coolvetica Rg", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkQuechu.ForeColor = System.Drawing.Color.White;
            this.checkQuechu.Location = new System.Drawing.Point(11, 65);
            this.checkQuechu.Name = "checkQuechu";
            this.checkQuechu.Size = new System.Drawing.Size(70, 19);
            this.checkQuechu.TabIndex = 2;
            this.checkQuechu.Text = "Quecho";
            this.checkQuechu.UseVisualStyleBackColor = true;
            this.checkQuechu.CheckedChanged += new System.EventHandler(this.chequeos);
            // 
            // checkMostaza
            // 
            this.checkMostaza.AutoSize = true;
            this.checkMostaza.Font = new System.Drawing.Font("Coolvetica Rg", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMostaza.ForeColor = System.Drawing.Color.White;
            this.checkMostaza.Location = new System.Drawing.Point(11, 42);
            this.checkMostaza.Name = "checkMostaza";
            this.checkMostaza.Size = new System.Drawing.Size(75, 19);
            this.checkMostaza.TabIndex = 1;
            this.checkMostaza.Text = "Mostaza";
            this.checkMostaza.UseVisualStyleBackColor = true;
            this.checkMostaza.CheckedChanged += new System.EventHandler(this.chequeos);
            // 
            // checkMayonasa
            // 
            this.checkMayonasa.AutoSize = true;
            this.checkMayonasa.Font = new System.Drawing.Font("Coolvetica Rg", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMayonasa.ForeColor = System.Drawing.Color.White;
            this.checkMayonasa.Location = new System.Drawing.Point(11, 19);
            this.checkMayonasa.Name = "checkMayonasa";
            this.checkMayonasa.Size = new System.Drawing.Size(84, 19);
            this.checkMayonasa.TabIndex = 0;
            this.checkMayonasa.Text = "Mayonesa";
            this.checkMayonasa.UseVisualStyleBackColor = true;
            this.checkMayonasa.CheckedChanged += new System.EventHandler(this.chequeos);
            // 
            // lstChegu
            // 
            this.lstChegu.FormattingEnabled = true;
            this.lstChegu.Location = new System.Drawing.Point(118, 323);
            this.lstChegu.Name = "lstChegu";
            this.lstChegu.Size = new System.Drawing.Size(463, 238);
            this.lstChegu.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(216, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio parcial:";
            // 
            // LblPrecioParcial
            // 
            this.LblPrecioParcial.AutoSize = true;
            this.LblPrecioParcial.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblPrecioParcial.Location = new System.Drawing.Point(291, 303);
            this.LblPrecioParcial.Name = "LblPrecioParcial";
            this.LblPrecioParcial.Size = new System.Drawing.Size(13, 13);
            this.LblPrecioParcial.TabIndex = 11;
            this.LblPrecioParcial.Text = "$";
            // 
            // btnAddCarrito
            // 
            this.btnAddCarrito.ForeColor = System.Drawing.Color.Black;
            this.btnAddCarrito.Location = new System.Drawing.Point(160, 621);
            this.btnAddCarrito.Name = "btnAddCarrito";
            this.btnAddCarrito.Size = new System.Drawing.Size(86, 28);
            this.btnAddCarrito.TabIndex = 12;
            this.btnAddCarrito.Text = "Añadir Carrito";
            this.btnAddCarrito.UseVisualStyleBackColor = true;
            this.btnAddCarrito.Click += new System.EventHandler(this.btnAddCarrito_Click);
            // 
            // btnCompltarCompra
            // 
            this.btnCompltarCompra.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCompltarCompra.Location = new System.Drawing.Point(392, 621);
            this.btnCompltarCompra.Name = "btnCompltarCompra";
            this.btnCompltarCompra.Size = new System.Drawing.Size(108, 28);
            this.btnCompltarCompra.TabIndex = 13;
            this.btnCompltarCompra.Text = "Completar compra";
            this.btnCompltarCompra.UseVisualStyleBackColor = true;
            this.btnCompltarCompra.Click += new System.EventHandler(this.btnCompltarCompra_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(615, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.integrantes_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(252, 617);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(506, 621);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 621);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "Ventas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCompltarCompra);
            this.Controls.Add(this.btnAddCarrito);
            this.Controls.Add(this.LblPrecioParcial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lstChegu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboProducto);
            this.Name = "inicio";
            this.Text = "El chegu";
            this.Load += new System.EventHandler(this.inicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkAmor;
        private System.Windows.Forms.CheckBox checkJamon;
        private System.Windows.Forms.CheckBox checkAji;
        private System.Windows.Forms.CheckBox checkChimichurry;
        private System.Windows.Forms.CheckBox checkQueso;
        private System.Windows.Forms.CheckBox checkHuevo;
        private System.Windows.Forms.CheckBox checkCebolla;
        private System.Windows.Forms.CheckBox checkLechga;
        private System.Windows.Forms.CheckBox checkTomate;
        private System.Windows.Forms.CheckBox checkQuechu;
        private System.Windows.Forms.CheckBox checkMostaza;
        private System.Windows.Forms.CheckBox checkMayonasa;
        private System.Windows.Forms.ListBox lstChegu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblPrecioParcial;
        private System.Windows.Forms.Button btnAddCarrito;
        private System.Windows.Forms.Button btnCompltarCompra;
        private System.Windows.Forms.ComboBox cboCantidad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
    }
}

