
//     class binaryfile_handling
//    {
//       void write_data()
//      {
//        string path = "C:\\Users\\FortuneCloudIndia\\Desktop\\user.bin";
//       FileStream fs=new FileStream(path, FileMode.OpenOrCreate);
//        BinaryWriter bw=new BinaryWriter(fs);
//        bw.Write(556);
//        bw.Write("hello everyone");
//        bw.Write(89.1);
//        bw.Write(true);
//        bw.Close();
//        fs.Close();
//    }
//    void read_data()
//    {
//        string path = "C:\\Users\\FortuneCloudIndia\\Desktop\\user.bin";
//        FileStream fs2 = new FileStream(path, FileMode.Open);
//        BinaryReader br=new BinaryReader(fs2);
//        int num=br.ReadInt32();
//        string str=br.ReadString();
//        double d=br.ReadDouble();
//        bool b=br.ReadBoolean();

//        Console.WriteLine("integer:"+num);
//        Console.WriteLine("String:" + str);
//        Console.WriteLine("Double:"+d);
//        Console.WriteLine("boolean:"+b);
//        br.Close();
//        fs2.Close();
//    }
//    public static void Main(string[] args)
//    {
//        binaryfile_handling ob=new binaryfile_handling();
//        ob.write_data();
//        ob.read_data();
//    }
//}
