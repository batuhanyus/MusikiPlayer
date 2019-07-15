using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Url { get; set; }
    public string ID { get; set; }
    public System.Drawing.Image Thumbnail { get; set; }
    public bool isDownloading { get; set; }
    public bool isInLibrary { get; set; }
}