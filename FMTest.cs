using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxs
{
    public partial class FMTest : Form
    {
        public void ShowMessage(string msg)
        {
            this.Dispatcher.Invoke(new MessageBoxShow(MessageBoxShow_F), new object[] { msg });
        }

        delegate void MessageBoxShow(string msg);
        void MessageBoxShow_F(string msg)
        {
            MessageBox.Show(msg, "提示信息", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public FMTest()
        {
            InitializeComponent();
        }

        private void FMTest_Load(object sender, EventArgs e)
        {
           // MessageBox
        }
    }
}
