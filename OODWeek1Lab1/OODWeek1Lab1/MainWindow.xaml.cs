using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace OODWeek1Lab1
{


    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BandCreate();

        }

        void BandCreate()
        {
            List<Band> bands = new List<Band>();

            List<string> n1 = new List<string> { "Phil", "Jack", "Tim" };
            List<string> n2 = new List<string> { "Shane", "Bartek" };
            List<string> n3 = new List<string> { "Jordan", "peter" };
            List<string> n4 = new List<string> { "Tizano", "Mike" };
            List<string> n5 = new List<string> { "name10", "David" };
            List<string> n6 = new List<string> { "fdod", "frek" };

            Indie b1 = new Indie("RaM gfgcow", new DateTime(2019, 09, 10), n1);
            Indie b2 = new Indie("HOP", new DateTime(2018, 09, 10), n2);

            Rock b6 = new Rock("HOP", new DateTime(2018, 09, 10), n2);
            Rock b10 = new Rock("HOP", new DateTime(2018, 09, 10), n2);

            Band b3 = new PoP("yAWN", new DateTime(2017, 09, 10), n3);
            Band b4 = new PoP("Chillout", new DateTime(2016, 09, 10), n4);

            Band b5 = new Band("Hey you", new DateTime(2014, 09, 10), n5);
            Band b7 = new Band("Blyat", new DateTime(2015, 09, 10),n6);

            bands.Add(b1);
            bands.Add(b2);
            bands.Add(b3);
            bands.Add(b4);
            bands.Add(b5);
            bands.Add(b6);

            LbxBands.ItemsSource = bands;

            bands.Sort();
        }
    }
}
