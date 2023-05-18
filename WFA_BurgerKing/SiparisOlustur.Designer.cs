namespace WFA_BurgerKing
{
    partial class SiparisOlustur
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
            groupBoxEkstraMalzemeler = new GroupBox();
            SuspendLayout();
            // 
            // groupBoxEkstraMalzemeler
            // 
            groupBoxEkstraMalzemeler.AutoSize = true;
            groupBoxEkstraMalzemeler.Location = new Point(17, 17);
            groupBoxEkstraMalzemeler.Margin = new Padding(4);
            groupBoxEkstraMalzemeler.Name = "groupBoxEkstraMalzemeler";
            groupBoxEkstraMalzemeler.Padding = new Padding(4);
            groupBoxEkstraMalzemeler.Size = new Size(330, 409);
            groupBoxEkstraMalzemeler.TabIndex = 0;
            groupBoxEkstraMalzemeler.TabStop = false;
            groupBoxEkstraMalzemeler.Text = "Ekstra Malzemeler";
            // 
            // SiparisOlustur
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 439);
            Controls.Add(groupBoxEkstraMalzemeler);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(3, 1, 3, 1);
            Name = "SiparisOlustur";
            Text = "SiparisOlustur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxEkstraMalzemeler;
    }
}