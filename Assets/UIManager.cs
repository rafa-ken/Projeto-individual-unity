using UnityEngine;

public class UIManager : MonoBehaviour
{
    public  GameObject endgamepanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameController.gameover)
        {
            endgamepanel.SetActive(true);
        }
    }
}
