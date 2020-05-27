using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class GameManager : MonoBehaviour
{
    bool GameEnd = false;
    AudioSource audioClip;

    public AudioClip HexComplete;
    public AudioClip NormalButtns;
    public AudioClip HexTouch;
    public GameObject GameOverUI;
    public float RestartDelay = 1f;
    public Text ScoreText;

    
    // number of hits scored.
    private int mHits;
    int select;

    public void Start()
    {
        mHits = PlayerPrefs.GetInt("score", 0);
        audioClip = GetComponent<AudioSource>();
        
      
    }
    public void GameOver()
    {
      audioClip.PlayOneShot(HexTouch, 1f);
      ScoreText.text = mHits.ToString();
      GamePaused();
      GameOverUI.SetActive(true);
    }

    public void GoHome()
    {
        audioClip.PlayOneShot(NormalButtns, 1f);
     
        mHits = 0;
        PlayerPrefs.SetInt("score", mHits);
        Hexa.GammePaused = false;
        SceneManager.LoadScene(0);
    }
   

    public void IncrementHits()
    {
        audioClip.PlayOneShot(HexComplete, 1f);
        mHits = mHits + 1;
    
    }

    public void GamePaused()
    {
        Hexa.GammePaused = true;
    }

   
    
    public void FacebookOpen()
    {
        audioClip.PlayOneShot(NormalButtns, 1f);
        Application.OpenURL("https://www.facebook.com/thestraightuptech/");
    }

    public void InstaOpen()
    {
        audioClip.PlayOneShot(NormalButtns, 1f);
        Application.OpenURL("https://www.instagram.com/thestraightuptech/");
    }

   

    public void Review()
    {
        audioClip.PlayOneShot(NormalButtns, 1f);
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.Straightuptech.Hexzer");
    }

}

