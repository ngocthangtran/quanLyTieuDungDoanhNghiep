﻿namespace quanLyTieuDungDn.views.userControll
{
    partial class thongke
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgThongKe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labHanMuc = new System.Windows.Forms.Label();
            this.labTong = new System.Windows.Forms.Label();
            this.labCaNhan = new System.Windows.Forms.Label();
            this.labVuot = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgThongKe
            // 
            this.dgThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgThongKe.Location = new System.Drawing.Point(3, 42);
            this.dgThongKe.Name = "dgThongKe";
            this.dgThongKe.RowHeadersWidth = 51;
            this.dgThongKe.RowTemplate.Height = 24;
            this.dgThongKe.Size = new System.Drawing.Size(1252, 489);
            this.dgThongKe.TabIndex = 0;
            this.dgThongKe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgThongKe_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hạn mức:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 632);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vượt mức:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng hiện tại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 632);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cá nhân:";
            // 
            // labHanMuc
            // 
            this.labHanMuc.AutoSize = true;
            this.labHanMuc.Location = new System.Drawing.Point(141, 562);
            this.labHanMuc.Name = "labHanMuc";
            this.labHanMuc.Size = new System.Drawing.Size(93, 32);
            this.labHanMuc.TabIndex = 2;
            this.labHanMuc.Text = "label5";
            // 
            // labTong
            // 
            this.labTong.AutoSize = true;
            this.labTong.Location = new System.Drawing.Point(615, 562);
            this.labTong.Name = "labTong";
            this.labTong.Size = new System.Drawing.Size(93, 32);
            this.labTong.TabIndex = 2;
            this.labTong.Text = "label5";
            // 
            // labCaNhan
            // 
            this.labCaNhan.AutoSize = true;
            this.labCaNhan.Location = new System.Drawing.Point(615, 632);
            this.labCaNhan.Name = "labCaNhan";
            this.labCaNhan.Size = new System.Drawing.Size(93, 32);
            this.labCaNhan.TabIndex = 2;
            this.labCaNhan.Text = "label5";
            // 
            // labVuot
            // 
            this.labVuot.AutoSize = true;
            this.labVuot.Location = new System.Drawing.Point(141, 632);
            this.labVuot.Name = "labVuot";
            this.labVuot.Size = new System.Drawing.Size(93, 32);
            this.labVuot.TabIndex = 2;
            this.labVuot.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(474, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 46);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thống kê chung";
            // 
            // thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labVuot);
            this.Controls.Add(this.labCaNhan);
            this.Controls.Add(this.labTong);
            this.Controls.Add(this.labHanMuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgThongKe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "thongke";
            this.Size = new System.Drawing.Size(1258, 691);
            this.Load += new System.EventHandler(this.thongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labHanMuc;
        private System.Windows.Forms.Label labTong;
        private System.Windows.Forms.Label labCaNhan;
        private System.Windows.Forms.Label labVuot;
        private System.Windows.Forms.Label label5;
    }
}
