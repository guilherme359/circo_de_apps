namespace circideapps
{
    partial class frmcpf
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
            label1 = new Label();
            btnverificar = new Button();
            btnfechar = new Button();
            lblresultado = new Label();
            mtxtcpf = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 0;
            label1.Text = "DIGITE O CPF";
            // 
            // btnverificar
            // 
            btnverificar.BackColor = Color.Lime;
            btnverificar.FlatStyle = FlatStyle.Flat;
            btnverificar.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnverificar.Location = new Point(253, 35);
            btnverificar.Name = "btnverificar";
            btnverificar.Size = new Size(88, 23);
            btnverificar.TabIndex = 1;
            btnverificar.Text = "VERIFICAR";
            btnverificar.UseVisualStyleBackColor = false;
            btnverificar.Click += btnverificar_Click;
            // 
            // btnfechar
            // 
            btnfechar.BackColor = Color.Red;
            btnfechar.FlatStyle = FlatStyle.Flat;
            btnfechar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnfechar.Location = new Point(241, 119);
            btnfechar.Name = "btnfechar";
            btnfechar.Size = new Size(100, 32);
            btnfechar.TabIndex = 3;
            btnfechar.Text = "FECHAR";
            btnfechar.UseVisualStyleBackColor = false;
            btnfechar.Click += btnfechar_Click;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblresultado.Location = new Point(12, 72);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(0, 25);
            lblresultado.TabIndex = 4;
            // 
            // mtxtcpf
            // 
            mtxtcpf.Location = new Point(12, 35);
            mtxtcpf.Mask = "000.000.000-00";
            mtxtcpf.Name = "mtxtcpf";
            mtxtcpf.Size = new Size(236, 23);
            mtxtcpf.TabIndex = 5;
            mtxtcpf.KeyPress += mtxtcpf_KeyPress;
            // 
            // frmcpf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Magenta;
            ClientSize = new Size(354, 165);
            Controls.Add(mtxtcpf);
            Controls.Add(lblresultado);
            Controls.Add(btnfechar);
            Controls.Add(btnverificar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmcpf";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmcpf";
            Load += frmcpf_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnverificar;
        private Button btnfechar;
        private Label lblresultado;
        private MaskedTextBox mtxtcpf;
    }
}