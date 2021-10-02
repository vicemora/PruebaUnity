using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    
    public static int contMon=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoverMoneda();
    }

    void MoverMoneda(){
        gameObject.transform.position= new Vector3(this.gameObject.transform.position.x,
        gameObject.transform.position.y -0.01f,0f); 
    }
    
    void OnBecameInvisible(){
        contMon-=1;
        Destroy(gameObject);
    }
}
