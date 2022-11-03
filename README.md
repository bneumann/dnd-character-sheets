# DnDCharacterSheets

> Dungeons and Dragons 5th Edition character sheets created in Blazor.

This is a port of the amazing ReactJS DnD Character sheets by Daryl Buckle [https://github.com/DarylBuckle/dnd-character-sheets](https://github.com/DarylBuckle/dnd-character-sheets)


<img width="600" alt="Screenshot 2020-09-06 at 19 35 55" src="https://user-images.githubusercontent.com/15156674/92332881-adbfee80-f078-11ea-8bcc-82cfb6484465.png">


## Contents

- [DnDCharacterSheets](#dndcharactersheets)
  - [Contents](#contents)
  - [About](#about)
  - [Install](#install)
  - [Usage](#usage)
  - [Props](#props)
  - [DnDCharacter Class](#dndcharacter-class)
  - [License](#license)


## About

Blazor components that render Dungeons & Dragons character sheets, namely a character stats sheet, character profile sheet and spell sheet.

The attributes in the example can be populated on the web page and outputs to print nicely, so you can populate some attributes on the page and print the sheet. Characters can also be exported to a json file and imported from a json file.


## Install

```bash
dotnet add package DnDCharacterSheets
```

## Usage

```c#
@page "/profile"
@using DnDCharacterSheets.Pages
@inject SessionStorage storage;

<DnDCharacterProfileSheet Character="@character" CharacterChanged="SaveCharacter"/>

@code
{
    private DnDCharacter? character = new();
    protected override async Task OnInitializedAsync()
    {
        character = await storage.Read();
    }

    private void SaveCharacter(DnDCharacter character)
    {
        storage.Save(character);
    }
}

```

```DnDCharacterStatsSheet``` renders a stats sheet.

```DnDCharacterProfileSheet``` renders a character traits sheet.

```DnDCharacterSpellSheet``` renders a spell sheet.


## Props

Each component accepts the same props.

Each component can be controlled or uncontrolled. Either character and onCharacterChanged should be specified (controlled), or defaultCharacter should be specified.

| Property           | Type                           | Description                                                                                                              |
| ------------------ | ------------------------------ | ------------------------------------------------------------------------------------------------------------------------ |
| defaultCharacter   | DnDCharacter                   | An instance of the DnDCharacter class. If character is not set the sheet will initialize with the values specified here. |
| character          | DnDCharacter                   | An instance of the DnDCharacter class. If set the sheet will always use the values specified here.                       |
| onCharacterChanged | func (character: DnDCharacter) | Called whenever a value in a sheet is changed. A modified DnDCharacter object is returned.                               |


## DnDCharacter Class

The DnDCharacter class holds the attributes of a character. The attributes are shown below. I kept it almost compatible with the ReactJS version.

```c#
public class DnDCharacter
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
}
```


## License

MIT © [Daryl Buckle](https://github.com/DarylBuckle) 2020
