﻿using BIT706_A1_5030521;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Customers
{
    public partial class CustomerAccount : Customers.BaseForm
    {

        protected BindingSource custBinding = new BindingSource();
        public CustomerAccount()
        {
            InitializeComponent();

            custBinding.DataSource = Controller.customers;
            listCustomers2.DataSource = custBinding;
            listCustomers2.DisplayMember = "IdFullName";
            listCustomers2.ValueMember = "ID";
            searchCustTextBox2.SelectionStart = 0;
        }

        private void btnManageCustAcc_Click(object sender, EventArgs e)
        {
            this.Close();
            AcManagement AM = new AcManagement();
            AM.Show();
        }

        private void btn_backmm2_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Menu M_M = new Main_Menu();
            M_M.Show();
        }
    }
}