using System;
using System.Collections;




    class Nongeneric_collection
    {
      void ng_collection()
    {
        ArrayList al=new ArrayList();//[101,"payal",76.5]
        al.Add(101);
        al.Add("payal");
        al.Add(76.5);
        foreach (string studentdata in al)
        {
            Console.WriteLine(studentdata);
            Thread.Sleep(1000);
        }


        Console.WriteLine("contains 202??" + al.Contains(101));
        Console.WriteLine("count:"+al.Count);
        Console.WriteLine("index of payal:"+al.IndexOf("payal"));
        al.Insert(0, 'A');
        for (int i = 0; i < al.Count; i++)
        {
            Console.WriteLine(al[i]);
            Thread.Sleep(1000);
        }
        //remove,removeat,lastindexof,reverse
        
        //removerange,add range,insertrange,toarray,tostring =homework on 15 to 20 objects by user input
        al.Clear();//remove all objects of the collections
        
    }
    public static void Main(string[] args)
    {
        Nongeneric_collection o1=new Nongeneric_collection();
        o1.ng_collection();
    }
}
