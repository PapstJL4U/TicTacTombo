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
using model;

namespace TicTacWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Controller_Spiel MeinSpiel = null;
        Dictionary<Farbe, SolidColorBrush> KVBrushes = new Dictionary<Farbe, SolidColorBrush>(){
            { Farbe.Weiss, Brushes.AntiqueWhite},
            { Farbe.Schwarz, Brushes.DimGray },
            { Farbe.Blau, Brushes.AliceBlue },
            { Farbe.Rot, Brushes.MistyRose},
            { Farbe.Lila, Brushes.BlueViolet }
        };
        
        Button[,] MyButtons = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void setStructure(int row, int col){

            MyButtons = new Button[row, col];
            DockPanel MyDock = (DockPanel)this.Content;
            Grid center = (Grid) MyDock.Children[2];
            foreach (Button bt in center.Children){
                int r ,c;
                (r, c) = Name_to_Coordinates(bt.Name);
                MyButtons[r, c] = bt;
            }

            this.setArrow(0);
        }

        internal void gewonnenesSpiel(string Spielername, int SpielerID, int Spiele_gewonnen)
        {   
            tb_output.Text = $"{Spielername} hat gewonnen.";
            int i = SpielerID + 1;
            Label win = (Label)this.FindName("p" + i + "wins");
            win.Content = Spiele_gewonnen;
            foreach (Button bt in MyButtons)
            {
                bt.IsHitTestVisible = false;
            }
        }

        internal void setArrow(int anDerReihe)
        {
            if(anDerReihe == 0){
                arrow.Source = new BitmapImage(new Uri("pack://application:,,,/res/arrow_left.png"));
            }else{
                arrow.Source = new BitmapImage(new Uri("pack://application:,,,/res/arrow_right.png"));
            }
        }
        internal void setSpiel(Controller_Spiel Spiel){
            MeinSpiel = Spiel;
        }
        internal void setButton(int row, int col, Farbe far)
        {
            Button btn = (Button)this.FindName(Coordinates_to_Name(row, col));
            btn.Background = KVBrushes[far];
            btn.IsHitTestVisible = false;
        }

        internal void setSpielernamen(String Spieler1, String Spieler2)
        {
            player1.Content = Spieler1;
            player2.Content = Spieler2;
        }

        private (int, int) Name_to_Coordinates(String button_name)
        {
            string[] parts = button_name.Split("_");
            int r = Convert.ToInt32(parts[1]);
            int c = Convert.ToInt32(parts[2]);
            return (r, c);
        }

        private String Coordinates_to_Name(int row, int col)
        {
            return "button_" + row + "_" + col;
        }

        internal void neuesSpiel(object sender, RoutedEventArgs e)
        {   
            foreach(Button bt in MyButtons){
                bt.Background = Brushes.LightGray;
                bt.IsHitTestVisible = true;
            }
            MeinSpiel.neuesSpiel();
        }

        internal void SetStone(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            int row, col;
            (row, col) = Name_to_Coordinates(bt.Name);
            MeinSpiel.pressedButton(row, col);
        }

        internal void setGoal(int win){
            tb_output.Text = $"Du brauchst {win} in einer Reihe zum gewinnen";
        }

        internal void setSpielerFarbe(Farbe farbe1, Farbe farbe2)
        {
            p1wins.Background = KVBrushes[farbe1];
            p2wins.Background = KVBrushes[farbe2];
        }
    }
}
