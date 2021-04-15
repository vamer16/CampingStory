using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelMouseDrag : MonoBehaviour
{
    private Vector3 lastpos;//位置记录
    private float speed = 10;//拖拽速度
    public AudioSource clickSound;//点击音效


    /// <summary>
    /// 鼠标点击记录樱桃位置
    /// </summary>
    private void OnMouseDown()
    {
        //三维物体坐标转屏幕坐标
        Vector3 screenSpace = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z);
        //物体的位置，屏幕坐标转换为世界坐标
        Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        lastpos = objectPosition;
        clickSound.Play();
    }
    /// <summary>
    /// 拖拽樱桃
    /// </summary>
    private void OnMouseDrag()
    {
        //三维物体坐标转屏幕坐标
        Vector3 screenSpace = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z);
        //物体的位置，屏幕坐标转换为世界坐标
        Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector3 offset = objectPosition - lastpos;
        Vector3 pos = transform.position + offset;
        transform.position = Vector3.Lerp(transform.position, new Vector3(pos.x, pos.y, pos.z), speed * Time.deltaTime * 10);
        lastpos = objectPosition;
    }
    /// <summary>
    /// 鼠标松开记录拾取个数，并销毁本身
    /// </summary>
    private void OnMouseUp()
    {
        GameManager._instance.index += 1;
        GameManager._instance.berryTxt.text = GameManager._instance.index.ToString();
        Destroy(gameObject);
    }
}
