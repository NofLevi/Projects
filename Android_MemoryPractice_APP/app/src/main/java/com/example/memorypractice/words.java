package com.example.memorypractice;

import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.os.Handler;
import android.text.method.ScrollingMovementMethod;
import android.view.View;
import android.view.WindowManager;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.Spinner;
import android.widget.TextView;

import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

import java.util.Arrays;

public class words extends AppCompatActivity {

    WordsBank bank = new WordsBank();
    String[] strArray;
    Button playbutton,instructionbutton,menubutton,tryagainbutton,applybutton;
    ImageButton homebutton;
    TextView title,instruction,aboveinput;
    int instructionflag = 0;
    final Handler handler = new Handler();
    TextView gametext1,gametext2,abovespinner;
    EditText textfield;
    Spinner dropdown;
    String[] items;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_words);
        getWindow().addFlags(WindowManager.LayoutParams.FLAG_KEEP_SCREEN_ON);
        init();
    }


    public void init(){
        strArray = bank.randomWords(30);
        playbutton = (Button) findViewById(R.id.PlayButton);
        applybutton = (Button) findViewById(R.id.ApplyButton);
        instructionbutton = (Button) findViewById(R.id.InstructionButton);
        menubutton = (Button) findViewById(R.id.MenuButton);
        tryagainbutton = (Button) findViewById(R.id.TryAgainButton);
        title = (TextView) findViewById(R.id.title);
        instruction = (TextView) findViewById(R.id.InstructionTextView);
        gametext1 = (TextView) findViewById(R.id.Gametext1);
        gametext2 = (TextView) findViewById(R.id.Gametext2);
        textfield = (EditText) findViewById(R.id.input);
        aboveinput = (TextView) findViewById(R.id.aboveinput);
        dropdown = (Spinner) findViewById(R.id.spinner);
        abovespinner = (TextView) findViewById(R.id.abovespinner);

        textfield = (EditText)findViewById(R.id.input);
        textfield.setOnEditorActionListener(new DoneOnEditorActionListener());

        items = new String[]{"3 [Standard]","1", "2","4","5"};
        ArrayAdapter<String> adapter = new ArrayAdapter<>(this, android.R.layout.simple_spinner_dropdown_item, items);
        dropdown.setAdapter(adapter);
    }

    public void startGame(View view){
        String text = dropdown.getSelectedItem().toString();
        int ms = Character.getNumericValue(text.charAt(0))*60000;
        instructionflag = 0;
        instructionbutton.setText("Instruction");
        instruction.setVisibility(View.GONE);
        instructionbutton.setVisibility(View.GONE);
        playbutton.setVisibility(View.GONE);
        dropdown.setVisibility(View.GONE);
        abovespinner.setVisibility(View.GONE);
        showNumbers();

        final Handler handler = new Handler();
        handler.postDelayed(new Runnable() {
            @Override
            public void run() {
                numbersGone();
                aboveinput.setVisibility(View.VISIBLE);
                textfield.setVisibility(View.VISIBLE);
                applybutton.setVisibility(View.VISIBLE);
            }
        },ms);//replace with variable ms

    }

    public void openInstruction(View view){
        if(instructionflag == 0){
            instructionflag = 1;
            instructionbutton.setText("Close Instruction");
            instruction.setText("Test1: Three-minute words:\n" +
                    "Try memorizing the following words in the coreect order (beginning with the first column on the left and reading down) with the correct spelling. You have 3 minutes to perform the memorization and as long as you need to write the words down once the time is up. No peeking!");
        }

        else{
            instructionflag = 0;
            instructionbutton.setText("Instruction");
            instruction.setText("");
        }
    }

    public void showNumbers(){
        String st1 = "\n\n";
        String st2 = "\n\n";

        for(int i = 0; i < 15;i++){
            st1 += strArray[i] + "\n";
        }

        for(int i = 15; i < 30; i++){
            st2 += strArray[i] + "\n";
        }

        gametext1.setText(st1);
        gametext2.setText(st2);
        gametext2.setMovementMethod(new ScrollingMovementMethod());
        gametext1.setMovementMethod(new ScrollingMovementMethod());
        gametext1.setVisibility(View.VISIBLE);
        gametext2.setVisibility(View.VISIBLE);
    }

    public void numbersGone(){
        gametext1.setVisibility(View.GONE);
        gametext2.setVisibility(View.GONE);
    }

    public void checkResult(){
        String st = textfield.getText().toString();
        int score = 0;
        String[] userArray = st.split(" ");
        for(int i = 0; i < userArray.length; i++){
            System.out.println(userArray[i].toUpperCase() + " = " + strArray[i]);
            if(strArray[i].equals(userArray[i].toUpperCase())){
                score++;
            }
        }

        textfield.setVisibility(View.GONE);
        applybutton.setVisibility(View.GONE);
        aboveinput.setText("Your score is: " + score);
        menubutton.setVisibility(View.VISIBLE);
        tryagainbutton.setVisibility(View.VISIBLE);
    }

    public void applyData(View view){
        checkResult();
    }

    public void backHome(View view){
        Intent intent = new Intent(this,MainActivity.class);
        startActivity(intent);
    }

    public void goMenu(View view){
        Intent intent = new Intent(this,MainActivity.class);
        startActivity(intent);
    }

    public void tryAgain(View view){
        Intent intent = new Intent(this,ThreeMinNumbers.class);
        startActivity(intent);
    }
}