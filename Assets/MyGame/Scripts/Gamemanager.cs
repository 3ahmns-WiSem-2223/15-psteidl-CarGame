using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gamemanager : MonoBehaviour
{
    public bool collected;
    public int score;
    [SerializeField]
    string scoretext;
    [SerializeField]
    TextMeshProUGUI text;
    public bool itemspawning1;
    public bool itemspawning2;
    public bool itemspawning3;
    public bool itemspawning4;
    public bool itemspawning5;
    public bool itemspawning6;
    public bool itemspawning7;



    private void Start()
    {
    }

    private void Update()
    {
        scoretext = score.ToString();
        text.text = scoretext;
    }
}
