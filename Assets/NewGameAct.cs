using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class NewGameAct : MonoBehaviour
{

    public TMP_InputField inputName;
    public AudioSource audioSource;
    public AudioClip clipClick;     /// / 
    /// </summary>  // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {

        string userName = inputName.text;
        if (userName.Length <= 0)
        {
            userName = "none";
        }

        PlayerPrefs.SetString("userName", userName);
        SceneManager.LoadScene("StarFightScene");
    }
    public void playClick()
    {
        audioSource.PlayOneShot(clipClick, 1.0f);
    }
}
