namespace Prototype
{
    partial class Translation_form
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Transaletion = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.make = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.translation_type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 122);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(427, 332);
            this.textBox1.TabIndex = 0;
            // 
            // Transaletion
            // 
            this.Transaletion.Location = new System.Drawing.Point(372, 490);
            this.Transaletion.Name = "Transaletion";
            this.Transaletion.Size = new System.Drawing.Size(97, 41);
            this.Transaletion.TabIndex = 1;
            this.Transaletion.Text = "แปลงภาษา";
            this.Transaletion.UseVisualStyleBackColor = true;
            this.Transaletion.Click += new System.EventHandler(this.Transaletion_Click);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(504, 490);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(91, 41);
            this.show.TabIndex = 3;
            this.show.Text = "แสดงผล";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(581, 122);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(435, 332);
            this.textBox2.TabIndex = 4;
            // 
            // make
            // 
            this.make.Location = new System.Drawing.Point(626, 490);
            this.make.Name = "make";
            this.make.Size = new System.Drawing.Size(97, 41);
            this.make.TabIndex = 5;
            this.make.Text = "บันทึกข้อมูล";
            this.make.UseVisualStyleBackColor = true;
            this.make.Click += new System.EventHandler(this.make_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(277, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(534, 29);
            this.label16.TabIndex = 27;
            this.label16.Text = "โปรแกรมแปลงภาษาทางการสำหรับใช้ในเอกสารราชการ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "กรอกเนื้อความเอกสาร";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "ผลลัพธ์การแปลงภาษา";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "เครื่องมือแปลงภาษา";
            // 
            // translation_type
            // 
            this.translation_type.FormattingEnabled = true;
            this.translation_type.Items.AddRange(new object[] {
            "คัดคำ - cutkum",
            "ดีพคัด - deepcut"});
            this.translation_type.Location = new System.Drawing.Point(81, 499);
            this.translation_type.Name = "translation_type";
            this.translation_type.Size = new System.Drawing.Size(169, 24);
            this.translation_type.TabIndex = 31;
            this.translation_type.Text = "คัดคำ - cutkum";
            // 
            // Translation_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 557);
            this.Controls.Add(this.translation_type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.make);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.show);
            this.Controls.Add(this.Transaletion);
            this.Controls.Add(this.textBox1);
            this.Name = "Translation_form";
            this.Text = "Official Languages Transformation for Government Documentation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Transaletion;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button make;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox translation_type;
    }
}

