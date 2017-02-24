namespace CalcDate
{
    partial class FrmCalcDate
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStartDay = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStartMonth = new System.Windows.Forms.ComboBox();
            this.cmbStartYear = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEndDay = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEndMonth = new System.Windows.Forms.ComboBox();
            this.cmbEndYear = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbStartDay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbStartMonth);
            this.groupBox1.Controls.Add(this.cmbStartYear);
            this.groupBox1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "開始日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(303, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "日";
            // 
            // cmbStartDay
            // 
            this.cmbStartDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStartDay.FormattingEnabled = true;
            this.cmbStartDay.Location = new System.Drawing.Point(238, 29);
            this.cmbStartDay.Name = "cmbStartDay";
            this.cmbStartDay.Size = new System.Drawing.Size(59, 31);
            this.cmbStartDay.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(203, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "月";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(103, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "年";
            // 
            // cmbStartMonth
            // 
            this.cmbStartMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStartMonth.FormattingEnabled = true;
            this.cmbStartMonth.Location = new System.Drawing.Point(138, 29);
            this.cmbStartMonth.Name = "cmbStartMonth";
            this.cmbStartMonth.Size = new System.Drawing.Size(59, 31);
            this.cmbStartMonth.TabIndex = 2;
            // 
            // cmbStartYear
            // 
            this.cmbStartYear.BackColor = System.Drawing.SystemColors.Window;
            this.cmbStartYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStartYear.FormattingEnabled = true;
            this.cmbStartYear.Location = new System.Drawing.Point(7, 29);
            this.cmbStartYear.Name = "cmbStartYear";
            this.cmbStartYear.Size = new System.Drawing.Size(90, 31);
            this.cmbStartYear.TabIndex = 0;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCalc.Location = new System.Drawing.Point(20, 179);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(90, 36);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "計算";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.White;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblResult.Location = new System.Drawing.Point(235, 179);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(98, 36);
            this.lblResult.TabIndex = 4;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbEndDay);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbEndMonth);
            this.groupBox2.Controls.Add(this.cmbEndYear);
            this.groupBox2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox2.Location = new System.Drawing.Point(13, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "終了日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(303, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "日";
            // 
            // cmbEndDay
            // 
            this.cmbEndDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEndDay.FormattingEnabled = true;
            this.cmbEndDay.Location = new System.Drawing.Point(238, 29);
            this.cmbEndDay.Name = "cmbEndDay";
            this.cmbEndDay.Size = new System.Drawing.Size(59, 31);
            this.cmbEndDay.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(203, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "月";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("メイリオ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(103, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "年";
            // 
            // cmbEndMonth
            // 
            this.cmbEndMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEndMonth.FormattingEnabled = true;
            this.cmbEndMonth.Location = new System.Drawing.Point(138, 29);
            this.cmbEndMonth.Name = "cmbEndMonth";
            this.cmbEndMonth.Size = new System.Drawing.Size(59, 31);
            this.cmbEndMonth.TabIndex = 2;
            // 
            // cmbEndYear
            // 
            this.cmbEndYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEndYear.FormattingEnabled = true;
            this.cmbEndYear.Location = new System.Drawing.Point(7, 29);
            this.cmbEndYear.Name = "cmbEndYear";
            this.cmbEndYear.Size = new System.Drawing.Size(90, 31);
            this.cmbEndYear.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("メイリオ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(146, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "経過日数";
            // 
            // lblMsg
            // 
            this.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMsg.Location = new System.Drawing.Point(20, 224);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(346, 29);
            this.lblMsg.TabIndex = 6;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("メイリオ", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(337, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "日";
            // 
            // FrmCalcDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 262);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCalcDate";
            this.Text = "CalcDate";
            this.Load += new System.EventHandler(this.FrmCalcDate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMsg;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbStartDay;
        private System.Windows.Forms.ComboBox cmbStartMonth;
        private System.Windows.Forms.ComboBox cmbStartYear;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox cmbEndDay;
        private System.Windows.Forms.ComboBox cmbEndMonth;
        private System.Windows.Forms.ComboBox cmbEndYear;
    }
}

