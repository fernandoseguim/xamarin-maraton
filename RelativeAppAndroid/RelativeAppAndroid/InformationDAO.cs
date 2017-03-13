using System.Linq;
using Android.Content;
using Android.Widget;
using SQLite;

namespace RelativeAppAndroid
{
    public class InformationDAO
    {
        SQLiteConnection _conn = DBConnection.Connection();
        Context _context;

        public InformationDAO(Context context)
        {
            this._context = context;
        }

        public void Insert(Information information)
        {

            try
            {
                var info = this._conn.GetTableInfo("Information");
                if (!info.Any())
                    this._conn.CreateTable<Information>();

                this._conn.Insert(information);
                Toast.MakeText(this._context, "Salvando informações...", ToastLength.Short).Show();

            }
            catch (SQLiteException ex)
            {
                Toast.MakeText(this._context, ex.Message, ToastLength.Short).Show();
            }
            finally
            {
                try
                {
                    _conn.Close();
                }
                catch (SQLiteException ex)
                {
                    Toast.MakeText(this._context, ex.Message, ToastLength.Short).Show();
                }
            }

        }

        public TableQuery<Information> GetAll()
        {
            var informations = from s in this._conn.Table<Information>() select s;

            return informations;
        } 

    }
}