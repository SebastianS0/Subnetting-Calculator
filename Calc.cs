using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubnettingCalc
{
    public partial class Frm_Calc : Form
    {
        // Subnet Mask in Binary saved as Array
        // Gets set when Mask is changed
        string[] subBin = new string[4];

        // IP Address in Decimal saved as Array
        // Gets set when IP is changed
        byte[] ipSplt = new byte[4];

        public Frm_Calc()
        {
            InitializeComponent();
        }

        private void txt_subin_TextChanged(object sender, EventArgs e)
        {
            string subMsk = txt_subin.Text;
            char[] spltby = new char[] { '.' };
            byte cidrnot;
            string[] result;
            byte i = 0;
            string subdec = "";
            
            // Sets Num of Hosts and Subnets
            NumHostsNets();

            Array.Clear(subBin, 0, subBin.Length);
            if (rB_CidrY.Checked)
            {
                txt_subin.Width = 50;
                lbl_subdec.Visible = true;


                if (subMsk == "" || Convert.ToInt32(subMsk) > 32)
                {
                    lbl_Subbin.Text = "";
                    return;
                }
                cidrnot = Convert.ToByte(subMsk);

                // Convert Decimal Subnet Mask to Binary
                for (byte j = 0; j <= 3; j++)
                {
                    if (cidrnot >= 8)
                    {
                        cidrnot -= 8;
                        subBin[j] = string.Concat(Enumerable.Repeat("1", 8));
                        subdec += Convert.ToInt32(subBin[j], 2);

                    }
                    else if (cidrnot == 0)
                    {
                        subBin[j] = string.Concat(Enumerable.Repeat("0", 8));
                        subdec += 0;
                    }
                    else
                    {
                        subBin[j] = string.Concat(Enumerable.Repeat("1", cidrnot));
                        subBin[j] = subBin[j] + string.Concat(Enumerable.Repeat("0", 8 - subBin[j].Length));
                        subdec += Convert.ToInt32(subBin[j], 2);
                        cidrnot = 0;
                    }
                    if (j < 3)
                    {
                        subdec += ".";
                    }


                    }
                lbl_subdec.Text = subdec;
            }
            else
            {
                txt_subin.Width = 150;
                lbl_subdec.Visible = false;
                lbl_subdec.Text = subMsk;
                result = subMsk.Split(spltby);
                foreach (string x in result)
                {
                    if (x == "" || Convert.ToInt32(x) > 255) return;
                    subBin[i] = ToBinary(x);
                    i++;
                }
                //Console.WriteLine(string.Join(".", subBin));
            }
            lbl_Subbin.Text = string.Join(".", subBin);
            UpdateSubID();


        }

        private void txt_ipin_TextChanged(object sender, EventArgs e)
        {
            string ipAdr = txt_ipin.Text;
            char[] spltby = new char[] { '.' };
            string[] ipBin = new string[4];
            string[] ipSplt2;
            byte i = 0;

            //Array.Clear(ipSplt, 0, ipSplt.Length);
            ipSplt2 = ipAdr.Split(spltby);
            if (ipSplt2[ipSplt2.Length-1] == "") return;
            ipSplt = Array.ConvertAll(ipSplt2, s => byte.Parse(s));
            TypeSubnet();
            foreach (byte x in ipSplt)
            {
                if (x == 0 || Convert.ToInt32(x) > 255) return;
                ipBin[i] = ToBinary(x);
                i++;
            }
            //Console.WriteLine(string.Join(".", ipBin));
            lbl_IpBin.Text = string.Join(".", ipBin);
            UpdateSubID();
        }

        private static string ToBinary(string num)
        {
            string bin;
            bin = Convert.ToString(Convert.ToInt32(num), 2);
            if (bin.Length < 8)
            {
                bin = string.Concat(Enumerable.Repeat("0", 8 - bin.Length)) + bin;
            }
            return bin;
        }
        private static string ToBinary(byte num)
        {
            string bin;
            bin = Convert.ToString(num, 2);
            if (bin.Length < 8)
            {
                bin = string.Concat(Enumerable.Repeat("0", 8 - bin.Length)) + bin;
            }
            return bin;
        }

        private void UpdateSubID()
        {
            string ipAdr = txt_ipin.Text;
            string subMsk = lbl_subdec.Text;
            string[] ipSplt;
            string[] subSplt;
            char[] spltby = new char[] { '.' };
            Byte[] subID = new Byte[4];
            int maxSize;

            ipSplt = ipAdr.Split(spltby, 4);
            subSplt = subMsk.Split(spltby, 4);
            maxSize = Math.Min(ipSplt.Length, subSplt.Length);
            if (maxSize <= 1) return;
            for (byte i = 0; i <= maxSize -1; i++)
            {
                subID[i] = (byte)(Convert.ToByte(ipSplt[i]) & Convert.ToByte(subSplt[i]));
            }

            lbl_SubID.Text = string.Join(".", subID);
        }
        private void NumHostsNets()
        {
            if (txt_subin.Text == "") return;
            if (rB_CidrY.Checked){
                byte y = (byte)(32 - Convert.ToByte(txt_subin.Text));
                byte x = Convert.ToByte(txt_subin.Text);
                UInt32 hosts = (uint)Math.Pow(2, y) - 2;
                UInt32 netze = (uint)Math.Pow(2, x);
                Lbl_hosts.Text = hosts + "";
                Lbl_Netze.Text = netze + "";
            }
        }
        private void TypeSubnet()
        {
            if (txt_ipin.Text == "") return;
            byte firstOctet = Convert.ToByte(ipSplt[0]);
            if (firstOctet <= 127)
            {
                //A
                Lbl_NetClass.Text = "A";
            }
            else if (firstOctet <= 191)
            {
                //B
                Lbl_NetClass.Text = "B";
            }
            else if (firstOctet <= 223)
            {
                //C
                Lbl_NetClass.Text = "C";
            }
            else if (firstOctet <= 231)
            {
                //D
                Lbl_NetClass.Text = "D";
            }
            else if (firstOctet >= 232)
            {
                //E
                Lbl_NetClass.Text = "E";
            }
        }
        private void rB_CidrN_CheckedChanged(object sender, EventArgs e)
        {
            txt_subin.Text = "";
            txt_subin.Width = 150;
            lbl_subdec.Visible = rB_CidrY.Checked;
            if (rB_CidrY.Checked)
            {
                txt_subin.Width = 50;
            }
            else
            {
                txt_subin.Width = 150;
            }
        }
    }
}
