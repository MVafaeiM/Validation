using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Validation
{
    namespace Windows
    {
        public static class WindowsValidation
        {
            public enum Extension
            {
                Jpg, Jpeg, Png, Tiff, Bmp, Rar, Zip, Mp3, Docx, Xml, Xlsx, Mdb, Accdb, Exe, Bat, Dll, Html, Css, Js, Php, Wave, Json, Java
            }
            public enum Software
            {
                Chrome, Iexplore, Devenv, Explorer, Egui, Calculator
            }
            public static bool CheckExtention(this string path, Extension ex)
            {
                string input = System.IO.Path.GetExtension(path);
                if (input != null && input.Contains(ex.ToString()))
                {
                    return true;
                }
                return false;
            }
            public static bool CheckExistsDirectory(this string path)
            {
                return Directory.Exists(path);
            }
            public static bool CheckExistsFile(this string path)
            {
                return File.Exists(path);
            }
            public static bool CheckAttributeFile(this string path, FileAttributes fileAttribute)
            {
                FileInfo f = new FileInfo(path);
                if (f.Attributes == fileAttribute)
                {
                    return true;
                }
                return false;
            }
            public static bool CheckLenghtFile(this string path, long lenghtKb)
            {
                FileInfo f = new FileInfo(path);
                if ((f.Length / 1024) < lenghtKb)
                {
                    return true;
                }
                return false;
            }
            public static bool CheckExistDrive(this String driveName)
            {
                foreach (DriveInfo item in DriveInfo.GetDrives())
                {
                    if (item.Name == driveName && item.IsReady)
                    {
                        return true;
                    }
                    else
                        return false;
                }
                return false;
            }
            public static bool CheckRunnigSoftware(Software s)
            {
                if (Process.GetProcessesByName(s.ToString()).Length > 0)
                {
                    return true;
                }
                return false;
            }
            public static bool CheckUsbConnect()
            {
                DriveInfo[] alldrive = DriveInfo.GetDrives();
                foreach (DriveInfo d in alldrive)
                {
                    if (d.DriveType == DriveType.Removable && d.IsReady)
                    {
                        return true;
                    }
                }
                return false;
            }
            public static bool CheckRunningInstance(this Process currentProccess, string addressExeFile)
            {
                Process[] processes = Process.GetProcessesByName(currentProccess.ProcessName);

                foreach (Process process in processes)
                {
                    if (process.Id != currentProccess.Id)
                    {
                        if (addressExeFile.
                                Replace("/", "\\") == currentProccess.MainModule.FileName)
                        {
                            return true;

                        }
                    }
                }
                return false;
            }

        }

    }

}
