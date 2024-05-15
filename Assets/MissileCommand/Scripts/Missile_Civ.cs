using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile_Civ : MonoBehaviour
{
    public float speed = .25f;
    public bool moveRight;

    public GameObject explosionPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Rotate();
    }

    // Update is called once per frame
    void Update()
    {
        if (moveRight)
        {
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }
        else
        {
            transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
        }
    }

    public void Rotate()
    {
        if (moveRight) 
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            Instantiate(explosionPrefab, collision.gameObject.transform.position, collision.gameObject.transform.rotation);

            Missile_Score scoreboard = FindObjectOfType<Missile_Score>();

            scoreboard.ScoreMissile(-25);

            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Boundary")
        {
            moveRight = !moveRight;
            Rotate();
        }

    }
}
