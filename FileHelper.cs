using System;
using System.IO;

namespace WinFormsApp5
{
    public static class FileHelper
    {
        private static string folderPath = "Hasil";
        private static string filePath = "Hasil/hasil.txt";

        // Simpan nilai ke file
        public static void SaveResult(int score, int total)
        {
            // Buat folder kalau belum ada
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string isi =
                "Hasil Kuis\n" +
                "==========\n" +
                $"Skor: {score}/{total}\n" +
                $"Waktu: {DateTime.Now}\n";

            File.WriteAllText(filePath, isi);
        }

        // Ambil waktu terakhir file diubah
        public static DateTime GetLastEditTime()
        {
            if (File.Exists(filePath))
            {
                return File.GetLastWriteTime(filePath);
            }

            return DateTime.MinValue;
        }
    }
}

