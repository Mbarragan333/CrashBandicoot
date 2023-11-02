using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//wright shane
//10-2023
public class Laser : MonoBehaviour
{
    public float speed;
    public bool moveRight;

    public float despawnTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DespawnTimer());
    }

    // Update is called once per frame
    void Update()
    {
        if (moveRight)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }

    IEnumerator DespawnTimer()
    {
        yield return new WaitForSeconds(despawnTime);
        Destroy(this.gameObject);
    }
}
