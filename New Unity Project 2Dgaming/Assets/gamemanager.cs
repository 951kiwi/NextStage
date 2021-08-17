using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public block[] blocks;
    public GameObject gameOverUI;
    public GameObject gameClearUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DestroyAllBlocks())
        {
            //ゲームクリア
            Debug.Log("クリア");
            gameClearUI.SetActive(true);
            GameObject ball = GameObject.Find(ball);
            Destroy(ball);
        }
    }

    private bool DestroyAllBlocks()
    {
        foreach(block b in blocks)
        {
            if(b != null)
            {
                return false;
            }
        }
        return true;
    }
    public void GameOver()
    {
        Debug.Log("GO");
        gameOverUI.SetActive(true);
    }
    public void GameRetry()
    {
        SceneManager.LoadScene("Block-des");
    }

}
