using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CafeGenerator : MonoBehaviour
{
    public List<string> names = new List<string>();
    public List<string> cafeNames = new List<string>();
    public List<string> description = new List<string>();

    public TextMeshProUGUI cafeTextObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string example = cafeNames[Random.Range(0,cafeNames.Count)];
        example = example.Replace("[name]", names[Random.Range(0,names.Count)]);
        int descIndex = 0;
        List<string> descWords = new List<string>();
        descWords.AddRange(description);
        do
        {
            descIndex = example.IndexOf("[desc]");
            if (descIndex >= 0)
            {
                example = example.Remove(descIndex, 6);
                int randWord = Random.Range(0, descWords.Count);
                example = example.Insert(descIndex, descWords[randWord]);
                descWords.RemoveAt(randWord);
            }
        } while (descIndex >= 0);
        

        Debug.Log(example);

        cafeTextObject.text = example;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Start();
        }
    }
}
