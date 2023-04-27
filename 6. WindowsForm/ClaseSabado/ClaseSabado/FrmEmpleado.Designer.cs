namespace ClaseSabado
{
    partial class FrmEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblNombre = new Label();
            lblSueldo = new Label();
            txtNombre = new TextBox();
            txtSueldo = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            btnSeleccionar = new Button();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(74, 258);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(208, 258);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(74, 63);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Location = new Point(74, 128);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(43, 15);
            lblSueldo.TabIndex = 3;
            lblSueldo.Text = "Sueldo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(183, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            txtNombre.Validating += txtNombre_Validating;
            txtNombre.Validated += txtNombre_Validated;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(183, 125);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(100, 23);
            txtSueldo.TabIndex = 5;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(208, 197);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(75, 23);
            btnSeleccionar.TabIndex = 6;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(63, 170);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 327);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(btnSeleccionar);
            Controls.Add(txtSueldo);
            Controls.Add(txtNombre);
            Controls.Add(lblSueldo);
            Controls.Add(lblNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "FrmEmpleado";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmEmpleado";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblNombre;
        private Label lblSueldo;
        private TextBox txtNombre;
        private TextBox txtSueldo;
        private ErrorProvider errorProvider1;
        private PictureBox pictureBox1;
        private Button btnSeleccionar;
        private OpenFileDialog openFileDialog1;
    }
}