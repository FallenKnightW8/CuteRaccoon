using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class Menu : MonoBehaviour
{
     public void StartGame()
    {
        if (PlayerPrefs.HasKey("SaveGame"))
        {
            
        }
        else
        {
            PlayerPrefs.SetInt("SaveGame", 0);
        }
    }
}
