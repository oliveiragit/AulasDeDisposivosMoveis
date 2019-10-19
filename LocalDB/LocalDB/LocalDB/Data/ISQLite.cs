using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocalDB.Data
{
    interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
