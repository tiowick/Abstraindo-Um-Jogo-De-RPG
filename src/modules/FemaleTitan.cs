namespace RPG.src.modules
{
    public class femaleTitan : Titan
    {
        public femaleTitan(string Name, int Level, string TitanType)
        {
            this.Name = Name;
            this.Level = Level;
            this.TitanType = TitanType;
        }
        public override string Attack()
        {
            return this.Name + "Ataque de chute Poderoso";
        }
        public string Attack(int BonusAnie)
        {
            if (BonusAnie == 20)
            {
                return this.Name + " " + $"Atacando e derrubando o oponente! bonus de  {BonusAnie}%!! ";
            }
            else if(BonusAnie >= 85)
            {
                return this.Name + " " + $"Ataque com artes Marciais, bonus de {BonusAnie}% !!";
            }
            else
            {
                return this.Name + " " + "Causou dano no adversário mas não foi o sufuciente!!";
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
            else
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