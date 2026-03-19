using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public static int loadedCoins;
    public static int loadedDistance;

    public static bool saveData;

    [SerializeField] int internalCoin;
    [SerializeField] int internalDistance;

    void Start()
    {
        loadedCoins = PlayerPrefs.GetInt("COINSAVE");
        loadedDistance = PlayerPrefs.GetInt("DISTANCESAVE");
    }

    // Update is called once per frame
    void Update()
    {
        internalCoin = loadedCoins + MasterInfo.coinCount;
        internalDistance = loadedDistance + MasterInfo.distancerun;
        if (saveData == true)
        {
            saveData = false;
            PlayerPrefs.SetInt("COINSAVE", internalCoin);
            PlayerPrefs.SetInt("DISTANCESAVE", internalDistance);
        }
    }
}
