

const string source = @"D:\Intervies\";
const string distination = @"D:\Interview Que\exp\";
/*copyfile();*/
/*copyallfile();*/
createfile();

static void createfile()
{
    StreamWriter file = new StreamWriter(source + "mangal.txt");
    file.WriteLine("helllooos");
    file.Close();
}


    static void copyfile()
    {
   

    if (File.Exists(distination + "INTERVIEW.docx"))
        {
            Console.WriteLine("file is already exist");
        }
        else
        {
            File.Copy(source + "INTERVIEW.docx", distination + "INTERVIEW.docx");
        }

        
    }
    static void copyallfile()
    {
    if (!Directory.Exists(distination))
    {
Directory.CreateDirectory(distination);
    }
   
        string[] files = Directory.GetFiles(source);
        foreach (string file in files)
        {
            string filename = Path.GetFileName(file);
            File.Copy(file, distination+filename, true);
        }
        Console.WriteLine("all file is done");
    }




static void movefiles()
{
    if (!Directory.Exists(distination))
    {
        Directory.CreateDirectory(distination);
    }
    if (File.Exists(distination + "INTERVIEW.docx"))
    {
        Console.WriteLine("file is already exist");
    }
    else
    {
        File.Move(source + "INTERVIEW.docx", distination + "INTERVIEW.docx");
    }
}
static void moveallfiles()
{
    string[] files = Directory.GetFiles(source);
    foreach (var item in files)
    {
        string file = Path.GetFileName(item);
        File.Move(item, distination+file,true);

    }
    Console.WriteLine("all files moved");
}
static void deletefile()
{
    File.Delete(distination + "INTERVIEW - Copy.docx");

}
static void deleteallfiles()
{
    string[] files = Directory.GetFiles(distination);
    foreach (var item in files)
    {
        File.Delete(item);
    }
}

