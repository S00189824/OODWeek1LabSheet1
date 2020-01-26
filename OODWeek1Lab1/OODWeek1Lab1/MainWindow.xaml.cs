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
        List<Band> Allbands = new List<Band>();
        List<Album> albumsToDisplay = new List<Album>();

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
            

            List<string> n1 = new List<string> { "Phil", "Jack", "Tim" };
            List<string> n2 = new List<string> { "Shane", "Bartek" };
            List<string> n3 = new List<string> { "Jordan", "peter" };
            List<string> n4 = new List<string> { "Tizano", "Mike" };
            List<string> n5 = new List<string> { "name", "David" };
            List<string> n6 = new List<string> { "fdod", "frek" };

            List<Album> albumname1 = new List<Album> { new Album("ffffff"),new Album("aaaaa") };
            List<Album> albumname2 = new List<Album> { new Album("bbbbbb"),new Album("ccccccc") };
            List<Album> albumname3 = new List<Album> { new Album("ddddd"),new Album("eeeeee") };
            List<Album> albumname4 = new List<Album> { new Album("ffff"),new Album("ggggggg") };
            List<Album> albumname5 = new List<Album> { new Album("hhhhhh"),new Album("iiiii") };
            List<Album> albumname6 = new List<Album> { new Album("jjjjj"),new Album("kkkk") };
            List<Album> albumname7 = new List<Album> { new Album("lllll"),new Album("mmmm") };
            List<Album> albumname8 = new List<Album> { new Album("nnnnnn"),new Album("ooooo") };



            Indie b1 = new Indie("RaM gfgcow", new DateTime(2019, 09, 10), n1, BandType.Indie,albumname1);
            Indie b2 = new Indie("fgjdk", new DateTime(2018, 09, 10), n2, BandType.Indie,albumname1);

            Rock b6 = new Rock("fgd", new DateTime(2018, 09, 10), n2, BandType.Rock,albumname3);
            Rock b8 = new Rock("dgfjh", new DateTime(2018, 09, 10), n1, BandType.Rock,albumname2);

            PoP b3 = new PoP("yAWN", new DateTime(2017, 09, 10), n3, BandType.Pop,albumname2);
            PoP b4 = new PoP("Chillout", new DateTime(2016, 09, 10), n4, BandType.Pop,albumname1);

            Rock b5 = new Rock("Hey you", new DateTime(2014, 09, 10), n5, BandType.Rock,albumname2);
            Rock b7 = new Rock("Blyat", new DateTime(2015, 09, 10), n6, BandType.Rock,albumname3);

            Allbands.Add(b1);
            Allbands.Add(b2);
            Allbands.Add(b3);
            Allbands.Add(b4);
            Allbands.Add(b5);
            Allbands.Add(b6);
            Allbands.Add(b7);
            Allbands.Add(b8);

            LbxBands.ItemsSource = Allbands;

            Allbands.Sort();

            //adding Genre Type to combobox
            ComboBox.Items.Add(BandType.Indie);
            ComboBox.Items.Add(BandType.Pop);
            ComboBox.Items.Add(BandType.Rock);


        }

        private void LbxBands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Band currentband = LbxBands.SelectedItem as Band;
            for (int i = 0; i < Allbands.Count; i++)
            {
                if(currentband == Allbands[i])
                {
                    
                }
            }

            txblockformed.Text = currentband.YearFormed.ToShortDateString();
            txblockMembers.Text =  currentband.Members[0].ToString() + " " + currentband.Members[1].ToString();

            
        }

        void DisplaySelected()
        {
            albumsToDisplay.Clear();
            AlbumsListBox.ItemsSource = null;

            if
        }
    }
}
