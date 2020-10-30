using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMotion : MonoBehaviour
{
    public Animator animator;
    public GameObject door_axis;
    public bool isOpen;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        //animator = GetComponent<Animator>();
        animator = door_axis.GetComponent<Animator>();
        isOpen = false;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "MainCamera")
        if (/*other.CompareTag("MainCamera") ||*/ other.gameObject.tag == "RedKnight")
        {
            // Update hp info
            ShowInfo.hp--;
            animator.SetTrigger("Open");
            isOpen = true;
            //audioSource.Play();
            audioSource.PlayDelayed(0.5f);
        }
            
    }

    void OnTriggerExit(Collider other)
    {
        if (isOpen && other.gameObject.tag == "RedKnight")
        {
            animator.SetTrigger("Close");
            isOpen = false;
            //audioSource.Play();
            audioSource.PlayDelayed(0.5f);
        }

    }


}
