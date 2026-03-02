
//class filehandling
//{
//    public static void Main(String[] args)
//    {
//        filehandling obj= new filehandling();
//        obj.filestaticclass();
//        obj.filinfoclass();

//    }
//    void filinfoclass()
//    {
//        Console.WriteLine("-------------File info class--------------");
//        string file_dest = "C:\\Users\\FortuneCloudIndia\\Desktop\\myfile.txt";
//        FileInfo fi = new FileInfo(file_dest);
//        fi.Create().Close();
//        ///if file is exist then display message file created successfully
//        if(fi.Exists)
//        {
//            fi.Delete();
//              if( fi.Exists )
//               {
//                Console.WriteLine("file is not deleted");
//               }
//            else
//               {
//                Console.WriteLine("file is deleted successfully");
//                }
//        }
//        else
//        {
//            Console.WriteLine("file is not exist!");
//        }
//            Console.WriteLine("Name:" + fi.Name);
//        Console.WriteLine("FullName:" + fi.FullName);
//        Console.WriteLine("creationtime:" + fi.CreationTime);
//        Console.WriteLine("directory name:"+fi.DirectoryName);
//    }
//    void filestaticclass()
//    {
//        Console.WriteLine("---------File static class-------------");
//        string file_path = "C:\\Users\\FortuneCloudIndia\\Desktop\\2ndmarch.txt";
//        File.Create(file_path);
//        //if file is exist then display message file created successfully
//        if (File.Exists(file_path))
//        {
//            Console.WriteLine("File created successfully!!creation time: " + File.GetCreationTime(file_path));
//        }
//        else
//        {
//            Console.WriteLine("file is not created");
//        }
//    }
//}