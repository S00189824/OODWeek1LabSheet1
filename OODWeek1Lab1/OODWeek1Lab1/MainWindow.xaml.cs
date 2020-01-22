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
        Band[] bands = new Band[6];
        ObservableCollection<Band> band;

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

            List<string> n1 = new List<string> { "name1", "Name2", "Name3" };
            List<string> n2 = new List<string> { "name4", "Name5" };
            List<string> n3 = new List<string> { "name6", "Name7" };
            List<string> n4 = new List<string> { "name8", "Name9" };
            List<string> n5 = new List<string> { "name10", "Name11" };
            List<string> n6 = new List<string> { "name12", "Name13" };

            Band b1 = new Band("Band1", new DateTime(2019, 09, 10), n1);
            Band b2 = new Band("Band2", new DateTime(2018, 09, 10), n2);
            Band b3 = new Band("Band3", new DateTime(2017, 09, 10), n3);
            Band b4 = new Band("Band4", new DateTime(2016, 09, 10), n4);
            Band b5 = new Band("Band5", new DateTime(2014, 09, 10), n5);
            Band b6 = new Band("Band6", new DateTime(2015, 09, 10),n6);

            List<Band> bands = new List<Band>();
            bands.Add(b1);
            bands.Add(b2);
            bands.Add(b3);
            bands.Add(b4);
            bands.Add(b5);
            bands.Add(b6);

            LbxBands.ItemsSource = bands;

            bands.Sort()
        }
    }
}
