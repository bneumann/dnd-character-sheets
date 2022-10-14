#pragma warning disable CS8618
namespace DnDCharacterSheets;

using System.ComponentModel;
using System.Runtime.CompilerServices;
using Annotations;

public class DnDCharacter : INotifyPropertyChanged, IDnDCharacter
{
    private string name;
    private string classLevel;
    private string background;
    private string playerName;
    private string faction;
    private string race;
    private string alignment;
    private string xp;
    private string dciNo;
    private int str;
    private int dex;
    private int con;
    private int i;
    private int wis;
    private int cha;
    private int inspiration;
    private int proficiencyBonus;
    private int strSave;
    private bool strSaveChecked;
    private int dexSave;
    private bool dexSaveChecked;
    private int conSave;
    private bool conSaveChecked;
    private int intSave;
    private bool intSaveChecked;
    private int wisSave;
    private bool wisSaveChecked;
    private int chaSave;
    private bool chaSaveChecked;
    private int skillAcrobatics;
    private bool skillAcrobaticsChecked;
    private int skillAnimalHandling;
    private bool skillAnimalHandlingChecked;
    private int skillArcana;
    private bool skillArcanaChecked;
    private int skillAthletics;
    private bool skillAthleticsChecked;
    private int skillDeception;
    private bool skillDeceptionChecked;
    private int skillHistory;
    private bool skillHistoryChecked;
    private int skillInsight;
    private bool skillInsightChecked;
    private int skillIntimidation;
    private bool skillIntimidationChecked;
    private int skillInvestigation;
    private bool skillInvestigationChecked;
    private int skillMedicine;
    private bool skillMedicineChecked;
    private int skillNature;
    private bool skillNatureChecked;
    private int skillPerception;
    private bool skillPerceptionChecked;
    private int skillPerformance;
    private bool skillPerformanceChecked;
    private int skillPersuasion;
    private bool skillPersuasionChecked;
    private int skillReligion;
    private bool skillReligionChecked;
    private int skillSlightOfHand;
    private bool skillSlightOfHandChecked;
    private int skillStealth;
    private bool skillStealthChecked;
    private int skillSurvival;
    private bool skillSurvivalChecked;
    private int passivePerception;
    private string otherProficiencies;
    private int ac;
    private int init;
    private int speed;
    private int maxHp;
    private int hp;
    private int tempHp;
    private string hitDiceMax;
    private string hitDice;
    private int deathsaveSuccesses;
    private int deathsaveFailures;
    private List<Attack> attacks = new() { new(), new(), new() };
    private string attacksText;
    private int copperPieces;
    private int silverPieces;
    private int etherumPieces;
    private int goldPieces;
    private int platinumPieces;
    private string equipment;
    private string equipment2;
    private string personalityTraits;
    private string ideals;
    private string bonds;
    private string flaws;
    private string featuresTraits;
    private int age;
    private int height;
    private int weight;
    private string eyes;
    private string skin;
    private string hair;
    private string appearance;
    private string backstory;
    private string factionImg;
    private string factionRank;
    private string allies;
    private string allies2;
    private string additionalFeatures;
    private string additionalFeatures2;
    private int totalNonConsumableMagicItems;
    private string treasure;
    private string treasure2;
    private string spellcastingClass;
    private int preparedSpellsTotal;
    private int spellSaveDc;
    private int spellAttackBonus;
    private List<Spell> cantrips = new();
    private int lvl1SpellSlotsTotal = 6;
    private int lvl1SpellSlotsUsed;
    private List<Spell> lvl1Spells = new();
    private int lvl2SpellSlotsTotal = 6;
    private int lvl2SpellSlotsUsed;
    private List<Spell> lvl2Spells = new();
    private int lvl3SpellSlotsTotal = 6;
    private int lvl3SpellSlotsUsed;
    private List<Spell> lvl3Spells = new();
    private int lvl4SpellSlotsTotal = 6;
    private int lvl4SpellSlotsUsed;
    private List<Spell> lvl4Spells = new();
    private int lvl5SpellSlotsTotal = 6;
    private int lvl5SpellSlotsUsed;
    private List<Spell> lvl5Spells = new();
    private int lvl6SpellSlotsTotal = 6;
    private int lvl6SpellSlotsUsed;
    private List<Spell> lvl6Spells = new();
    private int lvl7SpellSlotsTotal = 6;
    private int lvl7SpellSlotsUsed;
    private List<Spell> lvl7Spells = new();
    private int lvl8SpellSlotsTotal = 6;
    private int lvl8SpellSlotsUsed;
    private List<Spell> lvl8Spells = new();
    private int lvl9SpellSlotsTotal = 6;
    private int lvl9SpellSlotsUsed;
    private List<Spell> lvl9Spells = new();

