using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm7
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите имя студента");
			Student student1=new Student();
			student1.nameOfStudent = Console.ReadLine();
			Console.WriteLine("Введите фамилию студента");
			student1.surnameOfStudent = Console.ReadLine();
			
			while (true)
			{
				Console.WriteLine("Введите оценку студента(после ввода нажмите q)");
				string i = Console.ReadLine();
				if (i!="q")
				{
					int score = Convert.ToInt32(i);
					student1.AddNewGrade(score);
				}
				else
				{
					break;
				}
	
			}
			Console.WriteLine("Введите имя студента");
			Student student2 = new Student();
			student2.nameOfStudent = Console.ReadLine();
			Console.WriteLine("Введите фамилию студента");
			student2.surnameOfStudent = Console.ReadLine();

			while (true)
			{
				Console.WriteLine("Введите оценку студента(после ввода нажмите q)");
				string i = Console.ReadLine();
				if (i != "q")
				{
					int score = Convert.ToInt32(i);
					student2.AddNewGrade(score);
				}
				else
				{
					break;
				}

			}
			Console.WriteLine("Введите имя студента");
			Student student3 = new Student();
			student3.nameOfStudent = Console.ReadLine();
			Console.WriteLine("Введите фамилию студента");
			student3.surnameOfStudent = Console.ReadLine();

			while (true)
			{
				Console.WriteLine("Введите оценку студента(после ввода нажмите q)");
				string i = Console.ReadLine();
				if (i != "q")
				{
					int score = Convert.ToInt32(i);
					student3.AddNewGrade(score);
				}
				else
				{
					break;
				}

			}
			//student1.DisplayRatings();
			//student1.CalculateGradeAverage();
			//student2.DisplayRatings();
			//student2.CalculateGradeAverage();
			//student3.DisplayRatings();
			//student3.CalculateGradeAverage();
			Group bntu = new Group();
			bntu.group.Add(student1);
			bntu.group.Add(student2);
			bntu.group.Add(student3);
			bntu.ShowGradesAverageOfStudents();
			bntu.ShowStudentsGrades();
			bntu.CalculateGroupAverage();

			Console.ReadLine();
		}
		
	}
}
