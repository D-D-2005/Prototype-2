using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
   public static Points instance;

    public Text scoreText;
    public Text livesText;

    int score = 0;
    int lives = 3;


    private void Awake() {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + " Score";
        livesText.text = lives.ToString() + " Lives";

    }

    // Update is called once per frame
    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " Score";
    }

    public void DecreaseLives(){
        lives -= 1;
        livesText.text = lives.ToString() + " Lives";

        if(lives ==  0){
            Debug.Log("G A M E   O V E R  Y O U  D I S A P P O I N T M E N T");
            Destroy(GameObject.Find("Player"));
        }
    }  
}    