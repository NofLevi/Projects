package com.example.mp3player;

import android.media.MediaPlayer;
import android.widget.ImageView;

public class Song {
    String name;
    MediaPlayer player;
    ImageView songimage;

    public Song(String name){
        this.name = name;
    }


    public String GetName(){
        return name;
    }

}
