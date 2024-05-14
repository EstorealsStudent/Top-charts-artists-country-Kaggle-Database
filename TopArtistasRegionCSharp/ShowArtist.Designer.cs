using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace TopArtistasRegionSpotify
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ShowArtist : Form
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
            ComboBoxPais = new ComboBox();
            ComboBoxPais.SelectedIndexChanged += new EventHandler(ComboBox1_SelectedIndexChanged);
            TextBoxAristaNombre = new TextBox();
            Label3 = new Label();
            Label1 = new Label();
            ButtonSalir = new Button();
            ButtonSalir.Click += new EventHandler(ButtonSalir_Click);
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            ButtonELIMINAR = new Button();
            ButtonELIMINAR.Click += new EventHandler(ButtonELIMINAR_Click);
            SuspendLayout();
            // 
            // ComboBoxPais
            // 
            ComboBoxPais.FormattingEnabled = true;
            ComboBoxPais.Location = new Point(12, 138);
            ComboBoxPais.Name = "ComboBoxPais";
            ComboBoxPais.Size = new Size(172, 23);
            ComboBoxPais.TabIndex = 0;
            // 
            // TextBoxAristaNombre
            // 
            TextBoxAristaNombre.Location = new Point(12, 66);
            TextBoxAristaNombre.Name = "TextBoxAristaNombre";
            TextBoxAristaNombre.Size = new Size(172, 23);
            TextBoxAristaNombre.TabIndex = 1;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point);
            Label3.ForeColor = Color.White;
            Label3.Location = new Point(12, 43);
            Label3.Name = "Label3";
            Label3.Size = new Size(88, 20);
            Label3.TabIndex = 8;
            Label3.Text = "Artist Name";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point);
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(12, 115);
            Label1.Name = "Label1";
            Label1.Size = new Size(34, 20);
            Label1.TabIndex = 9;
            Label1.Text = "Pais";
            // 
            // ButtonSalir
            // 
            ButtonSalir.Location = new Point(12, 183);
            ButtonSalir.Name = "ButtonSalir";
            ButtonSalir.Size = new Size(81, 32);
            ButtonSalir.TabIndex = 10;
            ButtonSalir.Text = "Exit";
            ButtonSalir.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            Button1.Location = new Point(190, 183);
            Button1.Name = "Button1";
            Button1.Size = new Size(81, 32);
            Button1.TabIndex = 11;
            Button1.Text = "Update";
            Button1.UseVisualStyleBackColor = true;
            // 
            // ButtonELIMINAR
            // 
            ButtonELIMINAR.Location = new Point(103, 183);
            ButtonELIMINAR.Name = "ButtonELIMINAR";
            ButtonELIMINAR.Size = new Size(81, 32);
            ButtonELIMINAR.TabIndex = 12;
            ButtonELIMINAR.Text = "Eliminate";
            ButtonELIMINAR.UseVisualStyleBackColor = true;
            // 
            // ShowArtist
            // 
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(286, 450);
            Controls.Add(ButtonELIMINAR);
            Controls.Add(Button1);
            Controls.Add(ButtonSalir);
            Controls.Add(Label1);
            Controls.Add(Label3);
            Controls.Add(TextBoxAristaNombre);
            Controls.Add(ComboBoxPais);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShowArtist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowArtist";
            ResumeLayout(false);
            PerformLayout();

        }

        internal ComboBox ComboBoxPais;
        internal TextBox TextBoxAristaNombre;
        internal Label Label3;
        internal Label Label1;
        internal Button ButtonSalir;
        internal Button Button1;
        internal Button ButtonELIMINAR;
    }
}