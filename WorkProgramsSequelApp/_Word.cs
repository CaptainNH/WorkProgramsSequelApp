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
            template.Bookmarks["Direction"].SetText(wp.Direction);
            template.Bookmarks["Direction2"].SetText(wp.Direction);
            template.Bookmarks["Direction3"].SetText(wp.Direction);
            template.Bookmarks["Discipline"].SetText(wp.SubjectName);
            template.Bookmarks["Discipline2"].SetText(wp.SubjectName);
            foreach (var item in wp.bookmarks)
            {
                template.Bookmarks[item.Key].SetText(item.Value);
            }
            template.SaveAs(path);           
        }

    }
}
