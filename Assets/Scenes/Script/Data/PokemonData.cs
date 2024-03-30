using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PokemonData
{
    public string name;
    public float size;
    public float weight;
    public string caption;
    public Sprite icon;
    public string type;
    public float idPoke;

    public PokemonStats stats;
    public PokemonData(string name, float size, float idPoke, float weight, string caption, Sprite icon, string type)
    {
        this.name = name;
        this.size = size;
        this.idPoke = idPoke;
        this.weight = weight;
        this.caption = caption;
        this.icon = icon;
        this.type = type;
    }
}

[Serializable]
public struct PokemonStats
{
    public int pv;
    public int atk;
    public int def;
    public int atkSpe;
    public int defSpe;
    public int speed;

    public PokemonStats(int pv, int atk, int def, int atkSpe, int defSpe, int speed)
    {
        this.pv = pv;
        this.atk = atk;
        this.def = def;
        this.atkSpe = atkSpe;
        this.defSpe = defSpe;
        this.speed = speed;
    }
    public PokemonStats(PokemonStats statsBase, int coeff)
    {
        pv =statsBase.pv * coeff;
        atk = statsBase.atk * coeff;
        def = statsBase. def * coeff;
        atkSpe = statsBase. atkSpe * coeff;
        defSpe = statsBase. defSpe * coeff;
        speed = statsBase. speed * coeff;
    }
    public PokemonStats GetStatsByLvl(PokemonStats statBase, int level, int evolutionStep)
    {
        var coeff = level * evolutionStep / 10;
        return new PokemonStats(statBase, coeff);
    }
}
