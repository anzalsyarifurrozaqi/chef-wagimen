using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void OnPlay(){
        SceneManager.LoadScene("Play");
    }
    public void OnBack(){
        SceneManager.LoadScene("Menu");
    }
    public void OnHelp(){
        SceneManager.LoadScene("Help");
    }
    public void OnCredits(){
        SceneManager.LoadScene("Credits");
    }
    public void OnSetting(){
        SceneManager.LoadScene("Setting");
    }
    public void OnExit(){
        SceneManager.LoadScene("Exit");
    }
    public void OnStage1(){
        SceneManager.LoadScene("Stage1");
    }
    public void OnStage2(){
        SceneManager.LoadScene("Stage2");
    }
    public void OnStage3(){
        SceneManager.LoadScene("Stage3");
    }
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
