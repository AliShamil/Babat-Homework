namespace dictionary;

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

    public List<string> this[string index]
    {
        get
        {
            foreach (var p in pairs)
            {
                if(p.Key == index)
                    return p.Value;
            }
            throw new KeyNotFoundException();
        }
        set
        {
            foreach (var p in pairs)
            {
                if (p.Key == index)
                     p.Value = value;
            }
            throw new KeyNotFoundException();
        }
    }

}



class Program
{


    static void Main()
    {
        List<string?> AZ = new List<string?>();
        string[] azeword = { "Alma","Kepenek","Qus", "Ay", "Deniz", "Sican", "Komputer", "Stol","Qapi", "Pencere",
            "Agac", "Suse", "Odun","Pisik","It","Armud","Saftali","Gobelek","Xiyar","Pomidor",
            "Zeytun","Baliq","Heyvan","Insan","Yadplanetli","Bedheybet","Muellim","Sagird","Universitet","Mekteb" };
        AZ.AddRange(azeword);


        List<string?> ENG = new List<string?>();
        string[] engword = { "Apple","Butterfly","Bird", "Moon", "Deniz", "Mouse", "Computer", "Table","Door", "Window",
            "Tree", "Glass", "Wood","Cat","Dog","Pear","Peach","Mushroom","Cucumber","Tomato",
            "Olive","Fish","Animal","Human","Alien","Monster","Teacher","Student","University","School" };
        ENG.AddRange(engword);




        MyDictionary dictionary = new MyDictionary();

        dictionary["Apple"] = new List<string?> {"Alma"};
        dictionary["Butterfly"] = new List<string?> {"Kepenek","Pervane"};
        dictionary["Moon"] = new List<string?> {"Ay","Qemer"};
        dictionary["Sea"] = new List<string?> {"Deniz","Derya"};
        dictionary["Mouse"] = new List<string?> {"Sican"};
        dictionary["Computer"] = new List<string?> {"Komputer"};
        dictionary["Apple"] = new List<string?> {"Alma"};
        dictionary["Apple"] = new List<string?> {"Alma"};
        dictionary["Apple"] = new List<string?> {"Alma"};
        dictionary["Apple"] = new List<string?> {"Alma"};
        dictionary["Apple"] = new List<string?> {"Alma"};
        dictionary["Apple"] = new List<string?> {"Alma"};
        dictionary["Apple"] = new List<string?> {"Alma"};
        dictionary["Apple"] = new List<string?> {"Alma"};
        dictionary["Apple"] = new List<string?> {"Alma"};
        dictionary["Apple"] = new List<string?> {"Alma"};
        dictionary["Apple"] = new List<string?> {"Alma"};
        dictionary["Apple"] = new List<string?> {"Alma"};
        dictionary["Apple"] = new List<string?> {"Alma"};
        dictionary["Apple"] = new List<string?> {"Alma"};
        dictionary["Apple"] = new List<string?> {"Alma"};
        dictionary["Apple"] = new List<string?> {"Alma"};
        dictionary["Apple"] = new List<string?> {"Alma"};
        dictionary["Apple"] = new List<string?> {"Alma"};
        dictionary["Apple"] = new List<string?> {"Alma"};
        dictionary["Apple"] = new List<string?> {"Alma"};
        dictionary["Apple"] = new List<string?> {"Alma"};
        dictionary["Apple"] = new List<string?> {"Alma"};
        dictionary["Apple"] = new List<string?> {"Alma"};
        dictionary["Apple"] = new List<string?> {"Alma"};


        
        


    }
}