using System.Collections.Generic;
using System;
using HogmuraAudioTester.Resources;
using NAudio.Wave;
using System.Windows.Forms;
using System.Drawing;

namespace HogmuraAudioTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            PlayStereo(1.0f, 0.0f);
        }

        private void buttonCenter_Click(object sender, EventArgs e)
        {
            PlayStereo(1.0f, 1.0f);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            PlayStereo(0.0f, 1.0f);
        }

        private void PlayStereo(float leftVolume, float rightVolume)
        {
            WaveFileReader wave = new WaveFileReader(Hogs.hogmura_sound);
            VolumeStereoSampleProvider stereo = new VolumeStereoSampleProvider(wave.ToSampleProvider())
            {
                VolumeLeft = leftVolume,
                VolumeRight = rightVolume
            };
            Play(stereo, wave);
        }

        private void Play(ISampleProvider file, WaveFileReader wave)
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

    /// <summary>
    /// Very simple sample provider supporting adjustable gain
    /// </summary>
    public class VolumeStereoSampleProvider : ISampleProvider
    {
        private readonly ISampleProvider source;

        /// <summary>
        /// Allows adjusting the volume left channel, 1.0f = full volume
        /// </summary>
        public float VolumeLeft { get; set; }

        /// <summary>
        /// Allows adjusting the volume right channel, 1.0f = full volume
        /// </summary>
        public float VolumeRight { get; set; }

        /// <summary>
        /// Initializes a new instance of VolumeStereoSampleProvider
        /// </summary>
        /// <param name="source">Source sample provider, must be stereo</param>
        public VolumeStereoSampleProvider(ISampleProvider source)
        {
            if (source.WaveFormat.Channels != 2)
                throw new ArgumentException("Source sample provider must be stereo");

            this.source = source;
            VolumeLeft = 1.0f;
            VolumeRight = 1.0f;
        }

        /// <summary>
        /// WaveFormat
        /// </summary>
        public WaveFormat WaveFormat => source.WaveFormat;

        /// <summary>
        /// Reads samples from this sample provider
        /// </summary>
        /// <param name="buffer">Sample buffer</param>
        /// <param name="offset">Offset into sample buffer</param>
        /// <param name="sampleCount">Number of samples desired</param>
        /// <returns>Number of samples read</returns>
        public int Read(float[] buffer, int offset, int sampleCount)
        {
            int samplesRead = source.Read(buffer, offset, sampleCount);

            for (int n = 0; n < sampleCount; n += 2)
            {
                buffer[offset + n] *= VolumeLeft;
                buffer[offset + n + 1] *= VolumeRight;
            }

            return samplesRead;
        }
    }
}