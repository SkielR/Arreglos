namespace Arreglos1w1
{
    partial class frmEmpleados
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
            this.lstEmpleados = new System.Windows.Forms.ListBox();
            this.btnAumento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSueldos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstNetos = new System.Windows.Forms.ListBox();
            this.txtAumento = new System.Windows.Forms.TextBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.FormattingEnabled = true;
            this.lstEmpleados.ItemHeight = 24;
            this.lstEmpleados.Location = new System.Drawing.Point(16, 46);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(111, 220);
            this.lstEmpleados.TabIndex = 0;
            // 
            // btnAumento
            // 
            this.btnAumento.Location = new System.Drawing.Point(263, 146);
            this.btnAumento.Name = "btnAumento";
            this.btnAumento.Size = new System.Drawing.Size(108, 41);
            this.btnAumento.TabIndex = 1;
            this.btnAumento.Text = "Aumento";
            this.btnAumento.UseVisualStyleBackColor = true;
            this.btnAumento.Click += new System.EventHandler(this.btnAumento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Empleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sueldos";
            // 
            // lstSueldos
            // 
            this.lstSueldos.FormattingEnabled = true;
            this.lstSueldos.ItemHeight = 24;
            this.lstSueldos.Location = new System.Drawing.Point(146, 46);
            this.lstSueldos.Name = "lstSueldos";
            this.lstSueldos.Size = new System.Drawing.Size(111, 220);
            this.lstSueldos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sueldo Neto";
            // 
            // lstNetos
            // 
            this.lstNetos.FormattingEnabled = true;
            this.lstNetos.ItemHeight = 24;
            this.lstNetos.Location = new System.Drawing.Point(386, 46);
            this.lstNetos.Name = "lstNetos";
            this.lstNetos.Size = new System.Drawing.Size(122, 220);
            this.lstNetos.TabIndex = 5;
            // 
            // txtAumento
            // 
            this.txtAumento.Location = new System.Drawing.Point(292, 93);
            this.txtAumento.Name = "txtAumento";
            this.txtAumento.Size = new System.Drawing.Size(48, 29);
            this.txtAumento.TabIndex = 7;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(16, 284);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(111, 29);
            this.txtEmpleado.TabIndex = 8;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(146, 284);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(111, 29);
            this.txtSueldo.TabIndex = 9;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(61, 344);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(148, 59);
            this.btnCargar.TabIndex = 10;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(386, 284);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(122, 29);
            this.txtTotal.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(305, 344);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(148, 59);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 432);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.txtAumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstNetos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstSueldos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAumento);
            this.Controls.Add(this.lstEmpleados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEmpleados;
        private System.Windows.Forms.Button btnAumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSueldos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstNetos;
        private System.Windows.Forms.TextBox txtAumento;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBorrar;
    }
}