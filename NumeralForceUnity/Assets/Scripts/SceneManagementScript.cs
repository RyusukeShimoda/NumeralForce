using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class SceneManagementScript : MonoBehaviour
{
    //�X�e�[�W�J�n���\�b�h
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

    //�A�v���I�����\�b�h
    public void ExitApp()
    {
        Application.Quit();
    }
}
