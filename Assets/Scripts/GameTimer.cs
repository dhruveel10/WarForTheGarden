using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Level Timer In Seconds")]
    [SerializeField] float levelTimer = 50f;
    bool triggerLevelFinished = false;

    // Update is called once per frame
    void Update()
    {
        if (triggerLevelFinished) 
        { return; }
        
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTimer;

        bool timerFinished = (Time.timeSinceLevelLoad >= levelTimer);
        if(timerFinished)
        {
            FindObjectOfType<LevelController>().LevelTimerFinished();
            triggerLevelFinished = true;
        }
    }
}
