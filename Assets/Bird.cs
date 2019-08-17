using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public GameObject PanelGameOver;
    public GameObject PanelGoal;
    private bool isplaying = true;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (isplaying == false) { return; }


        if (coll.gameObject.name == "Goal")
        {
            PanelGoal.SetActive(true);
            isplaying = false;
        }
        else
        {
            PanelGameOver.SetActive(true);
            isplaying = false;
        }
    }

    public void Fly()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 1f);
    }


}

