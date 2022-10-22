using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
   public int score= 0;
   public TextMeshProUGUI scoreTx;
    public int inc = 1;
    int price = 5;
    public int point = 10;
    int boo = 20;


    // Start is called before the first frame update

    void Start()
    {
        
    }
     
    public void pressMe()
    {
        score++;
        scoreTx.text = "Score :"+score;

    }
    public void house()
    {
        if (score >= price)
            inc++;
        score -= price;
        scoreTx.text = "Score :" + score;

    }
     
    public void surprise()
    {
        if (score >= boo )
            point++;
        score += boo;
        scoreTx.text = "Score :" + score;

    }



}
