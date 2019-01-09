using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using Validation.Public;

namespace Validation
{
    namespace Windows
    {
        public static class WindowsValidation
        {
            public enum Extension
            {
                Jpg, Jpeg, Png, Tiff, Bmp, Rar, Zip, Mp3, Docx, Xml, Xlsx, Mdb, Accdb, Exe, Bat, Dll, Html, Css, Js, Php, Wave, Json, Java, Less
            }
            public static bool CheckExtention(this string path, Extension ex)
            {
                string input = Path.GetExtension(path);
                if (input != null && input.Contains(ex.ToString().ToLower()))
                {
                    return true;
                }
                return false;
            }
            public static bool CheckAttributeFile(this string path, FileAttributes fileAttribute)
            {
                if (path.CheckEmpty()) return false;

                try
                {
                    FileInfo f = new FileInfo(path);
                    if (f.Attributes == fileAttribute)
                    {
                        return true;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
                return false;
            }
            public static bool CheckExistDrive(this string driveName)
            {
                if (driveName.CheckEmpty()) return false;
                try
                {
                    foreach (DriveInfo item in DriveInfo.GetDrives())
                    {
                        if (item.Name.ToLower() == driveName.ToLower() && item.IsReady)
                        {
                            return true;
                        }
                    }
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
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
            public static bool CheckInstalledFont(this string fontName)
            {
                if (fontName.CheckEmpty()) return false;
                float fontSize = 12;

                using (Font fontTester = new Font(
                    fontName,
                    fontSize,
                    FontStyle.Regular,
                    GraphicsUnit.Pixel))
                {
                    if (fontTester.Name.ToLower() == fontName.ToLower())
                    {
                        return true;
                    }
                    return false;
                }
            }


        }

    }

}
