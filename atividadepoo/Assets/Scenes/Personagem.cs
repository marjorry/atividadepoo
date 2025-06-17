using UnityEngine;

public class Personagem : MonoBehaviour
{
    [SerializeField] public string Nome;
    [SerializeField] public int Vida;
    [SerializeField] public int Ataque;
    [SerializeField] public int Defesa;

    public void AtribuirNome(string nome)
    {
        this.Nome = nome;
    }

    public string GetNome()
    {
        return this.Nome;
    }

    public void AtribuirVida(int vida)
    {
        this.Vida = vida;
    }

    public int GetVida()
    {
        return this.Vida;
    }

    public void AtribuirAtaque(int ataque)
    {
        this.Ataque = ataque;
    }

    public int GetAtaque()
    {
        return this.Ataque;
    }

    public void AtribuirDefesa(int defesa)
    {
        this.Defesa = defesa;
    }

    public int GetDefesa()
    {
        return this.Defesa;
    }

    public void ReceberDano(int dano)
    {
        int danoFinal = Mathf.Max(dano - Defesa, 0);
        Vida -= danoFinal;

        Debug.Log(Nome + " recebeu " + danoFinal + " de dano. Vida restante: " + Vida);
    }
}