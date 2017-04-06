using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.WFA
{
    public static class Conversao
    {
        public static System.IO.MemoryStream StringToStream(string s)
        {
            byte[] byteArray = Encoding.GetEncoding("iso-8859-1").GetBytes(s);
            return new MemoryStream(byteArray);
        }

        public static string StreamToString(MemoryStream ms)
        {
            StreamReader reader = new StreamReader(ms);
            return reader.ReadToEnd();
        }

        public static string KeyCodeToString(Keys key, bool shift)
        {
            if ((key == Keys.A) || (key == Keys.B) || (key == Keys.C) || (key == Keys.D) || (key == Keys.E) || (key == Keys.F) || (key == Keys.G) ||
                (key == Keys.H) || (key == Keys.I) || (key == Keys.J) || (key == Keys.K) || (key == Keys.L) || (key == Keys.M) || (key == Keys.N) ||
                (key == Keys.O) || (key == Keys.P) || (key == Keys.Q) || (key == Keys.R) || (key == Keys.S) || (key == Keys.T) || (key == Keys.U) ||
                (key == Keys.V) || (key == Keys.X) || (key == Keys.Y) || (key == Keys.W) || (key == Keys.Z))
                return shift ? key.ToString().ToUpper() : key.ToString().ToLower();
            else if (key == Keys.D0 || key == Keys.NumPad0)
                return shift ? ")" : "0";
            else if (key == Keys.D1 || key == Keys.NumPad1)
                return shift ? "!" : "1";
            else if (key == Keys.D2 || key == Keys.NumPad2)
                return shift ? "@" : "2";
            else if (key == Keys.D3 || key == Keys.NumPad3)
                return shift ? "#" : "3";
            else if (key == Keys.D4 || key == Keys.NumPad4)
                return shift ? "$" : "4";
            else if (key == Keys.D5 || key == Keys.NumPad5)
                return shift ? "%" : "5";
            else if (key == Keys.D6 || key == Keys.NumPad6)
                return shift ? "¨" : "6";
            else if (key == Keys.D7 || key == Keys.NumPad7)
                return shift ? "&" : "7";
            else if (key == Keys.D8 || key == Keys.NumPad8)
                return shift ? "*" : "8";
            else if (key == Keys.D9 || key == Keys.NumPad9)
                return shift ? "(" : "9";
            else
                return "";
        }

        public static Color SkinNameToColor(string s)
        {
            Color color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            switch (s)
            {
                case "Metropolis":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
                    break;
                case "Metropolis Dark Green":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(189)))), ((int)(((byte)(69)))));
                    break;
                case "Metropolis Dark":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(138)))), ((int)(((byte)(9)))));
                    break;
                case "Blue":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(92)))), ((int)(((byte)(146)))));
                    break;
                case "Caramel":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(116)))), ((int)(((byte)(100)))));
                    break;
                case "Lilian":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(175)))), ((int)(((byte)(212)))));
                    break;
                case "Money Twins":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(71)))), ((int)(((byte)(152)))));
                    break;
                case "The Asphalt World":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
                    break;
                case "iMaginary":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(186)))), ((int)(((byte)(236)))));
                    break;
                case "VS2010":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(41)))), ((int)(((byte)(62)))));
                    break;
                case "Blueprint":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
                    break;
                case "Black":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
                    break;
                case "DevExpress Style":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
                    break;
                case "DevExpress Dark Style":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
                    break;
                case "Coffee":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
                    break;
                case "Liquid Sky":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
                    break;
                case "London Liquid Sky":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
                    break;
                case "Glass Oceans":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
                    break;
                case "Stardust":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
                    break;
                case "Xmas 2008 Blue":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(103)))), ((int)(((byte)(143)))));
                    break;
                case "Valentine":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
                    break;
                case "McSkin":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
                    break;
                case "Summer2008":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
                    break;
                case "Pumpkin":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    break;
                case "Dark Side":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    break;
                case "Springtime":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(132)))), ((int)(((byte)(88)))));
                    break;
                case "Darkroom":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
                    break;
                case "Foggy":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(148)))), ((int)(((byte)(160)))));
                    break;
                case "Seven":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
                    break;
                case "Seven Classic":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(96)))), ((int)(((byte)(97)))));
                    break;
                case "Sharp":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
                    break;
                case "Sharp Plus":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
                    break;
                case "Office 2007 Blue":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
                    break;
                case "Office 2007 Black":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
                    break;
                case "Office 2007 Silver":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
                    break;
                case "Office 2007 Green":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(89)))), ((int)(((byte)(82)))));
                    break;
                case "Office 2007 Pink":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
                    break;
                case "Office 2010 Blue":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(93)))), ((int)(((byte)(125)))));
                    break;
                case "Office 2010 Black":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
                    break;
                case "Office 2010 Silver":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(93)))), ((int)(((byte)(98)))));
                    break;
                case "Whiteprint":
                    color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    break;
            }
            return color;
        }
    }
}
