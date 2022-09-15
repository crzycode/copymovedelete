string source = @"D:\Intervies\";
string distination = @"D:\Interview Que\";
if (File.Exists(distination + "INTERVIEW.docx"))
{
    Console.WriteLine("file is already exist");
}
else
{
    File.Copy(source + "INTERVIEW.docx", distination + "INTERVIEW.docx");
}
