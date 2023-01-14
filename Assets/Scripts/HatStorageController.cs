using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatStorageController : MonoBehaviour
{
    public GameObject panelHatStorage;
    public GameObject hat1, hat2, hat3;
    public static bool buyHat;
    public void BuyHat1()
    {
        panelHatStorage.SetActive(false);
        hat1.SetActive(true);
        hat2.SetActive(false);
        hat3.SetActive(false);

        buyHat = true;
    }

    public void BuyHat2()
    {
        panelHatStorage.SetActive(false);
        hat2.SetActive(true);
        hat1.SetActive(false);
        hat3.SetActive(false);

        buyHat = true;
    }

    public void BuyHat3()
    {
        panelHatStorage.SetActive(false);
        hat3.SetActive(true);
        hat2.SetActive(false);
        hat1.SetActive(false);

        buyHat = true;
    }

    public void Skip()
    {
        panelHatStorage.SetActive(false);
    }

    
}
