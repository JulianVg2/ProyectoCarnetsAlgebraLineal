namespace ProyectoCarnetsAlgebraLineal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCarnetActual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCarnetNuevo = new System.Windows.Forms.TextBox();
            this.btnGenerarQr = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generador De Carnets";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(24, 94);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el Carnet Actual:";
            // 
            // txtCarnetActual
            // 
            this.txtCarnetActual.Location = new System.Drawing.Point(24, 68);
            this.txtCarnetActual.Name = "txtCarnetActual";
            this.txtCarnetActual.Size = new System.Drawing.Size(120, 20);
            this.txtCarnetActual.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Carnet Generado:";
            // 
            // txtCarnetNuevo
            // 
            this.txtCarnetNuevo.Location = new System.Drawing.Point(27, 140);
            this.txtCarnetNuevo.Name = "txtCarnetNuevo";
            this.txtCarnetNuevo.Size = new System.Drawing.Size(120, 20);
            this.txtCarnetNuevo.TabIndex = 6;
            // 
            // btnGenerarQr
            // 
            this.btnGenerarQr.Location = new System.Drawing.Point(27, 193);
            this.btnGenerarQr.Name = "btnGenerarQr";
            this.btnGenerarQr.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarQr.TabIndex = 7;
            this.btnGenerarQr.Text = "Generar QR";
            this.btnGenerarQr.UseVisualStyleBackColor = true;
            this.btnGenerarQr.Click += new System.EventHandler(this.btnGenerarQr_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 353);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 645);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGenerarQr);
            this.Controls.Add(this.txtCarnetNuevo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCarnetActual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCarnetActual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCarnetNuevo;
        private System.Windows.Forms.Button btnGenerarQr;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

