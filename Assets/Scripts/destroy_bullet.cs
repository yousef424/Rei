using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_bullet : MonoBehaviour {
    private float destorytime = 0.5f;
    public GameObject bullet;
    // Use this for initialization
    void Start () {
       
    }

    // Update is called once per frame
    void Update() {
        bullet = GameObject.FindWithTag("bullet");
        Destroy(bullet, destorytime);
    }
        
}
