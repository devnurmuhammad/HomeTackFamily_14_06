namespace HomeTackFamily_14_06;

public class Person
{
    public bool oilalimi = false;
    public string Ism { get; set; }
    public Person jufti { get; set; }

    public static void FHDYO(Person p1,  Person p2)
    {
        p1.oilalimi =true;
        p2.oilalimi =true;
    }
    void func2(Person p) { 
        p.oilalimi =true;
    }
}
