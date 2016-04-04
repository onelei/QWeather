using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace QWeather
{
    public partial class Form1 : Form
    {
        public static string APIKEY = "cddb3268af79ff34900e3556166c70fc";
        public Form1()
        {
            InitializeComponent();

            resultLabel.Text = "";
        }
        string url = "http://apis.baidu.com/heweather/weather/free";
       // string param = "city=beijing";
        /// <summary>
        /// 发送HTTP请求
        /// </summary>
        /// <param name="url">请求的URL</param>
        /// <param name="param">请求的参数</param>
        /// <returns>请求结果</returns>
        public static string request(string url, string param)
        {
            string strURL = url + '?' + param;
            System.Net.HttpWebRequest request;
            request = (System.Net.HttpWebRequest)WebRequest.Create(strURL);
            request.Method = "GET";
            // 添加header;
            request.Headers.Add("apikey", APIKEY);
            System.Net.HttpWebResponse response;
            response = (System.Net.HttpWebResponse)request.GetResponse();
            System.IO.Stream s;
            s = response.GetResponseStream();
            string StrDate = "";
            string strValue = "";
            StreamReader Reader = new StreamReader(s, Encoding.UTF8);
            while ((StrDate = Reader.ReadLine()) != null)
            {
                strValue += StrDate + "\r\n";
            }
            return strValue;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            var cityName = this.cityNameTextBox.Text.Trim();
            if(string.IsNullOrEmpty(cityName))
            {
                MessageBox.Show("城市名不能为空.");
                return;
            }
            string result = request(url, "city=" + cityName);//cityName;

         
            result = result.Replace("HeWeather data service 3.0", "weather");
            var jobject = JObject.Parse(result);
            JToken weatherInfo = jobject["weather"];
            MyWeather myWeather = new MyWeather();
          //  var _cityName = weatherInfo["basic"].ToString();
           foreach(var o in weatherInfo)
           {
              // basic;
              var basic =  (JObject)o["basic"];
              myWeather.mCityName = basic["city"].ToString();
              myWeather.mCountry = basic["cnty"].ToString();
              myWeather.mLocalTime = basic["update"]["loc"].ToString();
               myWeather.mUTCTime = basic["update"]["utc"].ToString();
              // now;
              var now = (JObject)o["now"];
              var mText = now["cond"]["txt"];
              myWeather.mText = mText.ToString();
                 myWeather.tmp = now["tmp"].ToString();
               // suggestin;
               var suggestion = (JObject)o[""]; 
           }
           this.resultLabel.Text = 
               "更新时间:当地时间 "+myWeather.mLocalTime+"\n"
              + "天气: "+myWeather.mText+"\n" 
               + "温度: "+myWeather.tmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
         
    }
}
