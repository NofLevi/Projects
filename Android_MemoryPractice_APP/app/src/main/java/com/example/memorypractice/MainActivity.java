package com.example.memorypractice;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.WindowManager;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        getWindow().addFlags(WindowManager.LayoutParams.FLAG_KEEP_SCREEN_ON);
        setContentView(R.layout.activity_main);
    }

    public void openNumbersGame(View view){
        Intent intent = new Intent(this,ThreeMinNumbers.class);
        startActivity(intent);
    }


    public void openWordsGame(View view){
        Intent intent = new Intent(this,words.class);
        startActivity(intent);
    }


}
