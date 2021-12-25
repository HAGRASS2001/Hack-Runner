using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : enemyController
{
    private playercontroller Player;

    // Start is called before the first frame update

    void Start()
    {
        Player = FindObjectOfType<playercontroller>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, maxspeed * Time.deltaTime);

        if (Player.transform.position.x < gameObject.transform.position.x && isfacingright)
        flip();

        if (Player.transform.position.x > gameObject.transform.position.x && !isfacingright)
        flip();
    }
}
