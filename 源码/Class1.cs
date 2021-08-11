using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;

namespace JellyUI
{
    public class Class1
    {
        public void Silkymove(Control con, Single x,Single y,Single t)
        {
            float XZ=0;
            float YZ=0;
            //增加的像素
            float x1;
            float y1;


            //进行循环移动距离
            do
            {
                XZ = (x - con.Left) * t;//x是目标距离，con是当前距离，*t小数让速度越来越慢
                YZ = (y - con.Top) * t;
                x1 = con.Left + XZ;
                y1 = con.Top + YZ;
                con.Left = int.Parse(x1.ToString());
                con.Top = int.Parse(y1.ToString());
                if (System.Math.Abs(XZ) < 1 || System.Math.Abs(YZ) < 1)
                {
                    return;
                }

            } while (Math.Floor(Convert.ToDouble(Math.Abs(con.Left))) != x | Math.Floor(Convert.ToDouble(Math.Abs(con.Top))) != y);//判断是否到达大概距离
        }
        public void Sleep(int inval)
        {
            Thread.Sleep(inval);
            Application.DoEvents();
        }
    }
}
