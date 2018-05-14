using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    public float damage = 1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
        Player player = collision.collider.GetComponent<Player>();
        if (player != null)
        {
            player.ApplyDamage(damage);
        }
    }
}