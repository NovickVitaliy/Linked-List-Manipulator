using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Xml.Linq;

namespace Laba_15_1
{
  public static class LinkedListExntesion
  {
    public static void Sort(this LinkedList.LinkedList<string> list)
    {
      var current = list.First;

      for(int i = 0; i < list.Count; i++)
      {
        for(int j = 0; j < list.Count; j++)
        {
          
        }
      }
    }

    public static LinkedList.LinkedListNode<string> SortLinkedList(LinkedList.LinkedListNode<string> head, int count)
    {

      LinkedList.LinkedListNode<string> _current = head;
      LinkedList.LinkedListNode<string> _previous = _current;

      LinkedList.LinkedListNode<string> _min = _current;
      LinkedList.LinkedListNode<string> _minPrevious = _min;

      LinkedList.LinkedListNode<string> _sortedListHead = null;
      LinkedList.LinkedListNode<string> _sortedListTail = _sortedListHead;

      for (int i = 0; i < count; i++)
      {
        _current = head;
        _min = _current;
        _minPrevious = _min;

        //Find min Node
        while (_current != null)
        {
          if (_current.Data[0] < _min.Data[0])
          {
            _min = _current;
            _minPrevious = _previous;
          }
          _previous = _current;
          _current = _current.Next;
        }

        // Remove min Node 
        if (_min == head)
        {
          head = head.Next;
        }
        else if (_min.Next == null) //if tail is min node
        {
          _minPrevious.Next = null;
        }
        else
        {
          _minPrevious.Next = _minPrevious.Next.Next;
        }


        //Attach min Node to the new sorted linked list
        if (_sortedListHead != null)
        {
          _sortedListTail.Next = _min;
          _sortedListTail = _sortedListTail.Next;
        }
        else
        {
          _sortedListHead = _min;
          _sortedListTail = _sortedListHead;
        }
      }

      return _sortedListHead;
    }
  }
}
