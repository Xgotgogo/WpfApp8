using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для windowAuthorization.xaml
    /// </summary>
    public partial class windowAuthorization : Window
    {
        string captcha = "";
        public windowAuthorization()
        {
            InitializeComponent();
            loadcap();
        }
        void loadcap()
        {
            captcha = "";
            string ABC = "1,2,3,4,5,6,7,8,9,0,Q,W,E,R,T,Y,U,I,O,P,,A,S,D,F,G,H,J,K,L,Z,X,C,V,B,N,M," +
                "q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,,l,z,x,c,v,b,n,m";
            char[] a = { ',' };
            string[] ar = ABC.Split(a);
            //string pwd = " ";
            string temp = " ";
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                temp = ar[rnd.Next(0, ar.Length)];
                captcha += temp;

            }

            txtCaptcha2.Text = captcha;

            if (txtCaptcha == null)
            {
                MessageBox.Show("0!");
            }

        }



        private void btnentor_Click(object sender, RoutedEventArgs e)
        {
            if (txtLogin.Text == "client")
            {
                if (passwordBox.Password == "123" && txtCaptcha.Text == txtCaptcha.Text)
                {

                    formVitrina main = new formVitrina();
                    main.Show();
                    this.Hide();
                }
                else if (txtCaptcha.Text != txtCaptcha2.Text)
                {
                    MessageBox.Show("Error.");
                }

                else if (passwordBox.Password != "123")
                {

                    MessageBox.Show("Error.");
                    loadcap();
                }

            }


        }
        private void btnObnovit_Click(object sender, RoutedEventArgs e)
        {
            loadcap();
        }

        private void bntGost_Click(object sender, RoutedEventArgs e)
        {
            formVitrina main = new formVitrina();
            main.Show();
            this.Hide();

        }

        private void btnAdmin_Click(object sender, RoutedEventArgs e)
        {
            if (txtLogin.Text == "admin")
            {
                if (passwordBox.Password == "admin")
                {
                    if (txtCaptcha.Text == txtCaptcha2.Text || txtCaptcha2.Text.Length == 0)
                    {
                        formVitrinaAdmin main = new formVitrinaAdmin();
                        main.Show();
                        this.Hide();
                    }
                    else MessageBox.Show("ошибка каптчи");
                }
                else MessageBox.Show("неверный пароль");
            }
            else MessageBox.Show("неверный логин");
            loadcap();
        }
    }
}