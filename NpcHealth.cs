using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcHealth : MonoBehaviour
{
    int health = 5;
    int level = 2;
    int speed = 2;
    Vector3 new_pos;
    // Start is called before the first frame update
    void Start()
    {
        health += level;
    }

    // Update is called once per frame
    void Update()
    {
        new_pos = this.transform.position;
        new_pos.z += speed*Time.deltaTime;
        this.transform.position = new_pos;
    }
}
