using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace TopArtistasRegionSpotify
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Login : Form
    {

        // Form reemplaza a Dispose para limpiar la lista de componentes.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Requerido por el Diseñador de Windows Forms
        private System.ComponentModel.IContainer components;

        // NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        // Se puede modificar usando el Diseñador de Windows Forms.  
        // No lo modifique con el editor de código.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            TextBoxUsername = new TextBox();
            TextBoxPassword = new TextBox();
            Label1 = new Label();
            Label2 = new Label();
            ButtonExit = new Button();
            ButtonExit.Click += new EventHandler(ButtonExit_Click);
            ButtonEntrar = new Button();
            ButtonEntrar.Click += new EventHandler(ButtonEntrar_Click);
            PictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TextBoxUsername
            // 
            TextBoxUsername.Location = new Point(32, 171);
            TextBoxUsername.Name = "TextBoxUsername";
            TextBoxUsername.Size = new Size(212, 23);
            TextBoxUsername.TabIndex = 0;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Location = new Point(32, 219);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.PasswordChar = '*';
            TextBoxPassword.Size = new Size(212, 23);
            TextBoxPassword.TabIndex = 1;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.ForeColor = SystemColors.Control;
            Label1.Location = new Point(32, 153);
            Label1.Name = "Label1";
            Label1.Size = new Size(60, 15);
            Label1.TabIndex = 2;
            Label1.Text = "Username";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.ForeColor = SystemColors.Control;
            Label2.Location = new Point(32, 201);
            Label2.Name = "Label2";
            Label2.Size = new Size(57, 15);
            Label2.TabIndex = 3;
            Label2.Text = "Password";
            // 
            // ButtonExit
            // 
            ButtonExit.Location = new Point(32, 270);
            ButtonExit.Name = "ButtonExit";
            ButtonExit.Size = new Size(75, 23);
            ButtonExit.TabIndex = 4;
            ButtonExit.Text = "Exit";
            ButtonExit.UseVisualStyleBackColor = true;
            // 
            // ButtonEntrar
            // 
            ButtonEntrar.Location = new Point(169, 270);
            ButtonEntrar.Name = "ButtonEntrar";
            ButtonEntrar.Size = new Size(75, 23);
            ButtonEntrar.TabIndex = 5;
            ButtonEntrar.Text = "sign in";
            ButtonEntrar.UseVisualStyleBackColor = true;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.Spotify_logo_without_text_svg;
            PictureBox1.Location = new Point(32, 7);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(196, 143);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 6;
            PictureBox1.TabStop = false;
            // 
            // Login
            // 
            AcceptButton = ButtonEntrar;
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(284, 334);
            Controls.Add(PictureBox1);
            Controls.Add(ButtonEntrar);
            Controls.Add(ButtonExit);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(TextBoxPassword);
            Controls.Add(TextBoxUsername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(Login_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal TextBox TextBoxUsername;
        internal TextBox TextBoxPassword;
        internal Label Label1;
        internal Label Label2;
        internal Button ButtonExit;
        internal Button ButtonEntrar;
        internal PictureBox PictureBox1;
    }
}