using System;
using NAudio.Wave;

namespace HogmuraAudioTester
{
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