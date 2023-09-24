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
  /// Interaction logic for ReadFromFile.xaml
  /// </summary>
  public partial class ReadFromFileWindow : Window
  {
    private MainWindow _mainWindow;
    public ReadFromFileWindow(MainWindow mainWindow)
    {
      InitializeComponent();
      _mainWindow = mainWindow;
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
          if(!string.IsNullOrEmpty(saveFileDialog.FileName))
          {
            tbFilePath.Text = saveFileDialog.FileName;
          }
        }
        catch (Exception)
        {
          System.Windows.MessageBox.Show("Файл використовується іншим процесом");
          throw;
        }
      }
    }

    private void tbReadFromFileButton_Click(object sender, RoutedEventArgs e)
    {
      string path = tbFilePath.Text;
      if(string.IsNullOrEmpty(path))
      {
        MessageBox.Show("Wrong file path");
        return;
      }

      LinkedList.LinkedList<string> newList = new Laba_15_1.LinkedList.LinkedList<string>();

      using (StreamReader sr = new StreamReader(path))
      {
        string data = sr.ReadLine()!;

        while(data != null)
        {
          newList.AddLast(data);
          data = sr.ReadLine()!;
        }
      }

      _mainWindow.List = newList;
    }
  }
}
