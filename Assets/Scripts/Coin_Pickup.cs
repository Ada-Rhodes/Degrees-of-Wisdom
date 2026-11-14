using UnityEngine;

public class Coin_Pickup : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    AudioSource coinBlip;
    
    void Start()
    {
        coinBlip=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("touch");
        coinBlip.Play();
        if (collision.gameObject.name == "Fool")
        {
            // give fool the bindle 
            collision.gameObject.GetComponent<Inventory>().coins+=1;
            Coin_Purse.instance.coinBlips(collision.gameObject.GetComponent<Inventory>().coins);
            Debug.Log("+1 Coins = " + collision.gameObject.GetComponent<Inventory>().coins);
            gameObject.SetActive(false);
            
        }
        
    }
}
