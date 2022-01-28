using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Timer
    [SerializeField] private float timer = 1f;

    // Meu obstáculo
    [SerializeField] private GameObject obstaculo;

    // Posição para criar o obstáculo
    [SerializeField] private Vector3 posicao;

    // Posição mínima e máxima
    [SerializeField] private float posMin = -0.3f;
    [SerializeField] private float posMax = 2.4f;

    // Tempo mínimo e máximo
    [SerializeField] private float tMin = 1f;
    [SerializeField] private float tMAx = 3f;

    // Variável dos pontos
    private float pontos = 0f;

    // Variável dos pontos do canvas
    [SerializeField] private Text pontosTexto;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Dando oi SE timer for menor ou igual a 0
        // diminuir o valor do time por time.deltatime
        // Checar se o valor é menor ou igual a 0
        // SE a condião for verdadeira então diga "Oi"

        // Ganhando pontos
        Pontos();



        // Refatore este código e chame de CriaObstáculo
        CriaObstaculo();
    }

        // Criando o método para lidar com os pontos
        private void Pontos()
        {
        pontos += Time.deltaTime;

        // Passando os meus pontos para o texto dos pontos
        pontosTexto.text = Mathf.Round(pontos).ToString();


        Debug.Log(Mathf.Round(pontos));
    }

    private void CriaObstaculo()
    {
        timer -= Time.deltaTime;
        // timer = timer - Time.deltaTime;

        if (timer <= 0)
        {
            Debug.Log("Oi");

            // Resetando o meu timer
            // Timer vai ficar com um valor aleatório entre 1f e 3f
            timer = Random.Range(tMin, tMAx);



            posicao.y = Random.Range(posMin, posMax);

            // Criando os meus obstáculos
            // Comando para instanciar algo
            Instantiate(obstaculo, posicao, Quaternion.identity);
        }
    }

    
}
