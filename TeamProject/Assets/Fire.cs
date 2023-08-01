using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bulletPrefab;
    Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    void Shoot(){
        if(player.isDead == true)
            return;
        if(Input.GetMouseButtonDown(0)){
            GameObject bullet = Instantiate(bulletPrefab) as GameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }
}
