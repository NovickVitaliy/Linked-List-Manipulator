using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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

namespace Laba_15_1
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public LinkedList.LinkedList<string> List { get => _linkedList; set => _linkedList = value; }
    // 1 - Single Linked List
    // 2 - Doubly Linked List
    public int TypeOfList { get; set; } = 0;
    private LinkedList.LinkedList<string> _linkedList = new Laba_15_1.LinkedList.LinkedList<string>();
    public MainWindow()
    {
      GetChosenTypeOfList();
      InitializeComponent();
      ChosenList.Content += TypeOfList == 1 ? "Single Linked List of Shops" : "Doubly Linked List of TV Shows";
    }

    private void GetChosenTypeOfList()
    {
      ChooseTypeOfList choose = new ChooseTypeOfList(this);
      choose.ShowDialog();
    }

    private void AddElementButton_Click(object sender, RoutedEventArgs e)
    {
      string value = tbAddElement.Text;

      if(TypeOfList == 1)
      {
        _linkedList.AddLast(value);
        MessageBox.Show("Element added");
      }
      else if(TypeOfList == 2)
      {
        AddElementToDoublyLinkedList addElementToDoublyLinkedList = new AddElementToDoublyLinkedList(_linkedList, value);
        addElementToDoublyLinkedList.ShowDialog();
      }

    }

    private void CheckElement_Click(object sender, RoutedEventArgs e)
    {
      StringBuilder stringBuilder = new StringBuilder();  

      var runner = _linkedList.First;

      while(runner != null)
      {
        stringBuilder.Append(runner.Data + "; ");
        runner = runner.Next;
      }

      MessageBox.Show("Elements of linked list: " + stringBuilder.ToString());
    }

    private void Count_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show(_linkedList.Count.ToString());
    }

    private void IsEmpty_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show(_linkedList.IsEmpty() ? "Empty" : "Not empty");
    }

    private void Remove_Click(object sender, RoutedEventArgs e)
    {
      RemoveElementWindow remove = new RemoveElementWindow(_linkedList);
      remove.ShowDialog();
    }

    private void Edit_Click(object sender, RoutedEventArgs e)
    {
      EditElement edit = new EditElement(_linkedList);
      edit.ShowDialog();
    }


    private void Replace_Click(object sender, RoutedEventArgs e)
    {
      _linkedList.ReplaceAll(tbReplaceValueForAll.Text);
    }

    private void FindByField_Click(object sender, RoutedEventArgs e)
    {
      string field = tbFieldToFind.Text;

      var node = _linkedList.FindByField(field);
      if(node == null)
      {
        MessageBox.Show("No node was found with this field");
        return;
      }

      MessageBox.Show($"Info about node: Data:{node.Data}, Previous: {((node.Previous != null) ? (node.Previous.Data) : "Not exist")}, Next: {((node.Next != null) ? (node.Next.Data) : "Not exist")}");
    }

    private void Sort_Click(object sender, RoutedEventArgs e)
    {
      _linkedList.InsertionSort();
      MessageBox.Show("List has been sorted");
    }

    private void SaveToFile_Click(object sender, RoutedEventArgs e)
    {
       SaveToFileWindow saveToFile = new SaveToFileWindow(_linkedList);
       saveToFile.ShowDialog();
    }

    private void ReadFromFile_Click(object sender, RoutedEventArgs e)
    {
      ReadFromFileWindow readFromFile = new ReadFromFileWindow(this);
      readFromFile.ShowDialog();
    }
  }
}
