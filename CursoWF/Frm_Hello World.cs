﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWF
{
    public partial class Frm_HelloWorld : Form
    {
        public Frm_HelloWorld()
        {
            InitializeComponent();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_ModificaLabel_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = Txt_ConteudoLabel.Text;
        }

        

    }
}