    public string Name
    {
        get => name;
        set
        {
            name = value;
            OnPropertyChanged();
        }
    }

    public string ClassLevel
    {
        get => classLevel;
        set { classLevel = value; OnPropertyChanged(); }
    }

    public string Background
    {
        get => background;
        set { background = value; OnPropertyChanged(); }
    }

    public string PlayerName
    {
        get => playerName;
        set { playerName = value; OnPropertyChanged(); }
    }

    public string Faction
    {
        get => faction;
        set { faction = value; OnPropertyChanged(); }
    }

    public string Race
    {
        get => race;
        set { race = value; OnPropertyChanged(); }
    }

    public string Alignment
    {
        get => alignment;
        set { alignment = value; OnPropertyChanged(); }
    }

    public string Xp
    {
        get => xp;
        set { xp = value; OnPropertyChanged(); }
    }

    public string DciNo
    {
        get => dciNo;
        set { dciNo = value; OnPropertyChanged(); }
    }

    public int Str
    {
        get => str;
        set { str = value; OnPropertyChanged(); }
    }

    public int Dex
    {
        get => dex;
        set { dex = value; OnPropertyChanged(); }
    }

    public int Con
    {
        get => con;
        set { con = value; OnPropertyChanged(); }
    }

    public int Int
    {
        get => i;
        set { i = value; OnPropertyChanged(); }
    }

    public int Wis
    {
        get => wis;
        set { wis = value; OnPropertyChanged(); }
    }

    public int Cha
    {
        get => cha;
        set { cha = value; OnPropertyChanged(); }
    }

    public int Inspiration
    {
        get => inspiration;
        set { inspiration = value; OnPropertyChanged(); }
    }

    public int ProficiencyBonus
    {
        get => proficiencyBonus;
        set { proficiencyBonus = value; OnPropertyChanged(); }
    }

    public int StrSave
    {
        get => strSave;
        set { strSave = value; OnPropertyChanged(); }
    }

    public bool StrSaveChecked
    {
        get => strSaveChecked;
        set { strSaveChecked = value; OnPropertyChanged(); }
    }

    public int DexSave
    {
        get => dexSave;
        set { dexSave = value; OnPropertyChanged(); }
    }

    public bool DexSaveChecked
    {
        get => dexSaveChecked;
        set { dexSaveChecked = value; OnPropertyChanged(); }
    }

    public int ConSave
    {
        get => conSave;
        set { conSave = value; OnPropertyChanged(); }
    }

    public bool ConSaveChecked
    {
        get => conSaveChecked;
        set { conSaveChecked = value; OnPropertyChanged(); }
    }

    public int IntSave
    {
        get => intSave;
        set { intSave = value; OnPropertyChanged(); }
    }

    public bool IntSaveChecked
    {
        get => intSaveChecked;
        set { intSaveChecked = value; OnPropertyChanged(); }
    }

    public int WisSave
    {
        get => wisSave;
        set { wisSave = value; OnPropertyChanged(); }
    }

    public bool WisSaveChecked
    {
        get => wisSaveChecked;
        set { wisSaveChecked = value; OnPropertyChanged(); }
    }

    public int ChaSave
    {
        get => chaSave;
        set { chaSave = value; OnPropertyChanged(); }
    }

    public bool ChaSaveChecked
    {
        get => chaSaveChecked;
        set { chaSaveChecked = value; OnPropertyChanged(); }
    }

