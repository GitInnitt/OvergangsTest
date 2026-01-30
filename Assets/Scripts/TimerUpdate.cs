using UnityEngine;
using TMPro;

public class TimerUpdate : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerText.text = "Timerstarted";

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
