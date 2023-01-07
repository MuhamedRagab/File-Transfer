using File_Transfer.Models;
namespace File_Transfer.Services;
public class FileTransfareService
{
     Directories _directories =>  new ();
    public List<string?> GetDirectories() => _directories.GetDirectories();
    public List<string?> GetFiles(string _dir) => _directories.GetFiles(_dir);
}