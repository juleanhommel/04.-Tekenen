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

namespace _04.Tekenen
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

        private void blnLine_Click(object sender, RoutedEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.DarkSlateGray;
            myLine.X1 = 100;
            myLine.X2 = 150;
            myLine.Y1 = 100;
            myLine.Y2 = 150;
            myLine.StrokeThickness = 5;
            mainGrid.Children.Add(myLine);
        }

        private void blnCirkel_Click(object sender, RoutedEventArgs e)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Margin = new Thickness(0,0,210,100);
            ellipse.Width = 50;
            ellipse.Height = 50;
            ellipse.Stroke = Brushes.DarkSlateGray;
            ellipse.Fill = Brushes.LightBlue;
            ellipse.StrokeThickness = 5;
            mainGrid.Children.Add(ellipse);
        }

        private void blnLine2_Click(object sender, RoutedEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.DarkSlateGray;
            myLine.X1 = 150;
            myLine.X2 = 200;
            myLine.Y1 = 150;
            myLine.Y2 = 100;
            myLine.StrokeThickness = 5;
            mainGrid.Children.Add(myLine);
        }

        private void blnLine3_Click(object sender, RoutedEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.DarkSlateGray;
            myLine.X1 = 150;
            myLine.X2 = 150;
            myLine.Y1 = 130;
            myLine.Y2 = 200;
            myLine.StrokeThickness = 5;
            mainGrid.Children.Add(myLine);
        }

        private void blnLine4_Click(object sender, RoutedEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.DarkSlateGray;
            myLine.X1 = 100;
            myLine.X2 = 150;
            myLine.Y1 = 250;
            myLine.Y2 = 200;
            myLine.StrokeThickness = 5;
            mainGrid.Children.Add(myLine);
        }

        private void blnLine5_Click(object sender, RoutedEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.DarkSlateGray;
            myLine.X1 = 200;
            myLine.X2 = 150;
            myLine.Y1 = 250;
            myLine.Y2 = 200;
            myLine.StrokeThickness = 5;
            mainGrid.Children.Add(myLine);
        }
    }
    
}
