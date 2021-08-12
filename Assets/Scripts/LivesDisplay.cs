
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{

    [SerializeField] int lives = 10;
    Text livesText;
    [SerializeField] int damage = 1;

    void Start()
    {
        livesText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }

    public void TakeLife()
    {
        lives -= damage;
        UpdateDisplay();
    
        if(lives<=0)
        {
            FindObjectOfType<LevelLoader>().LoadLoseScreen();
        }
        
    }
}
