using AxAcroPDFLib;

namespace module3_laba5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "װאיכû pdf|*.pdf";
            openFileDialog1.ShowDialog();
            axAcropdf1.LoadFile(openFileDialog1.FileName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
