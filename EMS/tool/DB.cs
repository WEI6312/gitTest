using Dos.ORM;

namespace EMS.tool
{
    public class DB
    {
        public static readonly DbSession Context = new DbSession("DosConn");
    }
}