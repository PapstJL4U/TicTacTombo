using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TicTacWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void app_startup(object sender, StartupEventArgs e){
            int row, col, win;
            if (e.Args.Length == 3)
            {   
                try{
                row = Math.Max(Convert.ToInt32(e.Args[0]), 2);
                col = Math.Max(Convert.ToInt32(e.Args[1]), 2);
                win = Math.Min(Math.Min(Convert.ToInt32(e.Args[2]), row), col);
                }catch{
                    row = 3; col = 3; win = 3;    
                }
            }else{
                row = 3; col = 3; win = 3;
            }
            MainWindow wnd = new MainWindow();
            Grid game = buildGameGrid(row, col, wnd);
            DockPanel inter = (DockPanel)wnd.FindName("AppDock");
            inter.Children.Add(game);
            wnd.setStructure(row, col);
            Controller_Spiel MeinSpiel = new Controller_Spiel(wnd, row, col, win);
            wnd.setSpiel(MeinSpiel);
            wnd.Show();
            //wnd.setSpielernamen(ResourceAssembly.FullName, Convert.ToString(Resources.Count));
        }

        private Grid buildGameGrid(int row, int col, MainWindow wnd){
            Grid MyGrid= new Grid();
            MyGrid.Margin = new Thickness(5, 5, 5, 5);
            MyGrid.ShowGridLines = true;
            MyGrid.Name =  "TTTGrid";
            wnd.RegisterName(MyGrid.Name, MyGrid);
            foreach(int i in Enumerable.Range(0, row)){
                RowDefinition rowy = new RowDefinition();
                rowy.Name = "Row" + i;
                MyGrid.RowDefinitions.Add(rowy);
            }

            foreach(int i in Enumerable.Range(0, col)){
                ColumnDefinition coly = new ColumnDefinition();
                coly.Name = "Column" + i;
                MyGrid.ColumnDefinitions.Add(coly);   
            }

            for (int i = 0; i < row; i++){
                for (int j = 0; j < col; j++){
                    Button newButton = new Button();
                    newButton.Name = "button_" + i + "_" + j;
                    wnd.RegisterName(newButton.Name, newButton);
                    //newButton.Content = i + "_" + j;
                    newButton.Click += wnd.SetStone;
                    MyGrid.Children.Add(newButton);
                    Grid.SetRow(newButton, i);
                    Grid.SetColumn(newButton,j);
                }
            }
                return MyGrid;
        }
    }
}
