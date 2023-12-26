using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Udemy course 
 * Easy C# by Windows Forms
 * 186-189 Project 2
 * I haven't followed the lesson strictly as I has my own ideas on UI
 * as well as efficiency
 */

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
            this.searchItemTextBox.Text = "A";
            this.searchComboBox.SelectedIndex = 0;
            SearchItem();
        }

        private void SearchItemButton_Click(object sender, EventArgs e)
        {
            SearchItem();
        }

        private void SearchItem()
        {
            // On wait message
            this.waitLable.Visible = true;
            this.waitLable.Update();
            try
            {
                if (String.IsNullOrEmpty(this.searchItemTextBox.Text))
                    this.en_word_listTableAdapter.Fill_All(this.eng_dict_ds.en_word_list);
                else
                    this.en_word_listTableAdapter.Fill_Pattern(this.eng_dict_ds.en_word_list, GetSelectCombo());
                this.enwordlistBindingSource.Sort = "word ASC";
            }
            catch (Exception)
            {

                this.waitLable.Visible = false;
                MessageBox.Show("Error accessing data. Please try later");
            }
            //Off wait message
            this.waitLable.Visible = false;
        }
        
        private string GetSelectCombo()
        {
            string result = "";
            if(this.searchComboBox.SelectedIndex == 0) //Equals
            {
                result = this.searchItemTextBox.Text.Trim();
            }
            else if(this.searchComboBox.SelectedIndex == 1) //Starts with
            {
                result = this.searchItemTextBox.Text.Trim() + "%";
            }
            else if (this.searchComboBox.SelectedIndex == 2) //End with
            {
                result = "%" + this.searchItemTextBox.Text.Trim();
            }
            else if (this.searchComboBox.SelectedIndex == 3) //Contains
            {
                result = "%" + this.searchItemTextBox.Text.Trim() + "%";
            }
            else // Jsut in case i miscalculated
            {
                result = this.searchItemTextBox.Text.Trim();
            }
            return result;
        }
    }
}
