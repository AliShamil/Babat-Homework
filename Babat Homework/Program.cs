namespace dictionary;
//Kohne c++ dan yazdigimiz dictionary nin kodlarini c# formasinda yazdim
class MyKeyValuePair
{
    public string? Key { get; set; }

    public List<string> Value { get; set; }

    public MyKeyValuePair()
    {
        Key = default;
        Value = default;
    }

    public MyKeyValuePair(string key, List<string> value)
    {
        Key = key;
        Value = value;
    }
}


class MyDictionary
{
    private List<MyKeyValuePair> pairs;


    public MyDictionary()
    {
        pairs = new List<MyKeyValuePair>();
    }

    public List<string>? this[string key]
    {
        get
        {
            foreach (var pair in pairs)
            {
                if (pair.Key == key.ToLower())
                    return pair.Value;
            }

            throw new KeyNotFoundException();
        }
        set
        {
            foreach (var pair in pairs)
            {
                if (pair.Key == key.ToLower())
                    pair.Value = value!;
            }

            pairs.Add(new MyKeyValuePair(key, value!));
        }
    }
}



class Program
{


    static void Main()
    {


        MyDictionary dictionary = new MyDictionary();

        dictionary["apple"] = new List<string?> { "Alma" };
        dictionary["butterfly"] = new List<string?> { "Kepenek", "Pervane" };
        dictionary["moon"] = new List<string?> { "Ay", "Qemer" };
        dictionary["sea"] = new List<string?> { "Deniz", "Derya" };
        dictionary["mouse"] = new List<string?> { "Sican" };

        dictionary["computer"] = new List<string?> { "Komputer" };
        dictionary["table"] = new List<string?> { "Cedvel", "Stol" };
        dictionary["door"] = new List<string?> { "Qapi" };
        dictionary["window"] = new List<string?> { "Pencere" };
        dictionary["glass"] = new List<string?> { "Suse", "Stekan", "Qedeh", "Guzgu", "Ayna" };

        dictionary["wood"] = new List<string?> { "Taxta", "Odun", "Meshe" };
        dictionary["cat"] = new List<string?> { "Pisik", "Mestan" };
        dictionary["dog"] = new List<string?> { "It" };
        dictionary["pear"] = new List<string?> { "Armud" };
        dictionary["peach"] = new List<string?> { "Shaftali" };

        dictionary["mushroom"] = new List<string?> { "Gobelek" };
        dictionary["cucumber"] = new List<string?> { "Xiyar" };
        dictionary["tomato"] = new List<string?> { "Pomidor" };
        dictionary["olive"] = new List<string?> { "Zeytun" };
        dictionary["fish"] = new List<string?> { "Baliq" };

        dictionary["animal"] = new List<string?> { "Heyvan" };
        dictionary["human"] = new List<string?> { "Insan", "Adam" };
        dictionary["alien"] = new List<string?> { "Yad", "Ecnebi", "Yadplanetli" };
        dictionary["monster"] = new List<string?> { "Bedheybet", "Qulyabani" };
        dictionary["teacher"] = new List<string?> { "Muellim" };

        dictionary["student"] = new List<string?> { "Shagird", "Telebe" };
        dictionary["university"] = new List<string?> { "Universitet" };
        dictionary["school"] = new List<string?> { "Mekteb" };
        dictionary["bird"] = new List<string?> { "Qush" };
        dictionary["path"] = new List<string?> { "Yol", "Cigir" };



        while (true)
        {
            Console.Clear();
            Console.Write($@"(*If you want exit press 0)
Enter word: ");
            string? enter = Console.ReadLine();
            if (enter == "0")
            {
                Console.WriteLine("\n\n\n\n\n\n\t\t\t\t\t\t\tGOOD BYE!");
                Environment.Exit(0);
            }
            Console.WriteLine("\n\n----------- RESULT -----------\n");

            try
            {
            foreach (var word in dictionary[enter])
            {
                Console.WriteLine(word);
            }

            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Word not found !");
                Thread.Sleep(1500);
                continue;
            }
                Console.ReadKey(false);

        }



    }
}