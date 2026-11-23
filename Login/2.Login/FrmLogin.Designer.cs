
namespace Ariza.Login;


partial class FrmLogin
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
        panel1 = new Panel();
        label1 = new Label();
        pictureBox1 = new PictureBox();
        txtusuario = new TextBox();
        txtclave = new TextBox();
        btningresar = new Button();
        panel2 = new Panel();
        label2 = new Label();
        label3 = new Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(234, 220, 185);
        panel1.Location = new Point(1, 1);
        panel1.Margin = new Padding(3, 4, 3, 4);
        panel1.Name = "panel1";
        panel1.Size = new Size(249, 833);
        panel1.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(453, 73);
        label1.Name = "label1";
        label1.Size = new Size(209, 70);
        label1.TabIndex = 2;
        label1.Text = "ARIZA";
        // 
        // pictureBox1
        // 
        pictureBox1.BackColor = Color.FromArgb(234, 220, 185);
        pictureBox1.Image = Properties.Resources.arizat;
        pictureBox1.Location = new Point(22, 15);
        pictureBox1.Margin = new Padding(3, 4, 3, 4);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(233, 200);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 3;
        pictureBox1.TabStop = false;
        // 
        // txtusuario
        // 
        txtusuario.Location = new Point(466, 264);
        txtusuario.Margin = new Padding(3, 4, 3, 4);
        txtusuario.Name = "txtusuario";
        txtusuario.Size = new Size(260, 27);
        txtusuario.TabIndex = 3;
        txtusuario.TextChanged += txtusuario_TextChanged;
        // 
        // txtclave
        // 
        txtclave.Location = new Point(466, 400);
        txtclave.Margin = new Padding(3, 4, 3, 4);
        txtclave.Name = "txtclave";
        txtclave.PasswordChar = '*';
        txtclave.Size = new Size(260, 27);
        txtclave.TabIndex = 4;
        // 
        // btningresar
        // 
        btningresar.Location = new Point(544, 504);
        btningresar.Margin = new Padding(3, 4, 3, 4);
        btningresar.Name = "btningresar";
        btningresar.Size = new Size(86, 31);
        btningresar.TabIndex = 5;
        btningresar.Text = "Ingresar";
        btningresar.UseVisualStyleBackColor = true;
        btningresar.Click += btningresar_Click;
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(234, 220, 185);
        panel2.Controls.Add(label1);
        panel2.Controls.Add(pictureBox1);
        panel2.Location = new Point(-8, 1);
        panel2.Margin = new Padding(3, 4, 3, 4);
        panel2.Name = "panel2";
        panel2.Size = new Size(1054, 232);
        panel2.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(383, 400);
        label2.Name = "label2";
        label2.Size = new Size(83, 20);
        label2.TabIndex = 6;
        label2.Text = "Contraseña";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(406, 264);
        label3.Name = "label3";
        label3.Size = new Size(59, 20);
        label3.TabIndex = 7;
        label3.Text = "Usuario";
        // 
        // FrmLogin
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(891, 685);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(panel2);
        Controls.Add(btningresar);
        Controls.Add(txtclave);
        Controls.Add(txtusuario);
        Controls.Add(panel1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "FrmLogin";
        Text = "Ariza - Login";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private PictureBox pictureBox1;
    private Label label1;
    private TextBox txtusuario;
    private TextBox txtclave;
    private Button btningresar;
    private Panel panel2;
    private Label label2;
    private Label label3;
}
