using UnityEngine;
using TMPro;

public class Coin_Purse : MonoBehaviour
{
    public static Coin_Purse instance;
    public TMP_Text coinCounter;
    AudioSource coinBlip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Instantiate Coin Purse");
        if (instance == null)
        {
            instance = this; // set the static instance to this object
        }
        else
        {
            Destroy(gameObject); // destroy duplicate instances
        }
        coinBlip=GetComponent<AudioSource>();
    }

    public void coinBlips(int coinCount)
    {
        coinCounter.text = coinCount.ToString();
        coinBlip.Play();
    }
}
