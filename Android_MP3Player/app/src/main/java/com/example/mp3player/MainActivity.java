package com.example.mp3player;

import androidx.appcompat.app.AppCompatActivity;

import android.media.MediaPlayer;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.SeekBar;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
    MediaPlayer player;
    Button playbutton;
    Button backbutton;
    Button forwardbutton;
    TextView songname;
    ImageView songimage;
    Playlist playlist;
    SeekBar seekbar;

    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Init();
    }

    public void Init(){
        player = MediaPlayer.create(this, R.raw.amour);
        playbutton =  (Button)  findViewById(R.id.PlayButton);
        backbutton =  (Button)  findViewById(R.id.BackButton);
        forwardbutton =  (Button)  findViewById(R.id.ForwardButton);
        songname =  (TextView)  findViewById(R.id.SongName);
        songimage =  (ImageView)  findViewById(R.id.SongImage);
        seekbar = (SeekBar) findViewById(R.id.seekBar);
        playlist = new Playlist(player,playbutton,backbutton,forwardbutton,songname,songimage,seekbar);
    }

    public void Play(View view){
        playlist.Play();
    }

    public void Forward(View view){
        playlist.Forward();
    }

    public void Back(View view){
        playlist.Back();
    }
}
