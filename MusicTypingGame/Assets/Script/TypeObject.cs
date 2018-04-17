using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeObject : MonoBehaviour {

    public TextMesh stringTextMesh;
    public TextMesh alphabetTextMesh;
    TypingSystem ts;
    TypingTime typingTime;
    public Dictionary dictionary;

    [System.NonSerialized]
    public bool compulsionEnd = false;
    void Start()
    {
        
        ts = new TypingSystem();
        typingTime = FindObjectOfType<TypingTime>();
        ts.SetInputString(dictionary.GetRandomWord());
        UpdateText();
    }

    void Update()
    {
        string[] keys = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k",
                          "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v",
                          "w", "x", "y", "z", "-", };

   

        foreach (string key in keys)
        {
            if (Input.GetKeyDown(key))
            {
                if (ts.InputKey(key) == 1)
                {
                    UpdateText();
                }
                break;
            }
        }

        if (ts.isEnded() || compulsionEnd)
        {
            dictionary.i++;
            ts.SetInputString(dictionary.GetRandomWord());
            UpdateText();
            typingTime.SliderUpdate();
            compulsionEnd = false;
        }

    }

    void UpdateText()
    {
        stringTextMesh.text = "<color=red>" + ts.GetInputedString() + "</color>" + ts.GetRestString();
        alphabetTextMesh.text = "<color=red>" + ts.GetInputedKey() + "</color>" + ts.GetRestKey();
    }
}
