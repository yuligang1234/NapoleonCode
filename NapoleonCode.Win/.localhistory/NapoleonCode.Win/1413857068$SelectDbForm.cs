
using System.Windows.Forms;

namespace NapoleonCode.Win
{
    public partial class SelectDbForm : BaseForm
    {



        public SelectDbForm()
        {
            InitializeComponent();
        }

        private void SelectDbForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



    }
}
