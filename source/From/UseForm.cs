using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicUnblock
{
    public partial class UseForm : Form
    {
        public UseForm()
        {
            InitializeComponent();
        }

        private void UseForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            UsePic.Width = Properties.Resources.use.Width + 15;
            UsePic.Height = Properties.Resources.use.Height + 30;
            this.Width = Properties.Resources.use.Width + 15;
            this.Height = Properties.Resources.use.Height + 30;
        }

    }
}
