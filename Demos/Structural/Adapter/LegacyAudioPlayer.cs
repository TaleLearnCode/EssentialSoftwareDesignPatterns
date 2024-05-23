namespace Adapter;

public class LegacyAudioPlayer
{
	public void PlayMp3(String fileName)
		=> Console.WriteLine("Playing mp3 file. Name: " + fileName);

	public void PlayWAV(String fileName)
		=> Console.WriteLine("Playing WAV file. Name: " + fileName);
}