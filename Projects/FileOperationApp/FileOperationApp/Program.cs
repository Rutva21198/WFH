using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperationApp
{
    class Program
    {
        string filepath = @"C:\Users\Rutva\source\repos\FileOperationApp\Files\";
        static void Main(string[] args)
        {
            Program program = new Program();
            int choice;
            bool carryon = true;
            bool ContinueApp()
            {
                Console.WriteLine(" Do You Want To Continue ?? If Yes Press Y\nEnter Choice :");
                char c = Convert.ToChar(Console.ReadLine());
                if (c.Equals('y') || c.Equals('Y'))
                {
                    return true;
                }
                else
                    return false;
            }
            while (carryon)
            {
                Console.Clear();
                Console.WriteLine("1. Create File\n2. Write File\n3. Display File Content\n4. Rename File\n5. Concat Two File\n6. Copy File\n7. Delete File\n\nEnter Choice :");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        program.CreateFile();
                        carryon = ContinueApp();
                        break;
                    case 2:
                        program.WriteFile();
                        carryon = ContinueApp();
                        break;
                    case 3:
                        program.DisplayContent();
                        carryon = ContinueApp();
                        break;
                    case 4:
                        program.RenameFile();
                        carryon = ContinueApp();
                        break;
                    case 5:
                        program.ConcatFile();
                        carryon = ContinueApp();
                        break;
                    case 6:
                        program.CopyFile();
                        carryon = ContinueApp();
                        break;
                    case 7:
                        program.DeleteFile();
                        carryon = ContinueApp();
                        break;
                    default:
                        Console.WriteLine("Thank You For Visiting...");
                        break;
                }
            }
        }
        
        public void CreateFile()
        {
            Console.WriteLine("Enter FileName Without Any Extension :");
            string fileName = Console.ReadLine();
            string Path = filepath + fileName+".txt";
            if (!File.Exists(Path))
            {
                var file = File.CreateText(Path);
                Console.WriteLine("File successfully Created");
                file.Close();
            }
            else
            {
                Console.WriteLine("Already Exits");
            }

        }
        public void WriteFile()
        {
            Console.WriteLine("Enter FileName Without Any Extension :");
            string fileName = Console.ReadLine();
            string Path = filepath + fileName + ".txt";
            if (File.Exists(Path))
            {
                Console.WriteLine("Write Content Here....");
                var content = Console.ReadLine();
                StreamWriter sw = new StreamWriter(File.Open(Path, FileMode.Append));
                sw.Write(content);
                sw.Close();
                Console.WriteLine("Successfully Added Content");
            }

        }
        public void DisplayContent()
        {
            Console.WriteLine("Enter FileName Without Any Extension :");
            string fileName = Console.ReadLine();
            string Path = filepath + fileName + ".txt";
            if (File.Exists(Path))
            {
                StreamReader sr = new StreamReader(Path);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                sr.Close();
            }
        }

        public void RenameFile()
        {
            Console.WriteLine("Enter FileName Without Any Extension :");
            string fileName = Console.ReadLine();
            string Path = filepath + fileName + ".txt";

            FileInfo fileInfo = new System.IO.FileInfo(Path);

            if (fileInfo.Exists)
            {
                Console.WriteLine("Enter New FileName Without Any Extension :");
                string newName = Console.ReadLine();
                string newPath = filepath + newName + ".txt";
                fileInfo.MoveTo(newPath);
                Console.WriteLine("File Renamed Successfully");
            }
            else
            {
                Console.WriteLine("File Not exist");
            }
        }
        public void ConcatFile()
        {
            
            Console.WriteLine("Enter File1 Name Without Any Extension :");
            string firstfileName = Console.ReadLine();
            string FirstFilePath = filepath + firstfileName + ".txt";
            Console.WriteLine("Enter File2 Name Without Any Extension :");
            string secondfileName = Console.ReadLine();
            Console.WriteLine("Enter Concate New File Name Without Any Extension :");
            string concateFile = Console.ReadLine();
            var f=File.CreateText(filepath + concateFile + ".txt");
            f.Close();
            string secondFilePath = filepath + secondfileName + ".txt";
            string newFilePath = filepath + concateFile + ".txt";
            if (File.Exists(FirstFilePath) && File.Exists(secondFilePath))
            {
                StreamReader sr1 = new StreamReader(File.Open(FirstFilePath, FileMode.Open));
                StreamReader sr2 = new StreamReader(File.Open(secondFilePath, FileMode.Open));
                StreamWriter sw = new StreamWriter(File.Open(newFilePath, FileMode.Append));
                string line;
                while ((line = sr1.ReadLine()) != null)
                {
                    sw.Write(line);
                }
                while ((line = sr2.ReadLine()) != null)
                {
                    sw.Write(line);
                }
                sr1.Close();
                sr2.Close();
                sw.Close();
                Console.WriteLine(" Concate Successfully Done");
            }
            else
            {
                Console.WriteLine("File Not Found");
            }

        }

        public void CopyFile()
        {
            Console.WriteLine("Enter FileName Without Any Extension :");
            string fileName = Console.ReadLine();
            string Path = filepath + fileName + ".txt";
            if (File.Exists(Path))
            {
                Console.WriteLine("Enter Filename where you want to copy");
                string filecopy = Console.ReadLine();
                string newPath = filepath + filecopy + ".txt";
                if (File.Exists(newPath))
                {
                    File.Delete(newPath);

                }
                File.Copy(Path, newPath);

                Console.WriteLine("Successfully copied...");
            }
        }
        public void DeleteFile()
        {
           Console.WriteLine("Enter FileName Without Any Extension :");
            string fileName = Console.ReadLine();
            string Path = filepath + fileName + ".txt";
            if (File.Exists(Path))
            {
                File.Delete(Path);
            }
        }
    }
}
