public class DnDCharacter
{
#pragma warning disable CS8618
  public string Name { get; set; }
  public string ClassLevel { get; set; }
  public string Background { get; set; }
  public string PlayerName { get; set; }
  public string Faction { get; set; }
  public string Race { get; set; }
  public string Alignment { get; set; }
  public string Xp { get; set; }
  public string DciNo { get; set; }

  public int Str { get; set; }
  public int Dex { get; set; }
  public int Con { get; set; }
  public int Int { get; set; }
  public int Wis { get; set; }
  public int Cha { get; set; }

  public int Inspiration { get; set; }
  public int ProficiencyBonus { get; set; }

  public int StrSave { get; set; }
  public bool StrSaveChecked { get; set; }
  public int DexSave { get; set; }
  public bool DexSaveChecked { get; set; }
  public int ConSave { get; set; }
  public bool ConSaveChecked { get; set; }
  public int IntSave { get; set; }
  public bool IntSaveChecked { get; set; }
  public int WisSave { get; set; }
  public bool WisSaveChecked { get; set; }
  public int ChaSave { get; set; }
  public bool ChaSaveChecked { get; set; }

  public int SkillAcrobatics { get; set; }
  public bool SkillAcrobaticsChecked { get; set; }
  public int SkillAnimalHandling { get; set; }
  public bool SkillAnimalHandlingChecked { get; set; }
  public int SkillArcana { get; set; }
  public bool SkillArcanaChecked { get; set; }
  public int SkillAthletics { get; set; }
  public bool SkillAthleticsChecked { get; set; }
  public int SkillDeception { get; set; }
  public bool SkillDeceptionChecked { get; set; }
  public int SkillHistory { get; set; }
  public bool SkillHistoryChecked { get; set; }
  public int SkillInsight { get; set; }
  public bool SkillInsightChecked { get; set; }
  public int SkillIntimidation { get; set; }
  public bool SkillIntimidationChecked { get; set; }
  public int SkillInvestigation { get; set; }
  public bool SkillInvestigationChecked { get; set; }
  public int SkillMedicine { get; set; }
  public bool SkillMedicineChecked { get; set; }
  public int SkillNature { get; set; }
  public bool SkillNatureChecked { get; set; }
  public int SkillPerception { get; set; }
  public bool SkillPerceptionChecked { get; set; }
  public int SkillPerformance { get; set; }
  public bool SkillPerformanceChecked { get; set; }
  public int SkillPersuasion { get; set; }
  public bool SkillPersuasionChecked { get; set; }
  public int SkillReligion { get; set; }
  public bool SkillReligionChecked { get; set; }
  public int SkillSlightOfHand { get; set; }
  public bool SkillSlightOfHandChecked { get; set; }
  public int SkillStealth { get; set; }
  public bool SkillStealthChecked { get; set; }
  public int SkillSurvival { get; set; }
  public bool SkillSurvivalChecked { get; set; }

  public int PassivePerception { get; set; }
  public string OtherProficiencies { get; set; }

  public int Ac { get; set; }
  public int Init { get; set; }
  public int Speed { get; set; }

  public int MaxHp { get; set; }
  public int Hp { get; set; }
  public int TempHp { get; set; }

  public string HitDiceMax { get; set; }
  public string HitDice { get; set; }

  public int DeathsaveSuccesses { get; set; }
  public int DeathsaveFailures { get; set; }

  public string[] Attacks { get; set; }
  public string AttacksText { get; set; }

  public string Cp { get; set; }
  public string Sp { get; set; }
  public string Ep { get; set; }
  public string Gp { get; set; }
  public string Pp { get; set; }
  public string Equipment { get; set; }
  public string Equipment2 { get; set; }

  public string PersonalityTraits { get; set; }
  public string Ideals { get; set; }
  public string Bonds { get; set; }
  public string Flaws { get; set; }

  public string FeaturesTraits { get; set; }

  public string Age { get; set; }
  public string Height { get; set; }
  public string Weight { get; set; }
  public string Eyes { get; set; }
  public string Skin { get; set; }
  public string Hair { get; set; }

  public string Appearance { get; set; }
  public string Backstory { get; set; }

  public string FactionImg { get; set; }
  public string FactionRank { get; set; }
  public string Allies { get; set; }
  public string Allies2 { get; set; }

  public string AdditionalFeatures { get; set; }
  public string AdditionalFeatures2 { get; set; }

  public int TotalNonConsumableMagicItems { get; set; }
  public string Treasure { get; set; }
  public string Treasure2 { get; set; }

  public string SpellcastingClass { get; set; }
  public string PreparedSpellsTotal { get; set; }
  public string SpellSaveDC { get; set; }
  public string SpellAttackBonus { get; set; }

  public string[] Cantrips { get; set; }

  public string Lvl1SpellSlotsTotal { get; set; }
  public int Lvl1SpellSlotsUsed { get; set; }
  public string[] Lvl1Spells { get; set; }

  public string Lvl2SpellSlotsTotal { get; set; }
  public int Lvl2SpellSlotsUsed { get; set; }
  public string[] Lvl2Spells { get; set; }

  public string Lvl3SpellSlotsTotal { get; set; }
  public int Lvl3SpellSlotsUsed { get; set; }
  public string[] Lvl3Spells { get; set; }

  public string Lvl4SpellSlotsTotal { get; set; }
  public int Lvl4SpellSlotsUsed { get; set; }
  public string[] Lvl4Spells { get; set; }

  public string Lvl5SpellSlotsTotal { get; set; }
  public int Lvl5SpellSlotsUsed { get; set; }
  public string[] Lvl5Spells { get; set; }

  public string Lvl6SpellSlotsTotal { get; set; }
  public int Lvl6SpellSlotsUsed { get; set; }
  public string[] Lvl6Spells { get; set; }

  public string Lvl7SpellSlotsTotal { get; set; }
  public int Lvl7SpellSlotsUsed { get; set; }
  public string[] Lvl7Spells { get; set; }

  public string Lvl8SpellSlotsTotal { get; set; }
  public int Lvl8SpellSlotsUsed { get; set; }
  public string[] Lvl8Spells { get; set; }

  public string Lvl9SpellSlotsTotal { get; set; }
  public int Lvl9SpellSlotsUsed { get; set; }
  public string[] Lvl9Spells { get; set; }
#pragma warning restore CS8618

}
