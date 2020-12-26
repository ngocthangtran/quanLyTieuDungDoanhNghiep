﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanLyTieuDungDn.Model.Object;
using quanLyTieuDungDn.Model;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace quanLyTieuDungDn.controller
{
    class QuanLyController
    {
        private QuanLyModel quanLy;
        public DataTable phong, viewTieuDung, viewNhanVien;
        private int id_phong, id_tthai;
        public QuanLyController()
        {
            quanLy = new QuanLyModel();
            this.phong = quanLy.viewPhong;
        }
        //Kiểm duyệt
        public ArrayList ArrPhong()
        {
            ArrayList arrPhong = new ArrayList();
            foreach (DataRow dr in phong.Rows)
            {
                Phong p = new Phong();
                p.Id_phong = (int)dr["id"];
                p.T_phong = dr["Tên phòng"].ToString();
                arrPhong.Add(p);
            }
            return arrPhong;
        }
        public QuanLyController(NguoiDung ng, int id_phong, int id_tthai)
        {
            this.id_phong = id_phong;
            this.id_tthai = id_tthai;
            quanLy = new QuanLyModel(ng, id_phong, id_tthai);
            loadTable();
        }
        private void loadTable()
        {
            if (quanLy.viewTieuDung != null)
            {
                this.viewTieuDung = quanLy.viewTieuDung;
                
            }
            else
            {
                MessageBox.Show("Lỗi lấy dữ liệu tiêu dùng");
            }
            this.phong = quanLy.viewPhong;
        }
        public void CapNhatDataTieuDung(int row, TieuDung td)
        {
            if (row != -1)
            {
                if (td.Gia == 0)
                {
                    MessageBox.Show("Giá không hợp lệ");
                }
                else
                {
                    quanLy.KiemDuyetTieuDung(row, td);
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn dòng");
            }
        }
        //Phòng
        public QuanLyController(int id_phong)
        {
            quanLy = new QuanLyModel(id_phong);
            this.viewNhanVien = quanLy.viewNhanVien;
            this.viewTieuDung = quanLy.viewTieuDung;
            this.phong = quanLy.viewPhong;
        }
        public void ThemPhong(Phong p)
        {
            string mess = "";
            if (p.T_phong.Length == 0 || p.T_phong.Length>20)
            {
                mess += "Tên phòng còn trống\n";
            }
            if (p.H_muc == 0 || Int32.TryParse(p.H_muc.ToString(), out int i)==false)
            {
                mess += "Hạn mức không hợp lệ";
            }
            if (mess.Length == 0)
            {
                quanLy.ThemPhong(p);
            }
            else
            {
                MessageBox.Show(mess);
            }
        }
        public void SuaPhong(Phong p, int row)
        {
            if (row != -1)
            {
                string mess = "";
                if (p.T_phong.Length == 0)
                {
                    mess += "Tên phòng còn trống\n";
                }
                if (p.H_muc == 0)
                {
                    mess += "Hạn mức không hợp lệ";
                }
                if (mess.Length == 0)
                {
                    quanLy.SuaPhong(p, row);
                }
                else
                {
                    MessageBox.Show(mess);
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn dòng");
            }
        }
        public void XoaPhong(int row)
        {
            if (row != -1)
            {
                quanLy.XoaPhong(row);
            }
            else
            {
                MessageBox.Show("Bạn phải chọn dòng");
            }
        }
        public void CapNhatDatabasePhong()
        {
            quanLy.CapNhatDatabasePhong();
        }
    }
    
    //Nhân viên

}
