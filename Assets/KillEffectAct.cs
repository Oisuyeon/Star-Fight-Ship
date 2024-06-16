using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEffectAct : MonoBehaviour
{
    //float killTime = 3.0f;
    float totalTime = 0.0f;
    float showTime = 0.5f;
    float hideTime = 2.0f;
    Renderer rend;
    Color color;

    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject, killTime);
        rend = gameObject.GetComponent<Renderer>();
        color = rend.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        totalTime += Time.deltaTime;
        float alpha = 0.0f;
        if (totalTime <= showTime) // ȿ���� ���̰� �ϱ�
        {
            alpha = totalTime / showTime; // 0 -> 1�� �̵�
        }
        else if (totalTime <= showTime + hideTime) // ȿ�� ���߱�
        {
            alpha = 1.0f - (totalTime - showTime) / hideTime; // 1 -> 0���� �̵�
        }
        else
        {
            Destroy(gameObject);
        }
        color.a = alpha;
        rend.material.color = color;
    }
}