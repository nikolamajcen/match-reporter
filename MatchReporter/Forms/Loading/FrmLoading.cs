﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchReporter.Forms.Loading
{
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
        }

        public FrmLoading(string title, string message)
        {
            InitializeComponent();
            this.Text = title;
            lblMessage.Text = message + "Molimo pričekajte...";
        }
    }
}
