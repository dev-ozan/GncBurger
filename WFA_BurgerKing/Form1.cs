namespace WFA_BurgerKing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }



        public void PencereGoster(Form gonderilenForm)
        {
            bool durum = false; // en baþta cocugu yok o yüzden false yaptýk..



            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == gonderilenForm.Text)
                {
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }

            if (!durum)
            {
                gonderilenForm.MdiParent = this;
                gonderilenForm.Show();
            }
        }

        private void sipariþAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PencereGoster(new SiparisOlustur());
        }

        private void sipariþiDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PencereGoster(new SiparisGoruntukle());
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PencereGoster(new MenuEkleme1());
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PencereGoster(new EkstraEkle());
        }
    }
}