    public int SkillAcrobatics
    {
        get => skillAcrobatics;
        set { skillAcrobatics = value; OnPropertyChanged(); }
    }

    public bool SkillAcrobaticsChecked
    {
        get => skillAcrobaticsChecked;
        set { skillAcrobaticsChecked = value; OnPropertyChanged(); }
    }

    public int SkillAnimalHandling
    {
        get => skillAnimalHandling;
        set { skillAnimalHandling = value; OnPropertyChanged(); }
    }

    public bool SkillAnimalHandlingChecked
    {
        get => skillAnimalHandlingChecked;
        set { skillAnimalHandlingChecked = value; OnPropertyChanged(); }
    }

    public int SkillArcana
    {
        get => skillArcana;
        set { skillArcana = value; OnPropertyChanged(); }
    }

    public bool SkillArcanaChecked
    {
        get => skillArcanaChecked;
        set { skillArcanaChecked = value; OnPropertyChanged(); }
    }

    public int SkillAthletics
    {
        get => skillAthletics;
        set { skillAthletics = value; OnPropertyChanged(); }
    }

    public bool SkillAthleticsChecked
    {
        get => skillAthleticsChecked;
        set { skillAthleticsChecked = value; OnPropertyChanged(); }
    }

    public int SkillDeception
    {
        get => skillDeception;
        set { skillDeception = value; OnPropertyChanged(); }
    }

    public bool SkillDeceptionChecked
    {
        get => skillDeceptionChecked;
        set { skillDeceptionChecked = value; OnPropertyChanged(); }
    }

    public int SkillHistory
    {
        get => skillHistory;
        set { skillHistory = value; OnPropertyChanged(); }
    }

    public bool SkillHistoryChecked
    {
        get => skillHistoryChecked;
        set { skillHistoryChecked = value; OnPropertyChanged(); }
    }

    public int SkillInsight
    {
        get => skillInsight;
        set { skillInsight = value; OnPropertyChanged(); }
    }

    public bool SkillInsightChecked
    {
        get => skillInsightChecked;
        set { skillInsightChecked = value; OnPropertyChanged(); }
    }

    public int SkillIntimidation
    {
        get => skillIntimidation;
        set { skillIntimidation = value; OnPropertyChanged(); }
    }

    public bool SkillIntimidationChecked
    {
        get => skillIntimidationChecked;
        set { skillIntimidationChecked = value; OnPropertyChanged(); }
    }

    public int SkillInvestigation
    {
        get => skillInvestigation;
        set { skillInvestigation = value; OnPropertyChanged(); }
    }

    public bool SkillInvestigationChecked
    {
        get => skillInvestigationChecked;
        set { skillInvestigationChecked = value; OnPropertyChanged(); }
    }

    public int SkillMedicine
    {
        get => skillMedicine;
        set { skillMedicine = value; OnPropertyChanged(); }
    }

    public bool SkillMedicineChecked
    {
        get => skillMedicineChecked;
        set { skillMedicineChecked = value; OnPropertyChanged(); }
    }

    public int SkillNature
    {
        get => skillNature;
        set { skillNature = value; OnPropertyChanged(); }
    }

    public bool SkillNatureChecked
    {
        get => skillNatureChecked;
        set { skillNatureChecked = value; OnPropertyChanged(); }
    }

    public int SkillPerception
    {
        get => skillPerception;
        set { skillPerception = value; OnPropertyChanged(); }
    }

    public bool SkillPerceptionChecked
    {
        get => skillPerceptionChecked;
        set { skillPerceptionChecked = value; OnPropertyChanged(); }
    }

    public int SkillPerformance
    {
        get => skillPerformance;
        set { skillPerformance = value; OnPropertyChanged(); }
    }

    public bool SkillPerformanceChecked
    {
        get => skillPerformanceChecked;
        set { skillPerformanceChecked = value; OnPropertyChanged(); }
    }

    public int SkillPersuasion
    {
        get => skillPersuasion;
        set { skillPersuasion = value; OnPropertyChanged(); }
    }

    public bool SkillPersuasionChecked
    {
        get => skillPersuasionChecked;
        set { skillPersuasionChecked = value; OnPropertyChanged(); }
    }

