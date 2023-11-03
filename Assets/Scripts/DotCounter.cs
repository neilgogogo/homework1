using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DotCounter : MonoBehaviour
{
    public int dotCountThreshold = 10;
    private int dotCount;
    private int dotCountCurrentTime;
    // Start is called before the first frame update
    void Start()
    {
        dotCount = GameObject.FindGameObjectsWithTag("dot").Length;
    }

    

    // Update is called once per frame
    void Update()
    {
        dotCountCurrentTime = GameObject.FindGameObjectsWithTag("dot").Length;
        
        if(dotCount - dotCountCurrentTime > dotCountThreshold)
        {
            
            //UnityEditor.SceneManagement.EditorSceneManager.LoadScene("win game");
            SceneManager.LoadScene("win game");   // 使用 SceneManager.LoadScene 加载场景
        }
    }
}
