using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThoughtPoint : MonoBehaviour
{
    public GameObject gameObject;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<ThoughtDialogue>().Typing();
            gameObject.SetActive(false);
        }
    }


}
