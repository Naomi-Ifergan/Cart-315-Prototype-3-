using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoringSystem : MonoBehaviour
{

    public GameObject scoreText;
    public static int theScore = 0;


  void Start()
    {
       
      
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
            Destroy(gameObject);
            
        }
        
    }
    public void ResetScore()
    {
        theScore = 0;
        PlayerPrefs.SetInt("", theScore);
    }
}
