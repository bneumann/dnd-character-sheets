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

  public string Str { get; set; }
  public string Dex { get; set; }
  public string Con { get; set; }
  public string Int { get; set; }
  public string Wis { get; set; }
  public string Cha { get; set; }

  public string Inspiration { get; set; }
  public string ProficiencyBonus { get; set; }

  public string StrSave { get; set; }
  public bool StrSaveChecked { get; set; }
  public string DexSave { get; set; }
  public bool DexSaveChecked { get; set; }
  public string ConSave { get; set; }
  public bool ConSaveChecked { get; set; }
  public string IntSave { get; set; }
  public bool IntSaveChecked { get; set; }
  public string WisSave { get; set; }
  public bool WisSaveChecked { get; set; }
  public string ChaSave { get; set; }
  public bool ChaSaveChecked { get; set; }

  public string SkillAcrobatics { get; set; }
  public bool SkillAcrobaticsChecked { get; set; }
  public string SkillAnimalHandling { get; set; }
  public bool SkillAnimalHandlingChecked { get; set; }
  public string SkillArcana { get; set; }
  public bool SkillArcanaChecked { get; set; }
  public string SkillAthletics { get; set; }
  public bool SkillAthleticsChecked { get; set; }
  public string SkillDeception { get; set; }
  public bool SkillDeceptionChecked { get; set; }
  public string SkillHistory { get; set; }
  public bool SkillHistoryChecked { get; set; }
  public string SkillInsight { get; set; }
  public bool SkillInsightChecked { get; set; }
  public string SkillIntimidation { get; set; }
  public bool SkillIntimidationChecked { get; set; }
  public string SkillInvestigation { get; set; }
  public bool SkillInvestigationChecked { get; set; }
  public string SkillMedicine { get; set; }
  public bool SkillMedicineChecked { get; set; }
  public string SkillNature { get; set; }
  public bool SkillNatureChecked { get; set; }
  public string SkillPerception { get; set; }
  public bool SkillPerceptionChecked { get; set; }
  public string SkillPerformance { get; set; }
  public bool SkillPerformanceChecked { get; set; }
  public string SkillPersuasion { get; set; }
  public bool SkillPersuasionChecked { get; set; }
  public string SkillReligion { get; set; }
  public bool SkillReligionChecked { get; set; }
  public string SkillSlightOfHand { get; set; }
  public bool SkillSlightOfHandChecked { get; set; }
  public string SkillStealth { get; set; }
  public bool SkillStealthChecked { get; set; }
  public string SkillSurvival { get; set; }
  public bool SkillSurvivalChecked { get; set; }

  public string PassivePerception { get; set; }
  public string OtherProficiencies { get; set; }

  public string Ac { get; set; }
  public string Init { get; set; }
  public string Speed { get; set; }

  public string MaxHp { get; set; }
  public string Hp { get; set; }
  public string TempHp { get; set; }

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

  public string TotalNonConsumableMagicItems { get; set; }
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
