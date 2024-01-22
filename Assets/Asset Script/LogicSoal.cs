using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicSoal : MonoBehaviour
{
    private int A,B,C,D,E,F,G,H,I,J,Total;
    public GameObject A0, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10;

    void Update()
    {
        Total = (A + B + C + D + E + F + G + H + I + J);
        if (Total == 0)
        {
            A0.SetActive(true);
            A1.SetActive(false);
            A2.SetActive(false);
            A3.SetActive(false);
            A4.SetActive(false);
            A5.SetActive(false);
            A6.SetActive(false);
            A7.SetActive(false);
            A8.SetActive(false);
            A9.SetActive(false);
            A10.SetActive(false);
        }
        else if (Total == 1)
        {
            A0.SetActive(false);
            A1.SetActive(true);
            A2.SetActive(false);
            A3.SetActive(false);
            A4.SetActive(false);
            A5.SetActive(false);
            A6.SetActive(false);
            A7.SetActive(false);
            A8.SetActive(false);
            A9.SetActive(false);
            A10.SetActive(false);
        }
        else if (Total == 2)
        {
            A0.SetActive(false);
            A1.SetActive(false);
            A2.SetActive(true);
            A3.SetActive(false);
            A4.SetActive(false);
            A5.SetActive(false);
            A6.SetActive(false);
            A7.SetActive(false);
            A8.SetActive(false);
            A9.SetActive(false);
            A10.SetActive(false);
        }
        else if (Total == 3)
        {
            A0.SetActive(false);
            A1.SetActive(false);
            A2.SetActive(false);
            A3.SetActive(true);
            A4.SetActive(false);
            A5.SetActive(false);
            A6.SetActive(false);
            A7.SetActive(false);
            A8.SetActive(false);
            A9.SetActive(false);
            A10.SetActive(false);
        }
        else if (Total == 4)
        {
            A0.SetActive(false);
            A1.SetActive(false);
            A2.SetActive(false);
            A3.SetActive(false);
            A4.SetActive(true);
            A5.SetActive(false);
            A6.SetActive(false);
            A7.SetActive(false);
            A8.SetActive(false);
            A9.SetActive(false);
            A10.SetActive(false);
        }
        else if (Total == 5)
        {
            A0.SetActive(false);
            A1.SetActive(false);
            A2.SetActive(false);
            A3.SetActive(false);
            A4.SetActive(false);
            A5.SetActive(true);
            A6.SetActive(false);
            A7.SetActive(false);
            A8.SetActive(false);
            A9.SetActive(false);
            A10.SetActive(false);
        }
        else if (Total == 6)
        {
            A0.SetActive(false);
            A1.SetActive(false);
            A2.SetActive(false);
            A3.SetActive(false);
            A4.SetActive(false);
            A5.SetActive(false);
            A6.SetActive(true);
            A7.SetActive(false);
            A8.SetActive(false);
            A9.SetActive(false);
            A10.SetActive(false);
        }
        else if (Total == 7)
        {
            A0.SetActive(false);
            A1.SetActive(false);
            A2.SetActive(false);
            A3.SetActive(false);
            A4.SetActive(false);
            A5.SetActive(false);
            A6.SetActive(false);
            A7.SetActive(true);
            A8.SetActive(false);
            A9.SetActive(false);
            A10.SetActive(false);
        }
        else if (Total == 8)
        {
            A0.SetActive(false);
            A1.SetActive(false);
            A2.SetActive(false);
            A3.SetActive(false);
            A4.SetActive(false);
            A5.SetActive(false);
            A6.SetActive(false);
            A7.SetActive(false);
            A8.SetActive(true);
            A9.SetActive(false);
            A10.SetActive(false);
        }
        else if (Total == 9)
        {
            A0.SetActive(false);
            A1.SetActive(false);
            A2.SetActive(false);
            A3.SetActive(false);
            A4.SetActive(false);
            A5.SetActive(false);
            A6.SetActive(false);
            A7.SetActive(false);
            A8.SetActive(false);
            A9.SetActive(true);
            A10.SetActive(false);
        }
        else if (Total == 10)
        {
            A0.SetActive(false);
            A1.SetActive(false);
            A2.SetActive(false);
            A3.SetActive(false);
            A4.SetActive(false);
            A5.SetActive(false);
            A6.SetActive(false);
            A7.SetActive(false);
            A8.SetActive(false);
            A9.SetActive(false);
            A10.SetActive(true);
        }
    }
    public void soal1(int nilai)
    {
        A = nilai;
    }
    public void soal2(int nilai)
    {
        B = nilai;
    }
    public void soal3(int nilai)
    {
        C = nilai;
    }
    public void soal4(int nilai)
    {
        D = nilai;
    }
    public void soal5(int nilai)
    {
        E = nilai;
    }
    public void soal6(int nilai)
    {
        F = nilai;
    }
    public void soal7(int nilai)
    {
        G = nilai;
    }
    public void soal8(int nilai)
    {
        H = nilai;
    }
    public void soal9(int nilai)
    {
        I = nilai;
    }
    public void soal10(int nilai)
    {
        J = nilai;
    }
}
