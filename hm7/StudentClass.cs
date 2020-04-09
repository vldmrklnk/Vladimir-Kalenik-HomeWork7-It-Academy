using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm7
{
	class Student
	{
		
		public string nameOfStudent;
		public string surnameOfStudent;
		List<int> gradesOfStudent = new List<int>();
		public void AddNewGrade(int grade)
		{
			gradesOfStudent.Add(grade);
			return;
		}
		public double CalculateGradeAverage(double i)
		{
			double gradeAverage = gradesOfStudent.Average();
			return gradeAverage;
		}
		public double CalculateGradeAverage()
		{
			double gradeAverage = gradesOfStudent.Average();
			Console.WriteLine($"Arithmetic mean of student {nameOfStudent} {surnameOfStudent} grades is {gradeAverage}");
			return gradeAverage;
		}
		public void DisplayRatings()
		{
			Console.WriteLine($"List of grades {nameOfStudent} {surnameOfStudent}");
			foreach (int grade in gradesOfStudent)
			{
				Console.WriteLine(grade);
				
			}
			return;
		}

	}
}
