using System;

namespace ShopDataBase
{
    public class Item<TKey, TValue> //Item - класс, описывающий объект товар 
    {                               //public TKey Key – хранит наименование товара
                                    //public TValue Value – хранит цену товара
        public TKey Key { get; set; } //наименование товара
        public TValue Value { get; set; } //цена товара
        public Item(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }
}