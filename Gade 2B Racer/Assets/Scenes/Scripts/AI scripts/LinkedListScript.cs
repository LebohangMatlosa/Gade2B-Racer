using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedListScript : MonoBehaviour
{
    public class LinkedList<T>
    {
        private LinkedListNode<T> head;
    private LinkedListNode<T> last;
    private int size = 0;

    public void push(T data)
    {
        LinkedListNode<T> temp = new LinkedListNode<T>(data);
        if (head == null)
        {
            head = temp;
            last = temp;

        }
        else
        {
            
            last = temp;

        }
        ++size;

    }

    public void replace(int index, T data)
    {
        if (index >= 0 && index < this.size)
        {
            LinkedListNode<T> current = this.head;
            for (int i = 0; i <= index; ++i)
            {
                if (i != index)
                {
                    current = current.Next;
                }
                else
                {
                    current.Value = data;
                }
            }
        }
    }

    public void insertAtPosition(int index, T data)
    {
        if (index >= 0 && index < this.size)
        {
            LinkedListNode<T> new_data = new LinkedListNode<T>(data);
            if (index == 0)
            {
                new_data.Next() = this.head;
                this.head = new_data;
            }
            else
            {
                LinkedListNode<T> current = this.head;
                for (int i = 0; i < index; ++i)
                {
                    if (i == (index - 1))
                    {
                        LinkedListNode<T> next = current.Next;
                        current.Next() = new_data;
                        new_data.Next() = next;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }

                if (index == (this.size - 1))
                {
                    this.last = new_data;
                }
            }
            ++this.size;
        }
    }

    public void remove(int index)
    {
        if (index >= 0 && index < this.size)
        {
            if (index == 0)
            {
                if (this.head.Next != null)
                {
                    this.head = this.head.Next;
                }
                else
                {
                    this.head = null;
                    this.last = null;
                }

                --this.size;
            }
            else
            {
                LinkedListNode<T> current = this.head;
                for (int i = 0; i < this.size; ++i)
                {
                    if (i == (index - 1))
                    {
                        if (current.Next.Next != null)
                        {

                                current.Next = current.Next.Next;
                        }
                        else
                        {
                            current.Next = null;
                            this.last = current;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Next;
                    }
                }

                --this.size;
            }
        }
    }

    public T get(int index)
    {
        if (index >= 0 && index < this.size)
        {
            LinkedListNode<T> current = this.head;
            T val = default(T);
            for (int i = 0; i < this.size; ++i)
            {
                if (i == index)
                {
                    val = current.Value;
                }
                else
                {
                    current = current.Next;
                }
            }

            return val;
        }
        else
        {
            throw new System.NullReferenceException();
        }
    }

    public T pop()
    {
        if (head != null)
        {
            LinkedListNode<T> temp = this.head;
            if (head.Next != null)
            {
                this.head = head.Next;
            }
            else
            {
                this.head = null;
                this.last = null;
            }

            --this.size;
            return temp.Value;
        }
        else
        {
            throw new NullReferenceException();
        }
    }

    public bool contains(T data)
    {
        ListIterator<T> it = this.getIterator();
        bool found = false;

        while (!found && it.hasNext())
        {
            if (it.next().ToString() == data.ToString())
            {
                found = true;
            }
        }

        return found;
    }

    public int getSize()
    {
        return this.size;
    }

    public void displayList()
    {
        if (this.head != null)
        {
            Console.Write("[");
            this.head.display();
            Console.WriteLine("]");
        }
    }

    public LinkIterator<T> getIterator()
    {
        LinkIterator<T> it = new LinkIterator<T>(this.head);
        return it;
    }
    }
    
}
