using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class ProductCollection : IEnumerator<Product>, IEnumerable<Product>
    {
        private List<Product> products = new List<Product>();

        private int index = -1;
        public Product Current => products[index];

        object IEnumerator.Current => products[index];

        public void Add(Product product)
        {
            products.Add(product);
        }

        public void Remove(Product product)
        {
            products.Remove(product);
        }

        public Iterator<Product> CreateIterator()
        {
            return new ProductsListIterator(this);
        }

        public bool MoveNext()
        {
            if(  index < products.Count-1)
            {
                index++;
                return true;
            }
            return false;
            
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Product> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public class ProductsListIterator :  Iterator<Product>
        {
            private int index;
            private ProductCollection Collection;
            public ProductsListIterator(ProductCollection collection)
            {
                Collection = collection;
            }

            public bool HasNext()
            {
                return index < Collection.products.Count;
            }


            public Product Current()
            {
                return Collection.products[index];
            }

            
            public void Next()
            {
                index++;
            }

            

        }
    }
}
