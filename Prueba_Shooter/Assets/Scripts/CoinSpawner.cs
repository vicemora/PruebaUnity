using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject MonedaPrefab;
    public Moneda Moneda;
    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Moneda.contMon<3){
            mostrarMoneda();
        }
    }

    public void mostrarMoneda(){
        GameObject monedita1 = Instantiate(MonedaPrefab);
        float xr=Random.Range(-5.0f,5.0f);
        float yr=6.0f;
        monedita1.transform.position= new Vector3(xr,yr,0);  
        Moneda.contMon+=1;
    }
}