using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HollyLine1 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public Animator appearAnimation;

    private void Start()
    {
        appearAnimation.ResetTrigger("Next");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextSentence();
        }
    }

    public void Continue()
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
        appearAnimation.SetTrigger("Next");
    }
}
