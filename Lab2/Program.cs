using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2
{
    class Program
    {
        /*1.	В папке С:\temp создайте папки К1 и К2.
2.	В папке К1:
1.	создайте файл t1.txt, в который запишите следующий текст :
Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов
2.	создайте файл t2.txt, в который запишите следующий текст:
Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс
3.	В папке К2 создайте файл t3.txt, в который перепишите вначале текст из файла t1.txt, а затем из t2.txt
4.	Выведите развернутую информацию о созданных файлах.
5.	Файл t2.txt перенесите в папку K2.
6.	Файл t1.txt скопируйте в папку K2.
7.	Папку K2 переименуйте в ALL, а папку K1 удалите.
8.	Вывести полную информацию о файлах папки All.
*/
        static void Main(string[] args)
        {
            CreateDir();
        }

        static void CreateDir()
        {
            string path = @"C:\temp";
            DirectoryInfo dir = new DirectoryInfo(path); // В папке С:\temp создайте папки К1 и К2.
            dir.Create();

            dir.CreateSubdirectory("K1"); // папки К1
            dir.CreateSubdirectory("K2"); // папки К2
            string path2 = @"C:\temp\K1\t1.txt";

            FileInfo file = new FileInfo(path2); // создайте файл t1.txt, в который запишите следующий текст :
            FileStream fs = file.Create(); // создание файла
            fs.Close(); // закрыли поток

            using (StreamWriter sw = new StreamWriter(path2)) // Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов
            {
                string Name = "Иванов Иван Иванович";
                sw.WriteLine(Name);
                string Age = "1965 года рождения";
                sw.WriteLine(Age);
                string city = "место жительства г. Саратов";
                sw.WriteLine(city);

            }



            string path3 = @"C:\temp\K1\t2.txt";
            FileInfo file2 = new FileInfo(path3);// создайте файл t2.txt, в который запишите следующий текст:
            FileStream fs2 = file2.Create(); // создание файла
            fs2.Close(); // закрыли поток

            using (StreamWriter sw = new StreamWriter(path3)) // Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс
            {
                string Name = "Петров Сергей Федорович";
                sw.WriteLine(Name);
                string Age = "1966 года рождения";
                sw.WriteLine(Age);
                string city = "место жительства г.Энгельс";
                sw.WriteLine(city);

            }

            string path4 = @"C:\temp\K2\t3.txt";
            FileInfo file3 = new FileInfo(path4);// В папке К2 создайте файл t3.txt, в который перепишите вначале текст из файла t1.txt, а затем из t2.txt
            FileStream fs3 = file3.Create(); // создание файла
            fs3.Close(); // закрыли поток

            StreamReader sr = new StreamReader(path); // coty 1
            string text1 = sr.ReadToEnd();
            sr.Close();

            StreamWriter sws = new StreamWriter(path3); // past 1
            sws.Write(text1);

            StreamReader sr2 = new StreamReader(path2); // coty 2
            string text2 = sr.ReadToEnd();
            sr.Close();

            sws.Write(text2); // past 2

        }
    }
}

