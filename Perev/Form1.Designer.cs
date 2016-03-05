namespace Perev
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.nothing1 = new System.Windows.Forms.Label();
            this.inputNum = new System.Windows.Forms.TextBox();
            this.play = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.ss_select = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ss_select_out = new System.Windows.Forms.NumericUpDown();
            this.outputNum = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kol_input = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ss_select)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss_select_out)).BeginInit();
            this.SuspendLayout();
            // 
            // nothing1
            // 
            this.nothing1.AutoSize = true;
            this.nothing1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.nothing1.Location = new System.Drawing.Point(6, 25);
            this.nothing1.Name = "nothing1";
            this.nothing1.Size = new System.Drawing.Size(178, 31);
            this.nothing1.TabIndex = 0;
            this.nothing1.Text = "Введите с.с. :";
            // 
            // inputNum
            // 
            this.inputNum.BackColor = System.Drawing.SystemColors.Window;
            this.inputNum.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNum.Location = new System.Drawing.Point(112, 147);
            this.inputNum.Name = "inputNum";
            this.inputNum.Size = new System.Drawing.Size(135, 36);
            this.inputNum.TabIndex = 1;
            this.inputNum.TextChanged += new System.EventHandler(this.inputNum_TextChanged);
            this.inputNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNum_KeyPress);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.play.Font = new System.Drawing.Font("Tahoma", 11F);
            this.play.Location = new System.Drawing.Point(134, 218);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(427, 44);
            this.play.TabIndex = 2;
            this.play.Text = "Go";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // ss_select
            // 
            this.ss_select.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ss_select.Location = new System.Drawing.Point(53, 62);
            this.ss_select.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ss_select.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ss_select.Name = "ss_select";
            this.ss_select.Size = new System.Drawing.Size(120, 34);
            this.ss_select.TabIndex = 3;
            this.ss_select.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ss_select.ValueChanged += new System.EventHandler(this.ss_select_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label1.Location = new System.Drawing.Point(316, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Конечное число :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ss_select_out);
            this.groupBox1.Controls.Add(this.nothing1);
            this.groupBox1.Controls.Add(this.ss_select);
            this.groupBox1.Controls.Add(this.inputNum);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 194);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Начальное число";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "число :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "в";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "из";
            // 
            // ss_select_out
            // 
            this.ss_select_out.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ss_select_out.Location = new System.Drawing.Point(53, 102);
            this.ss_select_out.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ss_select_out.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ss_select_out.Name = "ss_select_out";
            this.ss_select_out.Size = new System.Drawing.Size(120, 34);
            this.ss_select_out.TabIndex = 4;
            this.ss_select_out.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ss_select_out.ValueChanged += new System.EventHandler(this.ss_select_out_ValueChanged);
            // 
            // outputNum
            // 
            this.outputNum.AutoSize = true;
            this.outputNum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outputNum.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputNum.Location = new System.Drawing.Point(316, 58);
            this.outputNum.Name = "outputNum";
            this.outputNum.Size = new System.Drawing.Size(39, 34);
            this.outputNum.TabIndex = 7;
            this.outputNum.Text = "...";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Tahoma", 13F);
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(316, 163);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 31);
            this.error.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label5.Location = new System.Drawing.Point(316, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "С точностью :";
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(631, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "знаков";
            // 
            // kol_input
            // 
            this.kol_input.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kol_input.Location = new System.Drawing.Point(503, 113);
            this.kol_input.Name = "kol_input";
            this.kol_input.Size = new System.Drawing.Size(122, 32);
            this.kol_input.TabIndex = 9;
            this.kol_input.Text = "16";
            this.kol_input.TextChanged += new System.EventHandler(this.kol_input_TextChanged);
            this.kol_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kol_input_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 274);
            this.Controls.Add(this.kol_input);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.error);
            this.Controls.Add(this.outputNum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.play);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "00оо00оо";
            this.TextChanged += new System.EventHandler(this.Form1_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ss_select)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ss_select_out)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nothing1;
        private System.Windows.Forms.TextBox inputNum;
        private System.Windows.Forms.Button play;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.NumericUpDown ss_select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label outputNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ss_select_out;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kol_input;
    }
}

