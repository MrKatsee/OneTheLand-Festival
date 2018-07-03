using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Iris4B : MonoBehaviour {

    public Vector2 irisSkill4BVector;
    float irisSkill4BSpeed;

	// Use this for initialization
	void Start () {
        StartCoroutine(IrisSkill4B());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator IrisSkill4B()
    {
        yield return new WaitForSeconds(1f);

        Vector2 irisSkill4B = Vector2.right;
        irisSkill4BVector.Normalize();
        irisSkill4BSpeed = 1000f;
        GetComponent<Rigidbody2D>().velocity = irisSkill4BSpeed * irisSkill4BVector;

        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
