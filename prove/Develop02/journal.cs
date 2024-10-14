using System.IO;
using System.Reflection.Metadata.Ecma335;
class Journal
{
    public List<Entry> journal = new List<Entry>();
    //foreach funciton that uses the random operatior to pick a random prompt
    public string _file; 

    public void SaveJournal()
    {
        if (string.IsNullOrEmpty(_file))
        {
            Console.WriteLine("please give a filename that you want to save this entry to");
            _file=Console.ReadLine();
            foreach (Entry entry in journal)
            {
                using (StreamWriter outputFile = new StreamWriter(_file,append:true))
                {
                    outputFile.WriteLine($"{entry.date}|{entry.prompt}|{entry.entry}~");
                }
            }
        }
    }
    public Journal LoadJournal(string fileName)
    {
        Journal loadedJournal = new Journal ();
        loadedJournal._file=fileName;

        //string[] lines = System.IO.File.ReadAllLines(fileName);
        string[] lines = File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            //Entry entry = new Entry();
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry();
                {
                    entry.date=lines[0];
                    entry.prompt=lines[1];
                    entry.entry=lines[2];
                };
                loadedJournal.journal.Add(entry);
            }
        }
        return loadedJournal;
    }
    public void ReadJournal ()
    {
        foreach (Entry entry in journal)
        {
            Console.WriteLine ($"\n{entry.date}\n{entry.prompt}");
            Console.WriteLine (entry.entry);
        }
    }
    
}

    
