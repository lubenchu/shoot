using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerDied : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameObject Obj;
  
    void Start()//start()һ��ʼ������Ϸ�ͽ��е���
    {
        Obj = GameObject.Find("Image");//�ҵ�Button����
        this.GetComponent<Button>().onClick.AddListener(OnClick);//���ü���
        Obj.SetActive(false);//��������


    }
    void OnClick()
    {
        Obj.SetActive(true);//��������
       
    }
}
