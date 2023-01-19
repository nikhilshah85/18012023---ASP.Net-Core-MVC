namespace shoppingAPPMVC.Models
{
    public class ProductDetails
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public string pCategory { get; set; }
        public double pPrice { get; set; }
        public bool pIsInStock { get; set; }


        static List<ProductDetails> pList = new List<ProductDetails>()
        {
            new ProductDetails(){ pId=101, pName="IPhone", pCategory="Electronics", pIsInStock=true, pPrice=140000},
            new ProductDetails(){ pId=102, pName="Samsung TV", pCategory="Electronics", pIsInStock=true, pPrice=140000},
            new ProductDetails(){ pId=103, pName="Maggie", pCategory="Fast-Food", pIsInStock=false, pPrice=140},
            new ProductDetails(){ pId=104, pName="Air pods", pCategory="Electronics", pIsInStock=true, pPrice=14000},
            new ProductDetails(){ pId=105, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=false, pPrice=14},
        };

        public List<ProductDetails> GetAllProducts()
        {
            return pList;
        }



    }
}
