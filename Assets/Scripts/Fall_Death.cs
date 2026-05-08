using UnityEngine;

public class Fall_Death : MonoBehaviour
{
    AudioSource deathSound;
    public GameObject checkPoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        deathSound = GetComponent<AudioSource>();
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
            deathSound.Play();
            // subtract flower petal 
            Debug.Log("LOSE LIFE NOT IMPLEMENTED");
            // get player check point
            checkPoint=collision.gameObject.GetComponent<Status>().checkPoint;
            // return to check point
            float checkX = checkPoint.GetComponent<Transform>().position.x;
            float checkY = checkPoint.GetComponent<Transform>().position.y;
            Debug.Log("X:" + checkX + ", Y:"+checkY);
            collision.gameObject.GetComponent<Transform>().position = new Vector2(checkX,checkY); //checkPoint.GetComponent<Transform>().position.x,checkPoint.GetComponent<Transform>().position.y
        }
    }
}
