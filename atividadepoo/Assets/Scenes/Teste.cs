using UnityEngine;

public class TesteCombate : MonoBehaviour
{
    void Start()
    {
        
        Gladiador gladiador = new GameObject("Gladiador").AddComponent<Gladiador>();
        gladiador.AtribuirNome("Maximus");
        gladiador.AtribuirVida(100);
        gladiador.AtribuirAtaque(20);
        gladiador.AtribuirDefesa(5);
        gladiador.AtribuirArma(Gladiador.ArmaDoGladiador.TRIDENTE);

        
        Personagem Personagem = new GameObject("personagem").AddComponent<Personagem>();
        Personagem.AtribuirNome("Gladiador");
        Personagem.AtribuirVida(80);
        Personagem.AtribuirAtaque(10);
        Personagem.AtribuirDefesa(3);

      
        Debug.Log("--- Combate Iniciado ---");
        Debug.Log(gladiador.GetNome() + " (Gladiador) VS " + Personagem.GetNome());
        Debug.Log("Gladiador ataca com: " + gladiador.GetArma());
        Debug.Log("Dano causado: " + gladiador.DanoDoGladiador());
        Debug.Log(gladiador + " recebeu " + " de dano. Vida restante: " + 100);

        
        Personagem.ReceberDano(gladiador.DanoDoGladiador());
    }

    void Update()
    {
        
    }
}