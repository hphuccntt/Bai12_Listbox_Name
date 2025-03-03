﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai12_Listbox_Name
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> ten = new List<string>();
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //lstName.Items.Add(txtName.Text);
           // txtName.Text = "";
           // txtName.Focus();
            ten.Add(txtName.Text);
            foreach (string t in ten)
            {
                lstName.Items.Add(t);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(lstName.SelectedIndex < 0)
            {
                MessageBox.Show(" Hãy Chọn Tên Trong Danh Sách", " Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lstName.Items[lstName.SelectedIndex] = txtName.Text;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstName.Items.Add ( " Ấn Vào Đây ");
            lstName.Items.Add ( " Ấn Vào Đây ");
            lstName.Items.Add ( " Ấn Vào Đây ");
            
        }

        private void lstName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstName.SelectedIndex < 0)
            {
                return;
            }
           txtName.Text = lstName.Items [lstName.SelectedIndex].ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstName.SelectedIndex >= 0) ;
            {
               
               lstName.Items.RemoveAt (lstName.SelectedIndex);
            }
        }

        private void btnInSert_Click(object sender, EventArgs e)
        {
            // lstName.Items.Insert ( convert.ToInt32(txtIndext.text), txtName.Text);
            if ( lstName.SelectedIndex >= 0)
            {
                lstName.Items.Insert(lstName.SelectedIndex, txtName.Text);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string t in ten)
            {
                lstName.Items.Add(t);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
