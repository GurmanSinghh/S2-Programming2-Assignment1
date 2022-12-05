class Program
{

    static void Main(String[] args)
    {
        Purchase Prod1 = new(ProductCategory.Miscellaneous, 10);
        Prod1.CalculateCost();
        Console.WriteLine(Prod1.ToString());


        Purchase Prod2 = new(ProductCategory.Beverages);
        Prod2.CalculateCost();
        Console.WriteLine(Prod2.ToString());




    }
}

enum ProductCategory
{
    Grocery,
    Electronics,
    Beverages,
    CleaningSupplies,
    Miscellaneous

}


class Purchase
{

    static int PURCHASE_ID = 0;
    public int quantities;
    public double cost;
    public ProductCategory category;

    public void CalculateCost()
    {

        switch (category)
        {

            case ProductCategory.Electronics:
                this.cost = (quantities * 15) - ((quantities * 15) * 10) / 100;
                this.cost = cost + (cost * 13) / 100;
                break;
            case ProductCategory.CleaningSupplies:
                this.cost = (quantities * 5) - ((quantities * 5) * 20) / 100;
                this.cost = cost + (cost * 13) / 100;
                break;
            case ProductCategory.Beverages:
                this.cost = (quantities * 10) - ((quantities * 10) * 20) / 100;
                this.cost = cost + (cost * 13) / 100;
                break;
            case ProductCategory.Grocery:
                this.cost = (quantities * 1) - ((quantities * 1) * 20) / 100;
                this.cost = cost + (cost * 13) / 100;
                break;

            case ProductCategory.Miscellaneous:
                this.cost = (quantities * 20) - ((quantities * 20) * 20) / 100;
                this.cost = cost + (cost * 13) / 100;
                break;
            default:
                Console.WriteLine("ERRORRRR!!!!");
                break;

        }

    }

    public Purchase(ProductCategory Category, int Quanities = 0)
    {


        this.category = Category;
        this.quantities = Quanities;
        this.cost = 0;
        PURCHASE_ID = PURCHASE_ID + 1;


    }






    public override string ToString()
    {
        Console.WriteLine($"Pruchase ID Number {PURCHASE_ID} ");
        return $"Product category is  {category} and the quantity purchased is {quantities} and total cost is {cost}";
    }







}

