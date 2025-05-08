using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Download_Manager.Service.Fetcher
{
    internal record ResponseFile(
        string Title,
        string ImageUrl,
        string FileUrl,
        int? Ram,
        int? Disk,
        float? Os,
        int Score
    );
}
