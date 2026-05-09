using UnityEngine;

public class Flower_Pickup : MonoBehaviour
{
    public GameObject checkPoint;
    public GameObject southButtonPanel;
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
            collision.gameObject.GetComponent<Inventory>().flower=true;
            Quest_Items.instance.SoundDadada();
            collision.gameObject.GetComponent<Status>().checkPoint = checkPoint;
            gameObject.SetActive(false);
            collision.gameObject.GetComponent<Player_Controls>().jumps=2;
            southButtonPanel.SetActive(true);
            Debug.Log("the fool has the flower PLAY DOUBLE JUMP ANIMATION HERE");
        }
        
    }
}
