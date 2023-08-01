using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 20;
    Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player")
        {
            player.PlayerHp -= damage;
            print(player.PlayerHp);
            Destroy(this.gameObject);
            if(player.PlayerHp <= 0)
            {
                player.isDead = true;
                Destroy(other.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 15f * Time.deltaTime);
    }
}
