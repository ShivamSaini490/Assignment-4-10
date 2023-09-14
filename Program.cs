using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Flags]
enum FilePermission
{
    None = 0,    
    Read = 1,      
    Write = 2,    
    Execute = 4    
}

class Program
{
    static void Main()
    {
        FilePermission readPermission = FilePermission.Read;
        FilePermission writePermission = FilePermission.Write;
        FilePermission executePermission = FilePermission.Execute;

        FilePermission userPermissions = readPermission | writePermission;

        bool canRead = (userPermissions & FilePermission.Read) == FilePermission.Read;
        bool canWrite = (userPermissions & FilePermission.Write) == FilePermission.Write;
        bool canExecute = (userPermissions & FilePermission.Execute) == FilePermission.Execute;

        Console.WriteLine($"User Permissions: {userPermissions}");
        Console.WriteLine($"Can Read: {canRead}");
        Console.WriteLine($"Can Write: {canWrite}");
        Console.WriteLine($"Can Execute: {canExecute}");

        Console.ReadLine();
    }
}
