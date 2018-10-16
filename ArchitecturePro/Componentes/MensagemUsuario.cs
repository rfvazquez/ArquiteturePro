using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchitecturePro.Componentes
{
    public partial class MensagemUsuario : UserControl
    {
        public string usuario { set; get; }
        public string msg { set; get; }
        public Color corFundo { set; get; } 


        public void MontaMensagem()
        {
            lblUsuario.Text = usuario;
            lblMsg.Text = msg;
            this.BackColor = corFundo;
        }

        public MensagemUsuario()
        {
            InitializeComponent();
        }
    }
}
