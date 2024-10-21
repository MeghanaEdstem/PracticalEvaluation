namespace PracticalEvaluation;

public class FileManagementSystem
    {
        string filePath = @"D:\Downloads\Test.txt";
        public void fileCreation(){
            try
            {
                using (var Fs = File.Create(filePath)) ;
            }
            catch (Exception e)
            {
                Console.WriteLine("file cannot be created" + e.Message);
            }
 
 
        }

 
        public void writeToAFile(string filePath)
        {
            Console.WriteLine("write text to the file: ");
            try
            {
                var content = Console.ReadLine();
                File.WriteAllText(filePath, content);
 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
 
            }
        }
            public void appendToAText(string filePath)
            {
                Console.WriteLine("write text to append to the file: ");
                try
                {
                    string appendText = Console.ReadLine();
                    File.AppendAllText(filePath, appendText);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
 
        public void readFromAFile(string filePath)
        {
            try
            {
                string read = File.ReadAllText(filePath);
                Console.WriteLine("the contents in the file are: " + read);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
 
        public void readAllLinesInFile(string filePath)
        {
            try
            {
                var numberOfLines = File.ReadAllLines(filePath).Length;
                Console.WriteLine("the number of lines : " + numberOfLines);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
 
        public void numberOftextsInFile(string filePath)
        {
            try
            {
                string str = File.ReadAllText(filePath);
                Console.WriteLine("the number of text in file is :" + str.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
 
        public void numberOfCharactersInFile(string filePath)
        {
            string content = File.ReadAllText(filePath);
            int charCount = content.Length;
            Console.WriteLine("the character count is : " + charCount);
        }
 
    }