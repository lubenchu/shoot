using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotJump: MonoBehaviour
{
    //���������
    public float JumpGravity = 1000f;
    //����
    public Rigidbody rg;
    void Start()
    {
        //Ѱ�Ҹ������
        rg = this.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //�ж��Ƿ��¿ո�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rg.velocity = new Vector3(rg.velocity.x, JumpGravity * Time.deltaTime, rg.velocity.z);

        }
    }
}
