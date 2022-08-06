using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    // HingeJointコンポーネントを入れる
    private HingeJoint myHingeJoint;

    // 初期の傾き
    private float defaultAngle = 20;

    // はじいた時の傾き
    private float flickAngle = -20;

    // Start is called before the first frame update
    void Start()
    {
        // HingeJointコンポーネント取得
        this.myHingeJoint = GetComponent<HingeJoint>();

        // フリッパーの傾きを設定
        SetAngle(this.defaultAngle);

    }

    // Update is called once per frame
    void Update()
    {
        // 左矢印キーを押したとき左フリッパーを動かす
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        // 右矢印キーを押したとき右フリッパーを動かす
        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        // 左矢印キーが離された時フリッパーを元に戻す
        if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        // 右矢印キーが離された時フリッパーを元に戻す
        if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }


        // Aキーを押したとき左フリッパーを動かす
        if (Input.GetKeyDown(KeyCode.A) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        // Dキーを押したとき右フリッパーを動かす
        if (Input.GetKeyDown(KeyCode.D) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        // Sキーを押したとき左右フリッパーを動かす
        if (tag == "LeftFripperTag" || tag == "RightFripperTag")
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                SetAngle(this.flickAngle);
            }
        }

        // Aキーが離された時フリッパーを元に戻す
        if (Input.GetKeyUp(KeyCode.A) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        // Dキーが離された時フリッパーを元に戻す
        if (Input.GetKeyUp(KeyCode.D) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        // Sキーが離された時左右フリッパーを元に戻す
        if (tag == "LeftFripperTag" || tag == "RightFripperTag")
        {
            if (Input.GetKeyUp(KeyCode.S))
            {
                SetAngle(this.defaultAngle);
            }
        }

        // タッチ処理
        if(Input.touchCount > 0)
        {
            // タッチ情報を取得
            foreach (Touch _touch in Input.touches)
            {
                // 画面の左側でタップした時、左フリッパーを動かす
                if (_touch.phase == TouchPhase.Began && tag == "LeftFripperTag")
                {
                    if(_touch.position.x <= 540 )
                    {
                        SetAngle(this.flickAngle);
                    }
                }
            

                // 画面の右側でタップした時、右フリッパーを動かす
                if (_touch.phase == TouchPhase.Began && tag == "RightFripperTag")
                {
                    if (_touch.position.x > 540)
                    {
                        SetAngle(this.flickAngle);
                    }
                }

                // 画面の左側でタップした時、左フリッパーを動かす
                if (_touch.phase == TouchPhase.Ended && tag == "LeftFripperTag")
                {
                    if (_touch.position.x <= 540)
                    {
                        SetAngle(this.defaultAngle);
                    }
                }

                // 画面の右側でタップした時、右フリッパーを動かす
                if (_touch.phase == TouchPhase.Ended && tag == "RightFripperTag")
                {
                    if (_touch.position.x > 540)
                    {
                        SetAngle(this.defaultAngle);
                    }
                }


            }
        }
    }

    //フリッパーの傾きを設定
    public void SetAngle (float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;

    }
}
