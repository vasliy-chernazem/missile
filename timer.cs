using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    void Update()
    {
        seconds -= Timer.deltaTime;
        if (seconds <= 0)
        {
            if (minutes > 0)
            {
                seconds += 59;

                minutes -;
            }
            else
            {

                int scenelendex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex)
            }
        }
    }
}
