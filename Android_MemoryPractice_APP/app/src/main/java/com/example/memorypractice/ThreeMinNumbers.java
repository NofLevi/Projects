package com.example.memorypractice;

import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.os.Handler;
import android.view.View;
import android.view.WindowManager;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.Spinner;
import android.widget.TextView;

public class ThreeMinNumbers extends AppCompatActivity {

    WordsBank bank = new WordsBank();
    int[] arrInt;
    Button playbutton,instructionbutton,menubutton,tryagainbutton,applybutton;
    ImageButton homebutton;
    TextView title,instruction,aboveinput;
    int instructionflag = 0;
    final Handler handler = new Handler();
    TextView six,twelve,eightteen,twentyfour,thirty,abovespinner;
    EditText textfield;
    Spinner dropdown;
    String[] items;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_three_min_numbers);
        getWindow().addFlags(WindowManager.LayoutParams.FLAG_KEEP_SCREEN_ON);
        init();
    }


    public void init(){
        arrInt = bank.randomNumbers(30);
        playbutton = (Button) findViewById(R.id.PlayButton);
        applybutton = (Button) findViewById(R.id.ApplyButton);
        instructionbutton = (Button) findViewById(R.id.InstructionButton);
        menubutton = (Button) findViewById(R.id.MenuButton);
        tryagainbutton = (Button) findViewById(R.id.TryAgainButton);
        title = (TextView) findViewById(R.id.title);
        instruction = (TextView) findViewById(R.id.InstructionTextView);
        six = (TextView) findViewById(R.id.six);
        twelve = (TextView) findViewById(R.id.twelve);
        eightteen = (TextView) findViewById(R.id.eighteen);
        twentyfour = (TextView) findViewById(R.id.twentyfour);
        thirty = (TextView) findViewById(R.id.thirty);
        textfield = (EditText) findViewById(R.id.input);
        aboveinput = (TextView) findViewById(R.id.aboveinput);
        dropdown = (Spinner) findViewById(R.id.spinner);
        abovespinner = (TextView) findViewById(R.id.abovespinner);

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
            instruction.setText("Test 2: Three-minute numbers\n" +
                    "Try memorizing the following numbers in the correct order, reading left to right. you have 3 minutes to perform the memorization and then as long as you need to write the numbers down from memory once the 3 minutes are up.as before - no peeking!");
        }

        else{
            instructionflag = 0;
            instructionbutton.setText("Instruction");
            instruction.setText("");
        }

    }

    public void showNumbers(){
        String tempst = "";
        for(int i = 0; i < 6; i++){
            tempst += arrInt[i] + "  ";
        }
        six.setText(tempst);
        tempst = "";

        for(int i = 6; i < 12; i++){
            tempst += arrInt[i] + "  ";
        }
        twelve.setText(tempst);
        tempst = "";

        for(int i = 12; i < 18; i++){
            tempst += arrInt[i] + "  ";
        }
        eightteen.setText(tempst);
        tempst = "";

        for(int i = 18; i < 24; i++){
            tempst += arrInt[i] + "  ";
        }
        twentyfour.setText(tempst);
        tempst = "";

        for(int i = 24; i < 30; i++){
            tempst += arrInt[i] + "  ";
        }
        thirty.setText(tempst);

        six.setVisibility(View.VISIBLE);
        twelve.setVisibility(View.VISIBLE);
        eightteen.setVisibility(View.VISIBLE);
        twentyfour.setVisibility(View.VISIBLE);
        thirty.setVisibility(View.VISIBLE);
    }

    public void numbersGone(){
        six.setVisibility(View.GONE);
        twelve.setVisibility(View.GONE);
        eightteen.setVisibility(View.GONE);
        twentyfour.setVisibility(View.GONE);
        thirty.setVisibility(View.GONE);
    }

    public void checkResult(){
        String st = textfield.getText().toString();
        int score = 0;
        for(int i = 0; i < st.length();i++){
            if(Character.getNumericValue(st.charAt(i)) == arrInt[i]){
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

    public void exitApp(View view){
        Intent homeIntent = new Intent(Intent.ACTION_MAIN);
        homeIntent.addCategory( Intent.CATEGORY_HOME );
        homeIntent.setFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);
        startActivity(homeIntent);
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
