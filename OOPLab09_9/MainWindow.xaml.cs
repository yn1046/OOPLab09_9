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
using Microsoft.Win32;
using System.IO;

namespace OOPLab09_9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ICommand NewCommand { get; set; }
        public ICommand OpenCommand { get; set; }
        public ICommand SaveCommand { get; set; }

        public static int Num { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            NewCommand = new DelegateCommand(OpenNew);
            OpenCommand = new DelegateCommand(DoOpen);
            SaveCommand = new DelegateCommand(DoSave);
            DataContext = this;
            if (Num == 0) Num = 1;
        }

        public void OpenNew()
        {
            var mainwin = new MainWindow();
            mainwin.Title = "Window" + Num;
            mainwin.Show();
            Num++;
        }

        public void DoOpen()
        {
            try
            {
                var dlg = new OpenFileDialog();
                dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
                if (dlg.ShowDialog() == true)
                {
                    var fileStream = new FileStream(dlg.FileName, FileMode.Open);
                    var range = new TextRange(textBox.Document.ContentStart,
                    textBox.Document.ContentEnd);
                    range.Load(fileStream, DataFormats.Rtf);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK);
            }
        }

        public void DoSave()
        {
            var dlg = new SaveFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                var fileStream = new FileStream(dlg.FileName, FileMode.Create);
                var range = new TextRange(textBox.Document.ContentStart,
                textBox.Document.ContentEnd);
                range.Save(fileStream, DataFormats.Rtf);
            }
        }
    }
}
