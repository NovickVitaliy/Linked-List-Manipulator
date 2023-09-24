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
  /// Interaction logic for AddElementToDoublyLinkedList.xaml
  /// </summary>
  public partial class AddElementToDoublyLinkedList : Window
  {
    LinkedList.LinkedList<string> _list;
    private string _value;
    public AddElementToDoublyLinkedList(LinkedList.LinkedList<string> list, string value)
    {
      InitializeComponent();
      _list = list;
      _value = value;
    }

    private void AddFirst_Click(object sender, RoutedEventArgs e)
    {
      _list.AddFirst(_value);
      Close();
    }

    private void AddLast_Click(object sender, RoutedEventArgs e)
    {
      _list.AddLast(_value);
      Close();
    }

    private void AddAtIndex_Click(object sender, RoutedEventArgs e)
    {
      bool success = int.TryParse(tbIndex.Text, out int index);
      if(!success)
      {
        MessageBox.Show("Index is not a number");
        return;
      }

      _list.Add(_value, index);
    }

  }
}
