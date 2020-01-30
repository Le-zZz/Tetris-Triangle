﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EggSpawning : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    [SerializeField] GameObject eggWhitePrefab;
    [SerializeField] GameObject eggBlackPrefab;
    [SerializeField] GameObject eggPurplePrefab;
    [SerializeField] GameObject eggYellowPrefab;

    public static bool isSpawning = true;
    

    // Update is called once per frame
    void Update()
    {
        if (isSpawning)
        {
            EggSpawn();
            isSpawning = false;
            PlayerController.isControlling = true;
        }
    }

    void EggSpawn()
    {
        int randomNumber = Random.Range(1, 4);
        
        if (randomNumber == 1)
        {
            GameObject egg = Instantiate(eggWhitePrefab, spawnPoint.position, spawnPoint.rotation);
        }
        if (randomNumber == 2)
        {
            GameObject egg = Instantiate(eggBlackPrefab, spawnPoint.position, spawnPoint.rotation);
        }
        if (randomNumber == 3)
        {
            GameObject egg = Instantiate(eggPurplePrefab, spawnPoint.position, spawnPoint.rotation);
        }
        if (randomNumber == 4)
        {
            GameObject egg = Instantiate(eggYellowPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
    
}
