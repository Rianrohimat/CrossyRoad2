using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    public void Play(){
        SceneManager.LoadScene("GamePlay");
    }

    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
    
    public void Quit(){
        Application.Quit();
    }
}
