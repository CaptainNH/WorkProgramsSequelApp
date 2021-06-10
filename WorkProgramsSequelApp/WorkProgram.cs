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
            bookmarks = FillDic();
        }

        private Dictionary<string, string> FillDic()
        {
            DataBaseWorker.OpenConnection();
            SubjectId = (int)DataBaseWorker.ExecuteQuery($"SELECT Id FROM Disciplines WHERE Name = N'{SubjectName}'")
                .Rows[0].ItemArray[0];
            var dic = new Dictionary<string, string>()
            {
                ["Direction"] = Direction,
                ["Direction2"] = Direction,
                ["Direction3"] = Direction,
                ["Discipline"] = SubjectName,
                ["Discipline2"] = SubjectName,
                ["AuditoryLessons"] = GetFromDB("AuditoryLessons"),
                ["Competencies"] = GetFromDB("Competencies"),
                ["CourseWork"] = GetFromDB("CourseWork"),
                ["CreditUnits"] = GetFromDB("CreditUnits") + " зачётных единиц",
                ["Director"] = GetFromDB("Director"),
                ["EdForm"] = GetFromDB("EdForm"),
                ["Hours"] = GetFromDB("Hours"),
                ["Hours2"] = GetFromDB("Hours"),
                ["IndependentWork"] = GetFromDB("IndependentWorkBySemester"),
                ["InteractiveWatch"] = GetFromDB("InteractiveWatch"),
                ["LaboratoryExercises"] = GetFromDB("LaboratoryExercises"),
                ["Lectures"] = GetFromDB("Lectures"),
                ["Position"] = GetFromDB("Position"),
                ["Profile"] = GetFromDB("Profile"),
                ["Protocol"] = GetFromDB("Protocol").Split('№')[0].Trim() + ", протокол № " + GetFromDB("Protocol").Split('№')[1].Trim(),
                ["Standart"] = GetFromDB("Standart"),
                ["Workshops"] = GetFromDB("Workshops"),
                ["TypeOfLessons"] = GetFromDB("TypesOfLessons"),
                ["SumIndependentWork"] = GetFromDB("SumIndependentWork"),
                ["StudyProgram"] = GetFromDB("StudyProgram")
            };
            return dic;
        }

        //private string GetSemesters()
        //{

        //}

        private string GetFromDB(string s)
        {
            return DataBaseWorker.ExecuteQuery($"SELECT DISTINCT {s} FROM Syllabuses WHERE PredmetId = '{SubjectId}'" +
                $"AND Year = '{Year}' AND Direction = N'{Direction}'").Rows[0].ItemArray[0].ToString();
        }
    }
}
