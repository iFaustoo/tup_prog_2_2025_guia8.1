namespace Ej1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Importe";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(128, 12);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(200, 30);
            this.tbNombre.TabIndex = 3;
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(128, 78);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(200, 30);
            this.tbDNI.TabIndex = 4;
            // 
            // tbImporte
            // 
            this.tbImporte.Location = new System.Drawing.Point(128, 151);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Size = new System.Drawing.Size(200, 30);
            this.tbImporte.TabIndex = 5;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(381, 38);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(117, 38);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(18, 219);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(310, 204);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(381, 219);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(117, 38);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 481);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.tbImporte);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.TextBox tbDNI;
        public System.Windows.Forms.TextBox tbImporte;
    }
}

