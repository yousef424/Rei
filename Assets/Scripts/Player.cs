using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public GameObject shotbullet;
    public GameObject Bullet;
    private Rigidbody bulletbody;
    private Rigidbody playerbody;
    public float enginepower;
    public float ammo = 2;
	// Use this for initialization
	void Start () {
        
        playerbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            playerbody.AddForce(transform.forward * enginepower);
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerbody.AddForce(-transform.forward * enginepower);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerbody.AddForce(transform.right * enginepower);
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerbody.AddForce(-transform.right * enginepower);
        }
        if (Input.GetKeyDown(KeyCode.Space) && ammo==2 || ammo==1)
        {
            shoot();
        }
       

    }
    public void shoot()
    {
        shotbullet = Instantiate(Bullet, transform.position, Quaternion.identity);
        bulletbody=shotbullet.GetComponent<Rigidbody>();
        bulletbody.AddForce(transform.forward, ForceMode.Impulse);
    }
}

