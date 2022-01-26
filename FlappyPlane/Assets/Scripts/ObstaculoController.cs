using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoController : MonoBehaviour
{

    // Variável dfe velocidade
    [SerializeField] private float velocidade = 5f;

    [SerializeField] private GameObject eu;


    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(eu, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        // Indo para a esquerda
        //transform.position = transform.position + Vector3.left;
        transform.position += Vector3.left * Time.deltaTime * velocidade;
    }
}
