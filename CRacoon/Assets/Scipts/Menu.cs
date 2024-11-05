using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
     public void StartGame()
    {
        if (PlayerPrefs.HasKey("SaveGame"))
        {
            SceneManager.LoadScene("University");
        }
        else
        {
            PlayerPrefs.SetInt("SaveGame", 0);
        }
    }
}
