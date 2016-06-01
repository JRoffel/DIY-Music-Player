using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using WMPLib;

namespace DIY_Music_Player
{
    static class PlayerUtilities
    {
        private static WindowsMediaPlayer Player = new WindowsMediaPlayer();
        private static List<string> AllSongs = new List<string>();
        private static int CurrentIndex = -1;
        private static MediaPlayerWindow window;
        private static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private static System.Windows.Forms.Timer PlaylistReadTimer = new System.Windows.Forms.Timer();
        [ThreadStatic]
        private static Random Local;
        private static string PlaylistFolder = "";
        private static bool Repeat = false;
        private static int PlayerState = 0;
        private static bool loadSubFolders = false;
        public static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MediaPlayerWindow());
        }

        public static void InitPlayer(string songFolder, bool subFolderRead)
        {
            loadSubFolders = subFolderRead;
            Player.settings.autoStart = false;
            Player.PlayStateChange += new _WMPOCXEvents_PlayStateChangeEventHandler(player_PlayStateChange);
            timer.Interval = 10;
            timer.Tick += new EventHandler(timer_Tick);
            PlaylistReadTimer.Interval = 3600000;
            PlaylistReadTimer.Tick += new EventHandler(ReloadPlaylist);
            PlaylistReadTimer.Start();
            PlaylistFolder = songFolder;
            GetAllSongsFromFolder();
            PlayerState = 1;
            GetNextSong();
        }

        public static void CreateWindowReference(MediaPlayerWindow Window)
        {
            window = Window;
        }

        public static void PlayCurrentSong()
        {
            timer.Stop();
            window.UpdatePlayLabel();
            Player.controls.play();
        }

        public static void PauseCurrentSong()
        {
            Player.controls.pause();
        }

        public static string GenerateLabelText()
        {
            string filePath = AllSongs[CurrentIndex].Split('\\').LastOrDefault();
            string fileName = filePath.Replace(".mp3", "");
            string labelText = "Currently Playing: " + fileName;
            Console.WriteLine(labelText);
            Console.WriteLine(AllSongs[CurrentIndex]);
            return labelText;
        }

        public static void GetNextSong()
        {
            CurrentIndex++;
            if (CurrentIndex > AllSongs.Count - 1)
            {
                if (Repeat == true)
                {
                    CurrentIndex = 0;
                }
                else
                {
                    Player.controls.stop();
                    CurrentIndex = 0;
                }
            }
            Player.URL = AllSongs[CurrentIndex];
            if(PlayerState == 2)
            {
                timer.Start();
            }
            else
            {
                PlayerState = 2;
            }
        }

        public static void GetPreviousSong()
        {
            CurrentIndex--;
            if (CurrentIndex < 0)
            {
                CurrentIndex = AllSongs.Count - 1;
            }
            Player.URL = AllSongs[CurrentIndex];
            timer.Start();
        }

        public static void SetRepeat(bool shouldRepeat)
        {
            Repeat = shouldRepeat;
        }

        public static void SetRandom(bool isRandom)
        {
            if (isRandom == true)
            {
                //setting current index to 0 to simulate full playlist play
                AllSongs.RandomizeOrder();
                CurrentIndex = 0;
                if ((int)Player.playState != 2 && (int)Player.playState != 3)
                {
                    Player.URL = AllSongs[CurrentIndex];
                }
            }
            else
            {
                string currentSong = AllSongs[CurrentIndex];
                //This work-around is easier and more memory efficient than to copy the entire list before randomizing it.
                GetAllSongsFromFolder();
                int iterator = 0;
                //The foreach loop decided where the player is in the normalized playlist, and continues to play in order from there on.
                foreach (string song in AllSongs)
                {
                    if (song == currentSong)
                    {
                        CurrentIndex = iterator;
                    }
                    iterator++;
                }
            }
        }

        private static void RandomizeOrder<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private static void GetAllSongsFromFolder()
        {
            var fileNames = Directory.GetFiles(PlaylistFolder, "*.mp3", loadSubFolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            AllSongs = fileNames.AsQueryable().OrderBy(s => s).ToList();
        }

        private static void player_PlayStateChange(int NewState)
        {
            if (NewState == (int)WMPPlayState.wmppsMediaEnded)
            {
                GetNextSong();
            }
        }

        private static void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            PlayCurrentSong();
        }

        private static void ReloadPlaylist(object sender, EventArgs e)
        {
            GetAllSongsFromFolder();
        }

    }
}