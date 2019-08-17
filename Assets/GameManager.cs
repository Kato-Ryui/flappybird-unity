using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void Retry()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    public void Next()
    {
        Application.LoadLevel(Application.loadedLevel);
    }


}
