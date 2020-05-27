using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour
{
    public Text Scoretext;
    int hex = 0;

    private void Start()
    {
        hex = PlayerPrefs.GetInt("score", 0);
        Scoretext.text = hex.ToString();
    }
    public void Scoreupdate()
    {
        hex = hex + 1;
        Scoretext.text = hex.ToString();
        FindObjectOfType<GameManager>().IncrementHits();
    }
}
