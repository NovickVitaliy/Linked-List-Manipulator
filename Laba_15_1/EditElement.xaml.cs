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
  /// Interaction logic for EditElement.xaml
  /// </summary>
  public partial class EditElement : Window
  {
    private LinkedList.LinkedList<string> _list;
    public EditElement(LinkedList.LinkedList<string> list)
    {
      InitializeComponent();
      _list = list;
    }

    private void EditElementButton_Click(object sender, RoutedEventArgs e)
    {
      var success = int.TryParse(tbIndex.Text, out int index);
      if (!success)
      {
        MessageBox.Show("Index not a number");
        return;
      }

      if (index < 0 || index >= _list.Count)
      {
        MessageBox.Show("Innapropriate index");
        return;
      }
      string value = tbValue.Text;

      _list.Replace(value, index);
    }
  }
}
