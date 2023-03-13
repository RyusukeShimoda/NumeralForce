using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class UIMover : MonoBehaviour
{
    [SerializeField] GameObject[] layer1;
    [SerializeField] GameObject[] layer112;
    [SerializeField] GameObject[] layer122;
    [SerializeField] GameObject[] layer132;
    [SerializeField] GameObject[] layer142;
    [SerializeField] GameObject[] layer11223;
    [SerializeField] GameObject[] layer11223b;
    [SerializeField] GameObject[] layer12213;
    [SerializeField] GameObject[] layer13213;

    [SerializeField] bool alphaOff;
    [SerializeField] float alphaFloat;
    [SerializeField] Renderer mat;

    // Start is called before the first frame update
    void Start()
    {
        alphaFloat = mat.material.color.a;
        alphaFloat = 0;
        SetAlpha();
    }

    // Update is called once per frame
    void Update()
    {
        if (alphaOff)
        {
            alphaFloat += 0.03f;
            SetAlpha();
            if (alphaFloat >= 1)
            {
                alphaOff = false;
            }
        }
    }

    void SetAlpha()
    {
        mat.material.color = new Color(1, 1, 1, alphaFloat);
    }

    public void Go1()
    {
        for (int i = 0; i <= layer1.Length-1; i++)
        {
            layer1[i].transform.DOLocalRotate(new Vector3(0, 0, 0), 1f);
            DOVirtual.DelayedCall(1, () => NextGo1());
        }
    }
    void NextGo1() 
    {
        for (int i = 0; i <= layer1.Length - 1; i++) 
        {
            layer1[i].GetComponent<BoxCollider2D>().enabled = true;
        }
    }

    public void Go112() 
    {
        for(int i = 0; i <= layer112.Length - 1; i++) 
        {
            layer112[i].transform.DOLocalRotate(new Vector3(0, 0, 0), 1f);
            DOVirtual.DelayedCall(1, () => NextGo112());
        }
    }
    void NextGo112()
    {
        for (int i = 0; i <= layer112.Length - 1; i++)
        {
            layer112[i].GetComponent<BoxCollider2D>().enabled = true;
        }
    }

    public void GoTutrial()
    {
        alphaOff = true;
        DOVirtual.DelayedCall(1, () => SceneManager.LoadScene(2));
    }

    public void Go122()
    {
        for (int i = 0; i <= layer122.Length - 1; i++)
        {
            layer122[i].transform.DOLocalRotate(new Vector3(0, 0, 0), 1f);
            DOVirtual.DelayedCall(1, () => NextGo122());
        }
    }
    void NextGo122()
    {
        for (int i = 0; i <= layer122.Length - 1; i++)
        {
            layer122[i].GetComponent<BoxCollider2D>().enabled = true;
        }
    }

    public void Go1s()
    {
        alphaOff = true;
        DOVirtual.DelayedCall(1, () => SceneManager.LoadScene(7));
    }
    public void Go2s()
    {
        alphaOff = true;
        DOVirtual.DelayedCall(1, () => SceneManager.LoadScene(8));
    }
    public void Go3s()
    {
        alphaOff = true;
        DOVirtual.DelayedCall(1, () => SceneManager.LoadScene(12));
    }
    public void Go4s()
    {
        alphaOff = true;
        DOVirtual.DelayedCall(1, () => SceneManager.LoadScene(13));
    }
    public void Go5s()
    {
        alphaOff = true;
        DOVirtual.DelayedCall(1, () => SceneManager.LoadScene(16));
    }

    public void Go132()
    {
        for (int i = 0; i <= layer132.Length - 1; i++)
        {
            layer132[i].transform.DOLocalRotate(new Vector3(0, 0, 0), 1f);
            DOVirtual.DelayedCall(1, () => NextGo132());
        }
    }
    void NextGo132()
    {
        for (int i = 0; i <= layer132.Length - 1; i++)
        {
            layer132[i].GetComponent<BoxCollider2D>().enabled = true;
        }
    }

    public void GoEasy()
    {
        alphaOff = true;
        DOVirtual.DelayedCall(1, () => SceneManager.LoadScene(6));
    }

    public void GoHard()
    {
        alphaOff = true;
        DOVirtual.DelayedCall(1, () => SceneManager.LoadScene(1));
    }

    public void GoOffline()
    {
        alphaOff = true;
        DOVirtual.DelayedCall(1, () => SceneManager.LoadScene(5));
    }

    public void Go142()
    {
        for (int i = 0; i <= layer142.Length - 1; i++)
        {
            layer142[i].transform.DOLocalRotate(new Vector3(0, 0, 0), 1f);
            DOVirtual.DelayedCall(1, () => NextGo142());
        }
    }
    void NextGo142()
    {
        for (int i = 0; i <= layer142.Length - 1; i++)
        {
            layer142[i].GetComponent<BoxCollider2D>().enabled = true;
        }
    }

    public void Go11223()
    {
        for (int i = 0; i <= layer11223.Length - 1; i++)
        {
            layer11223[i].transform.DOLocalRotate(new Vector3(0, 0, 0), 1f);
            DOVirtual.DelayedCall(1, () => NextGo11223());
        }
    }
    void NextGo11223()
    {
        for (int i = 0; i <= layer11223.Length - 1; i++)
        {
            layer11223[i].GetComponent<BoxCollider2D>().enabled = true;
        }
    }
    public void Go11223b()
    {
        for (int i = 0; i <= layer11223b.Length - 1; i++)
        {
            layer11223b[i].transform.DOLocalRotate(new Vector3(0, 0, 0), 1f);
            DOVirtual.DelayedCall(1, () => NextGo11223b());
        }
    }
    void NextGo11223b()
    {
        for (int i = 0; i <= layer11223b.Length - 1; i++)
        {
            layer11223b[i].GetComponent<BoxCollider2D>().enabled = true;
        }
    }

    public void Go12213()
    {
        for (int i = 0; i <= layer12213.Length - 1; i++)
        {
            layer12213[i].transform.DOLocalRotate(new Vector3(0, 0, 0), 1f);
            DOVirtual.DelayedCall(1, () => NextGo12213());
        }
    }
    void NextGo12213()
    {
        for (int i = 0; i <= layer12213.Length - 1; i++)
        {
            layer12213[i].GetComponent<BoxCollider2D>().enabled = true;
        }
    }

    public void Go13213()
    {
        for (int i = 0; i <= layer13213.Length - 1; i++)
        {
            layer13213[i].transform.DOLocalRotate(new Vector3(0, 0, 0), 1f);
            DOVirtual.DelayedCall(1, () => NextGo13213());
        }
    }
    void NextGo13213()
    {
        for (int i = 0; i <= layer13213.Length - 1; i++)
        {
            layer13213[i].GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
