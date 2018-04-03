using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Diagnostics;

namespace KassaRakendus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Tekst = new List<MyItem>();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        public List<string> OstukorvList { get; private set; }
        public List<MyItem> Tekst { get; private set; }

        public void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ostukorv
            this.InitializeComponent();

            

            // lisab veerud
            var gridView = new GridView();
            this.listView.View = gridView;
            gridView.Columns.Add(new GridViewColumn
            {
                Header = "Hind",
                DisplayMemberBinding = new Binding("Hind")

            });
            gridView.Columns.Add(new GridViewColumn
            {
                Header = "Toode",
                DisplayMemberBinding = new Binding("Toode")
            });
            gridView.Columns.Add(new GridViewColumn
            {
                Header = "Kogus",
                DisplayMemberBinding = new Binding("Kogus")
            });



        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            //hind
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            //kogus
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            //lisa
            this.listView.Items.Add(new MyItem { Toode = NimetusBox.Text, Hind = int.Parse(HindBox.Text), Kogus = int.Parse(KogusBox.Text) });
            Tekst.Add(new MyItem { Toode = NimetusBox.Text, Hind = int.Parse(HindBox.Text), Kogus = int.Parse(KogusBox.Text) });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //eemalda
            var selected = listView.SelectedItems.Cast<Object>().ToArray();
            foreach (var item in selected)
            {
                listView.Items.Remove(item);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //osta
            var Tšekk = new Tšekk();
            Tšekk.Print(Tekst);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Environment.Exit(420);
        }
    }
}
