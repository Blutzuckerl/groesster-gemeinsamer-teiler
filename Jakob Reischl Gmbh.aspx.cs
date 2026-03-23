using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Größter_gemeinsamer_Teiler
{
    public partial class Jakob_Reischl_Gmbh : System.Web.UI.Page
    {
        DateTime startZeit;
        DateTime EndZeit;
        //System.TimeSpan Dauer;
        System.TimeSpan Dauer;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // string strCaption;
            // string lol;
            string strEingabeZahl1;
            string strEingabeZahl2;
            strEingabeZahl1 = TextBox1.Text;
            strEingabeZahl2 = TextBox2.Text;
            long nEingabeZahl1;
            long EinagbeZahl2;
            //DateTime startZeit;
           // DateTime EndZeit;
            

            if (true == long.TryParse(strEingabeZahl1, out nEingabeZahl1) && (true == long.TryParse(strEingabeZahl2, out EinagbeZahl2)))
            {

                nEingabeZahl1 = System.Convert.ToInt64(strEingabeZahl1);
                EinagbeZahl2 = System.Convert.ToInt64(strEingabeZahl2);

                startZeit = DateTime.Now;
                this.TextBox3.Text = ggt1(nEingabeZahl1, EinagbeZahl2).ToString(); //strEingabeZahl1,strEingabeZahl2).ToString();//,startZeit
                EndZeit = DateTime.Now;
                //Zeit
                Dauer = EndZeit - startZeit;
                this.TextBox4.Text = Dauer.Minutes.ToString() + "." + Dauer.Seconds.ToString() + "." + Dauer.Milliseconds.ToString() + "." + Dauer.TotalMilliseconds.ToString();

            }
            else
            {

                this.TextBox4.Text = "lass es einfach";
                this.TextBox3.Text = "FEHLER";
            }

        }
        private long ggt1(long Zahl1, long Zahl2)//,DateTime start)
        {
          
            long MINZahl;
            int ggt = 0;

            MINZahl = Math.Min(Zahl1, Zahl2);
            for (int i = 2; i <= MINZahl; i++)
            {
                if (Zahl1 % i == 0 && Zahl2 % i == 0)
                {
                    ggt = i;

                }

            }
            if (ggt == 0)
            {
                ggt = 1;

            }
            return ggt ;//.ToString(); 
        }
        private ulong GigaMethode(ulong a, ulong b)//,DateTime start)
        {

            ulong rest = 1;
           // ulong ggT = 1;
            while(rest != 0)
            {
                rest = a % b;
                a = b;
                b = rest;
            }
            return a;//.ToString();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            // string strCaption;
            // string lol;
            string strEingabeZahl1;
            string strEingabeZahl2;
            strEingabeZahl1 = TextBox1.Text;
            strEingabeZahl2 = TextBox2.Text;
            ulong nEingabeZahl1;
            ulong EinagbeZahl2;
            //DateTime startZeit;
            // DateTime EndZeit;


            if (true == ulong.TryParse(strEingabeZahl1, out nEingabeZahl1) && (true == ulong.TryParse(strEingabeZahl2, out EinagbeZahl2)))
            {

                nEingabeZahl1 = System.Convert.ToUInt64(strEingabeZahl1);
                EinagbeZahl2 = System.Convert.ToUInt64(strEingabeZahl2);

                startZeit = DateTime.Now;
                this.TextBox3.Text = GigaMethode(nEingabeZahl1, EinagbeZahl2).ToString(); //strEingabeZahl1,strEingabeZahl2).ToString();//,startZeit
                EndZeit = DateTime.Now;
                //Zeit
                Dauer = EndZeit - startZeit;
                this.TextBox4.Text = Dauer.Minutes.ToString() + "." + Dauer.Seconds.ToString().PadLeft(2, '0') + "." + Dauer.Milliseconds.ToString().PadLeft(3, '0');

            }
            else
            {

                this.TextBox4.Text = "Du hast irgenwas Falsch gemacht. :I Bitte versuche es erneut!";
            }

        }
        private ulong ggT_Euklid_Rekursiv(ulong a, ulong b)//,DateTime start)
        {
            if (b == 0)
                return a;
            else
                return ggT_Euklid_Rekursiv(b, a % b);
           

        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            // string strCaption;
            // string lol;
            string strEingabeZahl1;
            string strEingabeZahl2;
            strEingabeZahl1 = TextBox1.Text;
            strEingabeZahl2 = TextBox2.Text;
            ulong nEingabeZahl1;
            ulong EinagbeZahl2;
            //DateTime startZeit;
            // DateTime EndZeit;


            if (true == ulong.TryParse(strEingabeZahl1, out nEingabeZahl1) && (true == ulong.TryParse(strEingabeZahl2, out EinagbeZahl2)))
            {

                nEingabeZahl1 = System.Convert.ToUInt64(strEingabeZahl1);
                EinagbeZahl2 = System.Convert.ToUInt64(strEingabeZahl2);

                startZeit = DateTime.Now;
                this.TextBox3.Text = ggT_Euklid_Rekursiv(nEingabeZahl1, EinagbeZahl2).ToString(); //strEingabeZahl1,strEingabeZahl2).ToString();//,startZeit
                EndZeit = DateTime.Now;
                //Zeit
                Dauer = EndZeit - startZeit;
                this.TextBox4.Text = Dauer.Minutes.ToString() + "." + Dauer.Seconds.ToString() + "." + Dauer.Milliseconds.ToString() + "." + Dauer.TotalMilliseconds.ToString();

            }
            else
            {

                this.TextBox4.Text = "Sind sie zu dumm zwei ganze Zahlen einzugeben";
                this.TextBox3.Text = "schwerwiegender FEHLER";
            }






        }
        //private string Zeit(long Zahl1, long Zahl2)//,DateTime start)
        //h{




       
    }
}
//bokaj<2