using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineManager : MonoBehaviour
{
    public int totalLaps = 3;
    private int currentLap = -1;

    void OnTriggerEnter(Collider lapDone)
    {
        if (lapDone.gameObject.tag == "Player")
        {
            currentLap++;
            Debug.Log("Current Lap: " + currentLap + "/3");

            if (currentLap >= totalLaps)
            {
                Debug.Log("You Win");
            }
        }   
    }
}
