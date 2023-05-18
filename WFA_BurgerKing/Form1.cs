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
            bool durum = false; // en ba�ta cocugu yok o y�zden false yapt�k..



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

        private void sipari�AlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PencereGoster(new SiparisOlustur());
        }

        private void sipari�iD�zenleToolStripMenuItem_Click(object sender, EventArgs e)
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