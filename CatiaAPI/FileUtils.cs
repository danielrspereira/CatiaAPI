using System;
using System.IO;
using System.Windows.Forms;

namespace CatiaApi
{
    internal class FileUtils
    {
        public static bool FileDirectoryExists(string filePath)
        {
            try
            {
                string directoryPath = Path.GetDirectoryName(filePath);
                if (Directory.Exists(directoryPath))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool IsFileOpened(string filePath)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    return false;
                }
            }
            catch (IOException ex)
            {
                if (IsFileLocked(ex))
                    return true;
                else
                {
                    MessageBox.Show("Failed to connect to file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }                   
            }
        }

        static bool IsFileLocked(IOException ex)
        {
            int errorCode = ex.HResult & 0xFFFF;
            return errorCode == 32 || errorCode == 33; // 32 = ERROR_SHARING_VIOLATION, 33 = ERROR_LOCK_VIOLATION
        }

        public static string SelectSavingPath(string fileExtension)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = $"{fileExtension} (*.{fileExtension})|*.{fileExtension}|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save File As";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return saveFileDialog.FileName;
                }
                return string.Empty;
            }
        }
    }
}
