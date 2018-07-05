using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMap1_1 : MonoBehaviour
{
    float speed_Bullet;
    public float bulletMap1_Rotation;

    Vector2 shootVector;

    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<BulletIdentifier>().bulletSpd = 20f;

        shootVector = Vector2.right;
        shootVector.x = Mathf.Cos(bulletMap1_Rotation * 6.28f);
        shootVector.y = Mathf.Sin(bulletMap1_Rotation * 6.28f);

        speed_Bullet = 200f;

        GetComponent<Rigidbody2D>().velocity = shootVector * speed_Bullet;

        StartCoroutine(DestroyMap1B());
    }

    // Update is called once per frame
    void Update()
    {


    }

    IEnumerator DestroyMap1B()
    {
        yield return new WaitForSeconds(10f);

        Destroy(gameObject);
    }

    void FixedUpdate()
    {
    }
}
