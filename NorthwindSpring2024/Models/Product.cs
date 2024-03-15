namespace NorthwindSpring2024.Models
{
    public class Product
    {
        // these are the class variables
        // -1 is an illegal id indicating that the variable hasn't been used yet
        private int productId = -1;
        private string productName = "n/a";
        private int supplierId = -1;
        private int categoryId = -1;
        private double unitPrice = Double.MaxValue;

        // this is how it's done in Java
        // public int getProductId() { return productId; }
        // public setProductId(int value) {  this.productId = value; }

        public int ProductId
        {
            get { return this.productId; }

            set { this.productId = value; }
        }

        public string ProductName
        {
            get { return this.productName; }

            set { this.productName = value; }
        }

        public int SupplierId
        {
            get { return this.supplierId; }

            set { this.supplierId = value; }
        }

        public int CategoryId
        {
            get { return this.categoryId; }

            set { this.categoryId = value; }
        }

        public double UnitPrice
        {
            get { return this.unitPrice; }

            set { this.unitPrice = value; }
        }

        // Constructors

        //public Product()
        //{
            // this is called the empty constructor because it has no parameters
            // it may have a lot of code here
        //}

        //public Product(int aProductId):this(aProductId, "n/a", -1, -1, Double.MaxValue)
        //{
        //    this.ProductId = aProductId; // this isn't needed if we are chaining constructors
        //}

        //public Product():this(-1, "n/a", -1, -1, Double.MaxValue)
        //{
            
        //}

        public Product(int aProductId, string aProductName, int aSupplierId, int aCategoryId, double aUnitPrice)
        {
            this.ProductId = aProductId; // runs the set for productId
            this.ProductName = aProductName;
            this.SupplierId = aSupplierId;
            this.CategoryId = aCategoryId;
            this.UnitPrice = aUnitPrice;
        }

        public override string ToString() // override replaces an already existing function or method
        {
            string message = "";
            message = message + "Product Id: " + this.ProductId + "<br />";
            message = message + "Product Name: " + this.ProductName + "<br />";
            message = message + "Supplier Id: " + this.SupplierId + "<br />";
            message = message + "Category Id: " + this.CategoryId + "<br />";
            message = message + "Unit Price: " + this.UnitPrice + "<br />";
            return message;
        }
    }
}
