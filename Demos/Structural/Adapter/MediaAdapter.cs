namespace Adapter;

public class MediaAdapter(LegacyAudioPlayer legacyAudioPlayer) : IMediaPlayer
{

	private readonly LegacyAudioPlayer _legacyAudioPlayer = legacyAudioPlayer;

	public void Play(string audioType, string fileName)
	{
		if (audioType.Equals("mp3", StringComparison.OrdinalIgnoreCase))
			_legacyAudioPlayer.PlayMp3(fileName);
		else if (audioType.Equals("wav", StringComparison.OrdinalIgnoreCase))
			_legacyAudioPlayer.PlayWAV(fileName);
		else
			Console.WriteLine("Invalid media. " + audioType + " format not supported");
	}

}