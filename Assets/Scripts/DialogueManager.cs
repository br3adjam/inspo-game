using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{

    private Queue<string> text;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        Debug.Log("convo w/ " + dialogue.name);
    }
}
