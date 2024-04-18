namespace NaukaKlas;

public class PowePointFile : IFile
{
    public string FileName { get; set; }
    public int Size { get; set; }
    public DateTime CreatedOn { get; set; }
    
    public void Compress()
    {
        Console.WriteLine("Compressing Powerpoint");
    }
    public void Present()
    {
        Console.WriteLine($"{FileName} presenting..");
    }
}