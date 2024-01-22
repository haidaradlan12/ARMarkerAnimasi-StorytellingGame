using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class GaerdenGameController : MonoBehaviour
{
    public GameObject soal1, soal2, soal3, soal4;
    int randomly;
    private string opening, level, sounder;

    void Start()
    {
        randomly = Random.Range(1, 4);
    }

    void Update()
    {
        if (randomly==1)
        {
            soal1.SetActive(true);
            soal2.SetActive(false);
            soal3.SetActive(false);
            soal4.SetActive(false);
        }
        else if (randomly == 2)
        {
            soal1.SetActive(false);
            soal2.SetActive(true);
            soal3.SetActive(false);
            soal4.SetActive(false);
        }
        else if (randomly == 3)
        {
            soal1.SetActive(false);
            soal2.SetActive(false);
            soal3.SetActive(true);
            soal4.SetActive(false);
        }
        else if (randomly == 4)
        {
            soal1.SetActive(false);
            soal2.SetActive(false);
            soal3.SetActive(false);
            soal4.SetActive(true);
        }
    }

    public void ButtonBenar()
    {
        opening = "NO";
        sounder = "k";
        level = "empat";
        DataScoreController.opening = opening;
        DataScoreController.level = level;
        SceneManager.LoadScene(0);
    }
    public void ButtonSalah()
    {
       SceneManager.LoadScene(3);
    }

    public void tombolKembali()
    {
        opening = "YES";
        sounder = "b";
        DataScoreController.opening = opening;
        SceneManager.LoadScene(0);
    }
}
