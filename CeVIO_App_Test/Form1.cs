using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CeVIO.Talk.RemoteService;

namespace CeVIO_App_Test
{
    public partial class Form1 : Form
    {


        private SpeakingState state;

        /// <summary>
        /// インスタンス生成
        /// </summary>
        private Talker talker = new Talker();

        public Form1()
        {
            InitializeComponent();
            
            //ぼくONEちゃんしか持ってない
            talker.Cast = "ONE";

            //音量設定
            talker.Volume = 100;

            try
            {

                var version = ServiceControl.HostVersion;

            }
            catch(Exception ex)
            {
                //:innocent:
            }

            
        }


        private void Talk_btn_Click(object sender, EventArgs e)
        {

            //再生
            state = talker.Speak(textBox1.Text);
            state.Wait();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            //CeVIO終了
            ServiceControl.CloseHost();
        }

        private void Start_Click_1(object sender, EventArgs e)
        {
            //CeVIO起動
            ServiceControl.StartHost(false);
        }
    }
}
