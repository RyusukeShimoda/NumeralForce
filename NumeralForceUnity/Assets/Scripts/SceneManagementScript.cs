using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class SceneManagementScript : MonoBehaviour
{
    //ステージ開始メソッド
    public void StartStage()
    {
        DOTween.Clear();
        SceneManager.LoadScene(1);
    }

    public void StartTutrial()
    {
        DOTween.Clear();
        SceneManager.LoadScene(2);
    }

    //アプリ終了メソッド
    public void ExitApp()
    {
        Application.Quit();
    }
}
