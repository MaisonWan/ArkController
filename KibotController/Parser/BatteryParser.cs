using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace KibotController.Parser
{
    /// <summary>
    /// 识别解析电池详细信息
    /// </summary>
    public class BatteryParser
    {
        private string info = null;
        private Hashtable dataMap = new Hashtable(14);

        /// <summary>
        /// 解析电池数据
        /// </summary>
        /// <param name="data">电池数据</param>
        /// <returns></returns>
        public static BatteryParser Parser(string data)
        {
            BatteryParser battery = new BatteryParser();
            parserInfo(battery.dataMap, data);
            return battery;
        }

        private static void parserInfo(Hashtable map, string data)
        {
            map.Clear();
            string[] lines = data.Split("\n".ToCharArray());
            foreach (string line in lines)
            {
                if (!line.StartsWith(" "))
                {
                    continue;
                }
                string[] items = line.Split(":".ToCharArray());
                if (items.Length == 2)
                {
                    string key = items[0].Trim();
                    string value = items[1].Trim();
                    map[key] = value;
                }
            }
        }

        private void getFormatInfo()
        {

        }

        /// <summary>
        /// 电池充电方式
        /// </summary>
        public string BatteryPlugged
        {
            get
            {
                if (dataMap["AC powered"].ToString() == "true")
                {
                    return "AC供电";
                }
                if (dataMap["USB powered"].ToString() == "true")
                {
                    return "USB供电";
                }
                if (dataMap["Wireless powered"].ToString() == "true")
                {
                    return "无线充电";
                }
                return "未插电";
            }
        }

        /// <summary>
        /// 电池当前状态
        /// </summary>
        public string BatteryStatus
        {
            get
            {
                string status = dataMap["status"].ToString();
                switch (status)
                {
                    case "2":
                        return "充电中";
                    case "3":
                        return "不能充电";
                    case "4":
                        return "未充电";
                    case "5":
                        return "充满电";
                    default:
                        return "未知";
                }
            }
        }

        /// <summary>
        /// 电池健康程度
        /// </summary>
        public string BatteryHealth
        {
            get
            {
                string health = dataMap["health"].ToString();
                switch (health)
                {
                    case "2":
                        return "很好";
                    case "3":
                        return "过热";
                    case "4":
                        return "已损坏";
                    case "5":
                        return "电压过大";
                    case "6":
                        return "未知错误";
                    default:
                        return "未知";
                }
            }
        }

        /// <summary>
        /// 电池温度，摄氏度
        /// </summary>
        public float BatteryTemperature
        {
            get
            {
                int temp = Convert.ToInt32(dataMap["temperature"].ToString());
                return temp * 0.1f;
            }
        }

        /// <summary>
        /// 电池电压，单位毫伏(mV)
        /// </summary>
        public int BatteryVoltage
        {
            get
            {
                int vol = Convert.ToInt32(dataMap["voltage"].ToString());
                return vol;
            }
        }

        /// <summary>
        /// 电池容量百分比最大1
        /// </summary>
        public float BatteryCapacityPresent
        {
            get
            {
                int level = Convert.ToInt32(dataMap["level"].ToString());
                int scale = Convert.ToInt32(dataMap["scale"].ToString());
                return level * 1.0f / scale;
            }
        }

        /// <summary>
        /// 电池类型
        /// </summary>
        public string BatteryType
        {
            get
            {
                return dataMap["technology"].ToString();
            }
        }

        /// <summary>
        /// 电池格式化信息
        /// </summary>
        public string BatteryFormatInfo
        {
            get 
            {
                if (dataMap.Count == 0)
                {
                    return null;
                }
                StringBuilder builder = new StringBuilder("电池信息\n");
                builder.Append("电源类型：").Append(BatteryPlugged).Append("\n");
                builder.Append("充电状态：").Append(BatteryStatus).Append("\n");
                builder.Append("电池电量：").AppendFormat("{0}%\n", BatteryCapacityPresent * 100);
                builder.Append("当前电压：").AppendFormat("{0}mV\n", BatteryVoltage);
                builder.Append("电池情况：").Append(BatteryHealth).Append("\n");
                builder.Append("电池温度：").AppendFormat("{0}℃", BatteryTemperature).Append("\n");
                builder.Append("电池类型：").Append(BatteryType).Append("\n");
                info = builder.ToString();
                return info;
            }
        }
    }
}
