using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeMissileAct : MonoBehaviour
{

    public GameObject missile;
    public GameObject smoke;
    float force = 3000.0f;
    GameManager gameManager;
    


    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newMissile = Instantiate(missile, transform.position, transform.rotation);

            Renderer missileRenderer = newMissile.GetComponent<Renderer>();                     //미사일의 색상을 랜덤하게 바꿈
            Color randomColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            missileRenderer.material.color = randomColor;

            Rigidbody2D rb2 = newMissile.GetComponent<Rigidbody2D>();
            rb2.AddForce(Vector2.right * force);
            Instantiate(smoke, transform.position, transform.rotation);
            gameManager.playMissile();
        }

    }

}
