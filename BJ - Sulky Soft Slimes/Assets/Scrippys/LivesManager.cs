using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesManager : MonoBehaviour
{
    [Header("Lives")]
    public int Lives;
    [Header("Heart UI Objects")]
    public GameObject[] Hearts;
    public GameObject LivesContainer;

    private YouLose losescrip;
    
    
    public void RemoveLife()
    {
        Lives -= 1;
    }
    void Start()
    {
        losescrip = GameObject.Find("GameManager").GetComponent<YouLose>();
    }

    
    void Update()
    {
        if (Lives <= 0)
        {
            losescrip.YouDie();
        }
    }
}
