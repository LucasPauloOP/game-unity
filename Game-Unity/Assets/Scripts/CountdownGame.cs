using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownGame : MonoBehaviour
{
    public Text displayCountdown;

    public float count = 120.0f;
    void Start()
    {

    }

    void Update()
    {
        print("count " + count);
        if (count > 0.0f)
        {
            count -= Time.deltaTime;
            displayCountdown.text = count.ToString("F2");
        }
        else
        {
            displayCountdown.text = "Time's up";
        }
    }
}
