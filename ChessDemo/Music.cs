using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Runtime.InteropServices;

namespace ChessDemo
{
    class Music
    {
        #region 音乐播放器
        [DllImport("winmm.dll")]
        private static extern int mciSendString
                (
                        string lpstrCommand,
                        string lpstrReturnString,
                        int uReturnLength,
                        int hwndCallback
                );

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetShortPathName
                (
                          [MarshalAs(UnmanagedType.LPTStr)]         string path,
                          [MarshalAs(UnmanagedType.LPTStr)]         StringBuilder shortPath,
                          int shortPathLength
                );
        /// <summary>
        /// 背景音乐播放
        /// </summary>
        /// <param name="FileName"></param>
        public static void PlaySong(string FileName)
        {
            StringBuilder shortPathTemp = new StringBuilder(255);
            int result = GetShortPathName(FileName, shortPathTemp, shortPathTemp.Capacity);
            string ShortPath = shortPathTemp.ToString();

            mciSendString("open   " + ShortPath + "   alias   song", "", 0, 0);
            mciSendString("play   song", "", 0, 0);
        }
        #endregion

        private static SoundPlayer soundPlayer = new SoundPlayer();

        /// <summary>
        /// 播放音效
        /// </summary>
        /// <param name="path"></param>
        public static void play(string command) {
            switch (command) { 
                case "换子":
                case "移动":
                case "选子":
                    soundPlayer.SoundLocation = @"sound\select.wav";
                    soundPlayer.Play();
                    break;
                case "吃子":
                    soundPlayer.SoundLocation = @"sound\eat.wav";
                    soundPlayer.Play();
                    break;
                default: break;
            }
        }
    }
}
