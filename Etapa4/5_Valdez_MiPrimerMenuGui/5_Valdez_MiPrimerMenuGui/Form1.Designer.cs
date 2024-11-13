namespace _5_Valdez_MiPrimerMenuGui
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
            this.SUMA = new System.Windows.Forms.Button();
            this.RESTA = new System.Windows.Forms.Button();
            this.MULTIPLICACION = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // SUMA
            // 
            this.SUMA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SUMA.Location = new System.Drawing.Point(209, 124);
            this.SUMA.Name = "SUMA";
            this.SUMA.Size = new System.Drawing.Size(117, 42);
            this.SUMA.TabIndex = 1;
            this.SUMA.Text = "SUMA";
            this.SUMA.UseVisualStyleBackColor = false;
            this.SUMA.Click += new System.EventHandler(this.button1_Click);
            // 
            // RESTA
            // 
            this.RESTA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RESTA.Location = new System.Drawing.Point(209, 203);
            this.RESTA.Name = "RESTA";
            this.RESTA.Size = new System.Drawing.Size(117, 42);
            this.RESTA.TabIndex = 2;
            this.RESTA.Text = "RESTA";
            this.RESTA.UseVisualStyleBackColor = false;
            this.RESTA.Click += new System.EventHandler(this.button2_Click);
            // 
            // MULTIPLICACION
            // 
            this.MULTIPLICACION.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MULTIPLICACION.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MULTIPLICACION.Location = new System.Drawing.Point(209, 289);
            this.MULTIPLICACION.Name = "MULTIPLICACION";
            this.MULTIPLICACION.Size = new System.Drawing.Size(117, 42);
            this.MULTIPLICACION.TabIndex = 3;
            this.MULTIPLICACION.Text = "MULTIPLICACION";
            this.MULTIPLICACION.UseVisualStyleBackColor = false;
            this.MULTIPLICACION.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(563, 474);
            this.Controls.Add(this.MULTIPLICACION);
            this.Controls.Add(this.RESTA);
            this.Controls.Add(this.SUMA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SUMA;
        private System.Windows.Forms.Button RESTA;
        private System.Windows.Forms.Button MULTIPLICACION;
    }
}

