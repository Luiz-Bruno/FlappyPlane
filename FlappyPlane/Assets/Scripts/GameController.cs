using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Timer
    [SerializeField] private float timer = 1f;

    // Meu obst?culo
    [SerializeField] private GameObject obstaculo;

    // Posi??o para criar o obst?culo
    [SerializeField] private Vector3 posicao;

    // Posi??o m?nima e m?xima
    [SerializeField] private float posMin = -0.3f;
    [SerializeField] private float posMax = 2.4f;

    // Tempo m?nimo e m?ximo
    [SerializeField] private float tMin = 1f;
    [SerializeField] private float tMAx = 3f;

    // Vari?vel dos pontos
    private float pontos = 0f;

    // Vari?vel dos pontos do canvas
    [SerializeField] private Text pontosTexto;

    // Vari?vel do level
    private int level = 1;
    [SerializeField] private Text levelTexto;

    // Vari?vel para ganhar level
    [SerializeField] private float proximoLevel = 10f;

    // Vari?vel do som
    [SerializeField] private AudioClip levelUp;

    // Varia?vel com a posi??o da minha c?mera
    private Vector3 camPos;
    
    // Start is called before the first frame update
    void Start()
    {
        camPos = Camera.main.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Dando oi SE timer for menor ou igual a 0
        // diminuir o valor do time por time.deltatime
        // Checar se o valor ? menor ou igual a 0
        // SE a condi?o for verdadeira ent?o diga "Oi"

        // Ganhando pontos
        Pontos();



        // Refatore este c?digo e chame de CriaObst?culo
        CriaObstaculo();

        // Ganhando level
        GanhaLevel();
    }

        // Criando o m?todo para lidar com os pontos
    private void Pontos()
    {
        pontos += Time.deltaTime * level;

        // Passando os meus pontos para o texto dos pontos
        pontosTexto.text = Mathf.Round(pontos).ToString();

    }

    // Ganhando level
    private void GanhaLevel()
    {
       

        // Passando o level para o texto do level
        levelTexto.text = level.ToString();


        // SE os pontos forem maiores do que pr?ximo level, ent?o eu aumento o valor do level
        // Eu dobro a quantidade de pontos para o pr?ximo level
        if (pontos > proximoLevel)
        {
            // Tocando o som
            AudioSource.PlayClipAtPoint(levelUp, transform.position);
            
            // Aumentando o level em 1
            level++;
            // Dobrando o valor do pr?ximo level
            proximoLevel = proximoLevel * 2; // proximoLevel *= 2;
        }
    }

    private void CriaObstaculo()
    {
        timer -= Time.deltaTime;
        // timer = timer - Time.deltaTime;

        if (timer <= 0)
        {
            

            // Resetando o meu timer
            // Timer vai ficar com um valor aleat?rio entre 1f e 3f
            timer = Random.Range(tMin / level, tMAx);



            posicao.y = Random.Range(posMin, posMax);

            // Criando os meus obst?culos
            // Comando para instanciar algo
            Instantiate(obstaculo, posicao, Quaternion.identity);
        }
    }

    // Criando um m?todo para retornar o level
    public int RetornaLevel()
    {
        return level;
    }

}
