using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        void czysc()
        {
            lblX1.Content = null;
            lblX2.Content = null;
        }
        void czyscPlotno()
        {
            cnvObraz.Children.Clear();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c, delta, x1, x2;
            try
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);
                delta = (b * b) - 4 * a * c;
                if (delta > 0)
                {
                    czysc();
                    lblDelta.Content = "Δ wynosi: " + delta.ToString();
                    x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                    x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                    lblX1.Content = "x1 wynosi: " + x1.ToString();
                    lblX2.Content = "x2 wynosi: " + x2.ToString();
                }
                else if (delta == 0)
                {
                    czysc();
                    lblDelta.Content = "Δ wynosi: 0";
                    x1 = -b / 2 * a;
                    lblX1.Content = "x wynosi: " + x1.ToString();
                }
                else
                {
                    czysc();
                    lblDelta.Content = "Δ jest ujemna. Brak rozwiązań";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Nieprawidłowe dane!!!", "BŁĄD", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnPiramida_Click(object sender, RoutedEventArgs e)
        {
            czyscPlotno();
            int szer = 50, x = 125, y = 25;
            for (int i = 0; i < 5; i++)
            {
                RysujKwadrat(szer, x, y);
                szer += 50; x -= 25; y += 50;
            }
        }
        void RysujKwadrat(int w, int x, int y, Brush col = null, Brush fillc = null, int h = 50)
        {
            if (col == null)
                col = Brushes.Black;
            if (fillc == null)
                fillc = Brushes.Red;

            var rect = new Rectangle();
            rect.Stroke = col;
            rect.Fill = fillc;
            rect.Width = w;
            rect.Height = h;
            Canvas.SetLeft(rect, x);
            Canvas.SetTop(rect, y);
            cnvObraz.Children.Add(rect);
        }

        private void btnSzachownica_Click(object sender, RoutedEventArgs e)
        {
            czyscPlotno();
            int w = 50, x = 0, y = 0;
            Brush czarny = Brushes.Black;
            Brush bialy = Brushes.White;
            for (int i = 0; i < 6; i++)
            {

                for (int j = 0; j < 6; j++)
                {
                    if (i == 0 || i == 2 || i == 4)
                    {
                        if (j == 1 || j == 3 || j == 5)
                            RysujKwadrat(w, x, y, czarny, czarny);

                        else
                            RysujKwadrat(w, x, y, bialy, bialy);
                        x += 50;
                    }
                    else
                    {
                        if (j == 0 || j == 2 || j == 4)
                            RysujKwadrat(w, x, y, czarny, czarny);

                        else
                            RysujKwadrat(w, x, y, bialy, bialy);
                        x += 50;
                    }
                }
                x = 0;
                y += 50;
            }

        }

        bool pytanie1()
        {
            if (chkGolak.IsChecked == true && chkJP2GMD.IsChecked == true)
                return true;
            else return false;
        }
        bool pytanie2()
        {
            if(cmbIDK.SelectedIndex == 1)
            return true;
            else return false;
        }
        bool pytanie3()
        {
            if(listLang.SelectedIndex == 1)
            return true;
            else
                return false;
        }
        bool pytanie4()
        {
            if(radMal3.IsChecked == true) return true;
            else
            return false;
        }
        bool pytanie5()
        {
            if(txtStanczyk.Text == "Urszula Stańczyk")
            return true;
            else
                return false;
        }
        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
        int licznik = 0;
            if (pytanie1())
                licznik++;
            if (pytanie2())
                licznik++;
            if (pytanie3())
                licznik++;
            if (pytanie4())
                licznik++;
            if (pytanie5())
                licznik++;
            lblRes.Content = "UZYSKANA LICZBA PUNKTÓW: " + licznik.ToString();
        }
       
    }
}

