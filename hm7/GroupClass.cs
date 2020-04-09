using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm7
{
	class Group
	{
		public List<Student> group = new List<Student>();
		public void CalculateGroupAverage()
		{
			double a = 0;
			for (int i = 0; i < group.Count; i++)
			a +=group[i].CalculateGradeAverage(0)/group.Count;
			Console.WriteLine($"Arithmetic mean of group is {a.ToString("#.##")}");
		}
		public void ShowStudentsGrades()
		{
			for (int i=0; i<group.Count; i++)
			{
				group[i].DisplayRatings();
			}
		}
		public void ShowGradesAverageOfStudents()
		{
			for (int i = 0; i < group.Count; i++)
			{
				group[i].CalculateGradeAverage();
			}

		}
	}
}
