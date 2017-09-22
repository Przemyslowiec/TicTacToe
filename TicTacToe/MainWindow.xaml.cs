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
using TicTacToe;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BitmapImage BitimgSharp;
        private Image ImgSharp;

        private BitmapImage BitimgCircle;
        private Image ImgCirlce;

        private Dictionary<string, string> List;

        private bool IsSomeoneWin;
        private string WhoWinName;
        public MainWindow()
        {
            InitializeComponent();

            BitimgSharp = new BitmapImage();
            BitimgSharp.BeginInit();
            BitimgSharp.UriSource = new Uri(@"D:\Programy\C#\TicTacToe\TicTacToe\sharp.png", UriKind.RelativeOrAbsolute);
            BitimgSharp.EndInit();
            ImgSharp = new Image();
            ImgSharp.Stretch = Stretch.Fill;
            ImgSharp.Source = BitimgSharp;

            BitimgCircle = new BitmapImage();
            BitimgCircle.BeginInit();
            BitimgCircle.UriSource = new Uri(@"D:\Programy\C#\TicTacToe\TicTacToe\circle.png", UriKind.RelativeOrAbsolute);
            BitimgCircle.EndInit();
            ImgCirlce = new Image();
            ImgCirlce.Stretch = Stretch.Fill;
            ImgCirlce.Source = BitimgCircle;
            
            O.IsChecked = true;
            IsSomeoneWin = false;
            WhoWinName = String.Empty;

            List = new Dictionary<string, string>();
        }
        
        private enum Player { circle, sharp };

        private void WhoWin()
        {

            string Value1;
            string Value2;
            string Value3;

            #region FirstCase
            List.TryGetValue("Button1", out Value1);
            List.TryGetValue("Button2", out Value2);
            List.TryGetValue("Button3", out Value3);
            if ((Value1 == "O" && Value2 == "O" && Value3 == "O")
                || (Value1 == "X" && Value2 == "X" && Value3 == "X"))
            {
                if (Value1 == "X")
                {
                    WhoWinName = "Player X is winner!";
                }
                else
                {
                    WhoWinName = "Player O is winner!";
                }
                Button1.Background = new SolidColorBrush(Colors.Blue);
                Button2.Background = new SolidColorBrush(Colors.Blue);
                Button3.Background = new SolidColorBrush(Colors.Blue);
                IsSomeoneWin = true;
            }
            #endregion

            #region SecondCase
            List.TryGetValue("Button4", out Value1);
            List.TryGetValue("Button5", out Value2);
            List.TryGetValue("Button6", out Value3);
            if ((Value1 == "O" && Value2 == "O" && Value3 == "O")
                || (Value1 == "X" && Value2 == "X" && Value3 == "X"))
            {
                if (Value1 == "X")
                {
                    WhoWinName = "Player X is winner!";
                }
                else
                {
                    WhoWinName = ("Player O is winner!");
                }
                Button4.Background = new SolidColorBrush(Colors.Blue);
                Button5.Background = new SolidColorBrush(Colors.Blue);
                Button6.Background = new SolidColorBrush(Colors.Blue);

                IsSomeoneWin = true;
            }
            #endregion

            #region ThirdCase
            List.TryGetValue("Button7", out Value1);
            List.TryGetValue("Button8", out Value2);
            List.TryGetValue("Button9", out Value3);
            if ((Value1 == "O" && Value2 == "O" && Value3 == "O")
                || (Value1 == "X" && Value2 == "X" && Value3 == "X"))
            {
                if (Value1 == "X")
                {
                    WhoWinName = ("Player X is winner!");
                }
                else
                {
                    WhoWinName = ("Player O is winner!");
                }
                Button7.Background = new SolidColorBrush(Colors.Blue);
                Button8.Background = new SolidColorBrush(Colors.Blue);
                Button9.Background = new SolidColorBrush(Colors.Blue);

                IsSomeoneWin = true;
            }
            #endregion

            #region FouthCase
            List.TryGetValue("Button1", out Value1);
            List.TryGetValue("Button5", out Value2);
            List.TryGetValue("Button9", out Value3);
            if ((Value1 == "O" && Value2 == "O" && Value3 == "O")
                || (Value1 == "X" && Value2 == "X" && Value3 == "X"))
            {
                if (Value1 == "X")
                {
                    WhoWinName = ("Player X is winner!");
                }
                else
                {
                    WhoWinName = ("Player O is winner!");
                }
                Button1.Background = new SolidColorBrush(Colors.Blue);
                Button5.Background = new SolidColorBrush(Colors.Blue);
                Button9.Background = new SolidColorBrush(Colors.Blue);

                IsSomeoneWin = true;
            }
            #endregion

            #region FifthCase
            List.TryGetValue("Button7", out Value1);
            List.TryGetValue("Button5", out Value2);
            List.TryGetValue("Button3", out Value3);
            if ((Value1 == "O" && Value2 == "O" && Value3 == "O")
                || (Value1 == "X" && Value2 == "X" && Value3 == "X"))
            {
                if (Value1 == "X")
                {
                    WhoWinName = ("Player X is winner!");
                }
                else
                {
                    WhoWinName = ("Player O is winner!");
                }
                Button7.Background = new SolidColorBrush(Colors.Blue);
                Button5.Background = new SolidColorBrush(Colors.Blue);
                Button3.Background = new SolidColorBrush(Colors.Blue);

                IsSomeoneWin = true;
            }
            #endregion

            #region SixthCase
            List.TryGetValue("Button1", out Value1);
            List.TryGetValue("Button4", out Value2);
            List.TryGetValue("Button7", out Value3);
            if ((Value1 == "O" && Value2 == "O" && Value3 == "O")
                || (Value1 == "X" && Value2 == "X" && Value3 == "X"))
            {
                if (Value1 == "X")
                {
                    WhoWinName = ("Player X is winner!");
                }
                else
                {
                    WhoWinName = ("Player O is winner!");
                }
                Button1.Background = new SolidColorBrush(Colors.Blue);
                Button4.Background = new SolidColorBrush(Colors.Blue);
                Button7.Background = new SolidColorBrush(Colors.Blue);

                IsSomeoneWin = true;
            }
            #endregion

            #region SeventhCase
            List.TryGetValue("Button2", out Value1);
            List.TryGetValue("Button5", out Value2);
            List.TryGetValue("Button8", out Value3);
            if ((Value1 == "O" && Value2 == "O" && Value3 == "O")
                || (Value1 == "X" && Value2 == "X" && Value3 == "X"))
            {
                if (Value1 == "X")
                {
                    WhoWinName = ("Player X is winner!");
                }
                else
                {
                   WhoWinName = ("Player O is winner!");
                }
                Button2.Background = new SolidColorBrush(Colors.Blue);
                Button5.Background = new SolidColorBrush(Colors.Blue);
                Button8.Background = new SolidColorBrush(Colors.Blue);

                IsSomeoneWin = true;
            }
            #endregion

            #region EightCase
            List.TryGetValue("Button3", out Value1);
            List.TryGetValue("Button6", out Value2);
            List.TryGetValue("Button9", out Value3);
            if ((Value1 == "O" && Value2 == "O" && Value3 == "O")
                || (Value1 == "X" && Value2 == "X" && Value3 == "X"))
            {
                if (Value1 == "X")
                {
                    WhoWinName = ("Player X is winner!");
                }
                else
                {
                    WhoWinName = ("Player O is winner!");
                }
                Button3.Background = new SolidColorBrush(Colors.Blue);  
                Button6.Background = new SolidColorBrush(Colors.Blue);
                Button9.Background = new SolidColorBrush(Colors.Blue);

                IsSomeoneWin = true;
            }
            #endregion
        }

        private void ButtonClicked(object sender, RoutedEventArgs e)
        {
            
            if (!List.ContainsKey((sender as Button).Name))
            {
                if (O.IsChecked == true)
                {
                    (sender as Button).Background = new ImageBrush(BitimgCircle);
                    (sender as Button).Background.Freeze();
                    O.IsChecked = false;
                    X.IsChecked = true;
                    List.Add((sender as Button).Name, "O");
                }
                else
                {
                    (sender as Button).Background = new ImageBrush(BitimgSharp);
                    (sender as Button).Background.Freeze();
                    O.IsChecked = true;
                    X.IsChecked = false;
                    List.Add((sender as Button).Name, "X");
                }
            }
         
            O.IsHitTestVisible = false;
            X.IsHitTestVisible = false;
            WhoWin();

            if (IsSomeoneWin)
            {
                var result = MessageBox.Show(WhoWinName+"\nPlay Again?", "Win",MessageBoxButton.YesNo);

                switch (result)
                {
                    case MessageBoxResult.Yes:
                        Button1.Background = new SolidColorBrush(Colors.White);
                        Button2.Background = new SolidColorBrush(Colors.White);
                        Button3.Background = new SolidColorBrush(Colors.White);
                        Button4.Background = new SolidColorBrush(Colors.White);
                        Button5.Background = new SolidColorBrush(Colors.White);
                        Button6.Background = new SolidColorBrush(Colors.White);
                        Button7.Background = new SolidColorBrush(Colors.White);
                        Button8.Background = new SolidColorBrush(Colors.White);
                        Button9.Background = new SolidColorBrush(Colors.White);

                        O.IsHitTestVisible = true;
                        X.IsHitTestVisible = true;

                        O.IsChecked = true;
                        IsSomeoneWin = false;
                        WhoWinName = String.Empty;
                        List.Clear();
                        break;
                    case MessageBoxResult.No:
                        this.Close();
                        break;
                }
            }
        }
    }
}

