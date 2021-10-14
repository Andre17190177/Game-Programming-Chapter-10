using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnTarget : MonoBehaviour
{
    public GameObject target;

    private void Start()
    {

    }

    public void Spawn()
    {
        Vector2 pos = new Vector2(Random.Range(-7f, 7f), Random.Range(-4f, 4f));
        target.transform.position = pos;
        target.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        target.SetActive(false);
        Scoring.score += 1;
        Invoke("Spawn", 3f);
    }
}
