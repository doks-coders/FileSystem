using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemLayer.BASE
{
     class AbstractionLevel : BaseFileOperations
    {
        /* saveItem Summary:
        //     Saves the data as a file.
        //
        // Returns:
        //     A returns the success message
        */
        public string saveItem(string fileText, RequestData requestData)
        {
          return  this.writeFile(requestData,fileText);
        }

        /* getItem Summary:
        //     Gets the text from the selected file.
        //
        // Returns:
        //     The UTF-8 content of the file
        */
        public string getItem(RequestData requestData)
        {
            return this.readFile(requestData);
        }
        /* deleteItem Summary:
        //     Deletes the item.
        //
        // Returns:
        //     The UTF-8 content of the file
        */
        public string deleteItem(RequestData requestData)
        {
            return this.deleteFile(requestData);
        }
    }
}
