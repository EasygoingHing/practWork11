using System.Text.RegularExpressions;
using System.Windows;

namespace WPFApp11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void Stroka1(string str)
        {
            Regex regex = new Regex(@"ahb|acb|aeb");     //регулярное выражение, которое находит ahb, acb, aeb.
            str = tbDano.Text;
            Match match = regex.Match(str);
            MatchCollection mathes = regex.Matches(str);

            object[] mas = new object[mathes.Count];
            mathes.CopyTo(mas, 0);
            tbResult.Text = mas[0].ToString() + " " + mas[1].ToString() + " " + mas[2].ToString();
        }

        void Stroka2(string str)
        {
            Regex regex = new Regex(@"a\d*a");     //регулярное выражение, которое находит строки в которых по краям стоят буквы 'a', а между ними любое количество цифр(в том числе и ноль цифр, то есть строка 'aa')
            str = tbDano2.Text;
            Match match = regex.Match(str);
            MatchCollection mathes = regex.Matches(str);

            object[] mas = new object[mathes.Count];
            mathes.CopyTo(mas, 0);
            tbResult2.Text = mas[0].ToString() + " " + mas[1].ToString() + " " + mas[2].ToString() + " " + mas[3].ToString() + " " + mas[4].ToString() + " " + mas[5].ToString();
        }

        private void ButtonToFind_Click(object sender, RoutedEventArgs e)
        {
            string S = "ahb acb aeb aeeb adcb axeb";
            Stroka1(S);
        }

        private void ButtonToFind2_Click(object sender, RoutedEventArgs e)
        {
            string S = "aa a1a a22a a333a a4444a a55555a aba aca";
            Stroka2(S);
        }
        

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил: Крутолапов Валерий ИСП-31 Вариант-1");
        }
    }
}