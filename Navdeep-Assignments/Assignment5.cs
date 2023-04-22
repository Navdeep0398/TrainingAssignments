using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;// to add collections to the application

namespace Navdeep_Assignments
{
    class Assignment5
    {
        static void addFunc(ArrayList al)
        {
            Console.WriteLine("Please enter the name of the movie to add");
            al.Add(Console.ReadLine());
        }
        static void deleteFunc(ArrayList al)
        {
            Console.WriteLine("Please enter the name of the movie to remove");
            string movie = Console.ReadLine();
            al.Remove(movie);
            Console.WriteLine("The movie is successfully removed");
        }
        static void searchFunc(ArrayList al)
        {
            Console.WriteLine("Enter the name of the movie to search");
            string movie = Console.ReadLine();
            if (al.Contains(movie) == true)
            {
                Console.WriteLine($"The movie {movie} is present in the list");
            }
            else
            {
                Console.WriteLine($"The movie {movie} is not present in the list");
            }
            
        }
        static void updateFunc(ArrayList al)
        {
            Console.WriteLine("Enter the movie to replace");
            string oldMovie = Console.ReadLine();
            Console.WriteLine("Enter the new name of the movie");
            string newMovie = Console.ReadLine();
            for (int i = 0; i < al.Count; i++)
            {
                if (string.Equals(al[i], oldMovie))
                {
                    Console.WriteLine($"{oldMovie}: {al[i]}");
                    al.Insert(i, newMovie);
                    al.Remove(oldMovie);
                    break;
                }
            }
        }
        static void operationFunc(ArrayList al, int choice)
        {
            switch (choice)
            {
                case 1:
                    addFunc(al);
                    break;
                case 2:
                    deleteFunc(al);
                    break;
                case 3:
                    searchFunc(al);
                    break;
                case 4:
                    updateFunc(al);
                    break;
                case 5:
                    printFunc(al);
                    break;
            }
        }
        public static void printFunc(ArrayList al)
        {
            Console.WriteLine("The list of the movie");
            foreach (var i in al)
            {
                Console.WriteLine(i);
            }

        }
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            bool flag = false;
            do {
                Console.WriteLine("Press 1 for Additing a movie");
                Console.WriteLine("Press 2 for deleting a movie");
                Console.WriteLine("Press 3 for finding a movie");
                Console.WriteLine("Press 4 for updating a movie");
                Console.WriteLine("Press 5 for list of movies");
                int choice = int.Parse(Console.ReadLine());
                operationFunc(al, choice);
                Console.WriteLine("Press true to continue and false to exit ");
                flag = bool.Parse(Console.ReadLine());
                Console.Clear();
            } while (flag != false);
        }
    }
}
