using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace Laba_15_1
{
  /// <summary>
  /// Interaction logic for SaveToFile.xaml
  /// </summary>
  public partial class SaveToFileWindow : Window
  {
    LinkedList.LinkedList<string> _list;
    public SaveToFileWindow(LinkedList.LinkedList<string> list)
    {
      InitializeComponent();
      _list = list;
    }

    private void ChooseFileButton_Click(object sender, RoutedEventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.InitialDirectory = "c:\\";
      saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
      saveFileDialog.FilterIndex = 2;
      saveFileDialog.RestoreDirectory = true;
      string path;
      Stream stream;

      if (saveFileDialog.ShowDialog() == true)
      {
        try
        {
          if ((stream = saveFileDialog.OpenFile()) != null)
          {
            using (stream)
            {
              tbFilePath.Text = saveFileDialog.FileName;
            }
          }
        }
        catch (Exception)
        {
          System.Windows.MessageBox.Show("Файл використовується іншим процесом");
          throw;
        }
      }
    }

    private void SaveToFileButton_Click(object sender, RoutedEventArgs e)
    {
      string path = tbFilePath.Text;
      if(string.IsNullOrEmpty(path))
      {
        MessageBox.Show("Wrong path");
        return;
      }

      using(var streamWriter = new StreamWriter(path))
      {
        foreach (var item in _list)
        {
          streamWriter.WriteLine(item.ToString());
        }
      }

      MessageBox.Show("Data was saved to file");
    }
  }
}
