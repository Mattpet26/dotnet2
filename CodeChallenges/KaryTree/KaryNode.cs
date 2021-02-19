using System;
using System.Collections.Generic;
using System.Text;

namespace KaryTree
{
    public class KaryNode<T>
    {
        private T value;
        private List<KaryNode<T>> children = new List<KaryNode<T>>();

        public KaryNode(T value)
        {
            this.value = value;
        }

        public T getValue()
        {
            return value;
        }
        public void setValue(T value)
        {
            this.value = value;
        }

        public List<KaryNode<T>> getChildren()
        {
            return children;
        }
        public void addChild(KaryNode<T> node)
        {
            children.Add(node);
        }
    }
}
