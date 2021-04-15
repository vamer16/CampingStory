using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //获取角色控制器

    public CharacterController playerCC;

    //摄像机

    private Camera Mcamera;

    //移动速度

    public float speed = 5f;

    //跳跃距离

    public float vy = 0;

    //重力

    public float groayt = -2;

    //摄像机高度

    public float cmcmHeight = 0.5f;

    // Use this for initialization

    void Start()
    {

        //获取主摄像机（角色摄像机）

        Mcamera = Camera.main;

    }

    // Update is called once per frame

    void Update()
    {

        //调用Move()函数

        Move();


    }

    /// <summary>

    /// 移动函数

    /// </summary>

    private void Move()

    {

        //轴输入

        float h = Input.GetAxis("Horizontal");

        float v = Input.GetAxis("Vertical");

        if (!playerCC.isGrounded)

        {

            vy += groayt * Time.deltaTime;

        }
        //利用角色控制器进行移动

        playerCC.Move(playerCC.transform.TransformDirection(new Vector3(h, vy, v) * speed * Time.deltaTime));

    }
}
