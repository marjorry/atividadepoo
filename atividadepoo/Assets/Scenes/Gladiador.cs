using UnityEngine;

public class Gladiador : Personagem
{
    public enum ArmaDoGladiador
    {
        TRIDENTE, REDE
    }

    public enum ArmaduraDoGladiador
    {
        COLETE_DE_ACO
    }

    [SerializeField]
    private ArmaduraDoGladiador armadura;

    [SerializeField]
    private ArmaDoGladiador arma;

    public void AtribuirArmadura(ArmaduraDoGladiador armadura)
    {
        this.armadura = armadura;
    }

    public ArmaduraDoGladiador GetArmadura()
    {
        return this.armadura;
    }

    public void AtribuirArma(ArmaDoGladiador arma)
    {
        this.arma = arma;
    }

    public ArmaDoGladiador GetArma()
    {
        return this.arma;
    }

    public int DanoDoGladiador()
    {
        int dano = 0;

        switch (arma)
        {
            case ArmaDoGladiador.TRIDENTE:
                dano = GetAtaque() + 15;
                break;
            case ArmaDoGladiador.REDE:
                dano = GetAtaque() + 5;
                break;
        }

        return dano;
    }

    public void RedeDeCaptura(Personagem alvo)
    {
        Debug.Log("Gladiador usou Rede de Captura em " + alvo.GetNome());
    }

    void Start()
    {
        // Exemplo de teste:
        AtribuirNome("Maximus");
        AtribuirAtaque(20);
        AtribuirArma(ArmaDoGladiador.TRIDENTE);

        Debug.Log("Nome: " + GetNome());
        Debug.Log("Ataque Base: " + GetAtaque());
        Debug.Log("Arma: " + GetArma());
        Debug.Log("Dano do Gladiador: " + DanoDoGladiador());
    }

    void Update()
    {
        
    }
}