using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public bool isdead = false, won, isGameStarted = false;
    public GameObject winPanel;
    public GameObject losePanel;
    public GameObject startText;

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Enemy"){//if enemy catches witch we lose
            isdead = true;
            losePanel.SetActive(true);
            won = false;
        }

        if (collision.gameObject.tag == "Finish"){//if witch passes finish line we win
            isdead = true;
            winPanel.SetActive(true);
            won = true;
        }
    }

    void Start() {//shows start text in the beginning
        {
            Time.timeScale = 1;
            isdead = false;
            isGameStarted = false;
            startText.SetActive(true);
        }
    }

    void Update() {
        
            if (isdead && won)//starts game again after winning
            {
                winPanel.SetActive(true);
                Time.timeScale = 0;
                 if(Input.GetMouseButtonDown(0))
                    {
                        winPanel.SetActive(false);
                        SceneManager.LoadScene(0);
                    }
            }

            if (isdead && !won)//starts game again after losing
            {
                losePanel.SetActive(true);
                Time.timeScale = 0;
                if(Input.GetMouseButtonDown(0))
                {
                    losePanel.SetActive(false);
                    SceneManager.LoadScene(0);
                    Time.timeScale = 0;
                }
            }

            if(Input.GetMouseButtonDown(0))//tap to start
            {
                isGameStarted = true;
                startText.SetActive(false);
            }
        }
}
    

