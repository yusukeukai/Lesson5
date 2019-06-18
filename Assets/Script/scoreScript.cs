using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour {

    public Text scoreText;//TEXT用変数

    private int score=0;//スコア計算用変数

	// Use this for initialization
	void Start () {

        score = 0;//初期スコアを代入して表示
        SetScore();
    }

    private void OnCollisionEnter(Collision collision)
    {
        string yourTag = collision.gameObject.tag;
        Debug.Log(yourTag + " / " +collision.gameObject.name);

        if (yourTag == "SmallStarTag")
        {
            score += 10;
        }
        else if (yourTag == "LargeStarTag")
        {
            score += 15;
        }
        else if (yourTag == "LargeCloudTag")
        {
            score += 20;
        }
        else if (yourTag == "SmallCloudTag")
        {
            score += 25;
        }
    
        SetScore();
        Debug.Log("ぶっかった" + score);

    }

    void SetScore()
  
    {
        scoreText.text = string.Format("Score:{0}", score);
    }



    // Update is called once per frame
    void Update () {
		
	}
}
