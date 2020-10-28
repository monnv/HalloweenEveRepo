using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpeechDialogue : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;



    //public GameObject continueButton;


    private void Update()
    {
        //if(textDisplay.text == sentences[index])
        //{
        //continueButton.SetActive(true);
        //}
    }

    public void Start()
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

    //Continue Button Bellow

    // public void NextSentence()
    //{
    //continueButton.SetActive(false);

    //if(index < sentences.Length - 1)
    //{
    //index++;
    //textDisplay.text = "";
    //StartCoroutine(Type());
    //}
    //else
    //{
    // textDisplay.text = "";
    //continueButton.SetActive(false);
    //}
    //}
}