    public int SkillReligion
    {
        get => skillReligion;
        set { skillReligion = value; OnPropertyChanged(); }
    }

    public bool SkillReligionChecked
    {
        get => skillReligionChecked;
        set { skillReligionChecked = value; OnPropertyChanged(); }
    }

    public int SkillSlightOfHand
    {
        get => skillSlightOfHand;
        set { skillSlightOfHand = value; OnPropertyChanged(); }
    }

    public bool SkillSlightOfHandChecked
    {
        get => skillSlightOfHandChecked;
        set { skillSlightOfHandChecked = value; OnPropertyChanged(); }
    }

    public int SkillStealth
    {
        get => skillStealth;
        set { skillStealth = value; OnPropertyChanged(); }
    }

    public bool SkillStealthChecked
    {
        get => skillStealthChecked;
        set { skillStealthChecked = value; OnPropertyChanged(); }
    }

    public int SkillSurvival
    {
        get => skillSurvival;
        set { skillSurvival = value; OnPropertyChanged(); }
    }

    public bool SkillSurvivalChecked
    {
        get => skillSurvivalChecked;
        set { skillSurvivalChecked = value; OnPropertyChanged(); }
    }

    public int PassivePerception
    {
        get => passivePerception;
        set { passivePerception = value; OnPropertyChanged(); }
    }

    public string OtherProficiencies
    {
        get => otherProficiencies;
        set { otherProficiencies = value; OnPropertyChanged(); }
    }

    public int Ac
    {
        get => ac;
        set { ac = value; OnPropertyChanged(); }
    }

    public int Init
    {
        get => init;
        set { init = value; OnPropertyChanged(); }
    }

    public int Speed
    {
        get => speed;
        set { speed = value; OnPropertyChanged(); }
    }

    public int MaxHp
    {
        get => maxHp;
        set { maxHp = value; OnPropertyChanged(); }
    }

    public int Hp
    {
        get => hp;
        set { hp = value; OnPropertyChanged(); }
    }

    public int TempHp
    {
        get => tempHp;
        set { tempHp = value; OnPropertyChanged(); }
    }

    public string HitDiceMax
    {
        get => hitDiceMax;
        set { hitDiceMax = value; OnPropertyChanged(); }
    }

    public string HitDice
    {
        get => hitDice;
        set { hitDice = value; OnPropertyChanged(); }
    }

    public int DeathsaveSuccesses
    {
        get => deathsaveSuccesses;
        set { deathsaveSuccesses = value; OnPropertyChanged(); }
    }

    public int DeathsaveFailures
    {
        get => deathsaveFailures;
        set { deathsaveFailures = value; OnPropertyChanged(); }
    }

    public List<Attack> Attacks
    {
        get => attacks;
        set { attacks = value; OnPropertyChanged(); }
    }

    public string AttacksText
    {
        get => attacksText;
        set { attacksText = value; OnPropertyChanged(); }
    }

    public int CopperPieces
    {
        get => copperPieces;
        set { copperPieces = value; OnPropertyChanged(); }
    }

    public int SilverPieces
    {
        get => silverPieces;
        set { silverPieces = value; OnPropertyChanged(); }
    }

    public int EtherumPieces
    {
        get => etherumPieces;
        set { etherumPieces = value; OnPropertyChanged(); }
    }

    public int GoldPieces
    {
        get => goldPieces;
        set { goldPieces = value; OnPropertyChanged(); }
    }

    public int PlatinumPieces
    {
        get => platinumPieces;
        set { platinumPieces = value; OnPropertyChanged(); }
    }

    public string Equipment
    {
        get => equipment;
        set { equipment = value; OnPropertyChanged(); }
    }

    public string Equipment2
    {
        get => equipment2;
        set { equipment2 = value; OnPropertyChanged(); }
    }

    public string PersonalityTraits
    {
        get => personalityTraits;
        set { personalityTraits = value; OnPropertyChanged(); }
    }

    public string Ideals
    {
        get => ideals;
        set { ideals = value; OnPropertyChanged(); }
    }

