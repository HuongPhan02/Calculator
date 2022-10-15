namespace Calculator
{
    partial class TinhToan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số b";
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(179, 104);
            this.txtSoA.Multiline = true;
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(335, 34);
            this.txtSoA.TabIndex = 1;
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(179, 147);
            this.txtSoB.Multiline = true;
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(335, 34);
            this.txtSoB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kết quả ";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(179, 188);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(335, 34);
            this.txtKetQua.TabIndex = 1;
            // 
            // btCong
            // 
            this.btCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCong.Location = new System.Drawing.Point(448, 259);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(151, 66);
            this.btCong.TabIndex = 2;
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // TinhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TinhToan";
            this.Text = "Tính Toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btCong;
    }
}

