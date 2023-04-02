using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kaspactl;
using Newtonsoft.Json;

namespace KaspactlDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void llGetInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetInfoCMD();
        }
        private void GetInfoCMD()
        {
            string strCmd = "F:\\Kas\\kas\\kaspactl /s 127.0.0.1 GetInfo";
            CmdRun(strCmd);
        }

        private void CmdRun(string strCmd)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();

            p.StandardInput.WriteLine(strCmd);// + "&exit");
            p.StandardInput.AutoFlush = true;
            p.StandardInput.Close();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            p.Close();

            txtInfo.Text = output;
            string strSplit1 = "{";
            string strSplit2 = "}";
            string strTemp = output;
            int nIndex1 = output.IndexOf(strSplit1);
            if (nIndex1 > 0)
            {
                strTemp = output.Substring(nIndex1);
                int nIndex2 = strTemp.LastIndexOf(strSplit2);
                if (nIndex2 > 0)
                {
                    strTemp = strTemp.Substring(0, nIndex2 + 1);
                }
            }
;
            string strJson = strTemp;// JsonHelper.ToJson(strTemp);
            bool bFlag = JsonHelper.IsJson(strJson);
            if (bFlag)
            {
                GetInfo dd = new kaspactl.GetInfo();

                GetInfo.Rootobject jo = (GetInfo.Rootobject)JsonConvert.DeserializeObject<GetInfo.Rootobject>(strJson);
                txtVersion.Text = jo.getInfoResponse.serverVersion;
                //Trace.WriteLine(jo.getInfoResponse.isUtxoIndexed.ToString());
            }
        }
    }
}
