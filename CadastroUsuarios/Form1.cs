using System.Diagnostics;

namespace CadastroUsuarios
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVS_Click(object sender, EventArgs e)
        {
            Process.Start("\"C:\\Program Files\\Microsoft VS Code\\Code.exe\"");
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            Process.Start("Notepad.exe");
        }

        private void btngoogle(object sender, EventArgs e)
        {
            String path = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
        }
    }
}
