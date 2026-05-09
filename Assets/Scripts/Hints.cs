using UnityEngine;
using TMPro;
using Unity.Burst.CompilerServices;

public class Hints : MonoBehaviour
{
    public static Hints instance;
    public TMP_Text hintText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Instantiate Hint List");
        if (instance == null)
        {
            instance = this; // set the static instance to this object
        }
        else
        {
            Destroy(gameObject); // destroy duplicate instances
        }
        //hintText.text = "test";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HintDisplay(int hintNumber)
    {
        switch (hintNumber)
        {
            case 0:
                hintText.text = "";
            break;
            case 1:
                hintText.text = "Use D-Pad, Left-Stick, or WASD to MOVE";
            break;
            case 2: 
                hintText.text = "Press A to JUMP";
            break;
            case 3:
                hintText.text = "The bindel lets you store items you pick up";
            break;
            case 4:
                hintText.text = "That tarot card may be useful later";
            break;
            case 5:
                hintText.text = "When holding the flower you can DOUBLE JUMP";
            break;
            case 6:
                hintText.text = "Double tap the jump button quickly to jump further";
            break;
            case 7:
                hintText.text = "You are The Fool, seek wisdom at the mountains peak";
            break;
            case 8:
                hintText.text = "Level Completed";
            break;
            case 9:
                hintText.text = "Leap towards the wisdom that lies below";
            break;
        }
    }
}
