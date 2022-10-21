using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject spawnObject;
    public GameObject[] spawnPoints;
    public float timer;
    public float timeBetweenSpawns;

    public float speedMultiplier;

    public TMP_Text distanceUI;
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        distanceUI.text = "Distance: " + distance.ToString("F2") + "km";
        speedMultiplier += Time.deltaTime * 0.1f;
        timeBetweenSpawns -= Time.deltaTime * 0.003f;

        timer += Time.deltaTime;
        distance += Time.deltaTime;

        if(timer > timeBetweenSpawns)
        {
            timer = 0;
            int randNum = Random.Range(0, 8);
            Instantiate(spawnObject, spawnPoints[randNum].transform.position, Quaternion.identity);
        }
    }
}
