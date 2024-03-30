using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

[CreateAssetMenu(fileName = "NamePokemonDataBase", menuName = "Database/Pokemon", order = 0)]
public class PokemonDataBase : ScriptableObject
{
    public List<PokemonData> datas = new();

    public void CreateData()
    {
        PokemonData newPoke = new(
        name: "Noctali",
        idPoke: 02,
        icon: null,
        type: "Plante et Poison",
        size: 100,
        weight: 27,
        caption: "Quand il s’expose aux ondes lunaires, ses anneaux brillent légèrement et il acquiert un mystérieux pouvoir."); ;


        datas.Add(newPoke);
    }

    public PokemonData GetData(int id) => datas[id];
}
