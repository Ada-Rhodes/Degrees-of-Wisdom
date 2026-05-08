using UnityEngine;

public class Quest_Items : MonoBehaviour
{
    public static Quest_Items instance;
    AudioSource daDaDaDaSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Instantiate Quest Items");
        if (instance == null)
        {
            instance = this; // set the static instance to this object
        }
        else
        {
            Destroy(gameObject); // destroy duplicate instances
        }
        daDaDaDaSound=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SoundDadada()
    {
        daDaDaDaSound.Play();
    }
}
