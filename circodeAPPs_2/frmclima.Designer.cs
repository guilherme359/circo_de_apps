namespace circideapps
{
    partial class frmclima
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
            btnpesquisar = new Button();
            txtcidade = new TextBox();
            lblcidade = new Label();
            lbltemperatura = new Label();
            lbldescricao = new Label();
            lblumidade = new Label();
            lblpressao = new Label();
            btnfechar = new Button();
            lblpais = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 21);
            label1.Name = "label1";
            label1.Size = new Size(252, 32);
            label1.TabIndex = 0;
            label1.Text = "DIGITE UMA CIDADE";
            // 
            // btnpesquisar
            // 
            btnpesquisar.BackColor = Color.LawnGreen;
            btnpesquisar.FlatStyle = FlatStyle.Flat;
            btnpesquisar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnpesquisar.Location = new Point(573, 26);
            btnpesquisar.Name = "btnpesquisar";
            btnpesquisar.Size = new Size(215, 87);
            btnpesquisar.TabIndex = 1;
            btnpesquisar.Text = "PESQUISAR";
            btnpesquisar.UseVisualStyleBackColor = false;
            btnpesquisar.Click += btnpesquisar_Click;
            // 
            // txtcidade
            // 
            txtcidade.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtcidade.Location = new Point(52, 56);
            txtcidade.Name = "txtcidade";
            txtcidade.Size = new Size(504, 29);
            txtcidade.TabIndex = 2;
            // 
            // lblcidade
            // 
            lblcidade.AutoSize = true;
            lblcidade.BackColor = Color.Transparent;
            lblcidade.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblcidade.ForeColor = SystemColors.ControlText;
            lblcidade.Location = new Point(52, 150);
            lblcidade.Name = "lblcidade";
            lblcidade.Size = new Size(0, 25);
            lblcidade.TabIndex = 3;
            // 
            // lbltemperatura
            // 
            lbltemperatura.AutoSize = true;
            lbltemperatura.BackColor = Color.Transparent;
            lbltemperatura.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbltemperatura.ForeColor = SystemColors.ControlText;
            lbltemperatura.Location = new Point(52, 199);
            lbltemperatura.Name = "lbltemperatura";
            lbltemperatura.Size = new Size(0, 25);
            lbltemperatura.TabIndex = 4;
            // 
            // lbldescricao
            // 
            lbldescricao.AutoSize = true;
            lbldescricao.BackColor = Color.Transparent;
            lbldescricao.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbldescricao.ForeColor = SystemColors.ControlText;
            lbldescricao.Location = new Point(52, 257);
            lbldescricao.Name = "lbldescricao";
            lbldescricao.Size = new Size(0, 25);
            lbldescricao.TabIndex = 5;
            // 
            // lblumidade
            // 
            lblumidade.AutoSize = true;
            lblumidade.BackColor = Color.Transparent;
            lblumidade.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblumidade.ForeColor = SystemColors.ControlText;
            lblumidade.Location = new Point(52, 304);
            lblumidade.Name = "lblumidade";
            lblumidade.Size = new Size(0, 25);
            lblumidade.TabIndex = 6;
            // 
            // lblpressao
            // 
            lblpressao.AutoSize = true;
            lblpressao.BackColor = Color.Transparent;
            lblpressao.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblpressao.ForeColor = SystemColors.ControlText;
            lblpressao.Location = new Point(52, 349);
            lblpressao.Name = "lblpressao";
            lblpressao.Size = new Size(0, 25);
            lblpressao.TabIndex = 7;
            // 
            // btnfechar
            // 
            btnfechar.BackColor = Color.Crimson;
            btnfechar.FlatStyle = FlatStyle.Flat;
            btnfechar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnfechar.Location = new Point(573, 119);
            btnfechar.Name = "btnfechar";
            btnfechar.Size = new Size(215, 87);
            btnfechar.TabIndex = 9;
            btnfechar.Text = "FECHAR";
            btnfechar.UseVisualStyleBackColor = false;
            btnfechar.Click += btnfechar_Click;
            // 
            // lblpais
            // 
            lblpais.AutoSize = true;
            lblpais.BackColor = Color.Transparent;
            lblpais.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblpais.ForeColor = SystemColors.ControlText;
            lblpais.Location = new Point(52, 397);
            lblpais.Name = "lblpais";
            lblpais.Size = new Size(0, 25);
            lblpais.TabIndex = 10;
            // 
            // frmclima
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            BackgroundImage = Properties.Resources.Sky_italia_2018;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(lblpais);
            Controls.Add(btnfechar);
            Controls.Add(lblpressao);
            Controls.Add(lblumidade);
            Controls.Add(lbldescricao);
            Controls.Add(lbltemperatura);
            Controls.Add(lblcidade);
            Controls.Add(txtcidade);
            Controls.Add(btnpesquisar);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmclima";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmclima";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnpesquisar;
        private TextBox txtcidade;
        private Label lblcidade;
        private Label lbltemperatura;
        private Label lbldescricao;
        private Label lblumidade;
        private Label lblpressao;
        private Button btnfechar;
        private Label lblpais;
    }
}