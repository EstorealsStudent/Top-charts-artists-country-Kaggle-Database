using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace TopArtistasRegionSpotify
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form overrides dispose to clean up the component list.
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

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            Label1 = new Label();
            DataGridView1 = new DataGridView();
            DataGridView1.CellDoubleClick += new DataGridViewCellEventHandler(DataGridView1_CellDoubleClick);
            ComboBoxPaises = new ComboBox();
            ComboBoxPaises.SelectedIndexChanged += new EventHandler(ComboBoxPaises_SelectedIndexChanged);
            TextBoxBuscar = new TextBox();
            PictureBox1 = new PictureBox();
            ButtonBuscar = new Button();
            ButtonBuscar.Click += new EventHandler(ButtonBuscar_Click);
            Label2 = new Label();
            Label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 27.75f, FontStyle.Bold, GraphicsUnit.Point);
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(201, -3);
            Label1.Name = "Label1";
            Label1.Size = new Size(344, 50);
            Label1.TabIndex = 0;
            Label1.Text = "Top Artist Country";
            // 
            // DataGridView1
            // 
            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.AllowUserToDeleteRows = false;
            DataGridView1.AllowUserToResizeRows = false;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(40, 40, 40);
            DataGridViewCellStyle1.ForeColor = Color.White;
            DataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            DataGridViewCellStyle1.SelectionForeColor = Color.White;
            DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
            DataGridView1.BackgroundColor = Color.FromArgb(36, 35, 40);
            DataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(17, 17, 17);
            DataGridViewCellStyle2.Font = new Font("Segoe UI", 18.0f, FontStyle.Bold, GraphicsUnit.Point);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.MediumSeaGreen;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.FromArgb(40, 40, 40);
            DataGridViewCellStyle3.Font = new Font("Segoe UI", 18.0f, FontStyle.Regular, GraphicsUnit.Point);
            DataGridViewCellStyle3.ForeColor = Color.White;
            DataGridViewCellStyle3.SelectionBackColor = Color.MediumSeaGreen;
            DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridView1.DefaultCellStyle = DataGridViewCellStyle3;
            DataGridView1.GridColor = Color.FromArgb(36, 35, 40);
            DataGridView1.Location = new Point(12, 155);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.ReadOnly = true;
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle4.BackColor = Color.FromArgb(17, 17, 17);
            DataGridViewCellStyle4.Font = new Font("Segoe UI", 9.0f, FontStyle.Regular, GraphicsUnit.Point);
            DataGridViewCellStyle4.ForeColor = Color.White;
            DataGridViewCellStyle4.SelectionBackColor = Color.MediumSeaGreen;
            DataGridViewCellStyle4.SelectionForeColor = Color.White;
            DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4;
            DataGridViewCellStyle5.BackColor = Color.FromArgb(17, 17, 17);
            DataGridViewCellStyle5.ForeColor = Color.White;
            DataGridViewCellStyle5.SelectionBackColor = Color.MediumSeaGreen;
            DataGridViewCellStyle5.SelectionForeColor = Color.White;
            DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5;
            DataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(17, 17, 17);
            DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(17, 17, 17);
            DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            DataGridView1.RowTemplate.Height = 25;
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView1.ShowCellErrors = false;
            DataGridView1.ShowCellToolTips = false;
            DataGridView1.ShowEditingIcon = false;
            DataGridView1.ShowRowErrors = false;
            DataGridView1.Size = new Size(616, 514);
            DataGridView1.TabIndex = 1;
            // 
            // ComboBoxPaises
            // 
            ComboBoxPaises.FormattingEnabled = true;
            ComboBoxPaises.Location = new Point(406, 123);
            ComboBoxPaises.Name = "ComboBoxPaises";
            ComboBoxPaises.Size = new Size(129, 23);
            ComboBoxPaises.TabIndex = 2;
            // 
            // TextBoxBuscar
            // 
            TextBoxBuscar.Location = new Point(257, 123);
            TextBoxBuscar.Name = "TextBoxBuscar";
            TextBoxBuscar.Size = new Size(143, 23);
            TextBoxBuscar.TabIndex = 3;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.Spotify_logo_without_text_svg;
            PictureBox1.Location = new Point(12, -3);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(161, 152);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 4;
            PictureBox1.TabStop = false;
            // 
            // ButtonBuscar
            // 
            ButtonBuscar.Location = new Point(541, 117);
            ButtonBuscar.Name = "ButtonBuscar";
            ButtonBuscar.Size = new Size(81, 32);
            ButtonBuscar.TabIndex = 5;
            ButtonBuscar.Text = "Buscar";
            ButtonBuscar.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 27.75f, FontStyle.Bold, GraphicsUnit.Point);
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(257, 47);
            Label2.Name = "Label2";
            Label2.Size = new Size(233, 50);
            Label2.TabIndex = 6;
            Label2.Text = "(2000-2023)";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point);
            Label3.ForeColor = Color.White;
            Label3.Location = new Point(163, 123);
            Label3.Name = "Label3";
            Label3.Size = new Size(88, 20);
            Label3.TabIndex = 7;
            Label3.Text = "Artist Name";
            // 
            // Form1
            // 
            AcceptButton = ButtonBuscar;
            AutoScaleDimensions = new SizeF(7.0f, 15.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 17);
            ClientSize = new Size(640, 681);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(ButtonBuscar);
            Controls.Add(PictureBox1);
            Controls.Add(TextBoxBuscar);
            Controls.Add(ComboBoxPaises);
            Controls.Add(DataGridView1);
            Controls.Add(Label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal DataGridView DataGridView1;
        internal ComboBox ComboBoxPaises;
        internal TextBox TextBoxBuscar;
        internal PictureBox PictureBox1;
        internal Button ButtonBuscar;
        internal Label Label2;
        internal Label Label3;
    }
}