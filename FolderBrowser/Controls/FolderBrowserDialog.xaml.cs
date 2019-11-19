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

namespace FolderBrowser.Controls
{
   
    public partial class FolderBrowserDialog : UserControl
    {

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(FolderBrowserDialog), new PropertyMetadata("Label"));



        public string TextButton
        {
            get { return (string)GetValue(TextButtonProperty); }
            set { SetValue(TextButtonProperty, value); }
        }

        public static readonly DependencyProperty TextButtonProperty =
            DependencyProperty.Register("TextButton", typeof(string), typeof(FolderBrowserDialog), new PropertyMetadata("Button"));



        public string Path
        {
            get { return (string)GetValue(PathProperty); }
            set { SetValue(PathProperty, value); }
        }

        public static readonly DependencyProperty PathProperty =
            DependencyProperty.Register("Path", typeof(string), typeof(FolderBrowserDialog), new PropertyMetadata(0));



        public FolderBrowserDialog()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialogo = new System.Windows.Forms.FolderBrowserDialog();

            System.Windows.Forms.DialogResult resultado = dialogo.ShowDialog();

            if (resultado == System.Windows.Forms.DialogResult.OK)
                Path = dialogo.SelectedPath;
        }
    }
}
