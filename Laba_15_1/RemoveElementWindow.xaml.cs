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
using System.Windows.Shapes;

namespace Laba_15_1
{
  /// <summary>
  /// Interaction logic for RemoveElementWindow.xaml
  /// </summary>
  public partial class RemoveElementWindow : Window
  {
    LinkedList.LinkedList<string> _list;
    public RemoveElementWindow(LinkedList.LinkedList<string> list)
    {
      InitializeComponent();
      _list = list;
    }

    private void DeleteAllElementButton_Click(object sender, RoutedEventArgs e)
    {
      _list.Clear();
      MessageBox.Show("All items was deleted");
    }

    private void DeleteByIndexButton_Click(object sender, RoutedEventArgs e)
    {
      var success = int.TryParse(tbIndex.Text, out int index);
      if(!success)
      {
        MessageBox.Show("Index is not a number");
        return;
      }

      if(index < 0 || index >= _list.Count)
      {
        MessageBox.Show("Innapropriate index");
        return;
      }

      _list.Remove(index);
    }

    private void DeleteByValueButton_Click(object sender, RoutedEventArgs e)
    {
      string value = tbValueSingle.Text;

      _list.Remove(value);
    }

    private void DeleteByValuesAsCSV_Click(object sender, RoutedEventArgs e)
    {
      string[] values = tbValuesAsCSV.Text.Split(',');

      foreach (string value in values)
      {
        _list.Remove(value);
      }
    }
  }
}
