using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logicscript : MonoBehaviour
{
    // Start is called before the first frame update

   
    public int playerscore=0;

    public Text scoretxt;

    public GameObject gameoverscreen;
    void Start()
    {
        scoretxt.text = playerscore.ToString();
    }
   
    [ContextMenu("Increase Score")] 
    public void scorefun(int scr)
    {
        playerscore = playerscore + scr;
        scoretxt.text=playerscore.ToString();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

    public void gameover()
    {
        gameoverscreen.SetActive(true);
    }
    
}
