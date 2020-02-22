using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _1._4_SettingAccessControlForADirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\miau");
            directoryInfo.Create();
            DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();
            directorySecurity.AddAccessRule(
            new FileSystemAccessRule("todos",
            FileSystemRights.ReadAndExecute,
            AccessControlType.Allow));
            directoryInfo.SetAccessControl(directorySecurity);
        }
    }
}
