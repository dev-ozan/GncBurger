namespace WFA_BurgerKing
{
    partial class EkstraEkle
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
            label1 = new Label();
            label2 = new Label();
            txtExtraAd = new TextBox();
            numEkstraFiyat = new NumericUpDown();
            fileSystemWatcher1 = new FileSystemWatcher();
            label3 = new Label();
            btnMalzemeEkle = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numEkstraFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(222, 21);
            label1.TabIndex = 0;
            label1.Text = "EKSTRA MALZEME BÖLÜMÜ";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 54);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(213, 29);
            label2.TabIndex = 1;
            label2.Text = "Ekstra Malzeme Adı :";
            // 
            // txtExtraAd
            // 
            txtExtraAd.Location = new Point(171, 54);
            txtExtraAd.Name = "txtExtraAd";
            txtExtraAd.Size = new Size(107, 29);
            txtExtraAd.TabIndex = 2;
            // 
            // numEkstraFiyat
            // 
            numEkstraFiyat.Location = new Point(350, 54);
            numEkstraFiyat.Name = "numEkstraFiyat";
            numEkstraFiyat.Size = new Size(120, 29);
            numEkstraFiyat.TabIndex = 3;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(285, 54);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 29);
            label3.TabIndex = 4;
            label3.Text = "Fiyatı :";
            // 
            // btnMalzemeEkle
            // 
            btnMalzemeEkle.Location = new Point(13, 102);
            btnMalzemeEkle.Name = "btnMalzemeEkle";
            btnMalzemeEkle.Size = new Size(222, 29);
            btnMalzemeEkle.TabIndex = 5;
            btnMalzemeEkle.Text = "Ekstra Malzeme Ekle";
            btnMalzemeEkle.UseVisualStyleBackColor = true;
            btnMalzemeEkle.Click += btnMalzemeEkle_Click;
            // 
            // button2
            // 
            button2.Location = new Point(241, 102);
            button2.Name = "button2";
            button2.Size = new Size(229, 29);
            button2.TabIndex = 6;
            button2.Text = "Fiyat Güncelle";
            button2.UseVisualStyleBackColor = true;
            // 
            // EkstraEkle
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 246);
            Controls.Add(button2);
            Controls.Add(btnMalzemeEkle);
            Controls.Add(label3);
            Controls.Add(numEkstraFiyat);
            Controls.Add(txtExtraAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "EkstraEkle";
            Text = "EkstraEkle";
            ((System.ComponentModel.ISupportInitialize)numEkstraFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtExtraAd;
        private NumericUpDown numEkstraFiyat;
        private FileSystemWatcher fileSystemWatcher1;
        private Button button2;
        private Button btnMalzemeEkle;
        private Label label3;
    }
}