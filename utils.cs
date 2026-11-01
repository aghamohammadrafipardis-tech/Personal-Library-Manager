using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace uni_project
{
    public static class Utils
    {
        public static string ComputeMD5(string input)
        {
            MD5 md5 = MD5.Create();

            try
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();

                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while hashing: " + ex.Message);
                return null;
            }
            finally
            {
                md5.Dispose();
            }
        }
    }
}
