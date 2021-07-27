package com.example.memorypractice;

public class topUserClass {
    String name;
    int score;

    public topUserClass(){

    }

    public topUserClass(String name, int score){
        this.name = name;
        this.score = score;
    }

    public topUserClass(topUserClass leaderboardUser){
        this.name = leaderboardUser.getName();
        this.score = leaderboardUser.getScore();
    }

    public String getName(){
        return name;
    }

    public int getScore(){
        return score;
    }
}
