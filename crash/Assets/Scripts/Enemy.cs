using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//shane wright
//10-2023
public class Enemy : MonoBehaviour
{
    public GameObject leftPoint;
    public GameObject rightPoint;

    private Vector3 leftPos;
    private Vector3 rightPos;

    public float speed;

    public bool goingLeft;






    // Start is called before the first frame update
    void Start()
    {
        leftPos = leftPoint.transform.position;
        rightPos = rightPoint.transform.position;       
    }

    // Update is called once per frame
    void Update()
    {


        EnemyMove();
    }

    private void EnemyMove()
    {
        if (goingLeft == true)
        {
            if (transform.position.x <= leftPos.x)
            {
                goingLeft = false;
            }
            else
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }

        else
        {
            if (transform.position.x >= rightPos.x)
            {
                goingLeft = true;
            }
            else
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
        }
    }


}
