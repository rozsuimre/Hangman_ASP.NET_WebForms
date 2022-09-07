using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace SimpleImike
{

    public partial class Default : System.Web.UI.Page
    {

        //       var fileContents = File.ReadAllText(path: Server.MapPath(@"~/App_Data/file.txt"));

        public string[] szavak = { "egg","apple", "alien","snow" };
        Random r = new Random();
        //public string kitalalando = "ai";

        public string kitalalando;
        public char[] khar;

        //public string kiirat;
        public int tipp = 0;
        public char tippChar;
        public char st;
        public int pont = 0;
        public char[] kiirat;
        public string kiirato = "";
        public bool ujraindult=true;
        public string cimke = "";
        public string lyukasszoveg;
        public string tippek;
        const string lyukF = "lyukasszoveg";
        const string tippF = "tippek";
        const string kitalF = "kitalalando";
        const string pontF = "pontszam";
        const string HallF = "Hall of Fame";
        const string hibaF = "hiba";
        public int hiba=0;
        
        public void UjJatek()
        {
            Label5.Text = " ";
            Label3.Text = "";
            Label8.Text = "";
            Label8.Visible = false;
            LabelPont0.Visible = false;
            //TextBox1.Text = "";
            //Label2.Text = "";
            //Label4.Text = "";
            //btUjJatek.Visible = false;
            ujraindult = true;
            pont = 0;
            //hiba = 0;
            kiir(lyukF,""); 
            kiir(tippF,"");
            kiir(kitalF,"apple");
            kiir(pontF,"0");
            UjraToltes();
        }
        public void UjraToltes()
        {
            kitalalando = beolvas(kitalF);//nem tudom, hogy ez miért létezik itten már ?
            khar = kitalalando.ToCharArray();//A kitalálandó szó áttöltése egy karakter tömbbe
            kiirat = new char[khar.Length]; //Kell egy lyukas szöveg
            pont = int.Parse(beolvas(pontF));

            for (int i = 0; i < khar.Length; i++)
            {
                khar[i] = kitalalando[i];
                kiirat[i] = '.';
                //Label1.Text = new string(kiirat);
            }
            if (lyukasszoveg == "") { lyukasszoveg = new string(kiirat); }
            else
            {
                lyukasszoveg = beolvas(lyukF);
            }
            
            Label5.Text = lyukasszoveg;
            Label3.Text = beolvas(pontF);
        }
       
        protected void Page_Load(object sender, EventArgs e)
        {
            //letrehoz(lyukF);
            //letrehoz(tippF);
            //letrehoz(kitalF);
            //letrehoz(pontF);
            //letrehoz(HallF);
            //letrehoz(hibaF);
            //start();

            //string [] szavak = new string[5000];
            string[] kistomb = new string[5000];
            var lista = new List<string>(5000);

            //IsPostBack==false ha először töltődik be és IsPostBack==true ha visszaküldés miatt töltődik be
            if (!IsPostBack) //első indítás
            {
                //TextBox1.Enabled = true;
                //btTipp.Enabled = true;
                int vmi = r.Next(4);
                //kitalalando = szavak[vmi];

                //StreamReader srszo = new StreamReader("~/topenglish5k.txt");
                int vmiszo = r.Next(4999)+1;

                //string mijonbe = "";
                string str = HttpContext.Current.Server.MapPath("~/topenglish5k.txt");//filename=
                if (File.Exists(str))
                {

                    using (StreamReader srszo = File.OpenText(str))
                    {
                        string line = null;

                        //for (int i = 0; i <vmiszo-1 ; i++)
                        //{
                        //    sr.ReadLine();

                        //}
                        //kitalalando = srszo.ReadLine();
                        while ((line = srszo.ReadLine()) != null)
                        {
                            
                            kistomb = line.Split(',');
                        }

                        kitalalando = (kistomb[vmiszo].ToLower()).Trim();
                        
                        //Label8.Text = kitalalando;

                        srszo.Close();

                    }

                }

                ujraindult = false;
                khar = kitalalando.ToCharArray();//A kitalálandó szó áttöltése egy karakter tömbbe
                kiirat = new char[khar.Length]; //Kell egy lyukas szöveg

                for (int i = 0; i < khar.Length; i++)
                {
                    khar[i] = kitalalando[i];
                    kiirat[i] = '.';
                    //Label1.Text = new string(kiirat);
                }

                lyukasszoveg = new string(kiirat); //mégis kelle egy sztring is a lyukas szövegről
                Label5.Text = lyukasszoveg;
                kiir(kitalF, kitalalando);
                kiir(lyukF, lyukasszoveg);//még csak pontok
                kiir(pontF, "0");
                kiir(tippF, "");
                kiir(hibaF, "0");
                Label3.Text = beolvas(pontF);
                //beolvas(kitalalando, kitalalando);//kitalalando.txt {"apple"}
            }
            else if (IsPostBack || ujraindult==false) //ha visszaküldésre töltődik be
            {
                UjraToltes();
            }
            
        }

        public void letrehoz(string filename)
        {
            string str = HttpContext.Current.Server.MapPath("~/" + filename + ".txt");//filename=
            FileStream f1 = null;
            if (!File.Exists(str))
            {
                using (f1 = File.Create(str))
                {
                }
            }
        }

        public void kiir(string filename, string mitirki) //milyen file-ba mit
        {
            //string str = @"./proba.txt"; //c:\ASPNETWebFormsSajat\TextFileHandlingInASPNETWebForms\TextFileHandlingInASPNETWebForms

            string str = HttpContext.Current.Server.MapPath("~/" + filename + ".txt");//filename=
            //string szoveg = TextBoxBe.Text;

            if (File.Exists(str))
            {
                using (StreamWriter sw = new StreamWriter(str))
                {
                    sw.Write(mitirki);//sw.Write(mitirki);
                    sw.Close();
                }
                
            }
        }

        public void hozzafuz(string filename, string mitfuz) //milyen file-ba mit
        {
            string str = HttpContext.Current.Server.MapPath("~/" + filename + ".txt");
            if (File.Exists(str))
            {
                string kimegy = beolvas(filename) + mitfuz;
                using (StreamWriter sw = new StreamWriter(str))
                {
                    sw.Write(kimegy);
                    sw.Close();
                }
            }
        }

        public string beolvas(string filename)
        {
            string mijonbe = "";
            string str = HttpContext.Current.Server.MapPath("~/" + filename + ".txt");//filename=
            if (File.Exists(str))
            {

                using (StreamReader sr = File.OpenText(str))
                {
                    string be = null;
                    while ((be = sr.ReadLine()) != null)
                    {
                        mijonbe = be;
                    }
                    sr.Close();

                }

            }
            return mijonbe;
        }



        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //if ((TextBox1.Text).Length > 1) { TextBox1.Text = ""; }
            //else
            //{
            //    tippChar = char.Parse(TextBox1.Text);
            //    hozzafuz(tippF, TextBox1.Text);
            //}
        }

        public void buttonPressed()
        {
            int talalat=0;
            hiba = int.Parse(beolvas(hibaF));
            hozzafuz(tippF, tippChar.ToString());
            string lyukas = beolvas(lyukF);
            for (int i = 0; i < lyukas.Length; i++)
            {
                kiirat[i] = lyukas[i];
            }
            //cimke = Label1.Text;
            for (int i = 0; i < khar.Length; i++)
            {

                if (khar[i] == tippChar && kiirat[i] == '.')
                {
                    kiirat[i] = khar[i];
                    pont++;
                    talalat = 1;
                }
            }
            if (talalat == 0)
            {
                hiba++;
                kiir(hibaF, hiba.ToString());
                Hiba();
            }
            kiir(pontF, pont.ToString());
            lyukas = new string(kiirat);
            kiir(lyukF, lyukas);
            Label3.Text = pont.ToString();
            //Label2.Text = tippChar.ToString();
            Label5.Text = lyukas;
            if (lyukas == kitalalando)
            {
                Label6.Text = "Győztél !!";
                //btUjJatek.Visible = true;
                //Label5.Text = "";
                Label3.Text = "";
                //Label2.Text = "";
                //TextBox1.Enabled = false;
                //btTipp.Enabled = false;
            }
        }
        protected void btTipp_Click(object sender, EventArgs e)
        {
             string lyukas = beolvas(lyukF);
            for (int i = 0; i < lyukas.Length; i++)
            {
                kiirat[i] = lyukas[i];
            }
            //cimke = Label1.Text;
            for (int i = 0; i < khar.Length; i++)
            {

                if (khar[i] == tippChar && kiirat[i] == '.')
                {
                    kiirat[i] = khar[i];
                    pont++;
                }
             }
            kiir(pontF, pont.ToString());
            lyukas = new string(kiirat);
            kiir(lyukF, lyukas);
            Label3.Text = pont.ToString();
            //Label2.Text = tippChar.ToString();
            Label5.Text = lyukas;
            if (lyukas == kitalalando)
            {
                Label6.Text = "Győztél !!";
                //btUjJatek.Visible = true;
                //Label5.Text = "";
                Label3.Text = "";
                //Label2.Text = "";
                //TextBox1.Enabled = false;
                //btTipp.Enabled = false;
            }
        }

        public void Hiba()
        {
            switch (hiba)
            {
                case 0: Image1.ImageUrl = "~/Kepek/hangman2.jpg";
                    break;
                case 1: Image1.ImageUrl = "~/Kepek/hangman3.jpg";
                    break;
                case 2:
                    Image1.ImageUrl = "~/Kepek/hangman4.jpg";
                    break;
                case 3:
                    Image1.ImageUrl = "~/Kepek/hangman5.jpg";
                    break;
                case 4:
                    Image1.ImageUrl = "~/Kepek/hangman6.jpg";
                    break;
                case 5:
                    Image1.ImageUrl = "~/Kepek/hangman7.jpg";
                    break;
                case 6:
                    Image1.ImageUrl = "~/Kepek/hangman8.jpg";
                    break;
                default:
                    Image1.ImageUrl = "~/Kepek/hangman2.jpg";
                    break;

            }
        
            if (hiba==6) 
            {
                Label6.Text = "Vesztettél !!";
                Label8.Visible = true;
                Label8.Text = kitalalando;
                LabelPont0.Visible = true;
            }
        }
        protected void btUjJatek_Click(object sender, EventArgs e)
        {
            ujraindult = true;
            UjJatek();
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            //ujraindult = true;
            UjJatek();
        }


        protected void btA_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 'a';
            buttonPressed();
            btA.Enabled = false;
            btA.BackColor = Color.Red;
        }
        protected void btB_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 'b';
            buttonPressed();
            btB.Enabled = false;
            btB.BackColor = Color.Red;
        }

        protected void btE_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 'e';
            buttonPressed();
            btE.Enabled = false;
            btE.BackColor = Color.Red;
        }

        protected void btL_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 'l';
            buttonPressed();
            btL.Enabled = false;
            btL.BackColor = Color.Red;
        }

        protected void btP_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 'p';
            buttonPressed();
            btP.Enabled = false;
            btP.BackColor = Color.Red;
        }

        protected void btI_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 'i';
            buttonPressed();
            btI.Enabled = false;
            btI.BackColor = Color.Red;
        }

        protected void btN_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 'n';
            buttonPressed();
            btN.Enabled = false;
            btN.BackColor = Color.Red;
        }

        protected void btF_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 'f';
            buttonPressed();
            btF.Enabled = false;
            btF.BackColor = Color.Red;
        }

        protected void btG_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 'g';
            buttonPressed();
            btG.Enabled = false;
            btG.BackColor = Color.Red;
        }

        protected void btH_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 'h';
            buttonPressed();
            btH.Enabled = false;
            btH.BackColor = Color.Red;
        }

        protected void btC_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 'c';
            buttonPressed();
            btC.Enabled = false;
            btC.BackColor = Color.Red;
        }

        protected void btD_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 'd';
            buttonPressed();
            btD.Enabled = false;
            btD.BackColor = Color.Red;
        }

        protected void btJ_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 'j';
            buttonPressed();
            btJ.Enabled = false;
            btJ.BackColor = Color.Red;
        }

        protected void btK_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 'k';
            buttonPressed();
            btK.Enabled = false;
            btK.BackColor = Color.Red;
        }

        protected void btM_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 'm';
            buttonPressed();
            btM.Enabled = false;
            btM.BackColor = Color.Red;
        }

        protected void btO_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 'o';
            buttonPressed();
            btO.Enabled = false;
            btO.BackColor = Color.Red;
        }

        protected void btQ_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 'q';
            buttonPressed();
            btQ.Enabled = false;
            btQ.BackColor = Color.Red;
        }

        protected void btR_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 'r';
            buttonPressed();
            btR.Enabled = false;
            btR.BackColor = Color.Red;
        }

        protected void btS_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 's';
            buttonPressed();
            btS.Enabled = false;
            btS.BackColor = Color.Red;
        }

        protected void btT_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 't';
            buttonPressed();
            btT.Enabled = false;
            btT.BackColor = Color.Red;
        }

        protected void btU_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 'u';
            buttonPressed();
            btU.Enabled = false;
            btU.BackColor = Color.Red;
        }

        protected void btV_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 'v';
            buttonPressed();
            btV.Enabled = false;
            btV.BackColor = Color.Red;
        }

        protected void btW_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 'w';
            buttonPressed();
            btW.Enabled = false;
            btW.BackColor = Color.Red;
        }

        protected void btX_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 'x';
            buttonPressed();
            btX.Enabled = false;
            btX.BackColor = Color.Red;
        }

        protected void btY_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 'y';
            buttonPressed();
            btY.Enabled = false;
            btY.BackColor = Color.Red;

        }

        protected void btZ_Click(object sender, EventArgs e)
        {
            tipp++;
            tippChar = 'z';
            buttonPressed();
            btZ.Enabled = false;
            btZ.BackColor = Color.Red;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //string QueryString = "";

            ////This is how you use a Session Variable
            ////These are variables not passed via Response.Redirect
            ////They are private variables and will not show in the browser
            //Session["pw"] = TxtPassword.Text;

            //QueryString = "?ID=" + TxtLoginName.Text;
            //Response.Redirect("Team.aspx" + QueryString);
        }
    }
}