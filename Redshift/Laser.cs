using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _speed = 8.0f;

    // Update is called once per frame
    void Update()
    {
        // Speed of laser
        transform.Translate(Vector3.up * _speed * Time.deltaTime);

        if (transform.position.y > 8.0f) {
            Destroy(this.gameObject);
        }
          
    }
}
