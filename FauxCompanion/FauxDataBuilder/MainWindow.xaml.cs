using System.Windows;

using Microsoft.Win32;

namespace EnergonSoftware.FauxDataBuilder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

#region UI Event Handlers
        private void MenuFileNew_Click(object sender, RoutedEventArgs e)
        {
            App.Instance.State.Reset();
        }

        private void MenuFileOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                FileName = App.Instance.State.LastFileName,
                DefaultExt = ".json",
                Filter = "JSON documents (.json)|*.json"
            };

            var result = dlg.ShowDialog();
            if(result.HasValue && result.Value) {
                if(!App.Instance.State.Open(dlg.FileName)) {
// TODO: what?
                }
            }
        }

        private void MenuFileSave_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(App.Instance.State.LastFileName)) {
                MenuFileSaveAs_Click(sender, e);
                return;
            }

            if(!App.Instance.State.Save()) {
// TODO: what?
            }
        }

        private void MenuFileSaveAs_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog
            {
                FileName = string.Empty,            // TODO: use the last opened filename
                DefaultExt = ".json",
                Filter = "JSON documents (.json)|*.json"
            };

            var result = dlg.ShowDialog();
            if(result.HasValue && result.Value) {
                if(!App.Instance.State.Save(dlg.FileName)) {
// TODO: what?
                }
            }
        }

        private void MenuFileExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
#endregion
    }
}
