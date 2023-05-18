namespace WFA_BurgerKing
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            siparişYönetimiToolStripMenuItem = new ToolStripMenuItem();
            siparişAlToolStripMenuItem = new ToolStripMenuItem();
            siparişiDüzenleToolStripMenuItem = new ToolStripMenuItem();
            siparişToolStripMenuItem = new ToolStripMenuItem();
            ürünYönetimiToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { siparişYönetimiToolStripMenuItem, ürünYönetimiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1180, 25);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            siparişYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { siparişAlToolStripMenuItem, siparişiDüzenleToolStripMenuItem, siparişToolStripMenuItem });
            siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            siparişYönetimiToolStripMenuItem.Size = new Size(103, 19);
            siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // siparişAlToolStripMenuItem
            // 
            siparişAlToolStripMenuItem.Name = "siparişAlToolStripMenuItem";
            siparişAlToolStripMenuItem.Size = new Size(180, 22);
            siparişAlToolStripMenuItem.Text = "Sipariş Al";
            siparişAlToolStripMenuItem.Click += siparişAlToolStripMenuItem_Click;
            // 
            // siparişiDüzenleToolStripMenuItem
            // 
            siparişiDüzenleToolStripMenuItem.Name = "siparişiDüzenleToolStripMenuItem";
            siparişiDüzenleToolStripMenuItem.Size = new Size(180, 22);
            siparişiDüzenleToolStripMenuItem.Text = "Sipariş Bilgileri";
            siparişiDüzenleToolStripMenuItem.Click += siparişiDüzenleToolStripMenuItem_Click;
            // 
            // siparişToolStripMenuItem
            // 
            siparişToolStripMenuItem.Name = "siparişToolStripMenuItem";
            siparişToolStripMenuItem.Size = new Size(180, 22);
            siparişToolStripMenuItem.Text = "Sipariş ";
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3 });
            ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            ürünYönetimiToolStripMenuItem.Size = new Size(95, 19);
            ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "Menü Ekle";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(180, 22);
            toolStripMenuItem3.Text = "Ekstra Ekle";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(32, 32);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 667);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Main Menu";
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private ToolStripMenuItem siparişAlToolStripMenuItem;
        private ToolStripMenuItem siparişiDüzenleToolStripMenuItem;
        private ToolStripMenuItem siparişToolStripMenuItem;
        private ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}