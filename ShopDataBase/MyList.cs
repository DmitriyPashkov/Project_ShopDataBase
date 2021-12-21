namespace ShopDataBase
{
    public class MyList //список элементов в списках
    {
        public ListItem Head;
        public int count;  // количество элементов в списке
        public int countCompare = 0; // количество сравнений

        public void Add(Item<string, int> data)
        {
            ListItem node = new ListItem(data);
            ListItem ptr = Head;
            if (Head == null)
                Head = node;
            else
            {
                while (ptr.Next != null)
                {
                    ptr = ptr.Next;
                }
                ptr.Next = node;
            }
            count++;
        }
        public bool Remove(Item<string, int> data) //Item<string, int> data - объект товар
        {
            ListItem current = Head;
            ListItem previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    // Если узел в середине или в конце
                    if (previous != null)
                    {
                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.Next = current.Next;
                    }
                    else
                    {
                        // если удаляется первый элемент
                        // переустанавливаем значение Head
                        Head = Head.Next;
                    }
                    count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public Item<string, int> Find(string data)
        {
            ListItem current = Head;
            countCompare = 0;
            while (current != null)
            {
                countCompare++;
                if (current.Data.Key.Equals(data))
                    return current.Data;
                current = current.Next;
            }
            return null;
        }
    }
}
