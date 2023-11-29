namespace SISTEMA_VENTA
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.btnIngresar = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 333);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistema de ventas";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Shopware;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 98;
            this.iconPictureBox1.Location = new System.Drawing.Point(66, 116);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(98, 109);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(260, 93);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(192, 27);
            this.txtusuario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña";
            // 
            // txtclave
            // 
            this.txtclave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.Location = new System.Drawing.Point(260, 175);
            this.txtclave.Margin = new System.Windows.Forms.Padding(2);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(192, 27);
            this.txtclave.TabIndex = 9;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnIngresar.IconColor = System.Drawing.Color.White;
            this.btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngresar.IconSize = 30;
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.Location = new System.Drawing.Point(234, 255);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(116, 43);
            this.btnIngresar.TabIndex = 10;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Firebrick;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 30;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(362, 255);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(113, 43);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 333);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtclave;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}