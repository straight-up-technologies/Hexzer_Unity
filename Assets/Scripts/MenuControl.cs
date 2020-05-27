using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{
    public GameObject Information;
    public GameObject SignIn;
    public Text SignInText;
    public AudioClip PlayButton;
    public AudioClip NormalButton;

    

    AudioSource AudioPlay;
   

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("score", 0);

        AudioPlay = GetComponent<AudioSource>();

      
    }

   
   
    public void StartGame()
    {
               AudioPlay.PlayOneShot(PlayButton, 1f);
        SceneManager.LoadScene(1);
    }

    public void InstaOpen()
    {
        AudioPlay.PlayOneShot(NormalButton, 1f);
        Application.OpenURL("https://www.instagram.com/thestraightuptech/");
    }

    public void ShowAchievments()
    {
        AudioPlay.PlayOneShot(NormalButton, 1f);
       
    }

    public void ShowLeaderBoards()
    {
        AudioPlay.PlayOneShot(NormalButton, 1f);

    }

  
    public void Info()
    {
        AudioPlay.PlayOneShot(NormalButton, 1f);
        Information.SetActive(true);
        StartCoroutine(ClosePanel());
    }

   public void Review()
    {
        AudioPlay.PlayOneShot(NormalButton, 1f);
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.Straightuptech.Hexzer");
    }

    IEnumerator ClosePanel()
    {
        yield return new WaitForSeconds(2);
        SignInText.text = " ";
        Information.SetActive(false);
        SignIn.SetActive(false);
    }
}
