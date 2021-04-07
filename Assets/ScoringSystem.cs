using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoringSystem : MonoBehaviour
{

    public GameObject scoreText;
    public AudioSource coinSource;
    public static int theScore = 0;


  void Start()
    {
        coinSource = GetComponent<AudioSource>();
    }

     void Update()
    {
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            theScore += 1;
            scoreText.GetComponent<TMPro.TextMeshProUGUI>().text = "score:" + theScore + "/30";
            coinSource.Play ();
            Destroy(gameObject);
        }
    }
}
