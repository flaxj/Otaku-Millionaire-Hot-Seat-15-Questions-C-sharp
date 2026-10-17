using System;
using System.IO;
using System.Media;

namespace Otaku_Millionaire_Hot_Seat
{
    internal enum AudioPlayMode { Background, BackgroundLoop, WaitToComplete }

    internal static class GameAudio
    {
        private static SoundPlayer player;
        internal static void Play(Stream stream, AudioPlayMode mode)
        {
            Stop();
            player = new SoundPlayer(stream);
            if (mode == AudioPlayMode.WaitToComplete) player.PlaySync();
            else if (mode == AudioPlayMode.BackgroundLoop) player.PlayLooping();
            else player.Play();
        }
        internal static void Stop()
        {
            if (player == null) return;
            player.Stop();
            player.Dispose();
            player = null;
        }
    }
}
