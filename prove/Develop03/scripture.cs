class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public bool AllWordsHidden => _words.All(w => w.IsHidden );

    public Scripture()
    {
        _reference = new Reference("",0,0);
        _words= new List<Word>();

    }

    public Scripture(Reference reference, string words )
    {
        _reference=reference;
        _words=words.Split(" ").Select(word => new Word(word)).ToList();
    }
    public Scripture GetScripture()
    {
        Console.WriteLine ("what scripture would you like to memorize. 1. heleman 5:12 2. Alma 26:35-36");
        string userInput =Console.ReadLine();

        Reference reference;
        string text;


        if (userInput == "2")
        {
            reference= new Reference("Alma",26,35,36);
            text = ("Now have we not reason to rejoice? Yea, I say unto you, there never were men that had so great reason to rejoice as we, since the world began; yea, and my joy is carried away, even unto boasting in my God; for he has all power, all wisdom, and all understanding; he comprehendeth all things, and he is a merciful Being, even unto salvation, to those who will repent and believe on his name.36 Now if this is boasting, even so will I boast; for this is my life and my light, my joy and my salvation, and my redemption from everlasting wo. Yea, blessed is the name of my God, who has been mindful of this people, who are a branch of the tree of Israel, and has been lost from its body in a strange land; yea, I say, blessed be the name of my God, who has been mindful of us, wanderers in a strange land.");
            return new Scripture(reference,text);
        }
        else if (userInput == "1")
        {
            reference= new Reference("Alma",26,35,36);
            text =( "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");
            return new Scripture(reference,text);
        }
        return new Scripture();
    }
    public void displayText()
    {
        Console.WriteLine(_reference.GetReferenceString());
        Console.WriteLine(string.Join(" ", _words.Select(w => w.GetWord())));
    } 
     public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(w => !w.IsHidden).ToList();

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
}