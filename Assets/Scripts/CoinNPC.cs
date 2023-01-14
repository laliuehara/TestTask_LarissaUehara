using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinNPC : MonoBehaviour
{
    public bool onTrigger;
    public GameObject panelCoinNPC;
    public GameObject player;
    public static bool takeCoin;

    // Start is called before the first frame update
    void Start()
    {
         panelCoinNPC.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("CollisionNPCcoin");
        if (collision.gameObject.Equals(player))
        {
            panelCoinNPC.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickBtnThanks()
    {
        panelCoinNPC.SetActive(false);
        takeCoin = true;
    }
}
