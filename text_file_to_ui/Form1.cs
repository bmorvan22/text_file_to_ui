using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text_file_to_ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UserParser parser = new UserParser();
            fillInformations(parser.parseFile(""));
        }

        public void fillInformations(User user)
        {
            this.textBox1.Text = user.name + " " + user.surname;
            this.textBox2.Text = user.birthYear.ToString();
            this.textBox3.Text = user.city;
            this.textBox4.Text = user.faculty;
            this.textBox5.Text = user.role;
            this.textBox6.Text = user.specificAttribute;
            this.label6.Text = user.specificAttributeName;
        }
    }
}
