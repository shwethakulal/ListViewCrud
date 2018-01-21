using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewCrud
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);
    }
}
