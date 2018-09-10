using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StringReader : MonoBehaviour {

    private Queue<string> sentences;
    
    public Text dialogueText;

    //public Animator animator;

	// Use this for initialization
	void Start () {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        //animator.SetBool("IsOpen", true);
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();

    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sent = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSenetence(sent));
    }

    IEnumerator TypeSenetence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    public void EndDialogue()
    {
        //animator.SetBool("IsOpen", false);
    }

    //void Update()
    //{
    //    if (time >= readingtimer)
    //    {
    //        if(!IsStringEmpty())
    //            textDisplay.text = textDisplay.text + Read();
    //        time = 0.0f;
    //    }
    //    else
    //        time += Time.deltaTime;
    //}

    //public bool IsStringEmpty()
    //{
    //    return myString == "";
    //}

    //public string Read()
    //{
    //    switch (Type)
    //    {
    //        case ReaderType.Char:
    //            {
    //                string returned = myString[0].ToString();
    //                myString = myString.Remove(0, 1);
    //                return returned;
    //            }
    //        case ReaderType.Delimiter:
    //            {
    //                int indexof = myString.IndexOfAny(delimiter);
    //                if (indexof == -1)
    //                {
    //                    string returned = myString;
    //                    myString = "";
    //                    return returned;
    //                }
    //                else
    //                {
    //                    string returned = myString.Substring(0, indexof + 1);
    //                    myString = myString.Remove(0, indexof + 1);
    //                    return returned;
    //                }
    //            }

    //        case ReaderType.Whole:
    //            {
    //                string returned = myString;
    //                myString = "";
    //                return returned;
    //            }
    //    }

    //    return "";
    //}


}
