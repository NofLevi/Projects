package com.example.mp3player;

import android.media.MediaPlayer;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.SeekBar;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;


public class Playlist extends AppCompatActivity {

    MediaPlayer player;
    Button playbutton;
    Button backbutton;
    Button forwardbutton;
    TextView songname;
    ImageView songimage;
    SeekBar seekbar;

    Song songslist[] = new Song[3];
    Song song1 = new Song("Amour");
    Song song2 = new Song("Haifisch");
    Song song3 = new Song("Meinherzbrennt");
    int index = 0;



    public Playlist(MediaPlayer player, Button playbutton, Button backbutton, Button forwardbutton, TextView songname, ImageView songimage, SeekBar seekBar){
        this.player = player;
        this.playbutton = playbutton;
        this.backbutton = backbutton;
        this.forwardbutton = forwardbutton;
        this.songname = songname;
        this.songimage = songimage;
        this.seekbar = seekBar;
        Fillsongslist();
    }

    public void Fillsongslist(){
        songslist[0] = song1;
        songslist[1] = song2;
        songslist[2] = song3;
    }

    public void Play(){
        if(!player.isPlaying()){
            player.start();
            playbutton.setText("Pause");
        }
        else{
            player.pause();
            playbutton.setText("Fortsetzen");
        }
    }

    public void Forward(){
        if(index == 2){
            index = 0;
            Switchsong();
        }
        else{
            index++;
            Switchsong();
        }
    }

    public void Back(){
        if(index == 0){
            index = 2;
            Switchsong();
        }
        else{
            index--;
            Switchsong();
        }
    }

    public void Switchsong(){
        songname.setText("Rammstein - " + songslist[index].GetName());
        player.release();
        switch(index){
            case 0:
                songimage.setImageResource(R.drawable.amourpic);
                player = MediaPlayer.create(this, R.raw.amour);
                break;

            case 1:
                songimage.setImageResource(R.drawable.haifischpic);
                player = MediaPlayer.create(this, R.raw.haifisch);
                break;

            default:
                songimage.setImageResource(R.drawable.meinherzbrenntpic);
                player = MediaPlayer.create(this, R.raw.meinherzbrennt);
                break;
        }
        player.start();
    }
}
