IMediaPlayer player = new MediaAdapter(new LegacyAudioPlayer());
player.Play("mp3", "Thunderstuck.mp3");
player.Play("wav", "Back-In-Black.wav");
player.Play("flac", "Hells-Highway.flac"); // Unsupported format