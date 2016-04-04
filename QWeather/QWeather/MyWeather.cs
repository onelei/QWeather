using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QWeather
{
    public class MyWeather
    {
        public class basic
        {
            public string city;
            public string cnty;
            public int id;
            public float lat;
            public float lon;
        }
        /// <summary>
        /// 城市名;
        /// </summary>
        public string mCityName;
        /// <summary>
        /// 国家;
        /// </summary>
        public string mCountry;
        /// <summary>
        /// 城市维度;
        /// </summary>
        public string mLat;
        /// <summary>
        /// 城市经度;
        /// </summary>
        public string mLon;
        /// <summary>
        /// 当地时间;
        /// </summary>
        public string mLocalTime;
        /// <summary>
        /// UTC时间;
        /// </summary>
        public string mUTCTime;
        /// <summary>
        /// 天气状况;
        /// </summary>
        public string mText;
        /// <summary>
        /// 体感温度;
        /// </summary>
        public string mFL;
        /// <summary>
        /// 温度;
        /// </summary>
        public string tmp;
    }
}
