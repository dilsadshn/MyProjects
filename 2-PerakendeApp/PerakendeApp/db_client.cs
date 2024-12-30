using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerakendeApp
{
    public class db_client
    {
        private bool _disposed = false;

        #region MySQL Connection
        string _ipv4 = "127.0.0.1";
        ushort _port = 3306;
        string _db_name = "PerakendeSatisDb";
        string _user_name = "root";
        string _psw = "634234";
        string _charset = "utf8";
        bool _pooling = true;
        bool _respect_binary_flags = false;
        short _conn_timeout = 10;
        short _command_timeout = 60;

        MySqlConnection _cn;
        MySqlTransaction _tra = null;

        public MySqlConnection cn { get { return _cn; } }
        public string ipv4 { get { return _ipv4; } }
        public ushort port { get { return _port; } }
        public string db_name { get { return _db_name; } }
        public string user_name { get { return _user_name; } }
        public string psw { get { return _psw; } }
        public bool local_definer { get; set; } = false;

        public bool connect()
        {
            try
            {//functions return string=yes;
                _cn = new MySqlConnection(string.Format("SERVER={0}; PORT={1}; DATABASE={2}; USER ID={3}; PASSWORD={4}; CHARSET={5}; POOLING={6}; CONNECTION TIMEOUT={7}; ",
                _ipv4, _port, _db_name, _user_name, _psw, _charset, _pooling.ToString(), _conn_timeout));
                _cn.Open();
                return true;
            }
            catch (Exception ex)
            {
                /*core.SaveError(ex.Message, "db_client.cs", " connect()", DateTime.Now, _dev_id);*/
                return false;
            }
        }

        bool disconnect()
        {
            try { _cn.Close(); _cn.Dispose(); return true; }
            catch (Exception ex) { /*core.SaveError(ex.Message, "db_client.cs", " disconnect()", DateTime.Now, _dev_id);*/ return false; }
        }

        public bool tra_begin(string caller)
        {
            try
            {
                _tra = _cn.BeginTransaction(IsolationLevel.Serializable);
            }
            catch (Exception ex)
            {
                /*core.SaveError(ex.Message, "db_client.cs", " tra_begin(string caller) Caller:" + caller, DateTime.Now, _dev_id);*/
                return false;
            }

            return true;
        }

        public bool tra_commit(string caller)
        {
            try
            {
                if (_tra == null) return false;

                _tra.Commit();
            }
            catch (Exception ex)
            {
                /*core.SaveError(ex.Message, "db_client.cs", " tra_commit(string caller) Caller:" + caller, DateTime.Now, _dev_id);*/
                return false;
            }

            return true;
        }

        public bool tra_rollback(string caller)
        {
            try
            {
                if (_tra == null) return false;

                _tra.Rollback();
            }
            catch (Exception ex)
            {
                /* core.SaveError(ex.Message, "db_client.cs", " tra_rollback(string caller) Caller:" + caller, DateTime.Now, _dev_id);*/
                return false;
            }

            return true;
        }

        public bool run_query(string sql, string caller)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, _cn) { CommandTimeout = _command_timeout }) { cmd.ExecuteNonQuery(); }
            }
            catch (Exception ex)
            {
                /*core.SaveError(ex.Message + " sql:[" + sql + "]", "db_client.cs", " run_query(string sql, string caller) Caller:" + caller, DateTime.Now, _dev_id);*/
                return false;
            }

            return true;
        }

        public bool run_query(string sql, ref object response, string caller)
        {
            try
            {
                response = null;
                using (MySqlCommand cmd = new MySqlCommand(sql, _cn) { CommandTimeout = _command_timeout }) { response = cmd.ExecuteScalar(); }
            }
            catch (Exception ex)
            {
                /*core.SaveError(ex.Message + " sql:[" + sql + "]", "db_client.cs", " run_query(string sql, ref object response, string caller) Caller:" + caller, DateTime.Now, _dev_id);*/
                return false;
            }

            return true;
        }

        public bool run_query(DataTable dt, string sql, string caller)
        {
            try
            {
                using (MySqlDataAdapter adp = new MySqlDataAdapter(sql, _cn)) { dt.Rows.Clear(); dt.Columns.Clear(); adp.Fill(dt); }
            }
            catch (Exception ex)
            {
                /*core.SaveError(ex.Message + " sql:[" + sql + "]", "db_client.cs", " run_query(DataTable dt, string sql, string caller) Caller:" + caller, DateTime.Now, _dev_id);*/
                return false;
            }

            return true;
        }
        #endregion

        public db_client()
        {
            /*ll_db_utility.combined_api_config_t settings = core.import();

            _ipv4 = settings.serv_config.ipv4;
            _port = (ushort)settings.serv_config.port;
            _db_name = settings.db_config.db_name;
            _user_name = settings.db_config.user_name;
            _psw = settings.db_config.psw;
            _charset = settings.cn_config.charset;
            _pooling = settings.cn_config.pooling;
            _conn_timeout = settings.cn_config.conn_timeout;
            _command_timeout = settings.cn_config.command_timeout;

            if (!connect()) throw new Exception($"Şirket Kayıt Veritabanı Bağlantı Hatası({_db_name})");*/
        }

        ~db_client() { this.Dispose(false); }

        public void Dispose() { this.Dispose(true); GC.SuppressFinalize(this); }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    disconnect();
                }
            }
            _disposed = true;
        }
    }
}
