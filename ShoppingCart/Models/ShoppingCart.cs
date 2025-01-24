namespace ShoppingCartProject.Models
{
    public class ShoppingCart
    {
        private readonly List<Product> _products;

        public ShoppingCart()
        {
            _products = new List<Product>();
        }

        public int ProductCount => _products.Count;

        public void AddProduct(string v1, double v2)
        {
            _products.Add(new Product(v1, v2));
        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        public double GetTotalPrice()
        {
            return _products.Sum(x => x.Price);
        }

        public void RemoveProduct(string v)
        {
            _products.Remove(_products.Where(x => x.Name == v).First());
        }

        //TODO Készítse el a ShoppingCart osztályban azokat a metódusokat, amelyekkel sikeresen lefutnak a tesztesetek!

    }
}
