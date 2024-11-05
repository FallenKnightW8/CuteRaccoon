using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour
{
    private int Stage = 0;
    private void FixedUpdate()
    {
        StartCoroutine(TimerToCheckGame());
    }

    private void Dowload()
    {
        PlayerPrefs.GetInt("SaveStage");
    }

    private void SaveGameS()
    {
        //PlayerPrefs.SetInt("SaveStage", Stage);
        Debug.Log("Игра успешно сохранена");
    }
    private IEnumerator TimerToCheckGame()
    {
        //do timer
        yield return new WaitForSeconds(60f);
        //posle
        SaveGameS();
        StopCoroutine(TimerToCheckGame());
    }

    public void SendSave()
    {
        SaveGameS();
    }
}
