using QRCoder;

namespace QrCodeGenerator
{
    public partial class Form1 : Form
    {
        private QRCodeGenerator qrGen = new QRCodeGenerator();
        private Bitmap generatedQRCode;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void genQRCode()
        {
            var url = urlTbx.Text;
            QRCodeData qrCodeData = qrGen.CreateQrCode(new PayloadGenerator.Url(url));
            QRCode qrCode = new QRCode(qrCodeData);
            generatedQRCode = qrCode.GetGraphic(10);
            QrPBX.Image = generatedQRCode;
        }

        private void BtnGen_Click(object sender, EventArgs e)
        {
            genQRCode();
        }

        private void urlTbx_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                genQRCode();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveQRCodeFile = new SaveFileDialog();

            // Configuration de la fenêtre
            saveQRCodeFile.AddExtension = true;
            saveQRCodeFile.Title = "Enregistrer le fichier docker-compose.yaml";
            saveQRCodeFile.Filter = "Fichiers png (*.png)|*.png|Tout les fichiers (*.*)|*.*";
            saveQRCodeFile.FilterIndex = 1;
            saveQRCodeFile.FileName = "qrcode.png";
            saveQRCodeFile.RestoreDirectory = true;

            // Traitement de la réponse
            if (saveQRCodeFile.ShowDialog() == DialogResult.OK)
            {
                generatedQRCode.Save(saveQRCodeFile.FileName);
                MessageBox.Show("Fichier enregistré");
            }
        }
    }
}
