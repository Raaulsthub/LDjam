using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class Card : MonoBehaviour
{

    [SerializeField]
    private int cost;
    [SerializeField]
    private int life;

    public UnityEvent OnSpawnEvent;
    public UnityEvent OnDestroyEvent;
    public UnityEvent OnUpdateEvent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DealDemage(int damage)
    {
        life -= damage;
    }
}
