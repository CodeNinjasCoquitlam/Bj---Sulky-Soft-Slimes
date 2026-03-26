using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroFellOffDetection : MonoBehaviour
{
    [Header("Scripps")]
    public YouLose losescrip;
    [Header("good guys")]
    public int AmmountOfGuys;
    public int AmmountOfFallenGuys;
    public int AmmountOfFallGuysAllowed = 1;
    [Header("bad guys")]
    public int AmmountOfEvilGuys;
    public int AmmountOfEvilFallGuys;
    public int AmmountOfEvilFallGuysAllowed;

    void Start()
    {
        AmmountOfGuys = GameObject.FindGameObjectsWithTag("good").Length;
        AmmountOfEvilGuys = GameObject.FindGameObjectsWithTag("bad").Length;
        AmmountOfFallGuysAllowed = 1;
    }

    void Update() 
    { 
        if (AmmountOfFallenGuys == AmmountOfFallGuysAllowed)
        {
            losescrip.YouLoser();
            //Debug.Log("lose");
        }

        if (AmmountOfEvilFallGuys == AmmountOfEvilGuys)
        {
            losescrip.YouWEENER();
            //Debug.Log("win");
        }
    }
}
