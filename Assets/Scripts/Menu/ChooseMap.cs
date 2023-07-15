using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseMap : MonoBehaviour
{
    public int map = 0;
        
    public void chooseCreateMap()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void chooseMap1()
    {
        map = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void chooseMap2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void chooseMap3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    public void chooseMap4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }
    public void backFromCreateMap()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Time.timeScale = 1.0f;
    }
    public void backFromMap1()
    {
        map = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        Time.timeScale = 1.0f;
    }
    public void backFromMap2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        Time.timeScale = 1.0f;
    }
    public void backFromMap3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
        Time.timeScale = 1.0f;
    }
}
