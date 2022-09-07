using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    int score = 0;
    public Text scoreText;
    int inc = 1;
    public Text incText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void scoreUp()
    {

        score += inc;
        print(score);
        scoreText.text = score.ToString();
    }
    public void scoreInc()
    {
     if (score >= 5)
        {
            score -= 5;
            inc += 1;
            scoreText.text = score.ToString();
            incText.text = "inc ="+ inc;
        }
    }
}
    
    

   
