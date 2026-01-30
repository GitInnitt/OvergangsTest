using UnityEngine;
using System.Collections;
using TMPro;
using Unity.Cinemachine;
using System.Runtime.CompilerServices;

public class SimpleTimer : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText;

    [SerializeField] private float targetTime = 60.0f;
    

    void Start()
    {
        //timerText = GetComponent<TMP_Text>();
    }
    void Update()
    {

        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }

        if (targetTime >= 0.0f)
        {
            timerText.text = "Tijd:" + Mathf.Ceil(targetTime).ToString();
        }

        if (gameObject.CompareTag("Player"))
        {
         
            if (targetTime <= 0.0f)
            {
                Debug.Log("Je hebt verloren");
            }
            else
            {
                Debug.Log("Je hebt gewonnen");
            }
        }



        void timerEnded()
        {
            timerText.text = "Time's Up!";

        }
    }

    public void Finish()
    {
        if (targetTime >= 0.0f)
        {
            Debug.Log("Je hebt gewonnen!");
        }
        else
        {
            Debug.Log("Je hebt verloren!");
        }
    }
}