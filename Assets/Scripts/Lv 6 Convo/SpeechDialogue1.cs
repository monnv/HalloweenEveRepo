using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpeechDialogue1 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public Animator appearAnimation;

    //private void Update()
    //{
        //if (textDisplay.text == sentences[index])
        //{
            //if (Input.GetKeyDown(KeyCode.Space))
            //{
                //NextSentence();
            //}
        //}
    //}

    public void Speak()
    {
        StartCoroutine(Type());
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
        if(index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
        }
    }
}

