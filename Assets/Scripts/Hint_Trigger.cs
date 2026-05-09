using UnityEngine;

public class Hint_Trigger : MonoBehaviour
{
    public int hintNumber;
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
        if (collision.gameObject.name == "Fool")
        {
            // Make hit popup visible
            Hints.instance.HintDisplay(hintNumber);
            //edit hint text 
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Fool")
        {
            // Make hit popup go away
            //clear hint text 
            Hints.instance.HintDisplay(0);
        }
    }
}
