using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginButton : MonoBehaviour
{
    public void BeginGame()
    {
        SceneManager.LoadScene("westonscene");
    }
}
