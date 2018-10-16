using System.Windows.Forms;

namespace ArchitecturePro.Util
{
    public static class Mensagem
    {
        public static string nomeSistema { set; get; }
        public static void MensagemShow(string msg, MessageBoxButtons btns, MessageBoxIcon imagem)
        {
            MessageBox.Show(msg, $"Architecture Pro - {nomeSistema}", btns, imagem);
        }
        public static void MensagemShow(string msg, string titulo, MessageBoxButtons btns, MessageBoxIcon imagem)
        {
            MessageBox.Show(msg, $"Architecture Pro - {nomeSistema}", btns, imagem);
        }
        public static DialogResult MensagemShow(string msg, MessageBoxButtons btns, MessageBoxIcon imagem, MessageBoxDefaultButton defaultButton)
        {
            return MessageBox.Show(msg, $"Architecture Pro - {nomeSistema}", btns, imagem, defaultButton);
        }
    }
}
