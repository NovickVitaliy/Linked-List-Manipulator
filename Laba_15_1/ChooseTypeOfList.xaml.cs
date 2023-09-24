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
  /// Interaction logic for ChooseTypeOfList.xaml
  /// </summary>
  /// 
  public partial class ChooseTypeOfList : Window
  {
    MainWindow _mainWindow;
    public ChooseTypeOfList(MainWindow mainWindow)
    {
      InitializeComponent();
      _mainWindow = mainWindow;
    }

    private void SingleLinkedList_Click(object sender, RoutedEventArgs e)
    {
      _mainWindow.TypeOfList = 1;
      this.Close();
    }

    private void DoublyLinkedList_Click(object sender, RoutedEventArgs e)
    {
      _mainWindow.TypeOfList = 2;
      this.Close();
    }
  }
}
