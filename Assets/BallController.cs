using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BallController : MonoBehaviour
{
    // �{�[����������\���̂���z���̍ŏ���
    private float visiblePosZ = -6.5f;

    // �Q�[���I�[�o�[��\������e�L�X�g
    private GameObject gameoverText;

    // �X�R�A��\������e�L�X�g
    private GameObject scoreText;

    // �X�R�A��錾
    private int Score_i = 0;



    // �召�̐��Ɖ_�ɏՓ˂����ۂɓ��_���Z
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
        // �V�[������GameOverText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("GameOverText");

        // �V�[������ScoreText�I�u�W�F�N�g���擾
        this.scoreText = GameObject.Find("ScoreText");


    }

    // Update is called once per frame
    void Update()
    {
        // �{�[������ʊO�ɏo���ꍇ
        if (this.transform.position.z < this.visiblePosZ) 
        {
            // gameoverText�ɃQ�[���I�[�o�[��\��
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

        // scoreText�ɓ��_��\������Bint�^��String�^�փR���o�[�g
        this.scoreText.GetComponent<Text>().text = Convert.ToString(this.Score_i);

    }
}
