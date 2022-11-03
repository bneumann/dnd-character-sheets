namespace DnDCharacterSheets;

using System.ComponentModel;

#pragma warning disable CS8618
public interface IDnDCharacter
{
    string Name { get; set; }
    string ClassLevel { get; set; }
    string Background { get; set; }
    string PlayerName { get; set; }
    string Faction { get; set; }
    string Race { get; set; }
    string Alignment { get; set; }
    string Xp { get; set; }
    string DciNo { get; set; }
    int Str { get; set; }
    int Dex { get; set; }
    int Con { get; set; }
    int Wis { get; set; }
    int Cha { get; set; }
    int Inspiration { get; set; }
    int ProficiencyBonus { get; set; }
    int StrSave { get; set; }
    bool StrSaveChecked { get; set; }
    int DexSave { get; set; }
    bool DexSaveChecked { get; set; }
    int ConSave { get; set; }
    bool ConSaveChecked { get; set; }
    int IntSave { get; set; }
    bool IntSaveChecked { get; set; }
    int WisSave { get; set; }
    bool WisSaveChecked { get; set; }
    int ChaSave { get; set; }
    bool ChaSaveChecked { get; set; }
    int SkillAcrobatics { get; set; }
    bool SkillAcrobaticsChecked { get; set; }
    int SkillAnimalHandling { get; set; }
    bool SkillAnimalHandlingChecked { get; set; }
    int SkillArcana { get; set; }
    bool SkillArcanaChecked { get; set; }
    int SkillAthletics { get; set; }
    bool SkillAthleticsChecked { get; set; }
    int SkillDeception { get; set; }
    bool SkillDeceptionChecked { get; set; }
    int SkillHistory { get; set; }
    bool SkillHistoryChecked { get; set; }
    int SkillInsight { get; set; }
    bool SkillInsightChecked { get; set; }
    int SkillIntimidation { get; set; }
    bool SkillIntimidationChecked { get; set; }
    int SkillInvestigation { get; set; }
    bool SkillInvestigationChecked { get; set; }
    int SkillMedicine { get; set; }
    bool SkillMedicineChecked { get; set; }
    int SkillNature { get; set; }
    bool SkillNatureChecked { get; set; }
    int SkillPerception { get; set; }
    bool SkillPerceptionChecked { get; set; }
    int SkillPerformance { get; set; }
    bool SkillPerformanceChecked { get; set; }
    int SkillPersuasion { get; set; }
    bool SkillPersuasionChecked { get; set; }
    int SkillReligion { get; set; }
    bool SkillReligionChecked { get; set; }
    int SkillSlightOfHand { get; set; }
    bool SkillSlightOfHandChecked { get; set; }
    int SkillStealth { get; set; }
    bool SkillStealthChecked { get; set; }
    int SkillSurvival { get; set; }
    bool SkillSurvivalChecked { get; set; }
    int PassivePerception { get; set; }
    string OtherProficiencies { get; set; }
    int Ac { get; set; }
    int Init { get; set; }
    int Speed { get; set; }
    int MaxHp { get; set; }
    int Hp { get; set; }
    int TempHp { get; set; }
    string HitDiceMax { get; set; }
    string HitDice { get; set; }
    int DeathsaveSuccesses { get; set; }
    int DeathsaveFailures { get; set; }
    List<Attack> Attacks { get; set; }
    string AttacksText { get; set; }
    int CopperPieces { get; set; }
    int SilverPieces { get; set; }
    int EtherumPieces { get; set; }
    int GoldPieces { get; set; }
    int PlatinumPieces { get; set; }
    string Equipment { get; set; }
    string Equipment2 { get; set; }
    string PersonalityTraits { get; set; }
    string Ideals { get; set; }
    string Bonds { get; set; }
    string Flaws { get; set; }
    string FeaturesTraits { get; set; }
    int Age { get; set; }
    int Height { get; set; }
    int Weight { get; set; }
    string Eyes { get; set; }
    string Skin { get; set; }
    string Hair { get; set; }
    string Appearance { get; set; }
    string Backstory { get; set; }
    string FactionImg { get; set; }
    string FactionRank { get; set; }
    string Allies { get; set; }
    string Allies2 { get; set; }
    string AdditionalFeatures { get; set; }
    string AdditionalFeatures2 { get; set; }
    int TotalNonConsumableMagicItems { get; set; }
    string Treasure { get; set; }
    string Treasure2 { get; set; }
    string SpellcastingClass { get; set; }
    int PreparedSpellsTotal { get; set; }
    int SpellSaveDC { get; set; }
    int SpellAttackBonus { get; set; }
    List<Spell> Cantrips { get; set; }
    int Lvl1SpellSlotsTotal { get; set; }
    int Lvl1SpellSlotsUsed { get; set; }
    List<Spell> Lvl1Spells { get; set; }
    int Lvl2SpellSlotsTotal { get; set; }
    int Lvl2SpellSlotsUsed { get; set; }
    List<Spell> Lvl2Spells { get; set; }
    int Lvl3SpellSlotsTotal { get; set; }
    int Lvl3SpellSlotsUsed { get; set; }
    List<Spell> Lvl3Spells { get; set; }
    int Lvl4SpellSlotsTotal { get; set; }
    int Lvl4SpellSlotsUsed { get; set; }
    List<Spell> Lvl4Spells { get; set; }
    int Lvl5SpellSlotsTotal { get; set; }
    int Lvl5SpellSlotsUsed { get; set; }
    List<Spell> Lvl5Spells { get; set; }
    int Lvl6SpellSlotsTotal { get; set; }
    int Lvl6SpellSlotsUsed { get; set; }
    List<Spell> Lvl6Spells { get; set; }
    int Lvl7SpellSlotsTotal { get; set; }
    int Lvl7SpellSlotsUsed { get; set; }
    List<Spell> Lvl7Spells { get; set; }
    int Lvl8SpellSlotsTotal { get; set; }
    int Lvl8SpellSlotsUsed { get; set; }
    List<Spell> Lvl8Spells { get; set; }
    int Lvl9SpellSlotsTotal { get; set; }
    int Lvl9SpellSlotsUsed { get; set; }
    List<Spell> Lvl9Spells { get; set; }
    int Int { get; set; }
    event PropertyChangedEventHandler? PropertyChanged;
}