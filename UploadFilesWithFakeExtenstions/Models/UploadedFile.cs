namespace UploadFilesWithFakeExtenstions.Models;

public class UploadedFile
{
    public int Id { get; set; }
    public string? FileName { get; set; }
    public string? StoredFileName { get; set; }
    public string? ContentType { get; set; }
}