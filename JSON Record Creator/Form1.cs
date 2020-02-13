using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSON_Record_Creator
{
    public partial class Form1 : Form
    {
        private string id;


        public Form1()
        {
            InitializeComponent();
        }

        private void Id_textBox_TextChanged(object sender, EventArgs e)
        {
            id = sender.ToString();
        }

        private void CreateJSON_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(id);
        }
    }
}
