using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Tester
{
    public partial class SimplestSample : Form
    {
        public SimplestSample()
        {
            InitializeComponent();
        }

        private void SimplestSample_Load(object sender, EventArgs e)
        {
            autocompleteMenu1.SetAutocompleteMenu(scintilla1, autocompleteMenu1);
            autocompleteMenu2.SetAutocompleteMenu(scintilla1, autocompleteMenu2);
        }
    }
}
