using System;
using System.IO;

namespace FileSystemOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.
            Console.WriteLine("=== Информация о дисках ===");
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in allDrives)
            {
                Console.WriteLine($"Диск: {drive.Name}");
                Console.WriteLine($"  Тип: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"  Файловая система: {drive.DriveFormat}");
                    Console.WriteLine($"  Доступно места: {drive.AvailableFreeSpace / (1024 * 1024 * 1024)} GB из {drive.TotalSize / (1024 * 1024 * 1024)} GB");
                }
                Console.WriteLine();
            }

            // 2.
            Console.WriteLine("\n=== Содержимое каталога C:\\Users ===");
            string usersPath = @"C:\Users";
            if (Directory.Exists(usersPath))
            {
                string[] userDirs = Directory.GetDirectories(usersPath);
                foreach (string dir in userDirs)
                {
                    Console.WriteLine(Path.GetFileName(dir));
                }
            }
            else
            {
                Console.WriteLine($"Каталог {usersPath} не существует");
            }

            // 3.
            string workPath = @"D:\work";
            string tempPath = Path.Combine(workPath, "temp");
            string newTempPath = @"D:\work\newTemp";

            try
            {
                if (!Directory.Exists(workPath))
                {
                    Directory.CreateDirectory(workPath);
                    Console.WriteLine($"\nСоздана папка: {workPath}");
                }

                if (!Directory.Exists(tempPath))
                {
                    Directory.CreateDirectory(tempPath);
                    Console.WriteLine($"Создана временная папка: {tempPath}");
                }

                // a)
                Console.WriteLine("\n=== Информация о текущем каталоге ===");
                DirectoryInfo workDir = new DirectoryInfo(workPath);
                Console.WriteLine($"Имя: {workDir.Name}");
                Console.WriteLine($"Полный путь: {workDir.FullName}");
                Console.WriteLine($"Родительский каталог: {workDir.Parent}");
                Console.WriteLine($"Дата создания: {workDir.CreationTime}");
                Console.WriteLine($"Атрибуты: {workDir.Attributes}");

                // b)
                Console.WriteLine("\n=== Содержимое каталога work ===");
                string[] workContents = Directory.GetFileSystemEntries(workPath);
                foreach (string item in workContents)
                {
                    Console.WriteLine(Path.GetFileName(item));
                }

                // c)
                Console.WriteLine("\n=== Перемещение каталога ===");
                if (Directory.Exists(tempPath) && !Directory.Exists(newTempPath))
                {
                    Directory.Move(tempPath, newTempPath);
                    Console.WriteLine($"Каталог {tempPath} успешно перемещен в {newTempPath}");
                }
                else
                {
                    Console.WriteLine($"Не удалось переместить каталог. Проверьте существование {tempPath} и отсутствие {newTempPath}");
                }

                // 5.
                if (Directory.Exists(tempPath))
                {
                    Directory.Delete(tempPath);
                    Console.WriteLine($"\nКаталог {tempPath} успешно удален");
                }
                else
                {
                    Console.WriteLine($"\nКаталог {tempPath} не существует (уже перемещен или удален)");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nОшибка: {ex.Message}");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}