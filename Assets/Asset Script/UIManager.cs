using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.Audio;

public class UIManager : MonoBehaviour
{
    public GameObject Back1, Back2, Back3, P1, P2, P3, K1, K2, K3, K4, A1, A2, A3, Sk,Pl,Gar;
    public RectTransform PUtama, PLevel, PPetunjuk, PTentang, PScore, PHome;
    public AudioSource Khusus, Biasa, Akhir;

    private string levl, open, soundd;
    // Start is called before the first frame update
    
    void Start()
    {
        open = DataScoreController.opening;
        Khusus.GetComponent<AudioSource>();
        Biasa.GetComponent<AudioSource>();
        Akhir.GetComponent<AudioSource>();

        if (open == "NO")
        {
            ButtonScore();
            Khusus.Play();
            Biasa.Stop();
            Akhir.Stop();
        }
        else if (open == "No Akhir")
        {
            ButtonHome();
            Biasa.Stop();
            Khusus.Stop();
            Akhir.Play();
        }
        else if (open == "YES")
        {
            ButtonLevel();
            Biasa.Play();
            Khusus.Stop();
            Akhir.Stop();
        }
        else 
        {

            Biasa.Play();
            Khusus.Stop();
            Akhir.Stop();
            Back1.SetActive(true);
            Back2.SetActive(false);
            Back3.SetActive(false);
            PUtama.DOAnchorPos(new Vector2(0, 0), 1.0f);
            PLevel.DOAnchorPos(new Vector2(0, 3000), 1.0f);
            PPetunjuk.DOAnchorPos(new Vector2(6000, 0), 1.0f);
            PTentang.DOAnchorPos(new Vector2(6000, 0), 1.0f);

            PScore.DOAnchorPos(new Vector2(0, -3000), 1.0f);
            PHome.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        }

        if (soundd == "akhir")
        {
            Khusus.Stop();
            Biasa.Stop();
            Akhir.Play();
        }
        else if (soundd == "b")
        {
            Khusus.Stop();
            Biasa.Play();
            Akhir.Stop();
        }
        else if (soundd == "k")
        {
            Khusus.Play();
            Biasa.Stop();
            Akhir.Stop();
        }

    }
    private void Update()
    {
        levl = DataScoreController.level;
        soundd = DataScoreController.sounder;

        Khusus.GetComponent<AudioSource>();
        Biasa.GetComponent<AudioSource>();
        Akhir.GetComponent<AudioSource>();
        if (soundd == "akhir")
        {
            Khusus.Stop();
            Biasa.Stop();
            Akhir.Play();
        }
        else if (soundd == "b")
        {
            Khusus.Stop();
            Biasa.Play();
            Akhir.Stop();
        }
        else if (soundd == "k")
        {
            Khusus.Play();
            Biasa.Stop();
            Akhir.Stop();
        }

        if (levl == "satu")
        {
            P1.SetActive(true);
            P2.SetActive(true);
            P3.SetActive(true);

            A1.SetActive(false);
            A2.SetActive(false);
            A3.SetActive(false);

            K1.SetActive(true);
            K2.SetActive(false);
            K3.SetActive(false);
            K4.SetActive(false);

            Sk.SetActive(true);
            Pl.SetActive(false);
            Gar.SetActive(false);

        }
        else if (levl == "dua")
        {
            P1.SetActive(false);
            P2.SetActive(true);
            P3.SetActive(true);

            A1.SetActive(true);
            A2.SetActive(false);
            A3.SetActive(false);

            K1.SetActive(false);
            K2.SetActive(true);
            K3.SetActive(false);
            K4.SetActive(false);

            Sk.SetActive(true);
            Pl.SetActive(false);
            Gar.SetActive(false);
        }
        else if (levl == "tiga")
        {
            P1.SetActive(false);
            P2.SetActive(false);
            P3.SetActive(true);

            A1.SetActive(true);
            A2.SetActive(true);
            A3.SetActive(false);
            
            K1.SetActive(false);
            K2.SetActive(false);
            K3.SetActive(true);
            K4.SetActive(false);

            Sk.SetActive(false);
            Pl.SetActive(true);
            Gar.SetActive(false);
        }
        else if (levl == "empat")
        {
            P1.SetActive(false);
            P2.SetActive(false);
            P3.SetActive(false);

            A1.SetActive(true);
            A2.SetActive(true);
            A3.SetActive(true);

            K1.SetActive(false);
            K2.SetActive(false);
            K3.SetActive(false);
            K4.SetActive(true);

            Sk.SetActive(false);
            Pl.SetActive(false);
            Gar.SetActive(true);
        }
        else
        {
            P1.SetActive(true);
            P2.SetActive(true);
            P3.SetActive(true);

            A1.SetActive(false);
            A2.SetActive(false);
            A3.SetActive(false);

            K1.SetActive(true);
            K2.SetActive(false);
            K3.SetActive(false);
            K4.SetActive(false);
        }
    }
    public void ButtonKembali()
    {
        Back1.SetActive(true);
        Back2.SetActive(false);
        Back3.SetActive(false);
        PUtama.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PLevel.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        PPetunjuk.DOAnchorPos(new Vector2(6000, 0), 1.0f);
        PTentang.DOAnchorPos(new Vector2(6000, 0), 1.0f);

        PScore.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        PHome.DOAnchorPos(new Vector2(0, -3000), 1.0f);
    }
    public void ButtonLevel()
    {
        Back1.SetActive(false);
        Back2.SetActive(true);
        Back3.SetActive(false);
        PUtama.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        PLevel.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PPetunjuk.DOAnchorPos(new Vector2(6000, 0), 1.0f);
        PTentang.DOAnchorPos(new Vector2(6000, 0), 1.0f);

        PScore.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        PHome.DOAnchorPos(new Vector2(0, -3000), 1.0f);
    }
    public void ButtonPetunjuk()
    {
        Back1.SetActive(false);
        Back2.SetActive(false);
        Back3.SetActive(true);
        PUtama.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        PLevel.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        PPetunjuk.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PTentang.DOAnchorPos(new Vector2(6000, 0), 1.0f);

        PScore.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        PHome.DOAnchorPos(new Vector2(0, -3000), 1.0f);
    }
    public void ButtonTentang()
    {
        Back1.SetActive(false);
        Back2.SetActive(false);
        Back3.SetActive(true);
        PUtama.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        PLevel.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        PPetunjuk.DOAnchorPos(new Vector2(6000, 0), 1.0f);
        PTentang.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PScore.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        PHome.DOAnchorPos(new Vector2(0, -3000), 1.0f);
    }
    public void ButtonScore()
    {
        PScore.DOAnchorPos(new Vector2(0, 0), 0.3f);
    }

    public void ButtonHome()
    {
        PHome.DOAnchorPos(new Vector2(0, 0), 0.3f);
    }

    public void Soundkembali()
    {
        soundd = "b";
        Biasa.Play();
    }
}