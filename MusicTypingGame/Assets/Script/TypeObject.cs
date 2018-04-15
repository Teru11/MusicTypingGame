using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeObject : MonoBehaviour {

    public TextMesh stringTextMesh;
    public TextMesh alphabetTextMesh;
    TypingSystem ts;
    public string String;

    void Start()
    {
        
        ts = new TypingSystem();
        ts.SetInputString(String);
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
    }

    void UpdateText()
    {
        stringTextMesh.text = "<color=red>" + ts.GetInputedString() + "</color>" + ts.GetRestString();
        alphabetTextMesh.text = "<color=red>" + ts.GetInputedKey() + "</color>" + ts.GetRestKey();
    }
}
