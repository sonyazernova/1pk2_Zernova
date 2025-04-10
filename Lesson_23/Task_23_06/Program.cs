using System;
using System.IO;

namespace FileSystemOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.
            Console.WriteLine("=== ���������� � ������ ===");
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in allDrives)
            {
                Console.WriteLine($"����: {drive.Name}");
                Console.WriteLine($"  ���: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"  �������� �������: {drive.DriveFormat}");
                    Console.WriteLine($"  �������� �����: {drive.AvailableFreeSpace / (1024 * 1024 * 1024)} GB �� {drive.TotalSize / (1024 * 1024 * 1024)} GB");
                }
                Console.WriteLine();
            }

            // 2.
            Console.WriteLine("\n=== ���������� �������� C:\\Users ===");
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
                Console.WriteLine($"������� {usersPath} �� ����������");
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
                    Console.WriteLine($"\n������� �����: {workPath}");
                }

                if (!Directory.Exists(tempPath))
                {
                    Directory.CreateDirectory(tempPath);
                    Console.WriteLine($"������� ��������� �����: {tempPath}");
                }

                // a)
                Console.WriteLine("\n=== ���������� � ������� �������� ===");
                DirectoryInfo workDir = new DirectoryInfo(workPath);
                Console.WriteLine($"���: {workDir.Name}");
                Console.WriteLine($"������ ����: {workDir.FullName}");
                Console.WriteLine($"������������ �������: {workDir.Parent}");
                Console.WriteLine($"���� ��������: {workDir.CreationTime}");
                Console.WriteLine($"��������: {workDir.Attributes}");

                // b)
                Console.WriteLine("\n=== ���������� �������� work ===");
                string[] workContents = Directory.GetFileSystemEntries(workPath);
                foreach (string item in workContents)
                {
                    Console.WriteLine(Path.GetFileName(item));
                }

                // c)
                Console.WriteLine("\n=== ����������� �������� ===");
                if (Directory.Exists(tempPath) && !Directory.Exists(newTempPath))
                {
                    Directory.Move(tempPath, newTempPath);
                    Console.WriteLine($"������� {tempPath} ������� ��������� � {newTempPath}");
                }
                else
                {
                    Console.WriteLine($"�� ������� ����������� �������. ��������� ������������� {tempPath} � ���������� {newTempPath}");
                }

                // 5.
                if (Directory.Exists(tempPath))
                {
                    Directory.Delete(tempPath);
                    Console.WriteLine($"\n������� {tempPath} ������� ������");
                }
                else
                {
                    Console.WriteLine($"\n������� {tempPath} �� ���������� (��� ��������� ��� ������)");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n������: {ex.Message}");
            }

            Console.WriteLine("\n������� ����� ������� ��� ������...");
            Console.ReadKey();
        }
    }
}