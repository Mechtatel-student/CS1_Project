using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furniture
{
    public partial class Form1 : Form
    {
        List<Client> clients = new List<Client>();
        public Form1()
        {
            
            InitializeComponent();

        }

        
        private void textBox1_Enter(object sender, EventArgs e)
        {
            MiddleName.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Telephones.Items.Add(Telephone.Text);
            Telephone.Clear();
            Telephone.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {  List<string> tel=new List<string>();
            foreach(var t in Telephones.Items )
            {
                tel.Add(t.ToString());
            }
            clients.Add(new Client(FirstName.Text,MiddleName.Text,LastName.Text,
                new Location(City.Text, Adress.Text), tel));
            
        }
    }
}
