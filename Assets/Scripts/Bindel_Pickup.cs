using UnityEngine;

public class Bindel_Pickup : MonoBehaviour
{
    public GameObject bindelPanel;

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
            col.gameObject.GetComponent<Inventory>().bindle=true;
            gameObject.SetActive(false);
            bindelPanel.SetActive(true);
            Debug.Log("the fool");
        }
        
    }
}
