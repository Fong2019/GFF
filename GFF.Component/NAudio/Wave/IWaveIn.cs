using System;

namespace GFF.Component.NAudio.Wave
{
	public interface IWaveIn : IDisposable
	{
		event EventHandler<WaveInEventArgs> DataAvailable;

		event EventHandler<StoppedEventArgs> RecordingStopped;

		WaveFormat WaveFormat
		{
			get;
			set;
		}

		void StartRecording();

		void StopRecording();
	}
}
