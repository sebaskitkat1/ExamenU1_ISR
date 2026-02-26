namespace ExamenU1_ISR
{
    partial class frmIsr
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSueldo = new TextBox();
            label1 = new Label();
            btnCalcular = new Button();
            label2 = new Label();
            label3 = new Label();
            txtIsrCalc = new TextBox();
            txtSueldoNeto = new TextBox();
            btnSalir = new Button();
            btnReiniciar = new Button();
            SuspendLayout();
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(42, 44);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(212, 23);
            txtSueldo.TabIndex = 0;
            txtSueldo.TextChanged += txtSueldo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 19);
            label1.Name = "label1";
            label1.Size = new Size(150, 22);
            label1.TabIndex = 1;
            label1.Text = "Sueldo Mensual:";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.White;
            btnCalcular.Enabled = false;
            btnCalcular.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(89, 94);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(103, 35);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular ISR";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 150);
            label2.Name = "label2";
            label2.Size = new Size(142, 22);
            label2.TabIndex = 3;
            label2.Text = "ISR Calculado: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 215);
            label3.Name = "label3";
            label3.Size = new Size(125, 22);
            label3.TabIndex = 4;
            label3.Text = "Sueldo Neto: ";
            // 
            // txtIsrCalc
            // 
            txtIsrCalc.Location = new Point(42, 179);
            txtIsrCalc.Name = "txtIsrCalc";
            txtIsrCalc.Size = new Size(212, 23);
            txtIsrCalc.TabIndex = 5;
            // 
            // txtSueldoNeto
            // 
            txtSueldoNeto.Location = new Point(42, 246);
            txtSueldoNeto.Name = "txtSueldoNeto";
            txtSueldoNeto.Size = new Size(212, 23);
            txtSueldoNeto.TabIndex = 6;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(169, 314);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(103, 36);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReiniciar.Location = new Point(24, 314);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(103, 35);
            btnReiniciar.TabIndex = 8;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // frmIsr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(293, 381);
            Controls.Add(btnReiniciar);
            Controls.Add(btnSalir);
            Controls.Add(txtSueldoNeto);
            Controls.Add(txtIsrCalc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCalcular);
            Controls.Add(label1);
            Controls.Add(txtSueldo);
            Cursor = Cursors.Cross;
            ImeMode = ImeMode.On;
            Name = "frmIsr";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculo de ISR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSueldo;
        private Label label1;
        private Button btnCalcular;
        private Label label2;
        private Label label3;
        private TextBox txtIsrCalc;
        private TextBox txtSueldoNeto;
        private Button btnSalir;
        private Button btnReiniciar;
    }
}
