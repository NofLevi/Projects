package com.example.memorypractice;

import java.util.Random;

public class WordsBank {
    String[] strArray = new String[] {
            "VIOLIN","KNIGHT","SUITCASE","NECKLACE","SNOWBALL","BABY","MASK","ROSE","GINGER",
            "ORCHESTRA","FILE","WINDOW","TABLE","BALL","PHOTO","ELEPHANT","TROPHY","PENCIL",
            "RAINBOW","CARPET","PEACH","PLANET","MAGAZINE","GOLD","WATCH","CAT","DOG","TOY",
            "BIRTHDAY","ICE","FIRE","CHURCH","SAND","BUS","GUITAR","BEETHOVEN","PLASTIC","ORANGE",
            "APPLE","SALT","MOON","SUN","PLASTER","GLASS","TORCH","MOBILEPHONE","CANDLE","SHARK",
            "BUBBLE","RIFLE","ROOF","MOUSE","CAMERA","SHOE","HAIRBRUSH","BICYCLE","COMPUTER",
            "LADDER","PILLOW","BOOMERANG","CAKE","DIARY","SOAP","GIRAFFE","DOOR","BOAR","GATE",
            "WINE","HEAVEN","HELL","BOOK"
    };
    Random random = new Random();
    int randomInteger;

    public String[] randomWords(int num){
        String[] newSt = new String[num];

        for(int i = 0; i < num; i++) {
            randomInteger = random.nextInt(strArray.length);

            for(int j = 0; j < i; j++){
                if(newSt[j] == strArray[randomInteger] ){
                    j = 0;
                    randomInteger = random.nextInt(strArray.length);
                }
            }
            newSt[i] = strArray[randomInteger];
        }
        return newSt;
    }

    public int[] randomNumbers(int num){
        int[] arrInt = new int[num];
        for(int i = 0; i < num; i++){
            arrInt[i] = randomInteger = random.nextInt(10);
        }
        return arrInt;
    }
}
