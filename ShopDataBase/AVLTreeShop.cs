namespace ShopDataBase
{
    public class AVLTreeShop
    {
        class Node
        {
            public Item<string, string> Key { get; set; }
            public Node left;
            public Node right;
            public int count;
            public Node(Item<string, string> key)
            {
                Key = key;
                left = null;
                right = null;
                count = 1;
            }
        }
        Node root;
        public int compare;
        public AVLTreeShop()
        {
            root = null;
            compare = 0;
        }
        public void Add(Item<string, string> key)
        {
            Node newItem = new Node(key);
            if (root == null)
            {
                root = newItem;
            }
            else
            {
                root = RecursiveInsert(root, newItem);
            }
        }

        private Node RecursiveInsert(Node current, Node newItem)
        {
            if (current == null)
            {
                current = newItem;
                return current;
            }
            else if ((newItem.Key.Key + newItem.Key.Value).CompareTo(current.Key.Key + current.Key.Value).Equals(0))
            {
                current.count++;
            }
            else if ((newItem.Key.Key + newItem.Key.Value).CompareTo(current.Key.Key + current.Key.Value) < 0)
            {
                current.left = RecursiveInsert(current.left, newItem);
                current = balance_tree(current);
            }
            else if ((newItem.Key.Key + newItem.Key.Value).CompareTo(current.Key.Key + current.Key.Value) > 0)
            {
                current.right = RecursiveInsert(current.right, newItem);
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
        public void Delete(Item<string, string> target)
        {
            root = Delete(root, target);
        }
        private Node Delete(Node current, Item<string, string> target)
        {
            Node parent;
            if (current == null)
            { 
                return null; 
            }
            else
            {
                //left subtree
                if ((target.Key + target.Value).CompareTo(current.Key.Key + current.Key.Value) < 0)
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
                //right subtree
                else if ((target.Key + target.Value).CompareTo(current.Key.Key + current.Key.Value) > 0)
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
                //if target is found
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

        public Item<string, string> Find(string key)
        {
            compare = 0;
            Node elem = Find(key, root);

            if (elem == null)
            {
                return null;
            }
            else if (elem.Key.Key + elem.Key.Value == key)
            {
                return elem.Key;
            }
            else
            {
                return null;
            }
        }
        private Node Find(string target, Node current)
        {           
            if (current == null)
            {
                compare++;
                return null;
            }
            if (target.CompareTo(current.Key.Key + current.Key.Value) < 0)
            {
                compare++;
                if (target == current.Key.Key + current.Key.Value)
                {                    
                    return current;
                }
                else
                    return Find(target, current.left);
            }
            else
            {
                compare++;
                if (target == current.Key.Key + current.Key.Value)
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
            int l = getHeight(current.left);
            int r = getHeight(current.right);
            int b_factor = l - r;
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
