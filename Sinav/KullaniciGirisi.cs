using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav
{
    public class KullaniciGirisi
    {
        DataBase db = new DataBase();
        public Boolean ogrenciGiris(string username,string password)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            db.connectDataBase();
            cmd = new SqlCommand();
            cmd.Connection = db.connectDataBase();
            cmd.Connection.Open();
            cmd.CommandText = "SELECT * FROM tblKullanici where username='" + username + "' AND password='" + password + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (Convert.ToInt32(dr[3]) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            else
            {
                return false;
            }    
        }
        public Boolean ogretmenGiris(string username, string password)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            db.connectDataBase();
            cmd = new SqlCommand();
            cmd.Connection = db.connectDataBase();
            cmd.Connection.Open();
            cmd.CommandText = "SELECT * FROM tblKullanici where username='" + username + "' AND password='" + password + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (Convert.ToInt32(dr[3]) == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }


    }
}
