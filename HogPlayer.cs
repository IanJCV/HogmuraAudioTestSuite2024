using System;
using HogmuraAudioTester.Resources;
using NAudio.Wave;

namespace HogmuraAudioTester
{
    public static class HogPlayer
    {
        public static void PlayRandomSound()
        {
            var rnd = new Random();

            PlayStereo((float)rnd.NextDouble(), (float)rnd.NextDouble());
        }

        public static void PlayStereo(float leftVolume, float rightVolume)
        {
            WaveFileReader wave = new WaveFileReader(Hogs.hogmura_sound);
            VolumeStereoSampleProvider stereo = new VolumeStereoSampleProvider(wave.ToSampleProvider())
            {
                VolumeLeft = leftVolume,
                VolumeRight = rightVolume
            };
            Play(stereo, wave);
        }

        public static void Play(ISampleProvider file, WaveFileReader wave)
        {
            var waveOut = new WaveOutEvent();
            waveOut.Init(file);
            waveOut.Play();
            waveOut.PlaybackStopped += (s, e) =>
            {
                waveOut.Dispose();
                wave.Dispose();
                GC.Collect();
            };
        }
    }
}