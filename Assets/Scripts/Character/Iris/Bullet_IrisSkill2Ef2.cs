using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_IrisSkill2Ef2 : MonoBehaviour
{ 
    int i = 0;

    GameObject[] skillParticle = new GameObject[12];
    public GameObject irisSkill2_Particle;
    Vector3[] randomPosition = new Vector3[12];

    // Use this for initialization
    void Start()
    {
        StartCoroutine(IrisSkill2Particle());
        StartCoroutine(StopIrisSkill2Particle());


        randomPosition[0] = new Vector3(0f, 10f, 0f);
        randomPosition[1] = new Vector3(0f, 20f, 0f);
        randomPosition[2] = new Vector3(0f, 30f, 0f);
        randomPosition[3] = new Vector3(10f, 0f, 0f);
        randomPosition[4] = new Vector3(20f, 0f, 0f);
        randomPosition[5] = new Vector3(30f, 0f, 0f);
        randomPosition[6] = new Vector3(10f, 10f, 0f);
        randomPosition[7] = new Vector3(20f, 10f, 0f);
        randomPosition[8] = new Vector3(30f, 10f, 0f);
        randomPosition[9] = new Vector3(10f, 20f, 0f);
        randomPosition[10] = new Vector3(20f, 20f, 0f);
        randomPosition[11] = new Vector3(30f, 30f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator IrisSkill2Particle()
    {
        while (true)
        {
            if (i == 12)
                i = 0;

            float irisEffectRotation;
            irisEffectRotation = i / 12f;

            skillParticle[i] = Instantiate(irisSkill2_Particle, gameObject.transform.position + randomPosition[i], Quaternion.Euler(0, 0, irisEffectRotation));
            Destroy(skillParticle[i], 1f);

            i++;

            yield return new WaitForSeconds(0.1f);
        }
    }

    IEnumerator StopIrisSkill2Particle()
    {
        yield return new WaitForSeconds(4.9f);

        StopCoroutine(IrisSkill2Particle());
        StopCoroutine(StopIrisSkill2Particle());
    }
}