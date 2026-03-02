
     class streamclass_filehandling
    {
      void writeop()
      {
        string path = "C:\\Users\\FortuneCloudIndia\\Desktop\\hellosecondmarch.txt";
       // FileStream fs = new FileStream(path,FileMode.Create);
       // FileStream fs = new FileStream(path, FileMode.Open);
        FileStream fs = new FileStream(path, FileMode.OpenOrCreate);

        StreamWriter swr = new StreamWriter(fs);
        swr.WriteLine("happy holi");
        swr.WriteLine("tomorrow is the holiday");
        swr.Close();
        fs.Close();
        Console.WriteLine("file writed successfully");
      }
    void readop()
    {
        string path = "C:\\Users\\FortuneCloudIndia\\Desktop\\dhuliwandan.txt";
        FileStream fs2 = new FileStream(path, FileMode.OpenOrCreate);
        StreamReader sr = new StreamReader(fs2);
        String alltext= sr.ReadToEnd();
        Console.WriteLine(alltext);
        sr.Close();
        fs2.Close();
    }
    public static void Main(string[] args)
    {
        streamclass_filehandling sh=new streamclass_filehandling();
        sh.writeop();
        sh.readop();
    }
}
