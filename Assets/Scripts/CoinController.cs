using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CoinController : MonoBehaviour
{
    [SerializeField] public TMP_Text coinTXT;
    public int cont = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CoinNPC.takeCoin == true)
        {
            cont = cont + 100;            
            coinTXT.text = cont.ToString();
            CoinNPC.takeCoin = false;
        }

        if (HatStorageController.buyHat == true)
        {
            cont = cont - 10;            
            coinTXT.text = cont.ToString();
            HatStorageController.buyHat = false;
        }
    }
}
