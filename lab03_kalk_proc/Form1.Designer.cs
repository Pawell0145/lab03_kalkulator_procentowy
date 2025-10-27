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
            conteinerNUM = new NumericUpDown();
            precentSub = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            containerComboBox = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            totalVolume = new TextBox();
            subVolume = new TextBox();
            liquidComboBox = new ComboBox();
            label8 = new Label();
            resButton = new Button();
            clearButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)conteinerNUM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)precentSub).BeginInit();
            SuspendLayout();
            // 
            // conteinerNUM
            // 
            conteinerNUM.Location = new Point(73, 153);
            conteinerNUM.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            conteinerNUM.Name = "conteinerNUM";
            conteinerNUM.Size = new Size(68, 23);
            conteinerNUM.TabIndex = 0;
            conteinerNUM.ThousandsSeparator = true;
            // 
            // precentSub
            // 
            precentSub.Location = new Point(221, 149);
            precentSub.Name = "precentSub";
            precentSub.Size = new Size(43, 23);
            precentSub.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 91);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 2;
            label1.Text = "Wybierz naczynie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 135);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 3;
            label2.Text = "Ilość";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(219, 135);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 4;
            label3.Text = "Ile procent";
            // 
            // containerComboBox
            // 
            containerComboBox.FormattingEnabled = true;
            containerComboBox.Location = new Point(73, 109);
            containerComboBox.Name = "containerComboBox";
            containerComboBox.Size = new Size(140, 23);
            containerComboBox.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(440, 162);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 10;
            label6.Text = "Łączna obj. płynu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(440, 193);
            label7.Name = "label7";
            label7.Size = new Size(123, 15);
            label7.TabIndex = 11;
            label7.Text = "Obj. czystej substancji";
            // 
            // totalVolume
            // 
            totalVolume.Location = new Point(545, 159);
            totalVolume.Name = "totalVolume";
            totalVolume.ReadOnly = true;
            totalVolume.Size = new Size(100, 23);
            totalVolume.TabIndex = 12;
            // 
            // subVolume
            // 
            subVolume.Location = new Point(569, 185);
            subVolume.Name = "subVolume";
            subVolume.ReadOnly = true;
            subVolume.Size = new Size(100, 23);
            subVolume.TabIndex = 13;
            // 
            // liquidComboBox
            // 
            liquidComboBox.FormattingEnabled = true;
            liquidComboBox.Location = new Point(221, 109);
            liquidComboBox.Name = "liquidComboBox";
            liquidComboBox.Size = new Size(121, 23);
            liquidComboBox.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(219, 91);
            label8.Name = "label8";
            label8.Size = new Size(92, 15);
            label8.TabIndex = 19;
            label8.Text = "Wybierz roztwór";
            // 
            // resButton
            // 
            resButton.Location = new Point(569, 223);
            resButton.Name = "resButton";
            resButton.Size = new Size(75, 23);
            resButton.TabIndex = 22;
            resButton.Text = "Wynik";
            resButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(464, 224);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 23;
            clearButton.Text = "Wyczyść";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 193);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 23);
            textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(221, 193);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 175);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 26;
            label4.Text = "Objętość naczynia (ml)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(219, 175);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 27;
            label5.Text = "Stężenie roztworu (%)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(clearButton);
            Controls.Add(resButton);
            Controls.Add(label8);
            Controls.Add(liquidComboBox);
            Controls.Add(subVolume);
            Controls.Add(totalVolume);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(containerComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(precentSub);
            Controls.Add(conteinerNUM);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Kalkulator procentowy";
            ((System.ComponentModel.ISupportInitialize)conteinerNUM).EndInit();
            ((System.ComponentModel.ISupportInitialize)precentSub).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown conteinerNUM;
        private NumericUpDown precentSub;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox containerComboBox;
        private Label label6;
        private Label label7;
        private TextBox totalVolume;
        private TextBox subVolume;
        private ComboBox liquidComboBox;
        private Label label8;
        private Button resButton;
        private Button clearButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
    }
}
