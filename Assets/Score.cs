using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public  TextMeshProUGUI uGUI;
         

    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        uGUI.text = score.ToString();
    }
}
