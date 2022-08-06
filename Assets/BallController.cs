using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BallController : MonoBehaviour
{
    // ボールが見える可能性のあるz軸の最小幅
    private float visiblePosZ = -6.5f;

    // ゲームオーバーを表示するテキスト
    private GameObject gameoverText;

    // スコアを表示するテキスト
    private GameObject scoreText;

    // スコアを宣言
    private int Score_i = 0;



    // 大小の星と雲に衝突した際に得点加算
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "SmallStar")
        {
            this.Score_i += 10;
        }
        else if (collision.gameObject.name == "SmallStarPrefab")
        {
            this.Score_i += 10;
        }
        else if (collision.gameObject.name == "SmallStarPrefab (1)")
        {
            this.Score_i += 10;
        }
        else if (collision.gameObject.name == "SmallStarPrefab (2)")
        {
            this.Score_i += 10;
        }
        else if (collision.gameObject.name == "SmallStarPrefab (3)")
        {
            this.Score_i += 10;
        }
        else if(collision.gameObject.name == "LargeStar")
        {
            this.Score_i += 30;
        }
        else if (collision.gameObject.name == "LargeStarPrefab")
        {
            this.Score_i += 30;
        }
        else if (collision.gameObject.name == "LargeStarPrefab (1)")
        {
            this.Score_i += 30;
        }
        else if(collision.gameObject.name == "SmallCloud")
        {
            this.Score_i += 20;
        }
        else if (collision.gameObject.name == "SmallCloudPrefab")
        {
            this.Score_i += 20;
        }
        else if(collision.gameObject.name == "LargeCloud")
        {
            this.Score_i += 40;
        }
        else
        {
            this.Score_i += 0;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");

        // シーン中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");


    }

    // Update is called once per frame
    void Update()
    {
        // ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ) 
        {
            // gameoverTextにゲームオーバーを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

        // scoreTextに得点を表示する。int型→String型へコンバート
        this.scoreText.GetComponent<Text>().text = Convert.ToString(this.Score_i);

    }
}
