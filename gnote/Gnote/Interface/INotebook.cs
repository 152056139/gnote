using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gnote.Interface
{
    interface INotebook
    {

        /// <summary>
        /// 创建笔记本
        /// </summary>
        /// <param name="notebookName">笔记本名</param>
        void createNotebook(string notebookName);

    }
}
