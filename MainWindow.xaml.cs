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
using System.Threading;

namespace WpfDrums
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

    public class CrashPlayer
    {
        public static void Play()
        {
            MediaPlayer _mediaPlayer = new MediaPlayer();
            _mediaPlayer.Open(new Uri(@"C:\Users\USER\Desktop\Drum\Crash.wav"));
            _mediaPlayer.Play();
        }
    }

    public class SnarePlayer
    {
        public static void Play()
        {
            MediaPlayer _mediaPlayer = new MediaPlayer();
            _mediaPlayer.Open(new Uri(@"C:\Users\USER\Desktop\Drum\Snare.wav"));
            _mediaPlayer.Play();
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
                //Thread.Sleep(400);
                CrashPlayer.Play();
                Thread.Sleep(100);
                SnarePlayer.Play();
                Thread.Sleep(100);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CrashPlayer.Play();
        }

    }
}
