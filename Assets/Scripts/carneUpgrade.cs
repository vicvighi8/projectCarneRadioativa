using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carneUpgrade : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "bolo_de_carne_radioativo")
        {
            if(collision.gameObject.GetComponent<radioativeMeatGrowUp>().meatLevel < 5)
            collision.gameObject.GetComponent<radioativeMeatGrowUp>().meatLevel++;
            
            //executar anima��o da carne sumindo

            Destroy(this.gameObject);
        }
    }
}
