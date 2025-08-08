using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectApp
{
    public partial class FinalProjectForm : Form
    {

        public FinalProjectForm()
        {
            InitializeComponent();
        }

        int userInputBtnPressed;

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            //handle adding an item
            if (addItemDropdown.SelectedItem != null)
            {
                string dropdownTemp = addItemDropdown.SelectedItem.ToString();
              
                if (dropdownTemp == "Physical Video Game")
                {


                }
                else if (dropdownTemp == "Physical Music")
                {
                }
                else if (dropdownTemp == "Physical Table Game")
                {
                }
                else if (dropdownTemp == "Physical Reading")
                {
                }
                else if (dropdownTemp == "Other Physical Media")
                {
                }
                else
                {
                    userInputPromptLbl.Text = "Error: Invalid Selection from Dropdown";
                }
            }


        }

        private void EditItemBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteItemBtn_Click(object sender, EventArgs e)
        {
     
        }

        private void addItemDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void userItemDetailInputLbl_Click(object sender, EventArgs e)
        {

        }

        private void enterUserInputBtn_Click(object sender, EventArgs e)
        {
            if (userInputTxtBox != null)
            {
                userInputBtnPressed = 1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
