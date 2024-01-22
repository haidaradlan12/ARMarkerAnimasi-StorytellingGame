using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class GazeIntPlayground : MonoBehaviour
{
    [Header("Keranjang")]
    public GameObject kuning1; public GameObject kuning2, kuning3, merah1, merah2, merah3, hijau1, hijau2, hijau3;
    [Header("Pasir")]
    public GameObject k1; public GameObject k2, k3, m1, m2, m3, h1, h2, h3;
    [Header("Button")]
    public GameObject ButtonLepas; public GameObject ButtonAmbil;
    [Header("Text")]
    public Text WarnaBola;
    [Header("Lingkaran")]
    public RectTransform Lingkaran;
    private int jenisbola, c, a, b, d, m, k, h, t , total;


    private string opening, level, sounder;
    // Start is called before the first frame update
    void Start()
    {
        c = 0;
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
            k = k;
            m = m;
            h = h;

            if (k == 0)
            {
                kuning1.SetActive(false);
                kuning2.SetActive(false);
                kuning3.SetActive(false);
                c = 0;
            }
            else if (k == 1)
            {
                kuning1.SetActive(true);
                kuning2.SetActive(false);
                kuning3.SetActive(false);
                c = 0;
            }
            else if (k == 2)
            {
                kuning1.SetActive(true);
                kuning2.SetActive(true);
                kuning3.SetActive(false);
                c = 0;
            }
            else if (k == 3)
            {
                kuning1.SetActive(true);
                kuning2.SetActive(true);
                kuning3.SetActive(true);
                c = 0;
            }

            if (h == 0)
            {
                hijau1.SetActive(false);
                hijau2.SetActive(false);
                hijau3.SetActive(false);
                c = 0;
            }
            else if (h == 1)
            {
                hijau1.SetActive(true);
                hijau2.SetActive(false);
                hijau3.SetActive(false);
                c = 0;
            }
            else if (h == 2)
            {
                hijau1.SetActive(true);
                hijau2.SetActive(true);
                hijau3.SetActive(false);
                c = 0;
            }
            else if (h == 3)
            {
                hijau1.SetActive(true);
                hijau2.SetActive(true);
                hijau3.SetActive(true);
                c = 0;
            }

            if (m == 0)
            {
                merah1.SetActive(false);
                merah2.SetActive(false);
                merah3.SetActive(false);
                c = 0;
            }
            else if (m == 1)
            {
                merah1.SetActive(true);
                merah2.SetActive(false);
                merah3.SetActive(false);
                c = 0;
            }
            else if (m == 2)
            {
                merah1.SetActive(true);
                merah2.SetActive(true);
                merah3.SetActive(false);
                c = 0;
            }
            else if (m == 3)
            {
                merah1.SetActive(true);
                merah2.SetActive(true);
                merah3.SetActive(true);
                c = 0;
            }

            total = m + k + h;
            if(total >= 9)
            {
                c = 3;
                opening = "NO";
                sounder = "k";
                level = "tiga";
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
            if (go.CompareTag("BM"))
            {
                ButtonAmbil.SetActive(true);
                ButtonLepas.SetActive(false);
                Debug.Log("a = 1");
                WarnaBola.text = "Bola Merah";
                a = 1;
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else if (go.CompareTag("BM1"))
            {
                ButtonAmbil.SetActive(true);
                ButtonLepas.SetActive(false);
                Debug.Log("a = 2");
                WarnaBola.text = "Bola Merah";
                a = 2;
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else if (go.CompareTag("BM2"))
            {
                ButtonAmbil.SetActive(true);
                ButtonLepas.SetActive(false);
                Debug.Log("a = 3");
                WarnaBola.text = "Bola Merah";
                a = 3;
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else if (go.CompareTag("BK"))
            {
                ButtonAmbil.SetActive(true);
                ButtonLepas.SetActive(false);
                Debug.Log("a = 4");
                WarnaBola.text = "Bola Kuning";
                a = 4;
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else if (go.CompareTag("BK1"))
            {
                ButtonAmbil.SetActive(true);
                ButtonLepas.SetActive(false);
                Debug.Log("a = 5");
                WarnaBola.text = "Bola Kuning";
                a = 5;
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else if (go.CompareTag("BK2"))
            {
                ButtonAmbil.SetActive(true);
                ButtonLepas.SetActive(false);
                Debug.Log("a = 6");
                WarnaBola.text = "Bola Kuning";
                a = 6;
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else if (go.CompareTag("BH"))
            {
                ButtonAmbil.SetActive(true);
                ButtonLepas.SetActive(false);
                Debug.Log("a = 7");
                WarnaBola.text = "Bola Hijau";
                a = 7;
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else if (go.CompareTag("BH1"))
            {
                ButtonAmbil.SetActive(true);
                ButtonLepas.SetActive(false);
                Debug.Log("a = 8");
                WarnaBola.text = "Bola Hijau";
                a = 8;
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else if (go.CompareTag("BH2"))
            {
                ButtonAmbil.SetActive(true);
                ButtonLepas.SetActive(false);
                Debug.Log("a = 9");
                WarnaBola.text = "Bola Hijau";
                a = 9;
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else
            {
                WarnaBola.text = "Pilih Bola";
                ButtonAmbil.SetActive(false);
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
        jenisbola = a;
        ButtonAmbil.SetActive(false);
        Lingkaran.sizeDelta = new Vector2(100, 100);
        if ((jenisbola == 1 || jenisbola == 2 || jenisbola == 3))
        {
            WarnaBola.text = "Letakkan Bola Merah";
        }
        else if ((jenisbola == 4 || jenisbola == 5 || jenisbola == 6))
        {
            WarnaBola.text = "Letakkan Bola Kuning";
        }
        else if ((jenisbola == 7 || jenisbola == 8 || jenisbola == 9))
        {
            WarnaBola.text = "Letakkan Bola Hijau";
        }
    }
    void FungsiKlikPertama()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
        {
            GameObject go = hit.collider.gameObject;
            if ((go.CompareTag("TM")) && (jenisbola==1 || jenisbola == 2 || jenisbola == 3))
            {
                ButtonLepas.SetActive(true);
                d = jenisbola;
                t = 1;
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else if ((go.CompareTag("TK")) && (jenisbola == 4 || jenisbola == 5 || jenisbola == 6))
            {
                ButtonLepas.SetActive(true);
                d = jenisbola;
                t = 1;
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else if ((go.CompareTag("TH")) && (jenisbola == 7 || jenisbola == 8 || jenisbola == 9))
            {
                ButtonLepas.SetActive(true);
                d = jenisbola;
                t = 1;
                Lingkaran.sizeDelta = new Vector2(125, 125);
            }
            else
            {
                ButtonLepas.SetActive(false);
                Lingkaran.sizeDelta = new Vector2(100, 100);
            }
        }
    }
    public void FungsiKlikKedua()
    {
        b = d;
        c = 2;
        if (b == 1)
        {
            m1.SetActive(false);
            m = m + t;
        }
        else if (b == 2)
        {
            m2.SetActive(false);
            m = m + t;
        }
        else if (b == 3)
        {
            m3.SetActive(false);
            m = m + t;
        }
        else if (b == 4)
        {
            k1.SetActive(false);
            k = k + t;
        }
        else if (b == 5)
        {
            k2.SetActive(false);
            k = k + t;
        }
        else if (b == 6)
        {
            k3.SetActive(false);
            k = k + t;
        }
        else if (b == 7)
        {
            h1.SetActive(false);
            h = h + t;
        }
        else if (b == 8)
        {
            h2.SetActive(false);
            h = h + t;
        }
        else if (b == 9)
        {
            h3.SetActive(false);
            h = h + t;
        }
        ButtonLepas.SetActive(false);
        Lingkaran.sizeDelta = new Vector2(100, 100);
    }

    public void tombolKembali()
    {
        opening = "YES";
        sounder = "b";
        DataScoreController.opening = opening;
        SceneManager.LoadScene(0);
    }

}
