using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterInfo : MonoBehaviour
{
    public static int coinCount = 0;
    [SerializeField] GameObject coinDisplay;
    public static int distancerun;
    [SerializeField] int internaldistance;
    [SerializeField] GameObject RunDisplay;

    void start()
    {
        coinCount = 0;
        distancerun = 0;
    }
    void Update()
    {
        internaldistance = distancerun;
        coinDisplay.GetComponent<TMPro.TMP_Text>().text = "" + coinCount;
       RunDisplay.GetComponent<TMPro.TMP_Text>().text = "" + distancerun;
    }
}