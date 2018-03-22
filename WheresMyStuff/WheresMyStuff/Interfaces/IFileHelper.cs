using System;
namespace wheresmystuff.Interfaces
{
    /// <summary>
    /// An interface for providing the File Helper framework
    /// </summary>
    public interface IFileHelper
    {
        string GetLocalPath(string filename);
    }
}
