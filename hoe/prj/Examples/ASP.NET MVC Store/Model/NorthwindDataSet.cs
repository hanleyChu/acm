using ASPNET_MVC_Store.Model.NorthwindDataSetTableAdapters;

namespace ASPNET_MVC_Store.Model {

    public partial class NorthwindDataSet
    {
        private static NorthwindDataSet instance;

        private CategoriesTableAdapter categoriesTableAdapter = new CategoriesTableAdapter();
        private ProductsTableAdapter productsTableAdapter = new ProductsTableAdapter();
        private SuppliersTableAdapter suppliersTableAdapter = new SuppliersTableAdapter();

        public static NorthwindDataSet Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NorthwindDataSet();
                    instance.Init();
                }
                return instance;
            }
        }

        public void Init()
        {
            if (IsInTestMode)
                FillWithTestData();
            else
                FillWithRealData();

        }

        private void FillWithTestData()
        {
            instance.Categories.AddCategoriesRow("Cat 1", "Cat 1 Desc", null);
            instance.Products.AddProductsRow("Pr 1", null, instance.Categories[0],
                                                          "1", 1, 1, 1, 1, false);
        }

        private void FillWithRealData()
        {
            categoriesTableAdapter.Fill(instance.Categories);
            productsTableAdapter.Fill(instance.Products);
            suppliersTableAdapter.Fill(instance.Suppliers);
        }

        private bool IsInTestMode
        {
            get
            {
                return System.Configuration.ConfigurationManager
                  .ConnectionStrings["NwindConnectionString"] == null;
            }
        }
    }
}
