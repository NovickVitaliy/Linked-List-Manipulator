using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows;

namespace Laba_15_1.LinkedList
{
  public class LinkedListNode<T>
  {
    private T _data;
    private LinkedListNode<T> _next;
    private LinkedListNode<T> _previous;

    public LinkedListNode(T data)
    {
      _data = data;
      _next = null;
    }

    public T Data
    {
      get => _data;
      set => _data = value;
    }

    public LinkedListNode<T> Next
    {
      get => _next;
      set => _next = value;
    }

    public LinkedListNode<T> Previous
    {
      get => _previous;
      set => _previous = value;
    }

  }

  public class LinkedList<T> : IEnumerable<T>
  {
    LinkedListNode<T> _head;
    LinkedListNode<T> _tail;
    int _count;

    public LinkedList()
    {
      _head = null;
      _tail = null;
    }

    public void Add(T value)
    {
      var node = new LinkedListNode<T>(value);
      if (_head == null)
      {
        _head = node;
        _tail = node;
      }
      else
      {
        //_tail.Next = node;
        _tail = node;
      }
      _count++;
    }

    public void Add(T value, int index)
    {
      var runner = First;
      LinkedList.LinkedListNode<T> previous = null;

      //index = _list.Count - index - 1;

      while (runner != null)
      {
        if (index == 0)
        {
          var node = new LinkedList.LinkedListNode<T>(value);

          if (previous == null)
          {
            runner.Previous = node;
            node.Next = runner;
            First = node;
          }
          else
          {
            previous.Next = node;
            node.Next = runner;
          }
          _count++;
          return;
        }
        previous = runner;
        runner = runner.Next;
        index--;
      }
    }

    public void Remove(int index)
    {
      var runner = _head;
      if (index == 0)
      {
        First = First.Next;
        _count--;
        return;
      }

      if(index == _count - 1)
      {
        _tail.Previous.Next = null;
        _count--;
        return;
      }

      for(int i = 0; i < index; ++i)
      {
        runner = runner.Next;
      }

      runner.Previous.Next = runner.Next;
      _count--;
    }

    public bool Contains(T value)
    {
      var current = _head;
      while (current != null)
      {
        if (current.Data.Equals(value))
        {
          return true;
        }

        current = current.Next;
      }

      return false;
    }

    public void Clear()
    {
      _head = null;
      _tail = null;
      _count = 0;
    }

    public bool IsEmpty()
    {
      return _count == 0;
    }

    public void AddFirst(T value)
    {
      LinkedListNode<T> node = new LinkedListNode<T>(value);

      LinkedListNode<T> temp = _head;

      _head = node;

      _head.Next = temp;

      if (Count == 0)
      {
        _tail = _head;
      }
      else
      {
        temp.Previous = _head;
      }

      _count++;
    }

    public void AddLast(T value)
    {
      LinkedListNode<T> node = new LinkedListNode<T>(value);

      if (Count == 0)
      {
        _head = node;
      }
      else
      {
        _tail.Next = node;

        node.Previous = _tail;
      }

      _tail = node;
      _count++;
    }

    public void RemoveFirst()
    {
      if (Count != 0)
      {
        _head = _head.Next;

        _count--;

        if (Count == 0)
        {
          _tail = null;
        }
        else
        {
          _head.Previous = null;
        }
      }
    }

    public void RemoveLast()
    {
      if (Count != 0)
      {
        if (Count == 1)
        {
          _head = null;
          _tail = null;
        }
        else
        {
          _tail.Previous.Next = null;
          _tail = _tail.Previous;
        }

        _count--;
      }
    }

    public void Replace(T value, int index)
    {
      var current = _head;

      for(int i = 0; i < index;++i)
      {
        current = current.Next;
      }

      current.Data = value;
    }

    public void ReplaceAll(T value)
    {
      var runner = _head;

      while(runner != null) 
      {
        runner.Data = value;
        runner = runner.Next;
      }
    }

    public bool Remove(T item)
    {
      LinkedListNode<T> previous = null;
      LinkedListNode<T> current = _head;


      while (current != null)
      {
        if ((typeof(T) == typeof(string) ? (current.Data as string)!.Equals(item as string, StringComparison.InvariantCultureIgnoreCase) : current.Data!.Equals(item)))
        {
          if (previous != null)
          {
            previous.Next = current.Next;

            if (current.Next == null)
            {
              _tail = previous;
            }
            else
            {
              current.Next.Previous = previous;
            }

            _count--;
          }
          else
          {
            RemoveFirst();
          }

          return true;
        }

        previous = current;
        current = current.Next;
      }

      return false;
    }

    public LinkedListNode<T> FindByField(string field)
    {
      var runner = _head;

      while(runner != null)
      {
        if((runner.Data as string)!.Contains(field))
        {
          return runner;
        }
        runner = runner.Next;
      }
      return null;
    }

    public void InsertionSort()
    {
      if (First == null || First.Next == null)
      {
        return; // Already sorted or empty list
      }

      LinkedListNode<T> sorted = null;
      LinkedListNode<T> current = First;

      while (current != null)
      {
        var next = current.Next;
        if (sorted == null || Comparer<T>.Default.Compare(current.Data, sorted.Data) < 0)
        {
          current.Next = sorted;
          sorted = current;
        }
        else
        {
          var search = sorted;
          while (search.Next != null && Comparer<T>.Default.Compare(current.Data, search.Next.Data) >= 0)
          {
            search = search.Next;
          }
          current.Next = search.Next;
          search.Next = current;
        }
        current = next;
      }

      First = sorted;
    }

    public int Count
    {
      get
      {
        return _count;
      }
    }

    public LinkedListNode<T> First
    { get { return _head; }
      private set { _head = value; }
    }
    public LinkedListNode<T> Last
    { get { return _tail; }
      private set { _tail = value; }
    }

    public IEnumerator<T> GetEnumerator()
    {
      var current = _head;
      while (current != null)
      {
        yield return current.Data;
        current = current.Next;
      }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return ((IEnumerable<T>)this).GetEnumerator();
    }
  }
}
