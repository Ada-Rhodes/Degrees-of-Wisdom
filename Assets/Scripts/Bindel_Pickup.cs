using UnityEngine;

public class Bindel_Pickup : MonoBehaviour
{
    public GameObject bindelPanel;
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
            Quest_Items.instance.SoundDadada();
            Debug.Log("Sound not playing because the object deactivates before it can play, need a separate parent object with all important items");
            collision.gameObject.GetComponent<Inventory>().bindle=true;
            collision.gameObject.GetComponent<Status>().checkPoint = checkPoint;
            gameObject.SetActive(false);
            bindelPanel.SetActive(true);
            Debug.Log("the fool");
        }
        
    }
}
