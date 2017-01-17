﻿using System.Numerics;

namespace LeagueSandbox.GameServer.NewGameObjects
{
    class CharData
    {
        public int UnitTags { get; private set; }
        public float AttaGameplayCollisionRadiusckRange { get; private set; }
        public float PathfindingCollisionRadius { get; private set; }
        public float SelectionRadius { get; private set; }
        public float SelectionHeight { get; private set; }
        public float HitFXScale { get; private set; }
        public float HoverIndicatorWidth { get; private set; }
        public float HoverIndicatorRadius { get; private set; }
        public string Tips2 { get; private set; }
        public string Tips1 { get; private set; }
        public string Lore1 { get; private set; }
        public string CritAttack1 { get; private set; }
        public string BasicAttack9 { get; private set; }
        public string BasicAttack8 { get; private set; }
        public string BasicAttack7 { get; private set; }
        public string BasicAttack6 { get; private set; }
        public string BasicAttack5 { get; private set; }
        public string BasicAttack4 { get; private set; }
        public string BasicAttack3 { get; private set; }
        public string BasicAttack2 { get; private set; }
        public string BasicAttack1 { get; private set; }
        public float Passive1Range { get; private set; }
        public string PassiveSpell { get; private set; }
        public string Passive1Desc1 { get; private set; }
        public string Passive1Desc { get; private set; }
        public string Passive1LuaName { get; private set; }
        public string Passive1Name { get; private set; }
        public string CriticalAttack { get; private set; }
        public string ExtraSpell16 { get; private set; }
        public string ExtraSpell15 { get; private set; }
        public string ExtraSpell14 { get; private set; }
        public string ExtraSpell13 { get; private set; }
        public string ExtraSpell112 { get; private set; }
        public string ExtraSpell12 { get; private set; }
        public string ExtraSpell11 { get; private set; }
        public string ExtraSpell10 { get; private set; }
        public string ExtraSpell9 { get; private set; }
        public string ExtraSpell8 { get; private set; }
        public string ExtraSpell7 { get; private set; }
        public string ExtraSpell6 { get; private set; }
        public string ExtraSpell5 { get; private set; }
        public string ExtraSpell4 { get; private set; }
        public string ExtraSpell3 { get; private set; }
        public string ExtraSpell2 { get; private set; }
        public string ExtraSpell1 { get; private set; }
        public string Spell4 { get; private set; }
        public string Spell3 { get; private set; }
        public string Spell2 { get; private set; }
        public string Spell1 { get; private set; }
        public float BaseAbilityPower { get; private set; }
        public float UntargetableSpawnTime { get; private set; }
        public float Significance { get; private set; }
        public float PerceptionBubbleRadius { get; private set; }
        public float GlobalExpGivenOnDeath { get; private set; }
        public float GlobalGoldGivenOnDeath { get; private set; }
        public float LocalGoldSplitWithLastHitter { get; private set; }
        public float LocalExpGivenOnDeath { get; private set; }
        public float LocalGoldGivenOnDeath { get; private set; }
        public float DeathEventListeningRadius { get; private set; }
        public float ExperienceRadius { get; private set; }
        public float GoldRadius { get; private set; }
        public float GoldGivenOnDeath { get; private set; }
        public float ExpGivenOnDeath { get; private set; }
        public float AttackDelayOffsetPercent { get; private set; }
        public float AttackDelayCastOffsetPercent { get; private set; }
        public float AttackDelayCastOffsetPercentAttackSpeedRatio { get; private set; }
        public float TowerTargettingPriorityBoost { get; private set; }
        public float AttackAutoInterruptPercent { get; private set; }
        public float FirstAcquisitionRange { get; private set; }
        public float AttackRange { get; private set; }
        public float MoveSpeed { get; private set; }
        public float CritDamageBonus { get; private set; }
        public float BaseCritChance { get; private set; }
        public float BaseMissChance { get; private set; }
        public float BaseDodge { get; private set; }
        public float SpellBlock { get; private set; }
        public float Armor { get; private set; }
        public float BaseStaticMPRegen { get; private set; }
        public float MPPerLevel { get; private set; }
        public float BaseMP { get; private set; }
        public float BaseStaticHPRegen { get; private set; }
        public float HPPerLevel { get; private set; }
        public float BaseHP { get; private set; }
        public int MonsterDataTableID { get; private set; }
        public bool ShowWhileUntargetable { get; private set; }
        public Vector3 WorldOffset { get; private set; }
        public float YOffset { get; private set; }
        public float XOffset { get; private set; }
        public float HPPerTick { get; private set; }
        public string BaseSkinName { get; private set; }
    }
}
