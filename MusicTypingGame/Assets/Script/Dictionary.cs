using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour {

    public TextAsset resouce;
    string[] words;

    [System.NonSerialized]
    public int i = 0;

    void Awake()
    {
        LoadDictionary();
    }

    public string GetRandomWord()
    {
        return words[i];
    }

    void LoadDictionary()
    {
        string trimedData = resouce.text.Replace("\r", "");
        char[] dem = { '\n' };
        words = trimedData.Split(dem);
    }
}
