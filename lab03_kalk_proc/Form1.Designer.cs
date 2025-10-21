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
            label4 = new Label();
            containerComboBox = new ComboBox();
            label5 = new Label();
            delButton = new Button();
            addButton = new Button();
            label6 = new Label();
            label7 = new Label();
            totalVolume = new TextBox();
            subVolume = new TextBox();
            ((System.ComponentModel.ISupportInitialize)conteinerNUM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)precentSub).BeginInit();
            SuspendLayout();
            // 
            // conteinerNUM
            // 
            conteinerNUM.Location = new Point(191, 109);
            conteinerNUM.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            conteinerNUM.Name = "conteinerNUM";
            conteinerNUM.Size = new Size(72, 23);
            conteinerNUM.TabIndex = 0;
            conteinerNUM.ThousandsSeparator = true;
            // 
            // precentSub
            // 
            precentSub.Location = new Point(292, 109);
            precentSub.Name = "precentSub";
            precentSub.Size = new Size(43, 23);
            precentSub.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 91);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 2;
            label1.Text = "Wybierz naczynie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 91);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 3;
            label2.Text = "Ilość";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 91);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 4;
            label3.Text = "Ile procent";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 144);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 5;
            label4.Text = "Usuń naczynie";
            // 
            // containerComboBox
            // 
            containerComboBox.FormattingEnabled = true;
            containerComboBox.Location = new Point(73, 109);
            containerComboBox.Name = "containerComboBox";
            containerComboBox.Size = new Size(112, 23);
            containerComboBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(162, 144);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 7;
            label5.Text = "Dodaj naczynie";
            // 
            // delButton
            // 
            delButton.Location = new Point(73, 162);
            delButton.Name = "delButton";
            delButton.Size = new Size(83, 23);
            delButton.TabIndex = 8;
            delButton.Text = "Usuń";
            delButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(162, 162);
            addButton.Name = "addButton";
            addButton.Size = new Size(87, 23);
            addButton.TabIndex = 9;
            addButton.Text = "Dodaj";
            addButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(73, 207);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 10;
            label6.Text = "Łączna obj. płynu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(73, 238);
            label7.Name = "label7";
            label7.Size = new Size(123, 15);
            label7.TabIndex = 11;
            label7.Text = "Obj. czystej substancji";
            // 
            // totalVolume
            // 
            totalVolume.Location = new Point(178, 204);
            totalVolume.Name = "totalVolume";
            totalVolume.ReadOnly = true;
            totalVolume.Size = new Size(100, 23);
            totalVolume.TabIndex = 12;
            // 
            // subVolume
            // 
            subVolume.Location = new Point(202, 230);
            subVolume.Name = "subVolume";
            subVolume.ReadOnly = true;
            subVolume.Size = new Size(100, 23);
            subVolume.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(subVolume);
            Controls.Add(totalVolume);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(addButton);
            Controls.Add(delButton);
            Controls.Add(label5);
            Controls.Add(containerComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(precentSub);
            Controls.Add(conteinerNUM);
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
        private Label label4;
        private ComboBox containerComboBox;
        private Label label5;
        private Button delButton;
        private Button addButton;
        private Label label6;
        private Label label7;
        private TextBox totalVolume;
        private TextBox subVolume;
    }
}
