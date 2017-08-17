using System;
using System.Collections.Generic;

namespace MenuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menuItems = {
                "List of all videos",
                "Add video",
                "Delete video",
                "Edit video",
                "Exit"
            };

            List<Video> videoList = new List<Video>(); 
            var selection = Menu(menuItems);

            while (selection != 5)
            {
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("\nShowing list of all videos...\n");
                        listVideos(videoList);
                        break;
                    case 2:
                        Console.WriteLine("\nAdd videos...\n");
                        Console.WriteLine("Please type the Name of the video\n");
                        string name = Console.ReadLine(); 
                        addVideo(name, videoList);
                        
                        break;
                    case 3:
                        Console.WriteLine("Delete video...");
                        break;
                    case 4:
                        Console.WriteLine("Edit video...");
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        break;
                }
                Console.WriteLine("Press enter to select another option");
                Console.ReadLine();
                
                selection = Menu(menuItems);
            }


            Console.ReadLine();
        }


        private static int Menu(string[] menuItems)
        {
            Console.Clear();
            Console.WriteLine("Select what you want to do: \n");
            Console.WriteLine("---------------------------\n");

            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($"{i + 1} : {menuItems[i]} \n");
            }

            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection) || selection < 1 || selection > 5)
            {
                Console.WriteLine("You need to select a number from 1-5");
            }
            Console.WriteLine("\nSelection : " + selection);
            return selection; 
        }

        private static List<Video> addVideo(string name, List<Video> videoList)
        {
            
            Video video = new Video();
            video.name = name;
            for (int i = 0; i < videoList.Count; i++)
            {
                if (videoList[i].id.Equals(null))
                {
                    videoList[i].id = i;
                    Console.WriteLine("{0} is the id of the video", i);
                }
            }

            videoList.Add(video);
            Console.WriteLine("\n{0} was added to videos : \n ", name);
            
            return videoList;
        }
        
        private static void listVideos(List<Video> vNames)
        {
            foreach (var vName in vNames)
            {
                Console.WriteLine(vName.name + "\n");
            }
        }

        
    }
}