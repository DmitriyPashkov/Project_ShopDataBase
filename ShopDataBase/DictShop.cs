using System.IO;
using System.Text;

namespace ShopDataBase
{
    public class DictShop
    {
        public int size = 10;
        public int fullness = 0;
        public Item<string, string>[] Items;
        public int compare = 0;

        public DictShop()
        {            
            Items = new Item<string, string>[size]; 

            string path = "Shops.txt";

            if (File.Exists(path))            
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))                
                    using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))                    
                        while (!sr.EndOfStream)
                        {
                            string[] s = sr.ReadLine().Split(';');
                            Add(new Item<string, string>(s[0], s[1]));
                        }       
        }

        public int GetHash(string name, string adress)
        {
            int sum = 0;
            string key = name + adress;

            for (int i = 0; i < key.Length; i++)
            {
                sum += key[i];
            }

            return sum % size;
        }

        public Item<string, string> Search(string name, string adress)
        {
            var hash = GetHash(name, adress);
            compare = 0;
            
            if (Items[hash] == null)
            {
                compare++;
                return null;
            }            

            if (Items[hash].Key.Equals(name) && Items[hash].Value.Equals(adress))
            {
                compare++;
                return Items[hash];
            }
            else
            {
                for (var i = hash; i < size; i++)
                {
                    compare++;

                    if (Items[i] == null)
                    {                        
                        return null;
                    }

                    if (Items[i].Key.Equals(name) && Items[i].Value.Equals(adress))
                    {
                        return Items[i];
                    }                    
                }

                for (var i = 0; i < hash; i++)
                {
                    compare++;

                    if (Items[i] == null)
                    {
                        return null;
                    }

                    if (Items[i].Key.Equals(name) && Items[i].Value.Equals(adress))
                    {
                        return Items[i];
                    }                    
                }                
            }
            return null;
        }

        public void Add(Item<string, string> item)
        {
            var hash = GetHash(item.Key, item.Value);

            if (Items[hash] == null)
            {
                Items[hash] = item;
                fullness++;
            }
            else
            {
                bool placed = false;

                for (var i = hash; i < size; i++)
                {
                    if (Items[i] == null || Items[i].Key == "empty")
                    {
                        Items[i] = item;
                        placed = true;
                        fullness++;
                        break;
                    }

                    if (Items[i].Key.Equals(item.Key) && Items[i].Value.Equals(item.Value))
                    {
                        return;
                    }
                }

                if (!placed)
                {
                    for (var i = 0; i < hash; i++)
                    {
                        if (Items[i] == null || Items[i].Key == "empty")
                        {
                            Items[i] = item;
                            placed = true;
                            fullness++;
                            break;
                        }

                        if (Items[i].Key.Equals(item.Key) && Items[i].Value.Equals(item.Value))
                        {
                            return;
                        }
                    }
                }               
            }  
            
            if (fullness > size / 2)
            {
                size = size * 2;
                Resize();
            }
        }

        private void Resize() //метод открытой адресации хэш-таблицы
        {
            var newItems = new Item<string, string>[size];

            foreach (var item in Items)
            {
                if (item != null && !item.Key.Equals("empty"))
                {

                    var hash = GetHash(item.Key, item.Value);

                    if (newItems[hash] == null)
                    {
                        newItems[hash] = item;
                    }
                    else
                    {
                        var placed = false;

                        for (var i = hash; i < size; i++)
                        {
                            if (newItems[i] == null)
                            {
                                newItems[i] = item;
                                placed = true;
                                break;
                            }

                            if (newItems[i].Key.Equals(item.Key) && newItems[i].Value.Equals(item.Value))
                            {
                                break;
                            }
                        }

                        if (!placed)
                        {
                            for (var i = 0; i < hash; i++)
                            {
                                if (newItems[i] == null)
                                {
                                    newItems[i] = item;
                                    placed = true;
                                    break;
                                }

                                if (newItems[i].Key.Equals(item.Key) && newItems[i].Value.Equals(item.Value))
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            Items = newItems;
        }

        public void Remove(string name, string adress)
        {
            var hash = GetHash(name, adress);

            if (Items[hash] == null)
            {
                return;
            }
            else
            {
                bool removed = false;

                for (var i = hash; i < size; i++)
                {
                    if (Items[i] == null)
                    {
                        return;
                    }

                    if (Items[i].Key.Equals(name) && Items[i].Value.Equals(adress))
                    {                        
                        Items[i].Key = "empty";
                        Items[i].Value = "empty";                        
                        fullness--;
                        removed = true;
                        break;
                    }                   
                }

                if (!removed)
                {
                    for (var i = 0; i < hash; i++)
                    {
                        if (Items[i] == null)
                        {
                            return;
                        }

                        if (Items[i].Key.Equals(name) && Items[i].Value.Equals(adress))
                        {
                            Items[i].Key = "empty";
                            Items[i].Value = "empty";
                            fullness--;
                            break;                            
                        }
                    }
                }
                
                if (removed && size > 10 && fullness < size / 2)
                {
                    size = size / 2;
                    Resize();
                }
            }            
        }        

       
    }
}
