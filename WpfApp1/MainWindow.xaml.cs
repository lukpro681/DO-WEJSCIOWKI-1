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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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

        private void btnOblicz_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double r, h, wynik;
                if (chkObj.IsChecked == true)
                {

                    r = Convert.ToDouble(txtPromien.Text);
                    h = Convert.ToDouble(txtWysokosc.Text);
                    if (r > 0 && h > 0)
                    {

                        switch (cmbBryly.SelectedIndex)
                        {
                            case 0:
                                wynik = Math.PI * (r * r) * h;
                                lblWynik.Content = "Objętość Walca wynosi: " + wynik.ToString("F2") + "m^3";
                                break;
                            case 1:
                                wynik = (Math.PI * (r * r) * h) / 3;
                                lblWynik.Content = "Objętość Stożka wynosi: " + wynik.ToString("F2") + "m^3";
                                break;
                            case 2:
                                wynik = (4 * Math.PI * (r * r * r)) / 3;
                                lblWynik.Content = "Objętość Kuli wynosi: " + wynik.ToString("F2") + "m^3";
                                break;
                        }
                    }
                    else
                        lblWynik.Content = "Ale ty głupi jesteś xD";
                }



                if (chkPole.IsChecked == true)
                {

                    r = Convert.ToDouble(txtPromien.Text);
                    h = Convert.ToDouble(txtWysokosc.Text);
                    if (r > 0 && h > 0)
                    {

                        switch (cmbBryly.SelectedIndex)
                        {
                            case 0:
                                wynik = 2 * Math.PI * r * h;
                                lblPow.Content = "Pole powierzchni Walca wynosi: " + wynik.ToString("F2") + "m^2";
                                break;
                            case 1:
                                wynik = (2 * Math.PI * r * h) / 3;
                                lblPow.Content = "Pole powierzchni Stożka wynosi: " + wynik.ToString("F2") + "m^2";
                                break;
                            case 2:
                                wynik = 4 * Math.PI * (r * r);
                                lblPow.Content = "Pole powierzchni wynosi: " + wynik.ToString("F2") + "m^2";
                                break;
                        }
                    }
                    else
                        lblPow.Content = "Debilu jebany";
                }

            }
            catch(FormatException)
            {
                MessageBox.Show("Nieprawidłowe dane!!!\nśmieciu xD");
            }

        }

        private void cmbBryly_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cmbBryly.SelectedIndex == 2)
            {
                txtWysokosc.Visibility = Visibility.Hidden;
                lblWysokosc.Visibility = Visibility.Hidden;
            }
            else
            {
                txtWysokosc.Visibility = Visibility.Visible;
                lblWysokosc.Visibility = Visibility.Visible;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
           var conf = MessageBox.Show("Czy na pewno chcesz zamknąć ten cyrk?", "Już spierdalasz?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(conf == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        private void btnRysuj1_Click(object sender, RoutedEventArgs e)
        {
            RysujLinie(100,200,200,100,Brushes.White, 10);
        }

        void RysujLinie(double x1, double x2, double y1, double y2, Brush col = null, double g = 1)
        {
            if (col == null)
                col = Brushes.Black;
            var linia = new Line();
            linia.Stroke = col;
            linia.X1 = x1;
            linia.X2 = x2;
            linia.Y1 = y1;
            linia.Y2 = y2;
            linia.StrokeThickness = g;
            cnvObraz.Children.Add(linia);
        }

        void Rysuj()
        {
            var myLine = new Line();
            myLine.Stroke = System.Windows.Media.Brushes.Red;
            myLine.X1 = 0;
            myLine.X2 = 299;
            myLine.Y1 = 150;
            myLine.Y2 = 150;
            myLine.StrokeThickness = 5;
            cnvObraz.Children.Add(myLine);
            var myLine2 = new Line();
            myLine2.Stroke = System.Windows.Media.Brushes.DarkGreen;
            myLine2.X1 = 150;
            myLine2.X2 = 150;
            myLine2.Y1 = 150;
            myLine2.Y2 = 300;
            myLine2.StrokeThickness = 5;
            cnvObraz.Children.Add(myLine2);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            cnvObraz.Children.Clear();
        }

        private void btnElipsa_Click(object sender, RoutedEventArgs e)
        {
            RysujElipse(200, 200, Brushes.Red, 50, 50);
        }
        void RysujElipse(double wid, double hei, Brush kolor, double x, double y)
        {
            Ellipse elips = new Ellipse();
            elips.Stroke = kolor;
            elips.Width = wid;
            elips.Height = hei;
            elips.Fill = kolor;
            cnvObraz.Children.Add(elips);
            Canvas.SetLeft(elips, x);
            Canvas.SetTop(elips, y);
        }

        private void btnKolo_Click(object sender, RoutedEventArgs e)
        {
            rysujWypelnioneKolo(50, 50);
        }
        void rysujWypelnioneKolo(double x, double y, double r = 50)
        {
            Brush col = Brushes.Green;
            RysujElipse(r, r, col, x, y);

        }
        void RysujDrzewo()
        {
            var pien = new Line();
            var korona = new Ellipse();

            pien.Stroke = Brushes.Brown;
            pien.X1 = 140;
            pien.Y1 = 150; //pień
            pien.X2 = 140;
            pien.Y2 = 300;
            pien.StrokeThickness = 10;
            cnvObraz.Children.Add(pien);
            rysujWypelnioneKolo(pien.X1 - 50, pien.Y1 - 50, 100); //korona

        }

        private void btnDrzewo_Click(object sender, RoutedEventArgs e)
        {
            RysujDrzewo();
        }
    }

}
