﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanLyTieuDungDn.controller;

namespace quanLyTieuDungDn.views.userControll
{
    public partial class thongke : UserControl
    {
        public delegate void sendId(int id_ndung, int id_phong);
        public sendId sen;
        private int id_ndung, id_phong;
        public thongke()
        {
            InitializeComponent();
            sen = new sendId(setId);
        }

        public void setId(int id_ndung, int id_phong)
        {
            this.id_ndung = id_ndung;
            this.id_phong = id_phong;
            thongkeController controllerThongke = new thongkeController();
            controllerThongke.dataBangThongKe(this.id_phong);
            dgThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgThongKe.DataSource = controllerThongke.DataTable;

            controllerThongke.setDataLable(id_ndung, id_phong);
            labCaNhan.Text = string.Format("{0:#,##0.00}", controllerThongke.DataLable.C_nhan);
            labHanMuc.Text = string.Format("{0:#,##0.00}", controllerThongke.DataLable.H_muc);
            labTong.Text = string.Format("{0:#,##0.00}", controllerThongke.DataLable.S_phong);
            labVuot.Text = string.Format("{0:#,##0.00}", controllerThongke.DataLable.V_muc);
        }

        private void thongke_Load(object sender, EventArgs e)
        {
        }
    }
}
