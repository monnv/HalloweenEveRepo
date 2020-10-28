using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EveLine2 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public Animator appearAnimation;

    private void Start()
    {
        appearAnimation.ResetTrigger("Next 2");
    }

    private void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                NextSentence();
            }
        }
    }

    public void Continue()
    {
        StartCoroutine(Type());
        appearAnimation.ResetTrigger("Next");
        appearAnimation.ResetTrigger("Next 3");
    }

    IEnumerator Type()
    {
        yield return new WaitForSeconds(1f);
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

    }


    public void NextSentence()
    {
        appearAnimation.SetTrigger("Next 3");
        
    }
}
