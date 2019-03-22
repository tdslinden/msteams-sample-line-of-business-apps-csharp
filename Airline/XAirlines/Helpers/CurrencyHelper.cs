﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace Airlines.XAirlines.Helpers
{
    public class CurrencyHelper
    {
        public CurrencyInfo GetCurrencyInfo()
        {
           
            string apiKey = "29d0ff0f89f41d3bdd19f6c25ea4b1c4";

            string url = string.Format("http://www.apilayer.net/api/live?access_key=29d0ff0f89f41d3bdd19f6c25ea4b1c4");

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                CurrencyInfo curr = (new JavaScriptSerializer().Deserialize<CurrencyInfo>(json));
                return curr;
            }
        }
    }
    public class CurrencyInfo
    {
        public bool success { get; set; }
        public string terms { get; set; }
        public string privacy { get; set; }
        public int timestamp { get; set; }
        public string source { get; set; }
        //public Quotes quotes { get; set; }
        public Dictionary<string, double> quotes { get; set; }
    }

    public class Quotes
    {
        public float USDAED { get; set; }
        public float USDAFN { get; set; }
        public float USDALL { get; set; }
        public float USDAMD { get; set; }
        public float USDANG { get; set; }
        public float USDAOA { get; set; }
        public float USDARS { get; set; }
        public float USDAUD { get; set; }
        public float USDAWG { get; set; }
        public float USDAZN { get; set; }
        public float USDBAM { get; set; }
        public float USDBBD { get; set; }
        public float USDBDT { get; set; }
        public float USDBGN { get; set; }
        public float USDBHD { get; set; }
        public float USDBIF { get; set; }
        public float USDBMD { get; set; }
        public float USDBND { get; set; }
        public float USDBOB { get; set; }
        public float USDBRL { get; set; }
        public float USDBSD { get; set; }
        public float USDBTC { get; set; }
        public float USDBTN { get; set; }
        public float USDBWP { get; set; }
        public float USDBYN { get; set; }
        public int USDBYR { get; set; }
        public float USDBZD { get; set; }
        public float USDCAD { get; set; }
        public float USDCDF { get; set; }
        public float USDCHF { get; set; }
        public float USDCLF { get; set; }
        public float USDCLP { get; set; }
        public float USDCNY { get; set; }
        public float USDCOP { get; set; }
        public float USDCRC { get; set; }
        public int USDCUC { get; set; }
        public float USDCUP { get; set; }
        public float USDCVE { get; set; }
        public float USDCZK { get; set; }
        public float USDDJF { get; set; }
        public float USDDKK { get; set; }
        public float USDDOP { get; set; }
        public float USDDZD { get; set; }
        public float USDEGP { get; set; }
        public float USDERN { get; set; }
        public float USDETB { get; set; }
        public float USDEUR { get; set; }
        public float USDFJD { get; set; }
        public float USDFKP { get; set; }
        public float USDGBP { get; set; }
        public float USDGEL { get; set; }
        public float USDGGP { get; set; }
        public float USDGHS { get; set; }
        public float USDGIP { get; set; }
        public float USDGMD { get; set; }
        public float USDGNF { get; set; }
        public float USDGTQ { get; set; }
        public float USDGYD { get; set; }
        public float USDHKD { get; set; }
        public float USDHNL { get; set; }
        public float USDHRK { get; set; }
        public float USDHTG { get; set; }
        public float USDHUF { get; set; }
        public float USDIDR { get; set; }
        public float USDILS { get; set; }
        public float USDIMP { get; set; }
        public float USDINR { get; set; }
        public float USDIQD { get; set; }
        public float USDIRR { get; set; }
        public float USDISK { get; set; }
        public float USDJEP { get; set; }
        public float USDJMD { get; set; }
        public float USDJOD { get; set; }
        public float USDJPY { get; set; }
        public float USDKES { get; set; }
        public float USDKGS { get; set; }
        public float USDKHR { get; set; }
        public float USDKMF { get; set; }
        public float USDKPW { get; set; }
        public float USDKRW { get; set; }
        public float USDKWD { get; set; }
        public float USDKYD { get; set; }
        public float USDKZT { get; set; }
        public float USDLAK { get; set; }
        public float USDLBP { get; set; }
        public float USDLKR { get; set; }
        public float USDLRD { get; set; }
        public float USDLSL { get; set; }
        public float USDLTL { get; set; }
        public float USDLVL { get; set; }
        public float USDLYD { get; set; }
        public float USDMAD { get; set; }
        public float USDMDL { get; set; }
        public float USDMGA { get; set; }
        public float USDMKD { get; set; }
        public float USDMMK { get; set; }
        public float USDMNT { get; set; }
        public float USDMOP { get; set; }
        public float USDMRO { get; set; }
        public float USDMUR { get; set; }
        public float USDMVR { get; set; }
        public float USDMWK { get; set; }
        public float USDMXN { get; set; }
        public float USDMYR { get; set; }
        public float USDMZN { get; set; }
        public float USDNAD { get; set; }
        public float USDNGN { get; set; }
        public float USDNIO { get; set; }
        public float USDNOK { get; set; }
        public float USDNPR { get; set; }
        public float USDNZD { get; set; }
        public float USDOMR { get; set; }
        public float USDPAB { get; set; }
        public float USDPEN { get; set; }
        public float USDPGK { get; set; }
        public float USDPHP { get; set; }
        public float USDPKR { get; set; }
        public float USDPLN { get; set; }
        public float USDPYG { get; set; }
        public float USDQAR { get; set; }
        public float USDRON { get; set; }
        public float USDRSD { get; set; }
        public float USDRUB { get; set; }
        public float USDRWF { get; set; }
        public float USDSAR { get; set; }
        public float USDSBD { get; set; }
        public float USDSCR { get; set; }
        public float USDSDG { get; set; }
        public float USDSEK { get; set; }
        public float USDSGD { get; set; }
        public float USDSHP { get; set; }
        public float USDSLL { get; set; }
        public float USDSOS { get; set; }
        public float USDSRD { get; set; }
        public float USDSTD { get; set; }
        public float USDSVC { get; set; }
        public float USDSYP { get; set; }
        public float USDSZL { get; set; }
        public float USDTHB { get; set; }
        public float USDTJS { get; set; }
        public float USDTMT { get; set; }
        public float USDTND { get; set; }
        public float USDTOP { get; set; }
        public float USDTRY { get; set; }
        public float USDTTD { get; set; }
        public float USDTWD { get; set; }
        public float USDTZS { get; set; }
        public float USDUAH { get; set; }
        public float USDUGX { get; set; }
        public int USDUSD { get; set; }
        public float USDUYU { get; set; }
        public float USDUZS { get; set; }
        public float USDVEF { get; set; }
        public float USDVND { get; set; }
        public float USDVUV { get; set; }
        public float USDWST { get; set; }
        public float USDXAF { get; set; }
        public float USDXAG { get; set; }
        public float USDXAU { get; set; }
        public float USDXCD { get; set; }
        public float USDXDR { get; set; }
        public float USDXOF { get; set; }
        public float USDXPF { get; set; }
        public float USDYER { get; set; }
        public float USDZAR { get; set; }
        public float USDZMK { get; set; }
        public float USDZMW { get; set; }
        public float USDZWL { get; set; }
    }

}