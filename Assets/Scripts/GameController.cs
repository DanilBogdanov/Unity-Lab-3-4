using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject OneBallPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AddABall", 1.5f, 1);
    }

    // ReSharper disable Unity.PerformanceAnalysis
    void AddABall()
    {
        Instantiate(OneBallPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
