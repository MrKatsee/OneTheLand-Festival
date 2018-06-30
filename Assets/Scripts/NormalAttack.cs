using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalAttack : MonoBehaviour
{

    public int attackSpeed;
    float spd;
    public GameObject nomalBullet;
    GameObject bullet_temp;
    Vector3 bulletShootPosition = new Vector3(0f, 0f, 0f);

    // Use this for initialization
    void Start()
    {
        spd = attackSpeed * Time.deltaTime;

        if (gameObject.GetComponent<InputKey>().isPlayer == 1)
        {
            bulletShootPosition = new Vector3(20f, 0f, 0f);
        }
        else if (gameObject.GetComponent<InputKey>().isPlayer == 2)
        {
            bulletShootPosition = new Vector3(-20f, 0f, 0f);
        }

        StartCoroutine(Attack(nomalBullet));
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Attack(GameObject Bullet)
    {
        while (true)
        {
            bullet_temp = Instantiate(Bullet);
            bullet_temp.transform.position = bulletShootPosition + gameObject.transform.position;
            bullet_temp.gameObject.GetComponent<BulletIdentifier>().isPlayer_Bullet = gameObject.GetComponent<InputKey>().isPlayer;
            Destroy(bullet_temp, 5f);
            yield return new WaitForSeconds(1f * spd);
        }
    }
}
