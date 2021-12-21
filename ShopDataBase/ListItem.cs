namespace ShopDataBase
{
    public class ListItem //Класс, описывающий узел односвязного списка
    {
        public ListItem(Item<string, int> data)
        {
            Data = data;
        }
        public Item<string, int> Data { get; set; } //хранит объект товар 
        public ListItem Next { get; set; } //хранит адрес следующего узла
    }
}
