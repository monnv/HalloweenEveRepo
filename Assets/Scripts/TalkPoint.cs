using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkPoint : MonoBehaviour
{

    public GameObject gameObject;
    public GameObject Convo;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Convo.SetActive(true);
            FindObjectOfType<SpeechDialogue>().Speak();
            gameObject.SetActive(false);
        }
    }

}
