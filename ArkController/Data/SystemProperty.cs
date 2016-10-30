using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArkController.Data
{
    /// <summary>
    /// 系统属性
    /// </summary>
    public class SystemProperty
    {
        /// <summary>
        /// 解析系统属性
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static List<KeyValuePair<string, string>> Parser(string content)
        {
            string[] lines = content.Split("\n".ToCharArray());
            List<KeyValuePair<string, string>> result = new List<KeyValuePair<string, string>>(lines.Length);
            foreach (string line in lines)
            {
                string[] keyValue = line.Trim().Split(": ".ToCharArray());
                if (keyValue.Length == 3)
                {
                    string key = keyValue[0].Replace("[", "").Replace("]", "");
                    string value = keyValue[2].Replace("[", "").Replace("]", "");
                    value = Encoding.UTF8.GetString(Encoding.Default.GetBytes(value));
                    result.Add(new KeyValuePair<string, string>(key, value));
                }
            }
            return result;
        }
    }
}
