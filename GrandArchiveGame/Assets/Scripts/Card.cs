using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Element { Norm, Fire, Water, Wind, Arcane, Crux, Luxem, Tera }
public enum Type { Action, Ally, Attack, Champion, Domain, Item, Regalia, Unique, Weapon, Null }
public enum Subtype
{
    Accessory, Angel, Animal, Ape, Artifact, Assassin, Bauble, Beast, Bird, Boar, Book, Bull, Castle, Cleric, Construct, Craft, Crystal, Dagger, Dog, Dryad, Elemental,
    Fairy, Flute, Golem, Guardian, Harmony, Horn, Horse, Human, Instrument, Isle, Lion, Mage, Map, Melody, Phoenix, Rabbit, Ranger, Reaction, Ring, Scepter, Selkie,
    Serpent, Skill, Slime, Spell, Spirit, Squirrel, Sword, Tamer, Turtle, Warrior, Wolf, Null
}
public enum Class { Assassin, Cleric, Guardian, Mage, Ranger, Tamer, Spirit, Warrior }

public class Card : ScriptableObject
{
    public string uuid;
    public Type[] types;
    public Class[] classes;
    public Subtype[] subtypes;
    public Element Element;
    public string name;
    public string slug;
    public string effect;
    public string effect_raw;
    public Rule[] rule;
    public string flavor;
    public int cost_memory;
    public int cost_reserve;
    public int level;
    public int power;
    public int life;
    public int durability;
    public bool speed;
    public bool legality;
    public Legality Legality;
    public object related_ids;
    public string last_update;
    public object result_editions;
    public Edition[] editions;
}

public class Rule
{
    public string title;
    public string date_added;
    public string description;
}
public class Legality
{
    public FormatLegality STANDARD;
}
public class FormatLegality
{
    public int limit;
}
public class Edition
{
    public string uuid;
    public string card_id;
    public string collector_number;
    public string slug;
    public string illustrator;
    public int rarity;
    public string effect;
    public string flavor;
    public string last_update;
    public int thema_grace_nonfoil;
    public int thema_valor_nonfoil;
    public int thema_charm_nonfoil;
    public int thema_mystique_nonfoil;
    public int thema_ferocity_nonfoil;
    public int thema_grace_foil;
    public int thema_valor_foil;
    public int thema_charm_foil;
    public int thema_mystique_foil;
    public int thema_ferocity_foil;
    public int thema_foil;
    public int thema_nonfoil;
    public object circulations;
    public CirculationTemplate[] circulationTemplates;
    public Set set;
}
public class CirculationTemplate
{
    public string uuid;
    public string name;
    public bool foil;
    public bool printing;
    public string population_operator;
    public int population;
}
public class Set
{
    public string name;
    public string prefix;
    public string language;
    public string last_update;
}