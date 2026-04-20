using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float timeElapsed = 0f;
    public static float finalTime;

    void Update()
    {
        if (!GameController.gameover)
        {
            timeElapsed += Time.deltaTime;
            finalTime = timeElapsed;
        }
        timerText.text = "Tempo: " + Mathf.FloorToInt(timeElapsed) + "s";
    }
}