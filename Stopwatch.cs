using UnityEngine;
using TMPro;

public class Stopwatch : MonoBehaviour
{
    public bool hasFinished;
    float minutes;
    float seconds;

    public TextMeshProUGUI stopwatch;

    void Update()
    {

        if (hasFinished == false)
        {
            seconds += Time.deltaTime;

            if (seconds >= 60)
            {
                minutes += 1;
                seconds -= 60;
            }

        }

        int m = Mathf.RoundToInt(minutes);
        int s = Mathf.RoundToInt(seconds);

        stopwatch.text = m + ":" + s;
    }
}