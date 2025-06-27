namespace circideapps
{
    partial class frmmenu
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
            pbxcalculadora = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pbxbuscacep = new PictureBox();
            label3 = new Label();
            pbxclima = new PictureBox();
            label4 = new Label();
            pbxcpf = new PictureBox();
            label6 = new Label();
            pbxfechar = new PictureBox();
            label7 = new Label();
            pbxdestino = new PictureBox();
            label8 = new Label();
            pbxcaracoroa = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxcalculadora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxbuscacep).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxclima).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxcpf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxfechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxdestino).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxcaracoroa).BeginInit();
            SuspendLayout();
            // 
            // pbxcalculadora
            // 
            pbxcalculadora.BackColor = Color.Transparent;
            pbxcalculadora.Image = Properties.Resources.calculator1;
            pbxcalculadora.Location = new Point(12, 12);
            pbxcalculadora.Name = "pbxcalculadora";
            pbxcalculadora.Size = new Size(248, 279);
            pbxcalculadora.SizeMode = PictureBoxSizeMode.Zoom;
            pbxcalculadora.TabIndex = 0;
            pbxcalculadora.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(56, 294);
            label1.Name = "label1";
            label1.Size = new Size(160, 24);
            label1.TabIndex = 1;
            label1.Text = "CALCULADORA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(339, 294);
            label2.Name = "label2";
            label2.Size = new Size(125, 24);
            label2.TabIndex = 3;
            label2.Text = "BUSCA CEP";
            // 
            // pbxbuscacep
            // 
            pbxbuscacep.BackColor = Color.Transparent;
            pbxbuscacep.Image = Properties.Resources.mailbox;
            pbxbuscacep.Location = new Point(276, 12);
            pbxbuscacep.Name = "pbxbuscacep";
            pbxbuscacep.Size = new Size(248, 279);
            pbxbuscacep.SizeMode = PictureBoxSizeMode.Zoom;
            pbxbuscacep.TabIndex = 2;
            pbxbuscacep.TabStop = false;
            pbxbuscacep.Click += pbxbuscacep_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(626, 294);
            label3.Name = "label3";
            label3.Size = new Size(83, 24);
            label3.TabIndex = 5;
            label3.Text = "TEMPO";
            // 
            // pbxclima
            // 
            pbxclima.BackColor = Color.Transparent;
            pbxclima.Image = Properties.Resources.weather_news;
            pbxclima.Location = new Point(544, 12);
            pbxclima.Name = "pbxclima";
            pbxclima.Size = new Size(248, 279);
            pbxclima.SizeMode = PictureBoxSizeMode.Zoom;
            pbxclima.TabIndex = 4;
            pbxclima.TabStop = false;
            pbxclima.Click += pbxclima_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(879, 294);
            label4.Name = "label4";
            label4.Size = new Size(128, 24);
            label4.TabIndex = 7;
            label4.Text = "VALIDA CPF";
            // 
            // pbxcpf
            // 
            pbxcpf.BackColor = Color.Transparent;
            pbxcpf.Image = Properties.Resources.sheet;
            pbxcpf.Location = new Point(808, 12);
            pbxcpf.Name = "pbxcpf";
            pbxcpf.Size = new Size(248, 279);
            pbxcpf.SizeMode = PictureBoxSizeMode.Zoom;
            pbxcpf.TabIndex = 6;
            pbxcpf.TabStop = false;
            pbxcpf.Click += pbxcpf_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(779, 613);
            label6.Name = "label6";
            label6.Size = new Size(56, 24);
            label6.TabIndex = 13;
            label6.Text = "SAIR";
            // 
            // pbxfechar
            // 
            pbxfechar.BackColor = Color.Transparent;
            pbxfechar.Image = Properties.Resources.emergency_exit;
            pbxfechar.Location = new Point(680, 331);
            pbxfechar.Name = "pbxfechar";
            pbxfechar.Size = new Size(248, 279);
            pbxfechar.SizeMode = PictureBoxSizeMode.Zoom;
            pbxfechar.TabIndex = 12;
            pbxfechar.TabStop = false;
            pbxfechar.Click += pbxfechar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(492, 613);
            label7.Name = "label7";
            label7.Size = new Size(89, 24);
            label7.TabIndex = 11;
            label7.Text = "VIAGEM";
            // 
            // pbxdestino
            // 
            pbxdestino.BackColor = Color.Transparent;
            pbxdestino.Image = Properties.Resources.travel;
            pbxdestino.Location = new Point(417, 331);
            pbxdestino.Name = "pbxdestino";
            pbxdestino.Size = new Size(248, 279);
            pbxdestino.SizeMode = PictureBoxSizeMode.Zoom;
            pbxdestino.TabIndex = 10;
            pbxdestino.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(185, 613);
            label8.Name = "label8";
            label8.Size = new Size(182, 24);
            label8.TabIndex = 9;
            label8.Text = "CARA OU COROA";
            // 
            // pbxcaracoroa
            // 
            pbxcaracoroa.BackColor = Color.Transparent;
            pbxcaracoroa.Image = Properties.Resources.coin_toss;
            pbxcaracoroa.Location = new Point(153, 331);
            pbxcaracoroa.Name = "pbxcaracoroa";
            pbxcaracoroa.Size = new Size(248, 279);
            pbxcaracoroa.SizeMode = PictureBoxSizeMode.Zoom;
            pbxcaracoroa.TabIndex = 8;
            pbxcaracoroa.TabStop = false;
            pbxcaracoroa.Click += pbxcaracoroa_Click;
            // 
            // frmmenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1068, 644);
            Controls.Add(label6);
            Controls.Add(pbxfechar);
            Controls.Add(label7);
            Controls.Add(pbxdestino);
            Controls.Add(label8);
            Controls.Add(pbxcaracoroa);
            Controls.Add(label4);
            Controls.Add(pbxcpf);
            Controls.Add(label3);
            Controls.Add(pbxclima);
            Controls.Add(label2);
            Controls.Add(pbxbuscacep);
            Controls.Add(label1);
            Controls.Add(pbxcalculadora);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmmenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pbxcalculadora).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxbuscacep).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxclima).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxcpf).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxfechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxdestino).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxcaracoroa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxcalculadora;
        private Label label1;
        private Label label2;
        private PictureBox pbxbuscacep;
        private Label label3;
        private PictureBox pbxclima;
        private Label label4;
        private PictureBox pbxcpf;
        private Label label6;
        private PictureBox pbxfechar;
        private Label label7;
        private PictureBox pbxdestino;
        private Label label8;
        private PictureBox pbxcaracoroa;
    }
}