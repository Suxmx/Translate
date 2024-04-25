using MachineTranslation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translate2.SubViews
{
    public partial class MachineTranslate : UserControl
    {
        private Translator translator;
        public MachineTranslate()
        {
            InitializeComponent();
            TranslateBtn.Click += onClickMachineTranslateBtn;
            translator = new Translator();
        }

        private async void onClickMachineTranslateBtn(object sender, EventArgs e)
        {
            string s=await translator.TranslateText(textBox1.Text, "zh");
            textBox2.Text = s;
        }
    }
}
