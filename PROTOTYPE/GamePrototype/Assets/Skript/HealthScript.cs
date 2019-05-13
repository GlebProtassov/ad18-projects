using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public float health = 100f;
    private float x_Death = -90f;
    private float dea;
    public void ApplyDamage(float damage)
    {
        health -= damage;

        if(health<=0){
            
        }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}
