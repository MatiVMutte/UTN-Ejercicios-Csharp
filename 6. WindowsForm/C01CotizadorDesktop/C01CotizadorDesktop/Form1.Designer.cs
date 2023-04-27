namespace C01CotizadorDesktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblCotizacion = new Label();
            lblEuro = new Label();
            lblDolar = new Label();
            lblPeso = new Label();
            txtConvertEuroA = new TextBox();
            txtConvertDolarA = new TextBox();
            txtConvertPesoA = new TextBox();
            btnEuroA = new Button();
            btnDolarA = new Button();
            btnPesoA = new Button();
            btnBlockCotizacion = new Button();
            txtCotizaEuroDolar = new TextBox();
            txtCotizaDolar = new TextBox();
            txtCotizaPesoDolar = new TextBox();
            lblEuro2 = new Label();
            lblDolar2 = new Label();
            lblPeso2 = new Label();
            txtEuroConvertEuro = new TextBox();
            txtDolarConvertEuro = new TextBox();
            txtPesoConvertEuro = new TextBox();
            txtEuroConvertDolar = new TextBox();
            txtDolarConvertDolar = new TextBox();
            txtPesoConvertDolar = new TextBox();
            txtEuroConvertPeso = new TextBox();
            txtDolarConvertPeso = new TextBox();
            txtPesoConvertPeso = new TextBox();
            SuspendLayout();
            // 
            // lblCotizacion
            // 
            lblCotizacion.AutoSize = true;
            lblCotizacion.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCotizacion.Location = new Point(83, 28);
            lblCotizacion.Name = "lblCotizacion";
            lblCotizacion.Size = new Size(100, 21);
            lblCotizacion.TabIndex = 0;
            lblCotizacion.Text = "Cotizacion";
            // 
            // lblEuro
            // 
            lblEuro.AutoSize = true;
            lblEuro.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEuro.Location = new Point(12, 82);
            lblEuro.Name = "lblEuro";
            lblEuro.Size = new Size(46, 21);
            lblEuro.TabIndex = 1;
            lblEuro.Text = "Euro";
            // 
            // lblDolar
            // 
            lblDolar.AutoSize = true;
            lblDolar.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDolar.Location = new Point(12, 129);
            lblDolar.Name = "lblDolar";
            lblDolar.Size = new Size(55, 21);
            lblDolar.TabIndex = 2;
            lblDolar.Text = "Dolar";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPeso.Location = new Point(12, 173);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(46, 21);
            lblPeso.TabIndex = 3;
            lblPeso.Text = "Peso";
            // 
            // txtConvertEuroA
            // 
            txtConvertEuroA.Location = new Point(83, 82);
            txtConvertEuroA.Name = "txtConvertEuroA";
            txtConvertEuroA.PlaceholderText = "Valor a convertir";
            txtConvertEuroA.Size = new Size(119, 23);
            txtConvertEuroA.TabIndex = 4;
            // 
            // txtConvertDolarA
            // 
            txtConvertDolarA.Location = new Point(83, 129);
            txtConvertDolarA.Name = "txtConvertDolarA";
            txtConvertDolarA.PlaceholderText = "Valor a convertir";
            txtConvertDolarA.Size = new Size(119, 23);
            txtConvertDolarA.TabIndex = 5;
            // 
            // txtConvertPesoA
            // 
            txtConvertPesoA.Location = new Point(83, 175);
            txtConvertPesoA.Name = "txtConvertPesoA";
            txtConvertPesoA.PlaceholderText = "Valor a convertir";
            txtConvertPesoA.Size = new Size(119, 23);
            txtConvertPesoA.TabIndex = 6;
            // 
            // btnEuroA
            // 
            btnEuroA.Enabled = false;
            btnEuroA.Location = new Point(230, 82);
            btnEuroA.Name = "btnEuroA";
            btnEuroA.Size = new Size(91, 23);
            btnEuroA.TabIndex = 7;
            btnEuroA.Text = "->";
            btnEuroA.UseVisualStyleBackColor = true;
            btnEuroA.Click += btnEuroA_Click;
            // 
            // btnDolarA
            // 
            btnDolarA.Enabled = false;
            btnDolarA.Location = new Point(230, 130);
            btnDolarA.Name = "btnDolarA";
            btnDolarA.Size = new Size(91, 23);
            btnDolarA.TabIndex = 8;
            btnDolarA.Text = "->";
            btnDolarA.UseVisualStyleBackColor = true;
            btnDolarA.Click += btnDolarA_Click;
            // 
            // btnPesoA
            // 
            btnPesoA.Enabled = false;
            btnPesoA.Location = new Point(230, 175);
            btnPesoA.Name = "btnPesoA";
            btnPesoA.Size = new Size(91, 23);
            btnPesoA.TabIndex = 9;
            btnPesoA.Text = "->";
            btnPesoA.UseVisualStyleBackColor = true;
            btnPesoA.Click += btnPesoA_Click;
            // 
            // btnBlockCotizacion
            // 
            btnBlockCotizacion.BackgroundImage = Resources.Imagenes.candado_abierto;
            btnBlockCotizacion.BackgroundImageLayout = ImageLayout.Zoom;
            btnBlockCotizacion.FlatAppearance.BorderColor = Color.Gray;
            btnBlockCotizacion.FlatAppearance.MouseDownBackColor = Color.White;
            btnBlockCotizacion.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnBlockCotizacion.FlatStyle = FlatStyle.Flat;
            btnBlockCotizacion.Location = new Point(230, 22);
            btnBlockCotizacion.Name = "btnBlockCotizacion";
            btnBlockCotizacion.Size = new Size(91, 37);
            btnBlockCotizacion.TabIndex = 3;
            btnBlockCotizacion.UseVisualStyleBackColor = true;
            btnBlockCotizacion.Click += btnBlockCotizacion_Click;
            // 
            // txtCotizaEuroDolar
            // 
            txtCotizaEuroDolar.Location = new Point(366, 30);
            txtCotizaEuroDolar.Name = "txtCotizaEuroDolar";
            txtCotizaEuroDolar.PlaceholderText = "Cotizacion Euro";
            txtCotizaEuroDolar.Size = new Size(119, 23);
            txtCotizaEuroDolar.TabIndex = 1;
            // 
            // txtCotizaDolar
            // 
            txtCotizaDolar.Location = new Point(520, 30);
            txtCotizaDolar.Name = "txtCotizaDolar";
            txtCotizaDolar.ReadOnly = true;
            txtCotizaDolar.Size = new Size(119, 23);
            txtCotizaDolar.TabIndex = 12;
            txtCotizaDolar.Text = "1";
            txtCotizaDolar.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCotizaPesoDolar
            // 
            txtCotizaPesoDolar.Location = new Point(669, 30);
            txtCotizaPesoDolar.Name = "txtCotizaPesoDolar";
            txtCotizaPesoDolar.PlaceholderText = "Cotizacion Peso";
            txtCotizaPesoDolar.Size = new Size(119, 23);
            txtCotizaPesoDolar.TabIndex = 2;
            // 
            // lblEuro2
            // 
            lblEuro2.AutoSize = true;
            lblEuro2.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEuro2.Location = new Point(404, 56);
            lblEuro2.Name = "lblEuro2";
            lblEuro2.Size = new Size(46, 21);
            lblEuro2.TabIndex = 14;
            lblEuro2.Text = "Euro";
            // 
            // lblDolar2
            // 
            lblDolar2.AutoSize = true;
            lblDolar2.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDolar2.Location = new Point(553, 56);
            lblDolar2.Name = "lblDolar2";
            lblDolar2.Size = new Size(55, 21);
            lblDolar2.TabIndex = 15;
            lblDolar2.Text = "Dolar";
            // 
            // lblPeso2
            // 
            lblPeso2.AutoSize = true;
            lblPeso2.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPeso2.Location = new Point(707, 56);
            lblPeso2.Name = "lblPeso2";
            lblPeso2.Size = new Size(46, 21);
            lblPeso2.TabIndex = 16;
            lblPeso2.Text = "Peso";
            // 
            // txtEuroConvertEuro
            // 
            txtEuroConvertEuro.Enabled = false;
            txtEuroConvertEuro.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtEuroConvertEuro.Location = new Point(366, 84);
            txtEuroConvertEuro.Name = "txtEuroConvertEuro";
            txtEuroConvertEuro.Size = new Size(119, 25);
            txtEuroConvertEuro.TabIndex = 17;
            // 
            // txtDolarConvertEuro
            // 
            txtDolarConvertEuro.Enabled = false;
            txtDolarConvertEuro.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtDolarConvertEuro.Location = new Point(366, 131);
            txtDolarConvertEuro.Name = "txtDolarConvertEuro";
            txtDolarConvertEuro.Size = new Size(119, 25);
            txtDolarConvertEuro.TabIndex = 18;
            // 
            // txtPesoConvertEuro
            // 
            txtPesoConvertEuro.Enabled = false;
            txtPesoConvertEuro.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPesoConvertEuro.Location = new Point(366, 175);
            txtPesoConvertEuro.Name = "txtPesoConvertEuro";
            txtPesoConvertEuro.Size = new Size(119, 25);
            txtPesoConvertEuro.TabIndex = 19;
            // 
            // txtEuroConvertDolar
            // 
            txtEuroConvertDolar.Enabled = false;
            txtEuroConvertDolar.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtEuroConvertDolar.Location = new Point(520, 84);
            txtEuroConvertDolar.Name = "txtEuroConvertDolar";
            txtEuroConvertDolar.Size = new Size(119, 25);
            txtEuroConvertDolar.TabIndex = 20;
            // 
            // txtDolarConvertDolar
            // 
            txtDolarConvertDolar.Enabled = false;
            txtDolarConvertDolar.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtDolarConvertDolar.Location = new Point(520, 131);
            txtDolarConvertDolar.Name = "txtDolarConvertDolar";
            txtDolarConvertDolar.Size = new Size(119, 25);
            txtDolarConvertDolar.TabIndex = 21;
            // 
            // txtPesoConvertDolar
            // 
            txtPesoConvertDolar.Enabled = false;
            txtPesoConvertDolar.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPesoConvertDolar.Location = new Point(520, 176);
            txtPesoConvertDolar.Name = "txtPesoConvertDolar";
            txtPesoConvertDolar.Size = new Size(119, 25);
            txtPesoConvertDolar.TabIndex = 22;
            // 
            // txtEuroConvertPeso
            // 
            txtEuroConvertPeso.Enabled = false;
            txtEuroConvertPeso.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtEuroConvertPeso.Location = new Point(669, 84);
            txtEuroConvertPeso.Name = "txtEuroConvertPeso";
            txtEuroConvertPeso.Size = new Size(119, 25);
            txtEuroConvertPeso.TabIndex = 23;
            // 
            // txtDolarConvertPeso
            // 
            txtDolarConvertPeso.Enabled = false;
            txtDolarConvertPeso.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtDolarConvertPeso.Location = new Point(669, 131);
            txtDolarConvertPeso.Name = "txtDolarConvertPeso";
            txtDolarConvertPeso.Size = new Size(119, 25);
            txtDolarConvertPeso.TabIndex = 24;
            // 
            // txtPesoConvertPeso
            // 
            txtPesoConvertPeso.Enabled = false;
            txtPesoConvertPeso.Font = new Font("Cascadia Code", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPesoConvertPeso.Location = new Point(669, 176);
            txtPesoConvertPeso.Name = "txtPesoConvertPeso";
            txtPesoConvertPeso.Size = new Size(119, 25);
            txtPesoConvertPeso.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 220);
            Controls.Add(txtPesoConvertPeso);
            Controls.Add(txtDolarConvertPeso);
            Controls.Add(txtEuroConvertPeso);
            Controls.Add(txtPesoConvertDolar);
            Controls.Add(txtDolarConvertDolar);
            Controls.Add(txtEuroConvertDolar);
            Controls.Add(txtPesoConvertEuro);
            Controls.Add(txtDolarConvertEuro);
            Controls.Add(txtEuroConvertEuro);
            Controls.Add(lblPeso2);
            Controls.Add(lblDolar2);
            Controls.Add(lblEuro2);
            Controls.Add(txtCotizaPesoDolar);
            Controls.Add(txtCotizaDolar);
            Controls.Add(txtCotizaEuroDolar);
            Controls.Add(btnBlockCotizacion);
            Controls.Add(btnPesoA);
            Controls.Add(btnDolarA);
            Controls.Add(btnEuroA);
            Controls.Add(txtConvertPesoA);
            Controls.Add(txtConvertDolarA);
            Controls.Add(txtConvertEuroA);
            Controls.Add(lblPeso);
            Controls.Add(lblDolar);
            Controls.Add(lblEuro);
            Controls.Add(lblCotizacion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCotizacion;
        private Label lblEuro;
        private Label lblDolar;
        private Label lblPeso;
        private TextBox txtConvertEuroA;
        private TextBox txtConvertDolarA;
        private TextBox txtConvertPesoA;
        private Button btnEuroA;
        private Button btnDolarA;
        private Button btnPesoA;
        private Button btnBlockCotizacion;
        private TextBox txtCotizaEuroDolar;
        private TextBox txtCotizaDolar;
        private TextBox txtCotizaPesoDolar;
        private Label lblEuro2;
        private Label lblDolar2;
        private Label lblPeso2;
        private TextBox txtEuroConvertEuro;
        private TextBox txtDolarConvertEuro;
        private TextBox txtPesoConvertEuro;
        private TextBox txtEuroConvertDolar;
        private TextBox txtDolarConvertDolar;
        private TextBox txtPesoConvertDolar;
        private TextBox txtEuroConvertPeso;
        private TextBox txtDolarConvertPeso;
        private TextBox txtPesoConvertPeso;
    }
}