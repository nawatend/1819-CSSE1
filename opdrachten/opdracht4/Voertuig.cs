class Voertuig
{

    //velden
    //properties
    //methodes
    //constructors ... 

    private bool motor;
    private int laadvermogen;


    public int Laadvermogen
    {
        get
        {
            return laadvermogen;
        }
        set
        {
            laadvermogen = value;
        }
    }
    public bool Motor
    {
        get;
        set;
    }
    public Voertuig(int laadvermogen)
    {
        this.laadvermogen = laadvermogen;
    }
    public Voertuig()
    {


    }

    public string ToString()
    {
        return "Vouertuig met laadvermogen: " + this.laadvermogen;
    }
}