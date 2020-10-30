using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnightBehaviour : MonoBehaviour
{
    public Text greetings;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RedKnight")
        {
            greetings.text = "Hello, i am a Iron Knight. Who are you ?";
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "RedKnight")
        {
            greetings.text = "";
        }

    }
}
