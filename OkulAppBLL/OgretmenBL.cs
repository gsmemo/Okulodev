using DAL;
using OkulApp.MODEL;
using System;
using System.Data.SqlClient;

namespace OkulAppBLL
{
    public class OgretmenBL
    {
        public bool OgretmenEkle(Ogretmen ogr)
        {

            try
            {

                SqlParameter[] p = {
                    new SqlParameter("@ad",ogr.ad),
                    new SqlParameter("@soyad",ogr.soyad),
                    new SqlParameter("@tc",ogr.tc)

                };
                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into tblogretmenler (ad,soyad,tc) values(@ad,@soyad,@tc) ", p) > 0;
            }

            catch (SqlException)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }
        }
    }
}
    

