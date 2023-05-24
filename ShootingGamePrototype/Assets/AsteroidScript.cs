using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    public float speed = 4.5f;     //���༺ �̵� �ӵ�
    public float rotSpeed = 50; //���༺ ȸ�� �ӵ�
    public float coin = 2;
    public int hp = 10;
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime; //�̵�-���� �̿�
        transform.Rotate(new Vector3(0,0,Time.deltaTime*rotSpeed));  //ȸ��-Rotate �Լ� �̿�
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}