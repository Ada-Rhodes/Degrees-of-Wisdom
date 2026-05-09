using UnityEngine;

public class Tarot_Card : MonoBehaviour
{
    public GameObject checkPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("touch");
        if (collision.gameObject.name == "Fool")
        {
            // give fool the bindle 
            collision.gameObject.GetComponent<Inventory>().tarotCards+=1;
            Quest_Items.instance.SoundDadada();
            collision.gameObject.GetComponent<Status>().checkPoint = checkPoint;
            gameObject.SetActive(false);
            Debug.Log("Acquire a tarot card");
        }
        
    }
}
