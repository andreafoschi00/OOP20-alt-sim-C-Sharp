using System;
using System.Windows;
using System.IO;

namespace AltSim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly double SCREEN_WIDTH = 1280;
        private static readonly double SCREEN_HEIGHT = 920;

        private static readonly string workingDirectory = Environment.CurrentDirectory;
        private static readonly string UserHomeDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

        public MainWindow()
        {
            InitializeComponent();
        }

        public static double GetWidth()
        {
            return SCREEN_WIDTH;
        }

        public static double GetHeight()
        {
            return SCREEN_HEIGHT;
        }

        public static string GetUserHomeDirectory()
        {
            return UserHomeDirectory;
        }
    }
}
