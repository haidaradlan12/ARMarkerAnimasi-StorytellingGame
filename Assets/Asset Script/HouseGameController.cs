using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HouseGameController : MonoBehaviour
{

    private string opening, level, sounder;
    public void aktifkanini()
    {
        opening = "No Akhir";
        sounder = "akhir";
        level = "empat";
        DataScoreController.opening = opening;
        DataScoreController.level = level;
        SceneManager.LoadScene(0);
    }
    
}
