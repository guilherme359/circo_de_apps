namespace circideapps
{
    partial class frmcaracoroa
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
            btnjogar = new Button();
            lblresultado = new Label();
            pbxmoeda = new PictureBox();
            btnfechar = new Button();
            lblplacar = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxmoeda).BeginInit();
            SuspendLayout();
            // 
            // btnjogar
            // 
            btnjogar.BackColor = Color.RoyalBlue;
            btnjogar.FlatStyle = FlatStyle.Flat;
            btnjogar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnjogar.Location = new Point(12, 399);
            btnjogar.Name = "btnjogar";
            btnjogar.Size = new Size(206, 103);
            btnjogar.TabIndex = 0;
            btnjogar.Text = "JOGAR";
            btnjogar.UseVisualStyleBackColor = false;
            btnjogar.Click += btnjogar_Click;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.BackColor = Color.Transparent;
            lblresultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblresultado.Location = new Point(12, 21);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(0, 21);
            lblresultado.TabIndex = 1;
            // 
            // pbxmoeda
            // 
            pbxmoeda.BackColor = Color.Transparent;
            pbxmoeda.Location = new Point(265, 160);
            pbxmoeda.Name = "pbxmoeda";
            pbxmoeda.Size = new Size(222, 242);
            pbxmoeda.SizeMode = PictureBoxSizeMode.Zoom;
            pbxmoeda.TabIndex = 2;
            pbxmoeda.TabStop = false;
            // 
            // btnfechar
            // 
            btnfechar.BackColor = Color.Red;
            btnfechar.FlatStyle = FlatStyle.Flat;
            btnfechar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnfechar.Location = new Point(265, 399);
            btnfechar.Name = "btnfechar";
            btnfechar.Size = new Size(206, 103);
            btnfechar.TabIndex = 3;
            btnfechar.Text = "FECHAR";
            btnfechar.UseVisualStyleBackColor = false;
            btnfechar.Click += btnfechar_Click;
            // 
            // lblplacar
            // 
            lblplacar.AutoSize = true;
            lblplacar.BackColor = Color.Transparent;
            lblplacar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblplacar.ForeColor = Color.Red;
            lblplacar.Location = new Point(12, 71);
            lblplacar.Name = "lblplacar";
            lblplacar.Size = new Size(0, 21);
            lblplacar.TabIndex = 4;
            // 
            // frmcaracoroa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            BackgroundImage = Properties.Resources.tigrozo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(483, 528);
            Controls.Add(lblplacar);
            Controls.Add(btnfechar);
            Controls.Add(pbxmoeda);
            Controls.Add(lblresultado);
            Controls.Add(btnjogar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmcaracoroa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmcaracoroa";
            ((System.ComponentModel.ISupportInitialize)pbxmoeda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnjogar;
        private Label lblresultado;
        private PictureBox pbxmoeda;
        private Button btnfechar;
        private Label lblplacar;
        private PictureBox pictureBox1;
    }
}