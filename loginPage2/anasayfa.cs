using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace loginPage2
{
    public partial class anasayfa : Form
    {
        public int GelenDeger { get; set; }

        public anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitapEklefrm kitapEklefrm = new kitapEklefrm();
            kitapEklefrm.GelenDeger = GelenDeger;
            kitapEklefrm.ShowDialog();
        }

        private void btnKitapListeleme_Click(object sender, EventArgs e)
        {
            KitapListelefrm kitapListelefrm = new KitapListelefrm();
            kitapListelefrm.GelenDeger = GelenDeger;
            kitapListelefrm.ShowDialog();
        }

        private void anasayfacs_Load(object sender, EventArgs e)
        {

        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            Grafikfrm grafikfrm = new Grafikfrm();
            grafikfrm.ShowDialog();
        }
    }
}
