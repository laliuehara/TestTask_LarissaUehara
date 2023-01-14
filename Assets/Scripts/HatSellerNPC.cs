using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatSellerNPC : MonoBehaviour
{
    public bool onTrigger;
    public GameObject panelHatNPC;
    public GameObject player;
    public GameObject hatStorage;

    // Start is called before the first frame update
    void Start()
    {
         panelHatNPC.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("CollisionHatNPC");
        if (collision.gameObject.Equals(player))
        {
            panelHatNPC.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BtnYes()
    {
        panelHatNPC.SetActive(false);
        hatStorage.SetActive(true);
    }

    public void BtnNo()
    {
        panelHatNPC.SetActive(false);
    }
}
