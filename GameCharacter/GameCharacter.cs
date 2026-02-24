using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    internal class GameCharacter
    {
        private string Name { get; }
        private int Level { get; }
        private int MaxHp {  get; }
        public int CurrentHp { get; private set; }
        private int AttackPower {  get; }
        private bool IsAlive { get; }
        public GameCharacter(string name, int level)
        {
            Name = name;
            Level = level;
            MaxHp = level * 100;
            AttackPower = level * 10;
            CurrentHp = MaxHp;
        }
        public void Attack(GameCharacter target)
        {
            target.TakeDameage(AttackPower);
            Console.WriteLine($"{Name}이(가) {target.Name}에게 {AttackPower} 데미지를 입혔습니다!");

        }
        public void TakeDameage(int damage)
        {
            CurrentHp -= damage;
            if(CurrentHp < 0)
            {
                CurrentHp = 0;
            }
        }

        public void ShowStatus()
        {
            Console.WriteLine($"[{Name}] Lv. {Level} - HP : {CurrentHp}/{MaxHp}, 공격력 : {AttackPower}");
        }
    }
}
