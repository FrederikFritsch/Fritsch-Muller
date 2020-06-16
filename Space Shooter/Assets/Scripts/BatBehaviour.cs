using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatBehaviour : MonoBehaviour
{

    void Update()
    {
        if(this.transform.position.y <= -5.0f) {
            Debug.Log("BordeFörstöra nåt nu!");
            Destroy(this.gameObject);
        }
    }
}
