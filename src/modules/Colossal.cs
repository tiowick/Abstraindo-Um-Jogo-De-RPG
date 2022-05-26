namespace RPG.src.modules
{
    public class Colossal : Titan   
    {   
        public Colossal(string Name, int Level, string TitanType)
        {
            this.Name = Name;
            this.Level = Level;
            this.TitanType = TitanType;
        }
        public override string Attack()
        {
            return this.Name + " " + "Ataque com soco Destrutivo!!";
        }
        public string Attack(int BonusColossal)
        {
            if (BonusColossal == 20)
            {
                return this.Name + " " + $"Ataque com vapor  destruindo tudo e todos ao seu redor! {BonusColossal}%!! ";
            }
            else if(BonusColossal >= 85)
            {
                return this.Name + " " + $"Destruição em massa {BonusColossal}% !!";
            }
            else
            {
                return this.Name + " " + "Causou muita destruição ao se transformar !!";
            }
        }
        public override string Defender()
        {
            return this.Name + " " + " Defendendo o ataque";
        }

        public string Defender(int Damage)
        {
            if(Damage == 30)
            {
                return this.Name + " " + $"Defendeu mas tomou dano de {Damage}%";
            }
            else if(Damage >= 60)
            {
                return this.Name + " " + $"Tomou dano de {Damage}%";
            }
            {
                return this.Name + " " + "Defendeu sem tomar dano!";
            }
        }
        public override string Hp()
        {
            return this.Name + " " + "HP cheio: [__##############__]";
        }
        public string Hp(int Full)
        {
            if(Full == 70)
            {
                return this.Name + " " + "Barra de HP razoavel: [__#########__]";
            }
            else if(Full < 70)
            {
                return this.Name + " " + "Barra de HP média: [__#######__]";
            }
            else
            {
                return this.Name + " " + "Barra de HP pequena: [__###__] ";
            }
        }
    }
}