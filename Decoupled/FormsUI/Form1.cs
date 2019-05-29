using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Decoupled;

namespace FormsUI
{
    public partial class Form1 : Form
    {
        IPerson p1 = new Employee("John Snow", 35, "Winterfell");
        IPerson p2 = new Customer("Sansa Stark", 18, "Kigs Landing");
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lblEmployee.Text = p1.DisplayInfo();
            lblCustomer.Text = p2.DisplayInfo();
        }
    }
}
