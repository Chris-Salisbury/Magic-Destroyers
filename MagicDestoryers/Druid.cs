﻿public class Druid
{
    private string faction;
    private string name;

    private int abilityPoints;
    private int healthPoints;
    private int level;

    private Leathervest bodyArmor;
    private Staff weapon;

    public string Faction { get; set; }
    public string Name { get; set; }

    public int AbilityPoints { get; set; }
    public int HealthPoints { get; set; }
    public int Level { get; set; }

    public Chainlink BodyArmor { get; set; }
    public Axe Weapon { get; set; }
}