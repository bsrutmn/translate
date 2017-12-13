using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace translate
{
    public partial class pdf : Form
    {
        public pdf(string pdf_yolu)
        {
            
            InitializeComponent();
            textBox1.Text = pdf_yolu;
            if (textBox1.Text == null)
            {
                MessageBox.Show("not found PDF path.");
            }
            
        }

        
    }
}
