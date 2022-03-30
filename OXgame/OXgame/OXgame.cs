using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OXgame
{
    public partial class OXgame : Form
    {
        Button[] btnT = new Button[9];  // 井字的按鍵
        bool isO = true; //O或X
        Player player = new Player(0, 0); //玩家贏的場數設定
        

        public OXgame()
        {
            InitializeComponent();
            btnT = new Button[9] { button1, button2, button3, button4, button5, button6, button7, button8, button9 }; //設定9個按鍵
        }

        private void gamereset()  //設定重置遊戲
        {
            isO = true;
            for(int i=0; i< btnT.Length; i++)
            {
                btnT[i].Text = "";
                btnT[i].Enabled = true;
            }
        }

        private void isX(bool isX) //O跟X交換
        {
            this.isO = isX;
        }

        private int[,] WinGroup = new int[8,3] // 8組連線
        {  
                {0,1,2},
                {3,4,5},
                {6,7,8},
                {0,3,6},
                {1,4,7},
                {2,5,8},
                {0,4,8},
                {2,4,6}
            };

        private void CheckWinGroup()
        {
            int btnIsUse = 1;

            for(int i = 0; i < 8; i++)
            {
                int a = WinGroup[i,0];  //抓取陣列的1~3列
                int b = WinGroup[i,1];
                int c = WinGroup[i,2];

                Button b1 = btnT[a];  // 設定三個變數去讓按鈕抓取陣列的排數
                Button b2 = btnT[b];
                Button b3 = btnT[c];

                if(b1.Text == "" || b2.Text == "" || b3.Text == "")  // 沒連線就傳回到前面
                {
                    continue;
                }

                if(b1.Text == "O" && b2.Text == "O" &&b3.Text == "O")  // 判定O跟X勝利
                {
                    MessageBox.Show("O勝利");
                    player.GameWin(1, 0);
                    playerO.Text = "" + player.PlayerO + "場";
                    for(int e=0;e < 9; e++) //關掉按鈕
                    {
                        btnT[e].Enabled = false;
                    }
                    break;  //不會在往下讀
                }
                if (b1.Text == "X" && b2.Text == "X" && b3.Text == "X")
                {
                    MessageBox.Show("X勝利");
                    player.GameWin(0, 1);
                    playerX.Text = "" + player.PlayerX + "場";
                    for (int e = 0; e < 9; e++) //關掉按鈕
                    {
                        btnT[e].Enabled = false;
                    }
                    break; //不會在往下讀
                }

                if(btnT[i].Text != "")  // 按鈕滿了就平局
                {
                    btnIsUse++;
                    if(btnIsUse ==9)
                    {
                        MessageBox.Show("平手\r\n請重新開始一場遊戲");
                    }
                }
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)  
        {
            gamereset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isO == true)
            {
                btnT[0].Text = "O";
                isX(false);
            }
            else
            {
                btnT[0].Text = "X";
                isX(true);
            }
            btnT[0].Enabled = false;
            CheckWinGroup();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isO == true)
            {
                btnT[1].Text = "O";
                isX(false);
            }
            else
            {
                btnT[1].Text = "X";
                isX(true);
            }
            btnT[1].Enabled = false;
            CheckWinGroup();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isO == true)
            {
                btnT[4].Text = "O";
                isX(false);
            }
            else
            {
                btnT[4].Text = "X";
                isX(true);
            }
            btnT[4].Enabled = false;
            CheckWinGroup();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isO == true)
            {
                btnT[3].Text = "O";
                isX(false);
            }
            else
            {
                btnT[3].Text = "X";
                isX(true);
            }
            btnT[3].Enabled = false;
            CheckWinGroup();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isO == true)
            {
                btnT[2].Text = "O";
                isX(false);
            }
            else
            {
                btnT[2].Text = "X";
                isX(true);
            }
            btnT[2].Enabled = false;
            CheckWinGroup();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isO == true)
            {
                btnT[5].Text = "O";
                isX(false);
            }
            else
            {
                btnT[5].Text = "X";
                isX(true);
            }
            btnT[5].Enabled = false;
            CheckWinGroup();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isO == true)
            {
                btnT[6].Text = "O";
                isX(false);
            }
            else
            {
                btnT[6].Text = "X";
                isX(true);
            }
            btnT[6].Enabled = false;
            CheckWinGroup();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isO == true)
            {
                btnT[7].Text = "O";
                isX(false);
            }
            else
            {
                btnT[7].Text = "X";
                isX(true);
            }
            btnT[7].Enabled = false;
            CheckWinGroup();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isO == true)
            {
                btnT[8].Text = "O";
                isX(false);
            }
            else
            {
                btnT[8].Text = "X";
                isX(true);
            }
            btnT[8].Enabled = false;
            CheckWinGroup();
        }
    }
}
