using UnityEngine;

public class Flower_Pickup : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("touch");
        if (col.gameObject.name == "Fool")
        {
            // give fool the bindle 
            col.gameObject.GetComponent<Inventory>().flower=true;
            gameObject.SetActive(false);
            col.gameObject.GetComponent<Player_Controls>().jumps=2;
            Debug.Log("the fool has the flower PLAY DOUBLE JUMP ANIMATION HERE");
        }
        
    }
}
