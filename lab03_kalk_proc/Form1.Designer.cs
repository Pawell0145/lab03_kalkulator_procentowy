namespace lab03_kalk_proc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            domainUpDownNumb = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            comboBoxDish = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            totalVolume = new TextBox();
            subVolume = new TextBox();
            comboBoxSubst = new ComboBox();
            label8 = new Label();
            submit = new Button();
            clear = new Button();
            txtBoxVol = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtBoxPerc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)domainUpDownNumb).BeginInit();
            SuspendLayout();
            // 
            // domainUpDownNumb
            // 
            domainUpDownNumb.Location = new Point(58, 121);
            domainUpDownNumb.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            domainUpDownNumb.Name = "domainUpDownNumb";
            domainUpDownNumb.Size = new Size(68, 23);
            domainUpDownNumb.TabIndex = 0;
            domainUpDownNumb.ThousandsSeparator = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 15);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 2;
            label1.Text = "Wybierz naczynie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 103);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 3;
            label2.Text = "Ilość";
            // 
            // comboBoxDish
            // 
            comboBoxDish.FormattingEnabled = true;
            comboBoxDish.Location = new Point(58, 33);
            comboBoxDish.Name = "comboBoxDish";
            comboBoxDish.Size = new Size(128, 23);
            comboBoxDish.TabIndex = 6;
            comboBoxDish.SelectedIndexChanged += comboBoxDish_SelectedIndexChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(87, 207);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 10;
            label6.Text = "Łączna obj. płynu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(63, 238);
            label7.Name = "label7";
            label7.Size = new Size(123, 15);
            label7.TabIndex = 11;
            label7.Text = "Obj. czystej substancji";
            // 
            // totalVolume
            // 
            totalVolume.Location = new Point(192, 204);
            totalVolume.Name = "totalVolume";
            totalVolume.ReadOnly = true;
            totalVolume.Size = new Size(121, 23);
            totalVolume.TabIndex = 12;
            // 
            // subVolume
            // 
            subVolume.Location = new Point(192, 230);
            subVolume.Name = "subVolume";
            subVolume.ReadOnly = true;
            subVolume.Size = new Size(121, 23);
            subVolume.TabIndex = 13;
            // 
            // comboBoxSubst
            // 
            comboBoxSubst.FormattingEnabled = true;
            comboBoxSubst.Location = new Point(192, 33);
            comboBoxSubst.Name = "comboBoxSubst";
            comboBoxSubst.Size = new Size(121, 23);
            comboBoxSubst.TabIndex = 14;
            comboBoxSubst.SelectedIndexChanged += comboBoxSubst_SelectedIndexChanged_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(192, 15);
            label8.Name = "label8";
            label8.Size = new Size(92, 15);
            label8.TabIndex = 19;
            label8.Text = "Wybierz roztwór";
            // 
            // submit
            // 
            submit.Location = new Point(192, 268);
            submit.Name = "submit";
            submit.Size = new Size(121, 23);
            submit.TabIndex = 22;
            submit.Text = "Wynik";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click_1;
            // 
            // clear
            // 
            clear.Location = new Point(63, 268);
            clear.Name = "clear";
            clear.Size = new Size(123, 23);
            clear.TabIndex = 23;
            clear.Text = "Wyczyść";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click_1;
            // 
            // txtBoxVol
            // 
            txtBoxVol.Location = new Point(58, 77);
            txtBoxVol.Name = "txtBoxVol";
            txtBoxVol.Size = new Size(128, 23);
            txtBoxVol.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 59);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 26;
            label4.Text = "Objętość naczynia (ml)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(192, 59);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 27;
            label5.Text = "Stężenie roztworu (%)";
            // 
            // txtBoxPerc
            // 
            txtBoxPerc.Location = new Point(192, 77);
            txtBoxPerc.Name = "txtBoxPerc";
            txtBoxPerc.Size = new Size(121, 23);
            txtBoxPerc.TabIndex = 28;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 305);
            Controls.Add(txtBoxPerc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtBoxVol);
            Controls.Add(clear);
            Controls.Add(submit);
            Controls.Add(label8);
            Controls.Add(comboBoxSubst);
            Controls.Add(subVolume);
            Controls.Add(totalVolume);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBoxDish);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(domainUpDownNumb);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Kalkulator procentowy";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)domainUpDownNumb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown domainUpDownNumb;
        private NumericUpDown txtBoxPercent;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxDish;
        private Label label6;
        private Label label7;
        private TextBox totalVolume;
        private TextBox subVolume;
        private ComboBox comboBoxSubst;
        private Label label8;
        private Button submit;
        private Button clear;
        private TextBox txtBoxVol;
        private Label label4;
        private Label label5;
        private TextBox txtBoxPerc;
    }
}
