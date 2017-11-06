using SQLite4Unity3d;

public class TranslationsDB {

    public string KeyText { get; set; }
    public string English { get; set; }
    public string Dutch { get; set; }

    public override string ToString()
    {
        return string.Format("{0}|{1}", English, Dutch);
    }

    public string ToEnglish()
    {
        return English;
    }

    public string ToDutch()
    {
        return Dutch;
    }
}
