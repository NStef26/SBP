using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using SBP.Entiteti;

namespace SBP
{
    public partial class Nova : Form
    {
        public Nova()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Akcija a = s.Load<Akcija>(5);
                MessageBox.Show(a.Naziv);
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Intervju i = new Intervju();
                i.Naziv = "Vreme";
                i.Intervjuisan = DateTime.Today;
                i.Objavljen = DateTime.Today;

                s.Save(i);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Pojavljivanje p = new Pojavljivanje();
                


                s.Save(p);
                MessageBox.Show(p.Id.ToString());
                s.Flush();
                s.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Aktivista a = new Aktivista();
                a.Ime = "Perica";
                a.Ime_roditelja = "Losa";
                a.Prezime = "Peric";
                a.Datum_rodjenja =DateTime.Parse("01.02.1992");
                a.Adresa = "Zikice Spanca 2";
                a.Primedba = "nema";

                
                s.Save(a);
                MessageBox.Show(a.Id.ToString());
                s.Flush();
                s.Close();

            }
            catch(Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                GlasackoMesto g = s.Load<GlasackoMesto>(1);
                foreach(Aktivista a in g.ListaAktivista)
                {
                    MessageBox.Show("Ime aktiviste: " + a.Ime);
                }
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Aktivista a = s.Load<Aktivista>(5);
                MessageBox.Show("Aktivista je na glasackom mestu: " + a.Posmatra.NazivIzborneJedinice);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Aktivista a = s.Load<Aktivista>(1);
                foreach(Akcija a1 in a.ListaAkcija)
                {
                    MessageBox.Show("Aktivista " + a.Ime + " ucestvuje na " + a1.Naziv);
                }

                Akcija a2 = s.Load<Akcija>(3);
                foreach(Aktivista a3 in a2.ListaAktivista)
                {
                    MessageBox.Show("Na akciji " + a2.Naziv + " ucestvuje " + a3.Ime);
                }
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Email email = new Email();
                Aktivista a = s.Load<Aktivista>(1);
                email.aktivista = a;
                email.Mail = "peraperic@gmail.com";

                s.Save(email);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Aktivista akt = s.Load<Aktivista>(1);

                foreach(Email em in akt.Mailovi)
                {
                    MessageBox.Show("Aktivista " + akt.Ime + " " + akt.Prezime + " ima mejl " + em.Mail);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Koordinator k = s.Load<Koordinator>(3);
                Aktivista a = s.Load<Aktivista>(21);
                a.NjegovKoordinator = k;
                s.Save(a);
                k.KoordiniseAktiviste.Add(a);
                s.SaveOrUpdate(k);
                s.Flush();
                s.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ZatvoreniProstor p = new ZatvoreniProstor()
                {
                    Vlasnik = "Novi Vlasnik",
                    Cena = "100"
                };
               // s.Save(p);

                Miting m = s.Load<Miting>(3);
                MessageBox.Show(m.Naziv);
                p.Dogadjaj = m;
                s.Save(p);
                //m.Prostor = p;
                s.Save(m);
                s.Flush();
                s.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
