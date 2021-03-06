using System;

namespace GFF.Component.NAudio.Wave
{
	public interface IWavePlayer : IDisposable
	{
		event EventHandler<StoppedEventArgs> PlaybackStopped;

		PlaybackState PlaybackState
		{
			get;
		}

		[Obsolete("Not intending to keep supporting this going forward: set the volume on your input WaveProvider instead")]
		float Volume
		{
			get;
			set;
		}

		void Play();

		void Stop();

		void Pause();

		void Init(IWaveProvider waveProvider);
	}
}
