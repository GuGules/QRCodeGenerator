namespace QrCodeGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            urlTbx = new TextBox();
            BtnGen = new Button();
            QrPBX = new PictureBox();
            btnQuit = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)QrPBX).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 364);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 0;
            label1.Text = "Url ou texte à encoder :";
            // 
            // urlTbx
            // 
            urlTbx.Location = new Point(178, 361);
            urlTbx.Name = "urlTbx";
            urlTbx.Size = new Size(331, 23);
            urlTbx.TabIndex = 1;
            urlTbx.KeyUp += urlTbx_KeyUp;
            // 
            // BtnGen
            // 
            BtnGen.Location = new Point(96, 399);
            BtnGen.Name = "BtnGen";
            BtnGen.Size = new Size(345, 30);
            BtnGen.TabIndex = 2;
            BtnGen.Text = "Générer Qr Code";
            BtnGen.UseVisualStyleBackColor = true;
            BtnGen.Click += BtnGen_Click;
            // 
            // QrPBX
            // 
            QrPBX.Location = new Point(108, 27);
            QrPBX.Name = "QrPBX";
            QrPBX.Size = new Size(344, 315);
            QrPBX.TabIndex = 3;
            QrPBX.TabStop = false;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(96, 471);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(345, 30);
            btnQuit.TabIndex = 4;
            btnQuit.Text = "Fermer l'application";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(96, 435);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(345, 30);
            btnSave.TabIndex = 5;
            btnSave.Text = "Enregistrer sous...";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 531);
            Controls.Add(btnSave);
            Controls.Add(btnQuit);
            Controls.Add(QrPBX);
            Controls.Add(BtnGen);
            Controls.Add(urlTbx);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "QrCodeGenerator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)QrPBX).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox urlTbx;
        private Button BtnGen;
        private PictureBox QrPBX;
        private Button btnQuit;
        private Button btnSave;
    }
}
