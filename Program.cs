using FileSystemLayer.BASE;
using FileSystemLayer.Folders;
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           string textName = "New Text File";

           string textContent = "This is the name of the file text";

           MusicFolder level = new MusicFolder();

           level.saveItem(textContent, new RequestData(textName));

           level.getItem(new RequestData(fname: textName));

           level.deleteItem(new RequestData(fname: textName));


        }
    }
}



