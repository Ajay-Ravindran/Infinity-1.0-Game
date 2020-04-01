using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endGame : MonoBehaviour
{
    public static bool GameOver = false;
    public GameObject endGameUI,backimage, banner;
    public Checkpointm resScript;
    public Checkpoint8 resScript8;
    public CheckpointA resScriptA;
    public CheckpointB resScriptB;
    public Checkpointe resScripte;
    public Checkpoint0 resScript0;
    Scene scene;

    // Update is called once per frame
    void Update()
    {
        if (GameOver){
            banner.SetActive(false);
            backimage.SetActive(true);
            endGameUI.SetActive(true);
        }
    }
    public void Home(){
        endGameUI.SetActive(false);
        backimage.SetActive(false);
        GameOver = false;
        SceneManager.LoadScene (sceneName:"ui");
    }
    public void Restart(){
        // Scene scene = SceneManager.GetActiveScene();
        endGameUI.SetActive(false);
        backimage.SetActive(false);
        GameOver = false;
        scene = SceneManager.GetActiveScene();
        if (scene.name == "Levelm")
            resScript.Restart();
        else if (scene.name == "Level0"){
            print("here");
            Checkpoint0.Restart();
        }
        else if (scene.name == "LevelA")
            resScriptA.Restart();
        else if (scene.name == "LevelB")
            resScriptB.Restart();
        else if (scene.name == "Levele")
            resScripte.Restart();
        else if (scene.name == "LevelEight")
            resScript8.Restart();
    }
    public void Next(){
        endGameUI.SetActive(false);
        backimage.SetActive(false);
        GameOver = false;
        scene = SceneManager.GetActiveScene();
        if(scene.name == "LevelEight")
            SceneManager.LoadScene ("LevelA");
        else if(scene.name == "LevelA")
            SceneManager.LoadScene ("Levele");
        else if(scene.name == "Levele")
            SceneManager.LoadScene ("Level0");
        else if(scene.name == "Level0")
            SceneManager.LoadScene ("Levelm");
        else if(scene.name == "Levelm")
            SceneManager.LoadScene ("LevelB");
        else if(scene.name == "LevelB")
            SceneManager.LoadScene ("ui");
    }
}
