using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillCutIn : MonoBehaviour
{
    private void Awake()
    {
    }

    void Start()
    {
        StartCoroutine(SkillCutInMove());
    }

    void Update()
    {

    }

    IEnumerator SkillCutInMove()
    {
        float elapsedTime = 0f;
        float duration = 0.25f;

        while (elapsedTime < duration)
        {
            yield return 0;
            elapsedTime += Time.unscaledDeltaTime;
            transform.position += new Vector3(2800f * Time.unscaledDeltaTime, 0f, 0f);
            if (transform.position.x > -200f)
                elapsedTime = duration;

            Time.timeScale = 0;
        }
        elapsedTime = 0;
        duration = 0.5f;
        while (elapsedTime < duration)
        {
            yield return 0;
            elapsedTime += Time.unscaledDeltaTime;
            Time.timeScale = 0;
        }
        elapsedTime = 0;
        duration = 0.5f;
        while (elapsedTime < duration)
        {
            yield return 0;
            elapsedTime += Time.unscaledDeltaTime;
            transform.position += new Vector3(2800f * Time.unscaledDeltaTime, 0f, 0f);
            if (transform.position.x > 700f)
                elapsedTime = duration;

            Time.timeScale = 0;
        }
        Time.timeScale = 1;
        Destroy(gameObject);

    }
}