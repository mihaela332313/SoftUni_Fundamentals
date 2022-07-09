using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class SoftUniCoursePlanning
    {
        static void Main(string[] args)
        {
            List<string> lessonsAndExercisesList = Console.ReadLine().Split(", ").ToList();

            string instructions = "";

            while ((instructions = Console.ReadLine()) != "course start")
            {
                string[] command = instructions.Split(":");

                lessonsAndExercisesList = ChangesToBeMade(lessonsAndExercisesList, command);
            }
            for (int currentIndex = 0; currentIndex < lessonsAndExercisesList.Count; currentIndex++)
            {
                Console.WriteLine($"{currentIndex + 1}.{lessonsAndExercisesList[currentIndex]}");
            }
        }

        private static List<string> ChangesToBeMade(List<string> lessonsAndExercisesList, string[] command)
        {
            switch (command[0])
            {
                case "Add":
                    lessonsAndExercisesList = Add(lessonsAndExercisesList, command);
                    break;
                case "Insert":
                    lessonsAndExercisesList = Insert(lessonsAndExercisesList, command);
                    break;
                case "Remove":
                    lessonsAndExercisesList = Remove(lessonsAndExercisesList, command);
                    break;
                case "Swap":
                    lessonsAndExercisesList = Swap(lessonsAndExercisesList, command);
                    break;
                case "Exercise":
                    lessonsAndExercisesList = Exercise(lessonsAndExercisesList, command); break;
                default:
                    break;
            }

            return lessonsAndExercisesList;
        }

        private static List<string> Add(List<string> lessonsAndExercisesList, string[] command)
        {
            if (!lessonsAndExercisesList.Contains(command[1]))
            {
                lessonsAndExercisesList.Add(command[1]);
            }
            return lessonsAndExercisesList;
        }
        private static List<string> Insert(List<string> lessonsAndExercisesList, string[] command)
        {
            int index = int.Parse(command[2]);

            if (index < 0 || index >= lessonsAndExercisesList.Count)
            {
                return lessonsAndExercisesList;
            }
            else if (!lessonsAndExercisesList.Contains(command[1]))
            {
                lessonsAndExercisesList.Insert(index, command[1]);
            }
            return lessonsAndExercisesList;
        }
        private static List<string> Remove(List<string> lessonsAndExercisesList, string[] command)
        {
            if (lessonsAndExercisesList.Contains(command[1]))
            {
                lessonsAndExercisesList.Remove(command[1]);
            }
            else if (lessonsAndExercisesList.Contains(command[1] + "-Exercise"))
            {
                lessonsAndExercisesList.Remove(command[1] + "-Exercise");
            }
            return lessonsAndExercisesList;
        }
        private static List<string> Swap(List<string> lessonsAndExercisesList, string[] command)
        {
            string lessonTitle1 = command[1];
            string lessonTitle2 = command[2];
            int index1 = lessonsAndExercisesList.IndexOf(lessonTitle1);
            int index2 = lessonsAndExercisesList.IndexOf(lessonTitle2);
            if (lessonsAndExercisesList.Contains(lessonTitle1) && lessonsAndExercisesList.Contains(lessonTitle2))
            {
                string temporalLessonTitle = lessonsAndExercisesList.ElementAt(index1);
                lessonsAndExercisesList[index1] = lessonsAndExercisesList[index2];
                lessonsAndExercisesList[index2] = temporalLessonTitle;
            }
            if (lessonsAndExercisesList.Contains(lessonTitle1 + "-Exercise") && lessonsAndExercisesList.Contains(lessonsAndExercisesList[index1]))
            {
                index1 = lessonsAndExercisesList.IndexOf(lessonTitle1);
                lessonsAndExercisesList.Remove(lessonTitle1 + "-Exercise");
                lessonsAndExercisesList.Insert(index1 + 1, lessonTitle1 + "-Exercise");
            }
            else if (lessonsAndExercisesList.Contains(lessonTitle2 + "-Exercise") && lessonsAndExercisesList.Contains(lessonsAndExercisesList[index2]))
            {
                index2 = lessonsAndExercisesList.IndexOf(lessonTitle2);
                lessonsAndExercisesList.Remove(lessonTitle2 + "-Exercise");
                lessonsAndExercisesList.Insert(index2 + 1, lessonTitle2 + "-Exercise");
            }

            return lessonsAndExercisesList;
        }

        private static List<string> Exercise(List<string> lessonsAndExercisesList, string[] command)
        {
            string lessonTitle = command[1];

            if (lessonsAndExercisesList.Contains(lessonTitle) && !lessonsAndExercisesList.Contains(lessonTitle + "-Exercise"))
            {
                int index = lessonsAndExercisesList.IndexOf(lessonTitle);
                lessonsAndExercisesList.Insert(index + 1, lessonTitle + "-Exercise");
            }
            else if (!lessonsAndExercisesList.Contains(lessonTitle))
            {
                lessonsAndExercisesList.Add(lessonTitle);
                lessonsAndExercisesList.Add(lessonTitle + "-Exercise");
            }

            return lessonsAndExercisesList;
        }

       

       




    }
}
