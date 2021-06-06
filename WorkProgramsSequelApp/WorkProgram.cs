using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkProgramsSequelApp
{
    class WorkProgram
    {
        public string SubjectName;

        private int SubjectId;

        public string StudyProgram;

        public string Direction;

        public int Year;

        public Dictionary<string, string> bookmarks;

        public WorkProgram(string subject, string sp, string dir, int year)
        {
            this.SubjectName = subject;
            this.StudyProgram = sp;
            this.Direction = dir;
            this.Year = year;
            bookmarks = new Dictionary<string, string>();
            FillDic();
        }

        private void FillDic()
        {
            DataBaseWorker.OpenConnection();
            SubjectId = (int)DataBaseWorker.ExecuteQuery($"SELECT Id FROM Disciplines WHERE Name = N'{SubjectName}'")
                .Rows[0].ItemArray[0];
            bookmarks["AuditoryLessons"] = GetFromDB("AuditoryLessons");
            bookmarks["Competencies"] = GetFromDB("Competencies");
            bookmarks["CourseWork"] = GetFromDB("CourseWork");
            bookmarks["CreditUnits"] = GetFromDB("CreditUnits") + "зачётных единиц";
            bookmarks["Director"] = GetFromDB("Director");
            bookmarks["EdForm"] = GetFromDB("EdForm");
            bookmarks["Hours"] = GetFromDB("Hours");
            bookmarks["Hours2"] = GetFromDB("Hours");
            bookmarks["IndependentWork"] = GetFromDB("IndependentWorkBySemester");
            bookmarks["InteractiveWatch"] = GetFromDB("InteractiveWatch");
            bookmarks["LaboratoryExercises"] = GetFromDB("LaboratoryExercises");
            bookmarks["Lectures"] = GetFromDB("Lectures");
            bookmarks["Position"] = GetFromDB("Position");
            bookmarks["Profile"] = GetFromDB("Profile");
            bookmarks["Protocol"] = GetFromDB("Protocol").Split('№')[0].Trim() + ", протокол" + GetFromDB("Protocol").Split('№')[1].Trim();
            bookmarks["Standart"] = GetFromDB("Standart");
            bookmarks["Workshops"] = GetFromDB("Workshops");
            bookmarks["TypeOfLessons"] = GetFromDB("TypesOfLessons");
        }

        private string GetFromDB(string s)
        {
            return DataBaseWorker.ExecuteQuery($"SELECT DISTINCT {s} FROM Syllabuses WHERE PredmetId = '{SubjectId}'" +
                $"AND Year = '{Year}' AND Direction = N'{Direction}'").Rows[0].ItemArray[0].ToString();
        }
    }
}
