using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startgame : MonoBehaviour {
    public string leveltoload;

    public void loadlevel(){
        SceneManager.LoadScene(leveltoload);
    }

}
