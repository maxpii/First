using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5;
    private void Start()
    {   
        StartCoroutine(ExecuteSomething());

    }
    IEnumerator ExecuteSomething() {
        yield return new WaitForSeconds(2f);
        Debug.Log("Something happened");
    }

    

    // Update is called once per frame
    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 pos = transform.position;
        
        pos.x += h* speed * Time.deltaTime;
        pos.y += v * speed * Time.deltaTime;

        transform.position = pos;
    }

}
