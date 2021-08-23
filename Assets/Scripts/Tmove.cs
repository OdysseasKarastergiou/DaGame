using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Tmove : MonoBehaviour
{

    public GameObject BadGuy;

    public Transform[] patrolPoints;
    public float speed;
    private int point;

    // Use this for initialization
    void Start()
    { //random point
        point = Random.Range(0, patrolPoints.Length);
    }

    // Update is called once per frame
    void Update()
    { //move to random point
        transform.position = Vector2.MoveTowards(transform.position, patrolPoints[point].position,speed*Time.deltaTime);

        if (Vector2.Distance(transform.position, patrolPoints[point].position)<0.2f)
        {
            point = Random.Range(0, patrolPoints.Length);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        pewpewCollision pewKill = collision.collider.GetComponent<pewpewCollision>();
        if (pewKill != null)
        {
            Destroy(BadGuy);

        }
    }
}