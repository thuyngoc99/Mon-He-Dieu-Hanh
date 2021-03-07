namespace Baitap3
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTaiungdung = new System.Windows.Forms.Button();
            this.btnDongungdung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader,
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(151, 48);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(323, 351);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader
            // 
            this.columnHeader.Text = "Tên ứng dụng";
            this.columnHeader.Width = 219;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 100;
            // 
            // btnTaiungdung
            // 
            this.btnTaiungdung.Location = new System.Drawing.Point(567, 72);
            this.btnTaiungdung.Name = "btnTaiungdung";
            this.btnTaiungdung.Size = new System.Drawing.Size(110, 31);
            this.btnTaiungdung.TabIndex = 1;
            this.btnTaiungdung.Text = "Tải ứng dụng";
            this.btnTaiungdung.UseVisualStyleBackColor = true;
            this.btnTaiungdung.Click += new System.EventHandler(this.btnTaiungdung_Click);
            // 
            // btnDongungdung
            // 
            this.btnDongungdung.Location = new System.Drawing.Point(567, 120);
            this.btnDongungdung.Name = "btnDongungdung";
            this.btnDongungdung.Size = new System.Drawing.Size(110, 31);
            this.btnDongungdung.TabIndex = 1;
            this.btnDongungdung.Text = "Đóng ứng dụng";
            this.btnDongungdung.UseVisualStyleBackColor = true;
            this.btnDongungdung.Click += new System.EventHandler(this.btnDongungdung_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDongungdung);
            this.Controls.Add(this.btnTaiungdung);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnTaiungdung;
        private System.Windows.Forms.Button btnDongungdung;
    }
}

