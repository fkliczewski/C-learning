using System;

namespace GradeManagerZadanie
{
    using System.Collections.Generic;
    using System.Linq;
    
    public class GradeManagerZadanie
    {
    
        static void Main(string[] args)
        {
        }

        private Dictionary<string, List<int>> students = new Dictionary<string, List<int>>();
        
        public void AddGrade(string studentName, int grade)
        {
            // TODO: Uzupełnij implementację metody AddGrade, aby dodawała nową ocenę do listy ocen ucznia.
            
            if (!students.ContainsKey(studentName))
            {
                students[studentName] = new List<int>();
            }
            students[studentName].Add(grade);
        }
    
        public void RemoveGrade(string studentName, int grade)
        {
            // TODO: Uzupełnij implementację metody RemoveGrade, aby usuwała ocenę z listy ocen ucznia, jeśli istnieje.
            
            List<int> singleStudentGrades = null;
            if (students.TryGetValue(studentName, out singleStudentGrades))
            {
                students[studentName].Remove(grade);
            }
            else
            {
                Console.WriteLine("Brak studenta o imieniu " + studentName);
            }
        }
    
        public double CalculateAverageGrade(string studentName)
        {
            // TODO: Uzupełnij implementację metody CalculateAverageGrade, aby obliczała średnią ocen ucznia, jeśli istnieją oceny.
            if (students.ContainsKey(studentName) && students[studentName].Count > 0)
            {
                return students[studentName].Average();
            }
            return 0.0;
        }
    }
}