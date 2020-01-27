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

        Album album1;
        Album album2;
        Album album3;
        Album album4;
        Album album5;
        Album album6;
        int x;
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BandCreate();
            AlbumCreate();
        }

        void BandCreate()
        {
            

            List<string> n1 = new List<string> { "Phil", "Jack", "Tim" };
            List<string> n2 = new List<string> { "Shane", "Bartek" };
            List<string> n3 = new List<string> { "Jordan", "peter" };
            List<string> n4 = new List<string> { "Tizano", "Mike" };
            List<string> n5 = new List<string> { "name", "David" };
            List<string> n6 = new List<string> { "fdod", "frek" };

            



            Indie b1 = new Indie("RaM gfgcow", new DateTime(2019, 09, 10), n1, BandType.Indie);
            Indie b2 = new Indie("fgjdk", new DateTime(2018, 09, 10), n2, BandType.Indie);

            Rock b6 = new Rock("fgd", new DateTime(2018, 09, 10), n2, BandType.Rock);
            Rock b8 = new Rock("dgfjh", new DateTime(2018, 09, 10), n1, BandType.Rock);

            PoP b3 = new PoP("yAWN", new DateTime(2017, 09, 10), n3, BandType.Pop);
            PoP b4 = new PoP("Chillout", new DateTime(2016, 09, 10), n4, BandType.Pop);

            Rock b5 = new Rock("Hey you", new DateTime(2014, 09, 10), n5, BandType.Rock);
            Rock b7 = new Rock("Blyat", new DateTime(2015, 09, 10), n6, BandType.Rock);

            Allbands.Add(b1);
            Allbands.Add(b2);
            Allbands.Add(b3);
            Allbands.Add(b4);
            Allbands.Add(b5);
            Allbands.Add(b6);
            Allbands.Add(b7);
            Allbands.Add(b8);

            

            LbxBands.ItemsSource = Allbands;
            AlbumsListBox.ItemsSource = albumsToDisplay;

            Allbands.Sort();

            //adding Genre Type to combobox
            ComboBox.Items.Add(BandType.Indie);
            ComboBox.Items.Add(BandType.Pop);
            ComboBox.Items.Add(BandType.Rock);


        }

        void AlbumCreate()
        {
            album1 = new Album("dfgjdg", RandonYear(), RandomSales());
            album2 = new Album("sup", RandonYear(), RandomSales());
            album3 = new Album("slakfs", RandonYear(), RandomSales());
            album4 = new Album("heyup", RandonYear(), RandomSales());
            album5 = new Album("foof", RandonYear(), RandomSales());
            album6 = new Album("OOP", RandonYear(), RandomSales());
        }

        Random rng = new Random();

        int RandomSales()
        {
            int randomsales = rng.Next(1000, 5001);
            return randomsales;
        }

        int RandonYear()
        {
            int randomyear = rng.Next(2000, 2020);
            return randomyear;
        }

        private void LbxBands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Band currentband = LbxBands.SelectedItem as Band;
            Album currentAlbum = AlbumsListBox.SelectedItem as Album;
            for (int i = 0; i < Allbands.Count; i++)
            {
                if(currentband == Allbands[i])
                {
                    x = i;
                }
                
            }

            txblockformed.Text = currentband.YearFormed.ToShortDateString();
            txblockMembers.Text =  currentband.Members[0].ToString() + " " + currentband.Members[1].ToString();

            DisplaySelected();
        }

        void DisplaySelected()
        {
            albumsToDisplay.Clear();
            AlbumsListBox.ItemsSource = null;

            switch(x)
            {
                case 0:
                    albumsToDisplay.Add(album1);
                    
                    break;
                case 1:
                    albumsToDisplay.Add(album3);
                    
                    break;
                case 2:
                    albumsToDisplay.Add(album5);
                    
                    break;
                case 3:
                    albumsToDisplay.Add(album2);
                    break;
                case 4:
                    albumsToDisplay.Add(album4);
                    break;
                case 5:
                    albumsToDisplay.Add(album6);
                    break;
                case 6:
                    albumsToDisplay.Add(album6);
                    break;
                case 7:
                    albumsToDisplay.Add(album6);
                    break;
            }
            AlbumsListBox.ItemsSource = albumsToDisplay;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
