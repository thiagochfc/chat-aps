using System;
using System.Windows.Forms;

namespace chat_aps.View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            new FrmChat().Show();
            Hide();
        }

        private void BtnCriar_Click(object sender, EventArgs e)
        {
            new FrmSala().Show();
            Hide();
        }
    }
}
