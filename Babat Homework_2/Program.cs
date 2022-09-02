using System.Text.RegularExpressions;
namespace Babat_2;


struct Article
{


    public string ProductCode { get; set; }
    public string ProductName { get; set; }
    private double price;

    public double Price
    {
        get { return price; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("value");

            price = value;
        }
    }


    public Article(string productCode, string productName, double price) : this()
    {
        ProductCode = productCode;
        ProductName = productName;
        Price = price;
    }


    public static bool operator <(Article a1, Article a2)
        => a1.Price < a2.Price;

    public static bool operator >(Article a1, Article a2)
        => a1.Price > a2.Price;

    public static bool operator <=(Article a1, Article a2)
    => a1.Price <= a2.Price;

    public static bool operator >=(Article a1, Article a2)
        => a1.Price >= a2.Price;

    public static bool operator ==(Article a1, Article a2)
    => a1.ProductCode == a2.ProductCode && a1.ProductName == a2.ProductName;

    public static bool operator !=(Article a1, Article a2)
        => !(a1 == a2);

    public override string ToString()
=> $@"ProductCode: {ProductCode}
ProductName: {ProductName}
Price: {Price} AZN";
}


struct Client
{
    #region HelperFunc
    // BU Kodu Internetden tapmisam deyilene gore telfon nomrelerini yoxluyur
    public const string motif = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";

    public static bool IsPhoneNbr(string number)
    {
        if (number != null) return Regex.IsMatch(number, motif);
        else return false;
    }

    #endregion

    public string ClientCode { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
    public short NumberOfOrdersByClient { get; set; }
    public short TotalAmountOfOrders { get; set; }
    private string telephone;


    public string Telephone
    {
        get { return telephone; }
        set 
        {
            if (!IsPhoneNbr(value))
                throw new ArgumentException("Invalid telephone number !");

            telephone = value; 
        }
    }



    public Client(string clientCode, string fullName, string address, string telephone, short numberOfOrdersByClient, short totalAmountOfOrders):this()
    {
        ClientCode=clientCode;
        FullName=fullName;
        Address=address;
        Telephone=telephone;
        NumberOfOrdersByClient=numberOfOrdersByClient;
        TotalAmountOfOrders=totalAmountOfOrders;
    }

    public static bool operator ==(Client c1, Client c2)
        => c1.ClientCode == c2.ClientCode && c1.FullName == c2.FullName && c1.Address == c2.Address && c1.Telephone == c2.Telephone;

    public static bool operator !=(Client c1, Client c2)
        => !(c1 == c2);

    public static bool operator >(Client c1, Client c2)
        => c1.TotalAmountOfOrders > c2.TotalAmountOfOrders;

    public static bool operator <(Client c1, Client c2)
        => c1.TotalAmountOfOrders < c2.TotalAmountOfOrders;

    public static bool operator >=(Client c1, Client c2)
        => c1.TotalAmountOfOrders >= c2.TotalAmountOfOrders;

    public static bool operator <=(Client c1, Client c2)
        => c1.TotalAmountOfOrders <= c2.TotalAmountOfOrders;


    public override string ToString()
=> $@"Client Code: {ClientCode}
Full Name: {FullName}
Address: {Address}
Telephone: {Telephone}
Number of orders by client: {NumberOfOrdersByClient}
Total amount of orders: {TotalAmountOfOrders}";
}









class Program
{
    static void Main()
    {
        #region Client

        //Client c1 = new("AA2141123123", "Ali Shamil", "Bibiheybat", "0517755590", 12, 178);
        //Client c2 = new("AA2141123254", "Vasif Babayev", "Hezi Aslanov", "0703718852", 15, 190);

        //Console.WriteLine(c1==c2);
        //Console.WriteLine(c1!=c2);
        //Console.WriteLine(c1>c2);
        //Console.WriteLine(c1<c2);
        //Console.WriteLine(c1>=c2);
        //Console.WriteLine(c1<=c2);

        #endregion


        #region Article
        
        //Article a1 = new("AWA2131r124", "Soap", 12);
        //Article a2 = new("AWA21311452", "Bread", 1.5);

        //Console.WriteLine(a1==a2);
        //Console.WriteLine(a1!=a2);
        //Console.WriteLine(a1>a2);
        //Console.WriteLine(a1<a2);
        //Console.WriteLine(a1>=a2);
        //Console.WriteLine(a1<=a2);

        #endregion
    }
}