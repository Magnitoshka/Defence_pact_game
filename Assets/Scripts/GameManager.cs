using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

 public static GameManager instance;

    private void Awake()
    {
        instance = this; 
    
    }


    public Transform playerTransform; 
}

public class ExampleClass : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))  // ���� ������ ������� Esc (Escape)
        {
            Application.Quit();    // ������� ����������
            Debug.Log("ESCAPE");
        }
    }
}