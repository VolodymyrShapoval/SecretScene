using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int counter;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        while(counter < 10)
            text.text = "Huh...";
        text.text = "Oh yeah!";
    }
    public void ButClick()
    {
        counter++;
        Debug.Log(counter);
    }
}