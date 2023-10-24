using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokolov_Ivan_praktik2
{
    public class Node
    {
        public Node next;
        public int data;

        public Node(int data)
        {
            this.data = data;
        }
    }
    internal class Queue
    {
        public int capacity;
        Node head;
        Node tail;
        public int count;

        public void Creat_Random_Queue(int capacity)
        {
            Random rnd = new Random();
            for (int i = 0; i < capacity; i++)
            {
                Enqueue(rnd.Next(1, capacity + 100));
            }

        }


        public void Enqueue(int data)
        {
            Node node = new Node(data);
            Node tempNode = tail;
            tail = node;
            if (IsFull)
                return;
            else
            {
                if (IsEmpty)
                {
                    head = tail;
                    count++;
                }
                else if (count == 1)
                {
                    tempNode.next = tail;
                    head = tempNode;
                    count++;
                }
                else
                {
                    tempNode.next = tail;
                    count++;
                }
            }
        }
        // удаление из очереди
        public void Dequeue()
        {
            if (IsEmpty)
            {
                return;
            }
            else
            {
                head = head.next;
                count--;
            }

        }
        // получаем первый элемент
        public int First()
        {
            return head.data;
        }
        // получаем последний элемент
        public int Last()
        {
            return tail.data;
        }
        public int Count { get { return count; } }
        public bool IsFull { get { return count == capacity; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
        // Вывод всей очереди
        public int[] Full_write()
        {
            int[] data = new int[count];
            Node current = head;
            for (int i = 0; i < count; i++)
            {
                data[i] = current.data;
                current = current.next;
            }
            return data;
        }
        public int GetElent(int index)
        {
            Node current = head;
            int l = 1;
            while (l < index)
            {
                current = current.next;
            }
            return current.data;
        }
        public void SetElement(int index, int data)
        {

        }
    }


}
