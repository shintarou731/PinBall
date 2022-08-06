using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    // HingeJoint�R���|�[�l���g������
    private HingeJoint myHingeJoint;

    // �����̌X��
    private float defaultAngle = 20;

    // �͂��������̌X��
    private float flickAngle = -20;

    // Start is called before the first frame update
    void Start()
    {
        // HingeJoint�R���|�[�l���g�擾
        this.myHingeJoint = GetComponent<HingeJoint>();

        // �t���b�p�[�̌X����ݒ�
        SetAngle(this.defaultAngle);

    }

    // Update is called once per frame
    void Update()
    {
        // �����L�[���������Ƃ����t���b�p�[�𓮂���
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        // �E���L�[���������Ƃ��E�t���b�p�[�𓮂���
        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        // �����L�[�������ꂽ���t���b�p�[�����ɖ߂�
        if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        // �E���L�[�������ꂽ���t���b�p�[�����ɖ߂�
        if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }


        // A�L�[���������Ƃ����t���b�p�[�𓮂���
        if (Input.GetKeyDown(KeyCode.A) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        // D�L�[���������Ƃ��E�t���b�p�[�𓮂���
        if (Input.GetKeyDown(KeyCode.D) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        // S�L�[���������Ƃ����E�t���b�p�[�𓮂���
        if (tag == "LeftFripperTag" || tag == "RightFripperTag")
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                SetAngle(this.flickAngle);
            }
        }

        // A�L�[�������ꂽ���t���b�p�[�����ɖ߂�
        if (Input.GetKeyUp(KeyCode.A) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        // D�L�[�������ꂽ���t���b�p�[�����ɖ߂�
        if (Input.GetKeyUp(KeyCode.D) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        // S�L�[�������ꂽ�����E�t���b�p�[�����ɖ߂�
        if (tag == "LeftFripperTag" || tag == "RightFripperTag")
        {
            if (Input.GetKeyUp(KeyCode.S))
            {
                SetAngle(this.defaultAngle);
            }
        }

        // �^�b�`����
        if(Input.touchCount > 0)
        {
            // �^�b�`�����擾
            foreach (Touch _touch in Input.touches)
            {
                // ��ʂ̍����Ń^�b�v�������A���t���b�p�[�𓮂���
                if (_touch.phase == TouchPhase.Began && tag == "LeftFripperTag")
                {
                    if(_touch.position.x <= 540 )
                    {
                        SetAngle(this.flickAngle);
                    }
                }
            

                // ��ʂ̉E���Ń^�b�v�������A�E�t���b�p�[�𓮂���
                if (_touch.phase == TouchPhase.Began && tag == "RightFripperTag")
                {
                    if (_touch.position.x > 540)
                    {
                        SetAngle(this.flickAngle);
                    }
                }

                // ��ʂ̍����Ń^�b�v�������A���t���b�p�[�𓮂���
                if (_touch.phase == TouchPhase.Ended && tag == "LeftFripperTag")
                {
                    if (_touch.position.x <= 540)
                    {
                        SetAngle(this.defaultAngle);
                    }
                }

                // ��ʂ̉E���Ń^�b�v�������A�E�t���b�p�[�𓮂���
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

    //�t���b�p�[�̌X����ݒ�
    public void SetAngle (float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;

    }
}
