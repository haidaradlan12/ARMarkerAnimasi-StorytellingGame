using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GazeInteraction : MonoBehaviour
{
    [Header("Button")]
    public GameObject ButtonAmbil;
    [Header("Lingkaran")]
    public RectTransform Lingkaran;
    private int terdeteksi, c, a, b, d, sal;
    private string opening, level, sounder;
    // Start is called before the first frame update
    void Start()
    {
        c = 0;
        sal = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (c == 0)
        {
            Mulai();
        }
        else if (c == 1)
        {
            FungsiKlikPertama();
        }
        else if (c == 2)
        {
            if (d==2)
            {
                c = 3;
                opening = "NO";
                sounder = "k";
                level = "dua";
            }
            else
            {
                sal = sal + 1;
                if (sal>3)
                {
                    c = 3;
                    opening = "YES";
                    sounder = "b";
                    level = "satu";
                }
                else
                {
                    c = 0;
                    opening = "NO";
                    sounder = "k";
                    level = "dua";
                }
            }
        }
        else if (c == 3)
        {
            DataScoreController.opening = opening;
            DataScoreController.level = level;
            SceneManager.LoadScene(0);
        }
    }
    void Mulai()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
        {
            GameObject go = hit.collider.gameObject;
            if (go.CompareTag("PTopi"))
            {
                ButtonAmbil.SetActive(true);
                Debug.Log("a = 1");
                a = 1;
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else if (go.CompareTag("PTas"))
            {
                ButtonAmbil.SetActive(true);
                Debug.Log("a = 2");
                a = 2;
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else if (go.CompareTag("PBuku"))
            {
                ButtonAmbil.SetActive(true);
                Debug.Log("a = 3");
                a = 3;
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else if (go.CompareTag("PBola"))
            {
                ButtonAmbil.SetActive(true);
                Debug.Log("a = 4");
                a = 4;
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else
            {
                ButtonAmbil.SetActive(false);
                Debug.Log("a = 0");
                a = 0;
                Lingkaran.sizeDelta = new Vector2(100, 100);
            }
        }
        else
        {
            ButtonAmbil.SetActive(false);
            Lingkaran.sizeDelta = new Vector2(100, 100);
        }
    }
    public void FungsiUPertama()
    {
        c = 1;
        terdeteksi = a;
        ButtonAmbil.SetActive(false);
        Lingkaran.sizeDelta = new Vector2(100, 100);
    }
    void FungsiKlikPertama()
    {
        d = terdeteksi;
        c = 2;
    }

    public void tombolKembali()
    {
        opening = "YES";
        sounder = "b";
        DataScoreController.opening = opening;
        SceneManager.LoadScene(0);
    }
}
