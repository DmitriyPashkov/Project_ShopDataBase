namespace ShopDataBase
{
    public class AVLTreePrice //класс, описывающий авл дерево
    {
        class Node
        {
            public Item<string, int> Key { get; set; } //объект товар
            public Node left;
            public Node right;
            public int count;
            public Node(Item<string, int> key)
            {
                Key = key;
                left = null;
                right = null;
                count = 1;
            }
        }
        Node root; //хранит корень дерева
        public int compare = 0; //хранит количество сравнений при поиске элемента
        public AVLTreePrice()
        {
            root = null;
            compare = 0;
        }
        public void Add(Item<string, int> key)
        {
            Node newItem = new Node(key);
            if (root == null)
            {
                root = newItem;
            }
            else
            {
                root = Insert(root, newItem);
            }
        }

        private Node Insert(Node current, Node newItem)
        {
            if (current == null)
            {
                current = newItem;
                return current;
            }
            else if (newItem.Key.Key.CompareTo(current.Key.Key) == 0)
            {
                current.count++;
            }
            else if (newItem.Key.Key.CompareTo(current.Key.Key) < 0)
            {
                current.left = Insert(current.left, newItem);
                current = balance_tree(current);
            }
            else if (newItem.Key.Key.CompareTo(current.Key.Key) > 0)
            {
                current.right = Insert(current.right, newItem);
                current = balance_tree(current);
            }            

            return current;
        }
        private Node balance_tree(Node current)
        {
            int b_factor = balance_factor(current);
            if (b_factor > 1)
            {
                if (balance_factor(current.left) > 0)
                {
                    current = RotateLL(current);
                }
                else
                {
                    current = RotateLR(current);
                }
            }
            else if (b_factor < -1)
            {
                if (balance_factor(current.right) > 0)
                {
                    current = RotateRL(current);
                }
                else
                {
                    current = RotateRR(current);
                }
            }
            return current;
        }
        public void Delete(Item<string, int> target)
        {
            root = Delete(root, target);
        }
        private Node Delete(Node current, Item<string, int> target)
        {
            Node parent;
            if (current == null)
            { 
                return null; 
            }
            else
            {
                if (target.Key.CompareTo(current.Key.Key) < 0)
                {
                    current.left = Delete(current.left, target);
                    if (balance_factor(current) == -2)
                    {
                        if (balance_factor(current.right) <= 0)
                        {
                            current = RotateRR(current);
                        }
                        else
                        {
                            current = RotateRL(current);
                        }
                    }
                }
                else if (target.Key.CompareTo(current.Key.Key) > 0)
                {
                    current.right = Delete(current.right, target);
                    if (balance_factor(current) == 2)
                    {
                        if (balance_factor(current.left) >= 0)
                        {
                            current = RotateLL(current);
                        }
                        else
                        {
                            current = RotateLR(current);
                        }
                    }
                }
                else
                {
                    if (current.count > 1)
                    {
                        current.count--;
                    }
                    else if (current.right != null)
                    {                        
                        parent = current.right;
                        while (parent.left != null)
                        {
                            parent = parent.left;
                        }
                        current.Key = parent.Key;
                        current.right = Delete(current.right, parent.Key);
                        if (balance_factor(current) == 2)
                        {
                            if (balance_factor(current.left) >= 0)
                            {
                                current = RotateLL(current);
                            }
                            else { current = RotateLR(current); }
                        }
                    }
                    else
                    {   
                        return current.left;
                    }
                }
            }
            return current;
        }
        public Item<string, int> Find(string key)
        {
            compare = 0;
            Node elem = Find(key, root);
            if (elem == null)
            {
                return null;
            }
            else if (elem.Key.Key == key)
            {
                return elem.Key;
            }
            else
            {
                return null;
            }
        }
        private Node Find(string target, Node current) //string target - хранит наименование товара
        {                                //Node current хранит корень дерева
            if (current == null)
            {
                compare++;
                return null;
            }
            if (target.CompareTo(current.Key.Key) < 0)
            {
                compare++;
                if (target == current.Key.Key)
                {
                    return current;
                }
                else
                    return Find(target, current.left);
            }
            else
            {
                compare++;
                if (target == current.Key.Key)
                {
                    return current;
                }
                else
                    return Find(target, current.right);
            }

        }        
        private int max(int l, int r)
        {
            return l > r ? l : r;
        }
        private int getHeight(Node current)
        {
            int height = 0;
            if (current != null)
            {
                int l = getHeight(current.left);
                int r = getHeight(current.right);
                int m = max(l, r);
                height = m + 1;
            }
            return height;
        }
        private int balance_factor(Node current)
        {
            int l = getHeight(current.left); //хранит высоту левого поддерева
            int r = getHeight(current.right); //хранит высоту правого поддерева
            int b_factor = l - r; //разница высот
            return b_factor;
        }
        private Node RotateRR(Node parent)
        {
            Node pivot = parent.right;
            parent.right = pivot.left;
            pivot.left = parent;
            return pivot;
        }
        private Node RotateLL(Node parent)
        {
            Node pivot = parent.left;
            parent.left = pivot.right;
            pivot.right = parent;
            return pivot;
        }
        private Node RotateLR(Node parent)
        {
            Node pivot = parent.left;
            parent.left = RotateRR(pivot);
            return RotateLL(parent);
        }
        private Node RotateRL(Node parent)
        {
            Node pivot = parent.right;
            parent.right = RotateLL(pivot);
            return RotateRR(parent);
        }
    }
}
