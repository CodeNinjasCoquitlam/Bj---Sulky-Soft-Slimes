using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroFellOffDETECORRRRRRRRRRR : MonoBehaviour
{
    private BroFellOffDetection mainScrip;

    void Start()
    {
        mainScrip = GameObject.Find("platform").GetComponent<BroFellOffDetection>();
    }

    void OnTriggerExit(Collider thingy)
    {
        if (thingy.tag == "bad")
        {
            mainScrip.AmmountOfEvilFallGuys++;
        }
        if (thingy.tag == "good")
        {
            mainScrip.AmmountOfFallenGuys++;
        }
    }
}
