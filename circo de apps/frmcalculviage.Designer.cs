namespace circideapps
{
    partial class frmcalculviage
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
            btncalcular = new Button();
            label1 = new Label();
            txtdistancia = new TextBox();
            cbbtipo = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtautonomia = new TextBox();
            lblgastototal = new Label();
            lbltotal = new Label();
            lbltempo = new Label();
            btnfechar = new Button();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.BackColor = Color.MediumSpringGreen;
            btncalcular.FlatStyle = FlatStyle.Flat;
            btncalcular.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btncalcular.Location = new Point(422, 63);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(184, 51);
            btncalcular.TabIndex = 0;
            btncalcular.Text = "CALCULAR";
            btncalcular.UseVisualStyleBackColor = false;
            btncalcular.Click += btncalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(50, 39);
            label1.Name = "label1";
            label1.Size = new Size(134, 21);
            label1.TabIndex = 1;
            label1.Text = "DISTANCIA (km)";
            // 
            // txtdistancia
            // 
            txtdistancia.Location = new Point(50, 63);
            txtdistancia.Name = "txtdistancia";
            txtdistancia.Size = new Size(337, 23);
            txtdistancia.TabIndex = 2;
            txtdistancia.TextChanged += txtcombustivel_TextChanged;
            // 
            // cbbtipo
            // 
            cbbtipo.FormattingEnabled = true;
            cbbtipo.Items.AddRange(new object[] { "alcool", "gasolina", "disel" });
            cbbtipo.Location = new Point(50, 142);
            cbbtipo.Name = "cbbtipo";
            cbbtipo.Size = new Size(262, 23);
            cbbtipo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(50, 118);
            label2.Name = "label2";
            label2.Size = new Size(185, 21);
            label2.TabIndex = 4;
            label2.Text = "TIPO DE COMBUSTIVEL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(50, 197);
            label3.Name = "label3";
            label3.Size = new Size(164, 21);
            label3.TabIndex = 5;
            label3.Text = "AUTONOMIA (km/L)";
            // 
            // txtautonomia
            // 
            txtautonomia.Location = new Point(50, 221);
            txtautonomia.Name = "txtautonomia";
            txtautonomia.Size = new Size(337, 23);
            txtautonomia.TabIndex = 6;
            // 
            // lblgastototal
            // 
            lblgastototal.AutoSize = true;
            lblgastototal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblgastototal.Location = new Point(50, 313);
            lblgastototal.Name = "lblgastototal";
            lblgastototal.Size = new Size(0, 21);
            lblgastototal.TabIndex = 8;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbltotal.Location = new Point(50, 365);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(0, 21);
            lbltotal.TabIndex = 9;
            // 
            // lbltempo
            // 
            lbltempo.AutoSize = true;
            lbltempo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbltempo.Location = new Point(50, 414);
            lbltempo.Name = "lbltempo";
            lbltempo.Size = new Size(0, 21);
            lbltempo.TabIndex = 10;
            
            // 
            // btnfechar
            // 
            btnfechar.BackColor = Color.FromArgb(255, 128, 128);
            btnfechar.FlatStyle = FlatStyle.Flat;
            btnfechar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnfechar.Location = new Point(422, 125);
            btnfechar.Name = "btnfechar";
            btnfechar.Size = new Size(184, 51);
            btnfechar.TabIndex = 12;
            btnfechar.Text = "FECHAR";
            btnfechar.UseVisualStyleBackColor = false;
            btnfechar.Click += btnfechar_Click;
            // 
            // frmcalculviage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(636, 563);
            Controls.Add(btnfechar);
            Controls.Add(lbltempo);
            Controls.Add(lbltotal);
            Controls.Add(lblgastototal);
            Controls.Add(txtautonomia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbbtipo);
            Controls.Add(txtdistancia);
            Controls.Add(label1);
            Controls.Add(btncalcular);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmcalculviage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmcalculviaje";
            Load += frmcalculviage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private Label label1;
        private TextBox txtdistancia;
        private ComboBox cbbtipo;
        private Label label2;
        private Label label3;
        private TextBox txtautonomia;
        private Label lblgastototal;
        private Label lbltotal;
        private Label lbltempo;
        private Button btnfechar;
    }
}