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
        public ICommand FontCommand { get; set; }
        public ICommand ColorCommand { get; set; }
        public ICommand SwitchCommand { get; set; }

        public Uri Russian { get; set; }
        public Uri English { get; set; }

        public static int Num { get; set; }

        public MainWindow()
        {
            Resources = new ResourceDictionary();
            English = new Uri("pack://application:,,,/English.xaml");
            Russian = new Uri("pack://application:,,,/Russian.xaml");
            Resources.Source = English;
            InitializeComponent();
            NewCommand = new DelegateCommand(OpenNew);
            OpenCommand = new DelegateCommand(DoOpen);
            SaveCommand = new DelegateCommand(DoSave);
            FontCommand = new DelegateCommand(ShowFontDialog);
            ColorCommand = new DelegateCommand(ShowColorDialog);
            SwitchCommand = new DelegateCommand(DoLangSwitch);
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

        public void ShowFontDialog()
        {
            var fd = new System.Windows.Forms.FontDialog();
            var result = fd.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var tr = new TextRange(textBox.Selection.Start, textBox.Selection.End);

                tr.ApplyPropertyValue(TextElement.FontFamilyProperty, new FontFamily(fd.Font.Name));
                tr.ApplyPropertyValue(TextElement.FontSizeProperty, fd.Font.Size * 96.0 / 72.0);
                tr.ApplyPropertyValue(TextElement.FontWeightProperty, textBox.FontWeight = fd.Font.Bold ? FontWeights.Bold : FontWeights.Regular);
                tr.ApplyPropertyValue(TextElement.FontStyleProperty, fd.Font.Italic ? FontStyles.Italic : FontStyles.Normal);

                TextDecorationCollection tdc = new TextDecorationCollection();
                if (fd.Font.Underline) tdc.Add(TextDecorations.Underline);
                else tr.ApplyPropertyValue(Inline.TextDecorationsProperty, null);
                if (fd.Font.Strikeout) tdc.Add(TextDecorations.Strikethrough);
                else tr.ApplyPropertyValue(Inline.TextDecorationsProperty, null);
                tr.ApplyPropertyValue(Inline.TextDecorationsProperty, tdc);
            }

        }

        public void ShowColorDialog()
        {
            var cd = new System.Windows.Forms.ColorDialog();
            var result = cd.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var tr = new TextRange(textBox.Selection.Start, textBox.Selection.End);
                tr.ApplyPropertyValue(TextElement.ForegroundProperty, new SolidColorBrush(System.Windows.Media.Color.FromArgb(cd.Color.A, cd.Color.R, cd.Color.G, cd.Color.B)));
            }
        }

        public void DoLangSwitch()
        {
            if (Resources.Source.AbsolutePath.Equals(Russian.AbsolutePath)) Resources.Source = English;
            else if (Resources.Source.AbsolutePath.Equals(English.AbsolutePath)) Resources.Source = Russian;
            InitializeComponent();
        }
    }
}
