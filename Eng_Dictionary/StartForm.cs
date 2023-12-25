using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eng_Dictionary
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eng_dict_ds.en_word_list' table. You can move, or remove it, as needed.
            this.en_word_listTableAdapter.Fill_All(this.eng_dict_ds.en_word_list);


        }
    }
}