    public string Bonds
    {
        get => bonds;
        set { bonds = value; OnPropertyChanged(); }
    }

    public string Flaws
    {
        get => flaws;
        set { flaws = value; OnPropertyChanged(); }
    }

    public string FeaturesTraits
    {
        get => featuresTraits;
        set { featuresTraits = value; OnPropertyChanged(); }
    }

    public int Age
    {
        get => age;
        set { age = value; OnPropertyChanged(); }
    }

    public int Height
    {
        get => height;
        set { height = value; OnPropertyChanged(); }
    }

    public int Weight
    {
        get => weight;
        set { weight = value; OnPropertyChanged(); }
    }

    public string Eyes
    {
        get => eyes;
        set { eyes = value; OnPropertyChanged(); }
    }

    public string Skin
    {
        get => skin;
        set { skin = value; OnPropertyChanged(); }
    }

    public string Hair
    {
        get => hair;
        set { hair = value; OnPropertyChanged(); }
    }

    public string Appearance
    {
        get => appearance;
        set { appearance = value; OnPropertyChanged(); }
    }

    public string Backstory
    {
        get => backstory;
        set { backstory = value; OnPropertyChanged(); }
    }

    public string FactionImg
    {
        get => factionImg;
        set { factionImg = value; OnPropertyChanged(); }
    }

    public string FactionRank
    {
        get => factionRank;
        set { factionRank = value; OnPropertyChanged(); }
    }

    public string Allies
    {
        get => allies;
        set { allies = value; OnPropertyChanged(); }
    }

    public string Allies2
    {
        get => allies2;
        set { allies2 = value; OnPropertyChanged(); }
    }

    public string AdditionalFeatures
    {
        get => additionalFeatures;
        set { additionalFeatures = value; OnPropertyChanged(); }
    }

    public string AdditionalFeatures2
    {
        get => additionalFeatures2;
        set { additionalFeatures2 = value; OnPropertyChanged(); }
    }

    public int TotalNonConsumableMagicItems
    {
        get => totalNonConsumableMagicItems;
        set { totalNonConsumableMagicItems = value; OnPropertyChanged(); }
    }

    public string Treasure
    {
        get => treasure;
        set { treasure = value; OnPropertyChanged(); }
    }

    public string Treasure2
    {
        get => treasure2;
        set { treasure2 = value; OnPropertyChanged(); }
    }

    public string SpellcastingClass
    {
        get => spellcastingClass;
        set { spellcastingClass = value; OnPropertyChanged(); }
    }

    public int PreparedSpellsTotal
    {
        get => preparedSpellsTotal;
        set { preparedSpellsTotal = value; OnPropertyChanged(); }
    }

    public int SpellSaveDC
    {
        get => spellSaveDc;
        set { spellSaveDc = value; OnPropertyChanged(); }
    }

    public int SpellAttackBonus
    {
        get => spellAttackBonus;
        set { spellAttackBonus = value; OnPropertyChanged(); }
    }

    public List<Spell> Cantrips
    {
        get => cantrips;
        set { cantrips = value; OnPropertyChanged(); }
    }

    public int Lvl1SpellSlotsTotal
    {
        get => lvl1SpellSlotsTotal;
        set { lvl1SpellSlotsTotal = value; OnPropertyChanged(); }
    }

    public int Lvl1SpellSlotsUsed
    {
        get => lvl1SpellSlotsUsed;
        set { lvl1SpellSlotsUsed = value; OnPropertyChanged(); }
    }

    public List<Spell> Lvl1Spells
    {
        get => lvl1Spells;
        set { lvl1Spells = value; OnPropertyChanged(); }
    }

    public int Lvl2SpellSlotsTotal
    {
        get => lvl2SpellSlotsTotal;
        set { lvl2SpellSlotsTotal = value; OnPropertyChanged(); }
    }

    public int Lvl2SpellSlotsUsed
    {
        get => lvl2SpellSlotsUsed;
        set { lvl2SpellSlotsUsed = value; OnPropertyChanged(); }
    }

