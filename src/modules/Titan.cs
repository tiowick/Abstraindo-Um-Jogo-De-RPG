namespace RPG.src.modules
{
    public abstract class Titan
    {   
        
        public Titan(string Name, int Level, string TitanType)
        {
            this.Name = Name;
            this.Level = Level;
            this.TitanType = TitanType;
            
            
        }
        
        public Titan() 

        {

        }

        public string Name;
        public int Level;
        public string TitanType;
        
       
        public override string ToString() // sobrescrevendo 
        {
            return this.Name + " " + this.Level + " " + this.TitanType;
        }

        public virtual string Attack()
        {
            return this.Name + " " + "Atacando!!";
        }
        public virtual string Defender()
        {
            return this.Name + " " + "Defendendo!!";
        }
        public virtual string Hp()
        {
            return this.Name + " " + " Barra HP: [__##############__]";
        }
    }
}