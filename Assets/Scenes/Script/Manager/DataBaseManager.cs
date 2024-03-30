using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBaseManager : MonoBehaviour
{
    public PokemonDataBase database;

    private void Start()
    {
        //database.CreateData();

        PokemonStats newStats = database.datas[0].stats;
        LoadStatsTo(database.datas[1], newStats.GetStatsByLvl(newStats,5, 2));
    }
    public PokemonData GetData(int id) => database.datas[id];
    public void LoadStatsTo(PokemonData data, PokemonStats stats)
    {
        data.stats = stats;
    }
   
}
