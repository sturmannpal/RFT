using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace Beadando_1_BK9YLY
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string eredeti = "";
        public static List<string> szavak = new List<string>();
        public static string szavak2;
        public static int counter;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            szavak2 = "";
            counter = 1;

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                string s = ofd.FileName;
                StreamReader sr = new StreamReader(s);
                while (!sr.EndOfStream)
                {
                    Random rnd = new Random();
                    szavak.Add(sr.ReadLine());
                    eredeti = szavak[rnd.Next(szavak.Count)].ToUpper();
                }
            }
            else MessageBox.Show("Nem választott ki elemet!");

            for (int i = 0; i < eredeti.Length; i++)
            {
                szavak2 += "_";
            }
            megjelenes();
        }
        private void megjelenes()
        {
                        for (int i = 0; i < szavak2.Length; i++)
            {
                kitalalando.Text += szavak2.Substring(i,1);
                kitalalando.Text += " ";

            }
        }

        

        private void Togklikk(object sender, RoutedEventArgs e)
        {
            TextBlock b = (TextBlock)sender;
            //char[] ABC = { 'A', 'Á', 'B', 'C', 'D', 'E', 'É', 'F', 'G', 'H', 'I', 'Í', 'J', 'K', 'L', 'M', 'N', 'O', 
            //'Ó', 'Ö', 'Ő', 'P', 'Q', 'R', 'S', 'T', 'U', 'Ú', 'Ü', 'Ű', 'V', 'W', 'X', 'Y', 'Z' };
            char[] tipp = szavak2.ToCharArray();
            char[] kit = eredeti.ToCharArray();
           // int j;
          char[] gomb = b.Text.ToCharArray();
         if (eredeti.Contains(b.Text))
         {
                    for (int i = 0; i < kit.Length; i++)
                    {
                        if (kit[i] == gomb[0] )
                        {
                            tipp[i] = gomb[0];
                        }
                    }
                    szavak2 = new string(tipp);
                    kitalalando.Text = "";
                    for (int i = 0; i < szavak2.Length; i++)
                    {
                        kitalalando.Text += szavak2.Substring(i, 1);
                        kitalalando.Text += " ";
                    }

                    b.Visibility = System.Windows.Visibility.Hidden;
                    if (eredeti == szavak2)
                    {
                        MessageBox.Show("Gratulálok! Kitaláltad!");
                        btn1.Content = "Új szót kérek!";
                        return;
                    }
                       

          }
                else
                {
                    if (counter == 1)
                        af1.Visibility = System.Windows.Visibility.Visible;
                    if (counter == 2)
                        af2.Visibility = System.Windows.Visibility.Visible;
                    if (counter == 3)
                        af3.Visibility = System.Windows.Visibility.Visible;
                    if (counter == 4)
                        af4.Visibility = System.Windows.Visibility.Visible;
                    if (counter == 5)
                        af5.Visibility = System.Windows.Visibility.Visible;
                    if (counter == 6)
                        af6.Visibility = System.Windows.Visibility.Visible;
                    if (counter == 7)
                        af7.Visibility = System.Windows.Visibility.Visible;
                    if (counter == 8)
                        af8.Visibility = System.Windows.Visibility.Visible;
                    if (counter == 9)
                        af9.Visibility = System.Windows.Visibility.Visible;
                    if (counter == 10)
                        af10.Visibility = System.Windows.Visibility.Visible;
                    if (counter == 11)
                        af11.Visibility = System.Windows.Visibility.Visible;
                    if (counter == 12)
                        af12.Visibility = System.Windows.Visibility.Visible;
                    if (counter == 13)
                        af13.Visibility = System.Windows.Visibility.Visible;
                    if (counter == 14)
                      
                    {
                        af14.Visibility = System.Windows.Visibility.Visible;
                        MessageBox.Show("Vesztettél!");
                        btn1.Content = "Új szót kérek!";
                        return;
                    }

                    b.Visibility = System.Windows.Visibility.Hidden;
                    counter++;
                }
            }
        }
    }

