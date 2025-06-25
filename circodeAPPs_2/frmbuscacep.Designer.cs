namespace circideapps
{
    partial class frmbuscacep
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
            btnpesquisar = new Button();
            label1 = new Label();
            txtcep = new TextBox();
            btnfechar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            lbluf = new Label();
            lblcidade = new Label();
            lblbairro = new Label();
            lblcomplemento = new Label();
            lblendereco = new Label();
            SuspendLayout();
            // 
            // btnpesquisar
            // 
            btnpesquisar.BackColor = Color.MidnightBlue;
            btnpesquisar.FlatStyle = FlatStyle.Popup;
            btnpesquisar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnpesquisar.ForeColor = SystemColors.ButtonHighlight;
            btnpesquisar.Location = new Point(299, 22);
            btnpesquisar.Name = "btnpesquisar";
            btnpesquisar.Size = new Size(150, 71);
            btnpesquisar.TabIndex = 0;
            btnpesquisar.Text = "PESQUISAR";
            btnpesquisar.UseVisualStyleBackColor = false;
            btnpesquisar.Click += btnpesquisar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 1;
            label1.Text = "Digite um CEP";
            // 
            // txtcep
            // 
            txtcep.Location = new Point(12, 47);
            txtcep.Name = "txtcep";
            txtcep.Size = new Size(281, 23);
            txtcep.TabIndex = 2;
            // 
            // btnfechar
            // 
            btnfechar.BackColor = Color.Red;
            btnfechar.FlatStyle = FlatStyle.Popup;
            btnfechar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnfechar.ForeColor = SystemColors.ButtonHighlight;
            btnfechar.Location = new Point(299, 114);
            btnfechar.Name = "btnfechar";
            btnfechar.Size = new Size(150, 71);
            btnfechar.TabIndex = 3;
            btnfechar.Text = "FECHAR";
            btnfechar.UseVisualStyleBackColor = false;
            btnfechar.Click += btnfechar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(12, 260);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 4;
            label2.Text = "Endereço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.InfoText;
            label3.Location = new Point(12, 310);
            label3.Name = "label3";
            label3.Size = new Size(123, 21);
            label3.TabIndex = 5;
            label3.Text = "Complemento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.InfoText;
            label4.Location = new Point(12, 410);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 7;
            label4.Text = "Cidade:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.InfoText;
            label5.Location = new Point(12, 359);
            label5.Name = "label5";
            label5.Size = new Size(60, 21);
            label5.TabIndex = 6;
            label5.Text = "Bairro:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.InfoText;
            label7.Location = new Point(12, 461);
            label7.Name = "label7";
            label7.Size = new Size(34, 21);
            label7.TabIndex = 8;
            label7.Text = "UF:";
            // 
            // lbluf
            // 
            lbluf.AutoSize = true;
            lbluf.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbluf.ForeColor = SystemColors.InfoText;
            lbluf.Location = new Point(196, 461);
            lbluf.Name = "lbluf";
            lbluf.Size = new Size(0, 21);
            lbluf.TabIndex = 13;
            // 
            // lblcidade
            // 
            lblcidade.AutoSize = true;
            lblcidade.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblcidade.ForeColor = SystemColors.InfoText;
            lblcidade.Location = new Point(196, 410);
            lblcidade.Name = "lblcidade";
            lblcidade.Size = new Size(0, 21);
            lblcidade.TabIndex = 12;
            // 
            // lblbairro
            // 
            lblbairro.AutoSize = true;
            lblbairro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblbairro.ForeColor = SystemColors.InfoText;
            lblbairro.Location = new Point(196, 359);
            lblbairro.Name = "lblbairro";
            lblbairro.Size = new Size(0, 21);
            lblbairro.TabIndex = 11;
            // 
            // lblcomplemento
            // 
            lblcomplemento.AutoSize = true;
            lblcomplemento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblcomplemento.ForeColor = SystemColors.InfoText;
            lblcomplemento.Location = new Point(196, 310);
            lblcomplemento.Name = "lblcomplemento";
            lblcomplemento.Size = new Size(0, 21);
            lblcomplemento.TabIndex = 10;
            // 
            // lblendereco
            // 
            lblendereco.AutoSize = true;
            lblendereco.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblendereco.ForeColor = SystemColors.InfoText;
            lblendereco.Location = new Point(196, 260);
            lblendereco.Name = "lblendereco";
            lblendereco.Size = new Size(0, 21);
            lblendereco.TabIndex = 9;
            // 
            // frmbuscacep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(461, 507);
            Controls.Add(lbluf);
            Controls.Add(lblcidade);
            Controls.Add(lblbairro);
            Controls.Add(lblcomplemento);
            Controls.Add(lblendereco);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnfechar);
            Controls.Add(txtcep);
            Controls.Add(label1);
            Controls.Add(btnpesquisar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmbuscacep";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmbuscacep";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnpesquisar;
        private Label label1;
        private TextBox txtcep;
        private Button btnfechar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label lbluf;
        private Label lblcidade;
        private Label lblbairro;
        private Label lblcomplemento;
        private Label lblendereco;
    }
}