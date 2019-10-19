using LocalDB.Android;
using LocalDB.Data;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;


[assembly: Dependency(typeof(SQLite_Android))]
namespace LocalDB.Android
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android()
        {
        }
        public SQLiteConnection GetConnection()
        {
            var arquivodb = "ifspdb.db3";
            string caminho =
            System.Environment.GetFolderPath
            (System.Environment.SpecialFolder.Personal);
            var local = Path.Combine(caminho, arquivodb);
            var conexao = new SQLiteConnection(local);
            return conexao;
        }

       
    }
}
