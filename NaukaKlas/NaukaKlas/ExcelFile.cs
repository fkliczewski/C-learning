namespace NaukaKlas;

public class ExcelFile : IFile/*, ISomeOtherInterface*/
{
    public string FileName { get; set; }
    public int Size { get; set; }
    public DateTime CreatedOn { get; set; }
    
    public void Compress()
    {
        Console.WriteLine("Compressing ExcelFile");
    }

    public void GenerateReport()
    {
        /*string prop = ProtectedProp;*/
        Console.WriteLine($"{FileName} report..");
    }
}