namespace RPG.src.modules
{
    public class Founder : Titan
    {
        public Founder(string Name, int Level, string TitanType)
        {
            this.Name = Name;
            this.Level = Level;
            this.TitanType = TitanType;
            
        }
        public override string Attack()
        {
            return this.Name + " " + "Atacando com o soco endurecido!!";
        }
        
        public string Attack(int Bonus)
        {
            if(Bonus == 50)
            {
                return this.Name + " " + "Atacando com o poder do martelo guerra";
            }
            else if(Bonus >= 100)
            {
                return this.Name + " " + $"Atacando usando espinhos gigantes com {Bonus}% de  ataque!";
            }
            else
            {
                return this.Name + " " + $"Atacando com um soco blindado!";
            }
        }

        public override string Defender()
        {
            return this.Name + " " + "Defendendo o ataque";
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
            if(Full == 50)
            {
                return this.Name + " " + "Barra de HP média: [__########__]";
            }
            else 
            {
                return this.Name + " " + "Barra de HP pequena: [__###__]";
            }
        } 
    }
}