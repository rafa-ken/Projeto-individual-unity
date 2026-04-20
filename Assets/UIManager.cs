using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject endgamepanel;
    public TextMeshProUGUI finalTimeText;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        GameController.Init();
        endgamepanel.SetActive(false);
    }

    void FixedUpdate()
    {
        scoreText.text = "Ossos: " + GameController.collected + " / 4";
        
        if (GameController.gameover)
        {
            endgamepanel.SetActive(true);
            finalTimeText.text = "Tempo: " + Mathf.FloorToInt(Timer.finalTime) + "s";
        }
    }
}