﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class OgrList : Form
    {
        public OgrList()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            //  ogrenciTableAdapter1.Fill(yurtOtomasyonuDataSet31.Ogrenci);
            // This line of code is generated by Data Source Configuration Wizard
            //  this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet3.Ogrenci);
            // This line of code is generated by Data Source Configuration Wizard
            ogrenciTableAdapter3.Fill(yurtOtomasyonuDataSet91.Ogrenci);
        }

        private void OgrList_Load(object sender, EventArgs e)
        {
            
        }
    }
}
