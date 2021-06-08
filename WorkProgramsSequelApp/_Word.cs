using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace WorkProgramsSequelApp
{
    static class _Word
    {
        public static string path;

        private static DocX template = DocX.Load(Environment.CurrentDirectory + @"\..\..\Documents\Word\WordTemplate.docx");

        public static void GenerateSubject(WorkProgram wp)
        {
            foreach (var item in wp.bookmarks)
            {
                if(!string.IsNullOrEmpty(item.Value))
                    template.Bookmarks[item.Key].SetText(item.Value);
            }
            template.SaveAs(path);           
        }

    }
}