    public List<Spell> Lvl2Spells
    {
        get => lvl2Spells;
        set { lvl2Spells = value; OnPropertyChanged(); }
    }

    public int Lvl3SpellSlotsTotal
    {
        get => lvl3SpellSlotsTotal;
        set { lvl3SpellSlotsTotal = value; OnPropertyChanged(); }
    }

    public int Lvl3SpellSlotsUsed
    {
        get => lvl3SpellSlotsUsed;
        set { lvl3SpellSlotsUsed = value; OnPropertyChanged(); }
    }

    public List<Spell> Lvl3Spells
    {
        get => lvl3Spells;
        set { lvl3Spells = value; OnPropertyChanged(); }
    }

    public int Lvl4SpellSlotsTotal
    {
        get => lvl4SpellSlotsTotal;
        set { lvl4SpellSlotsTotal = value; OnPropertyChanged(); }
    }

    public int Lvl4SpellSlotsUsed
    {
        get => lvl4SpellSlotsUsed;
        set { lvl4SpellSlotsUsed = value; OnPropertyChanged(); }
    }

    public List<Spell> Lvl4Spells
    {
        get => lvl4Spells;
        set { lvl4Spells = value; OnPropertyChanged(); }
    }

    public int Lvl5SpellSlotsTotal
    {
        get => lvl5SpellSlotsTotal;
        set { lvl5SpellSlotsTotal = value; OnPropertyChanged(); }
    }

    public int Lvl5SpellSlotsUsed
    {
        get => lvl5SpellSlotsUsed;
        set { lvl5SpellSlotsUsed = value; OnPropertyChanged(); }
    }

    public List<Spell> Lvl5Spells
    {
        get => lvl5Spells;
        set { lvl5Spells = value; OnPropertyChanged(); }
    }

    public int Lvl6SpellSlotsTotal
    {
        get => lvl6SpellSlotsTotal;
        set { lvl6SpellSlotsTotal = value; OnPropertyChanged(); }
    }

    public int Lvl6SpellSlotsUsed
    {
        get => lvl6SpellSlotsUsed;
        set { lvl6SpellSlotsUsed = value; OnPropertyChanged(); }
    }

    public List<Spell> Lvl6Spells
    {
        get => lvl6Spells;
        set { lvl6Spells = value; OnPropertyChanged(); }
    }

    public int Lvl7SpellSlotsTotal
    {
        get => lvl7SpellSlotsTotal;
        set { lvl7SpellSlotsTotal = value; OnPropertyChanged(); }
    }

    public int Lvl7SpellSlotsUsed
    {
        get => lvl7SpellSlotsUsed;
        set { lvl7SpellSlotsUsed = value; OnPropertyChanged(); }
    }

    public List<Spell> Lvl7Spells
    {
        get => lvl7Spells;
        set { lvl7Spells = value; OnPropertyChanged(); }
    }

    public int Lvl8SpellSlotsTotal
    {
        get => lvl8SpellSlotsTotal;
        set { lvl8SpellSlotsTotal = value; OnPropertyChanged(); }
    }

    public int Lvl8SpellSlotsUsed
    {
        get => lvl8SpellSlotsUsed;
        set { lvl8SpellSlotsUsed = value; OnPropertyChanged(); }
    }

    public List<Spell> Lvl8Spells
    {
        get => lvl8Spells;
        set { lvl8Spells = value; OnPropertyChanged(); }
    }

    public int Lvl9SpellSlotsTotal
    {
        get => lvl9SpellSlotsTotal;
        set { lvl9SpellSlotsTotal = value; OnPropertyChanged(); }
    }

    public int Lvl9SpellSlotsUsed
    {
        get => lvl9SpellSlotsUsed;
        set { lvl9SpellSlotsUsed = value; OnPropertyChanged(); }
    }

    public List<Spell> Lvl9Spells
    {
        get => lvl9Spells;
        set { lvl9Spells = value; OnPropertyChanged(); }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

public class Attack
{
    public string Name { get; set; }
    public string AttackBonus { get; set; }
    public string DamageType { get; set; }
}

public class Spell
{
    public string Name { get; set; }
    public bool Prepared { get; set; }
}