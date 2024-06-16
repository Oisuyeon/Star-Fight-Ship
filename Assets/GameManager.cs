using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioClip clipMissile;
    public AudioClip clipExplosion;
    public AudioSource audioSource;
    public AudioClip clipClick;         ///
    public TMP_Text textScore;
    public TMP_Text textBestName;
    public TMP_Text textBestScore;
    int score = 0;
    int bestScore = 0;
    string userName;
    string bestName;

    // Start is called before the first frame update
    void Start()
    {
        
        userName = PlayerPrefs.GetString("userName");

        bestName = PlayerPrefs.GetString("bestName");
        bestScore = PlayerPrefs.GetInt("bestScore");
        if (bestName.Length <= 0)
        {
            bestName = "none";
            bestScore = 0;
        }

        textBestName.text = bestName;
        textBestScore.text = bestScore.ToString();
        print("userName = " + userName);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
          
            if (score > bestScore)
            {
                PlayerPrefs.SetString("bestName", userName);
                PlayerPrefs.SetInt("bestScore", score);
                print("best : " + userName + " = " + score);

            }
            SceneManager.LoadScene("EndGameScene");
        }
    }

    public int getScore() { return score; }
    public void incScore()
    {
        score++;
        showScore();
    }
    public void decScore()
    {
        score--;
       showScore();
    }

    public void showScore()
    {
        textScore.text = score.ToString();
    }

    public void playMissile()
    {
        audioSource.PlayOneShot (clipMissile, 1.0f);
    }

    public void playExplosion()
    {
        audioSource.PlayOneShot(clipExplosion, 1.0f);
    }


  
}
