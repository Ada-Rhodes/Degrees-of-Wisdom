using UnityEngine;

public class Fall_Death : MonoBehaviour
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

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Fool")
        {
            // play sound
            // subtract flower petal 
            // return to check point
        }
    }
}
