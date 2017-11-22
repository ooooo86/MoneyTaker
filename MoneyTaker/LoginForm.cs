﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoneyTaker
{
    public partial class LoginForm : Form
    {

        private RootForm rootForm = null;
        private Register_Agree_Form register_Agree_Form;


        public LoginForm()
        {
            InitializeComponent();
            
        }

        public void setRootForm(RootForm rootForm)
        {
            this.rootForm = rootForm;
        }

        public RootForm getRootForm()
        {
            return rootForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rootForm.getRootPanel().Controls.Clear();

            register_Agree_Form.setLoginForm(this);
            register_Agree_Form.TopLevel = false;

            rootForm.getRootPanel().Controls.Add(register_Agree_Form);
            register_Agree_Form.Show();
        }

        private void backPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            register_Agree_Form = new Register_Agree_Form();
        }
    }
}
