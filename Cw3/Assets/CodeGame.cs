using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CodeGame : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreTx;
    public int inc = 1;
    int price = 5;


    // Start is called before the first frame update
    void Start ()
    {
        
    }

    public void pressMe()
    {
        score++;
        scoreTx.text = "Score :" + score.ToString();

    }
    public void shop()
    {
        if (score >= price)
            inc++;
        score -= price;
        scoreTx.text = "Score :" + score.ToString();

    }

}
