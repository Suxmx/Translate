using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translate2
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Dictionary<ELanguage, string> m_Language2str = new Dictionary<ELanguage, string>
            {
                { ELanguage.Auto, "Auto" },
                { ELanguage.English,"English" },
                { ELanguage.Chinese, "Chinese" },
                { ELanguage.Japanese, "Japanese" }

            };
            foreach(ELanguage key in System.Enum.GetValues(typeof(ELanguage)))
            {
                comboBox1.Items.Add(m_Language2str[key]);
            }
            comboBox1.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
