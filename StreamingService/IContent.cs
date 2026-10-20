using System;
using System.Collections.Generic;
using System.Text;

namespace StreamingService
{
    public interface IContent
    {
        string GetTitle();
        int GetLength();
    }
}
